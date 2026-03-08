#nullable enable
#nullable enable
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;

namespace RandomDraw;

public sealed class DrawRecord
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string EmployeeNumber { get; set; } = "";
    public string Region { get; set; } = "";
    public int? RandomId { get; set; }
    public Dictionary<string, string> ExtraColumns { get; set; } = new();
}

public sealed class WinnerRecord
{
    public string Region { get; set; } = "";
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string EmployeeNumber { get; set; } = "";
    public int RandomId { get; set; }
}

/// <summary>
/// Browser-compatible Excel service that reads the workbook once into
/// in-memory lists and performs all processing on those lists.
/// The workbook is only rebuilt on export.
/// </summary>
public class ExcelService
{
    private byte[]? _originalBytes;
    private string? _fileName;
    private List<string> _extraColumnHeaders = new();

    private const string WinnersSheetName = "Winners";

    // Configurable column names (defaults)
    public string FullNameColumn { get; set; } = "FullName";
    public string EmployeeNumberColumn { get; set; } = "Employee_Num";

    // In-memory data
    public List<DrawRecord> DrawData { get; private set; } = new();
    public List<WinnerRecord> Winners { get; private set; } = new();

    public bool IsLoaded => DrawData.Count > 0;
    public string? FileName => _fileName;

    /// <summary>
    /// Configure column name mappings.
    /// </summary>
    public void Configure(string? fullNameColumn, string? employeeNumberColumn)
    {
        if (!string.IsNullOrWhiteSpace(fullNameColumn))
            FullNameColumn = fullNameColumn;
        if (!string.IsNullOrWhiteSpace(employeeNumberColumn))
            EmployeeNumberColumn = employeeNumberColumn;
    }

    /// <summary>
    /// Loads an Excel file from uploaded bytes. Repairs, validates,
    /// and reads all data into in-memory lists.
    /// Returns null on success or an error message.
    /// </summary>
    public string? LoadFromBytes(byte[] bytes, string fileName)
    {
        _fileName = fileName;

        bytes = RepairXlsx(bytes);

        var error = ValidateAndLoad(bytes);
        if (error != null)
        {
            _originalBytes = null;
            DrawData = new();
            Winners = new();
            _extraColumnHeaders = new();
            return error;
        }

        _originalBytes = bytes;
        return null;
    }

    /// <summary>
    /// Builds workbook bytes on demand for download/export.
    /// </summary>
    public byte[]? GetWorkbookBytes()
    {
        if (!IsLoaded) return _originalBytes;

        using var wb = new XLWorkbook();

        // Draw sheet
        var ws = wb.Worksheets.Add("Draw");
        var knownHeaders = new List<string> { FullNameColumn, EmployeeNumberColumn, "Region", "ID", "RandomID" };
        var allHeaders = new List<string>(knownHeaders);
        allHeaders.AddRange(_extraColumnHeaders);

        for (int c = 0; c < allHeaders.Count; c++)
            ws.Cell(1, c + 1).Value = allHeaders[c];

        for (int r = 0; r < DrawData.Count; r++)
        {
            var rec = DrawData[r];
            int row = r + 2;
            ws.Cell(row, 1).Value = rec.FullName;
            ws.Cell(row, 2).Value = rec.EmployeeNumber;
            ws.Cell(row, 3).Value = rec.Region;
            ws.Cell(row, 4).Value = rec.Id;
            ws.Cell(row, 5).Value = rec.RandomId.HasValue ? rec.RandomId.Value : Blank.Value;
            for (int e = 0; e < _extraColumnHeaders.Count; e++)
            {
                var key = _extraColumnHeaders[e];
                ws.Cell(row, 6 + e).Value = rec.ExtraColumns.GetValueOrDefault(key, "");
            }
        }

        // Winners sheet
        var wws = wb.Worksheets.Add(WinnersSheetName);
        wws.Cell(1, 1).Value = "Region";
        wws.Cell(1, 2).Value = "ID";
        wws.Cell(1, 3).Value = FullNameColumn;
        wws.Cell(1, 4).Value = EmployeeNumberColumn;
        wws.Cell(1, 5).Value = "RandomID";

        for (int r = 0; r < Winners.Count; r++)
        {
            var w = Winners[r];
            int row = r + 2;
            wws.Cell(row, 1).Value = w.Region;
            wws.Cell(row, 2).Value = w.Id;
            wws.Cell(row, 3).Value = w.FullName;
            wws.Cell(row, 4).Value = w.EmployeeNumber;
            wws.Cell(row, 5).Value = w.RandomId;
        }

        using var outMs = new MemoryStream();
        wb.SaveAs(outMs);
        return outMs.ToArray();
    }

    /// <summary>
    /// Returns draw data filtered by region, or all if region is empty.
    /// </summary>
    public List<DrawRecord> GetDrawData(string? region = null)
    {
        if (string.IsNullOrEmpty(region))
            return DrawData;
        return DrawData.Where(r => r.Region.Equals(region, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    /// <summary>
    /// Returns distinct non-empty Region values.
    /// </summary>
    public List<string> GetDistinctRegions()
    {
        return DrawData
            .Select(r => r.Region)
            .Where(r => !string.IsNullOrEmpty(r))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    /// <summary>
    /// Clears all RandomID values.
    /// </summary>
    public void ClearRandomIDs()
    {
        foreach (var rec in DrawData)
            rec.RandomId = null;
    }

    /// <summary>
    /// Clears RandomID values only for rows matching the given region.
    /// </summary>
    public void ClearRandomIDsByRegion(string region)
    {
        foreach (var rec in DrawData)
        {
            if (rec.Region.Equals(region, StringComparison.OrdinalIgnoreCase))
                rec.RandomId = null;
        }
    }

    /// <summary>
    /// Assigns random IDs to the given records.
    /// Returns the list of (Id, RandomId) pairs that were assigned.
    /// </summary>
    public List<(int Id, int Rnd)> AssignRandomIDs(List<DrawRecord> records)
    {
        int count = records.Count;
        var indices = Enumerable.Range(0, count).ToArray();

        // Fisher-Yates shuffle
        var rng = new Random();
        for (int i = count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (indices[i], indices[j]) = (indices[j], indices[i]);
        }

        var pairs = new List<(int Id, int Rnd)>(count);
        for (int k = 0; k < count; k++)
        {
            records[k].RandomId = indices[k];
            pairs.Add((records[k].Id, indices[k]));
        }

        return pairs;
    }

    /// <summary>
    /// Inserts a winner into the in-memory list.
    /// </summary>
    public void InsertWinner(string region, int id, string fullName, string emplNo, int randomId)
    {
        Winners.Add(new WinnerRecord
        {
            Region = region,
            Id = id,
            FullName = fullName,
            EmployeeNumber = emplNo,
            RandomId = randomId
        });
    }

    /// <summary>
    /// Clears all winners.
    /// </summary>
    public void ClearWinners()
    {
        Winners.Clear();
    }

    /// <summary>
    /// Generates an HTML report of winners for printing.
    /// </summary>
    public string GenerateWinnersHtml()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("<!DOCTYPE html>");
        sb.AppendLine("<html><head><meta charset='utf-8'>");
        sb.AppendLine("<title>Random Draw - Winners</title>");
        sb.AppendLine("<style>");
        sb.AppendLine("  body { font-family: Arial, sans-serif; margin: 40px; }");
        sb.AppendLine("  h1 { color: #333; }");
        sb.AppendLine("  table { border-collapse: collapse; width: 100%; }");
        sb.AppendLine("  th, td { border: 1px solid #ccc; padding: 8px 12px; text-align: left; }");
        sb.AppendLine("  th { background-color: #4CAF50; color: white; }");
        sb.AppendLine("  tr:nth-child(even) { background-color: #f2f2f2; }");
        sb.AppendLine("  @media print { body { margin: 20px; } }");
        sb.AppendLine("</style>");
        sb.AppendLine("</head><body>");
        sb.AppendLine("<h1>Random Draw - Winners</h1>");
        sb.AppendLine("<table>");

        sb.AppendLine("<tr>");
        sb.AppendLine($"  <th>{Enc("Region")}</th>");
        sb.AppendLine($"  <th>{Enc("ID")}</th>");
        sb.AppendLine($"  <th>{Enc(FullNameColumn)}</th>");
        sb.AppendLine($"  <th>{Enc(EmployeeNumberColumn)}</th>");
        sb.AppendLine($"  <th>{Enc("RandomID")}</th>");
        sb.AppendLine("</tr>");

        foreach (var w in Winners)
        {
            sb.AppendLine("<tr>");
            sb.AppendLine($"  <td>{Enc(w.Region)}</td>");
            sb.AppendLine($"  <td>{Enc(w.Id.ToString())}</td>");
            sb.AppendLine($"  <td>{Enc(w.FullName)}</td>");
            sb.AppendLine($"  <td>{Enc(w.EmployeeNumber)}</td>");
            sb.AppendLine($"  <td>{Enc(w.RandomId.ToString())}</td>");
            sb.AppendLine("</tr>");
        }

        sb.AppendLine("</table>");
        sb.AppendLine("</body></html>");
        return sb.ToString();

        static string Enc(string s) => System.Net.WebUtility.HtmlEncode(s);
    }

    // ===== Private helpers =====

    private string[] RequiredColumns => [FullNameColumn, EmployeeNumberColumn];
    private static readonly string[] KnownColumns = ["Region", "ID", "RandomID"];

    private string? ValidateAndLoad(byte[] bytes)
    {
        using var ms = new MemoryStream(bytes);
        using var wb = new XLWorkbook(ms);

        var ws = FindDrawSheet(wb);
        if (ws == null)
            return "No visible data sheet found in the workbook.";

        if (ws.LastRowUsed() == null)
            return $"Sheet '{ws.Name}' is empty.";

        var headerRow = ws.Row(1);
        var headers = new List<string>();
        for (int c = 1; c <= ws.LastColumnUsed()!.ColumnNumber(); c++)
            headers.Add(headerRow.Cell(c).GetString().Trim());

        foreach (var col in RequiredColumns)
        {
            if (!headers.Any(h => h.Equals(col, StringComparison.OrdinalIgnoreCase)))
                return $"Required column '{col}' not found in sheet '{ws.Name}'.";
        }

        // Resolve column indices (case-insensitive)
        int Idx(string name) => headers.FindIndex(h => h.Equals(name, StringComparison.OrdinalIgnoreCase));

        int fullNameIdx = Idx(FullNameColumn);
        int emplNumIdx = Idx(EmployeeNumberColumn);
        int regionIdx = Idx("Region");
        int idIdx = Idx("ID");
        int randomIdIdx = Idx("RandomID");

        // Determine extra columns (anything that isn't a known/required column)
        var knownSet = new HashSet<string>(RequiredColumns.Concat(KnownColumns), StringComparer.OrdinalIgnoreCase);
        _extraColumnHeaders = headers.Where(h => !knownSet.Contains(h) && !string.IsNullOrEmpty(h)).ToList();

        var extraIndices = _extraColumnHeaders.Select(h => Idx(h)).ToList();

        int lastRow = ws.LastRowUsed()!.RowNumber();

        // Read draw data into list
        var drawData = new List<DrawRecord>(lastRow - 1);
        for (int r = 2; r <= lastRow; r++)
        {
            var rec = new DrawRecord
            {
                FullName = fullNameIdx >= 0 ? ws.Cell(r, fullNameIdx + 1).GetString().Trim() : "",
                EmployeeNumber = emplNumIdx >= 0 ? ws.Cell(r, emplNumIdx + 1).GetString().Trim() : "",
                Region = regionIdx >= 0 ? ws.Cell(r, regionIdx + 1).GetString().Trim() : "",
                Id = idIdx >= 0 && !ws.Cell(r, idIdx + 1).IsEmpty()
                    ? (int)ws.Cell(r, idIdx + 1).GetDouble()
                    : r - 1,
            };

            if (randomIdIdx >= 0 && !ws.Cell(r, randomIdIdx + 1).IsEmpty())
                rec.RandomId = (int)ws.Cell(r, randomIdIdx + 1).GetDouble();

            for (int e = 0; e < _extraColumnHeaders.Count; e++)
            {
                var idx = extraIndices[e];
                rec.ExtraColumns[_extraColumnHeaders[e]] = ws.Cell(r, idx + 1).GetString().Trim();
            }

            drawData.Add(rec);
        }

        // Ensure IDs are assigned
        for (int i = 0; i < drawData.Count; i++)
        {
            if (drawData[i].Id == 0)
                drawData[i].Id = i + 1;
        }

        DrawData = drawData;

        // Read winners sheet
        var winnersWs = wb.Worksheets.FirstOrDefault(s =>
            s.Name.Equals(WinnersSheetName, StringComparison.OrdinalIgnoreCase));
        var winners = new List<WinnerRecord>();

        if (winnersWs != null)
        {
            var wLastRow = winnersWs.LastRowUsed()?.RowNumber() ?? 1;
            var wLastCol = winnersWs.LastColumnUsed()?.ColumnNumber() ?? 0;

            // Find winner column indices
            var wHeaders = new List<string>();
            for (int c = 1; c <= wLastCol; c++)
                wHeaders.Add(winnersWs.Cell(1, c).GetString().Trim());

            int WIdx(string name) => wHeaders.FindIndex(h => h.Equals(name, StringComparison.OrdinalIgnoreCase));
            int wRegionIdx = WIdx("Region");
            int wIdIdx = WIdx("ID");
            int wFullNameIdx = WIdx(FullNameColumn);
            int wEmplIdx = WIdx(EmployeeNumberColumn);
            int wRndIdx = WIdx("RandomID");

            for (int r = 2; r <= wLastRow; r++)
            {
                var w = new WinnerRecord
                {
                    Region = wRegionIdx >= 0 ? winnersWs.Cell(r, wRegionIdx + 1).GetString().Trim() : "",
                    FullName = wFullNameIdx >= 0 ? winnersWs.Cell(r, wFullNameIdx + 1).GetString().Trim() : "",
                    EmployeeNumber = wEmplIdx >= 0 ? winnersWs.Cell(r, wEmplIdx + 1).GetString().Trim() : "",
                };
                if (wIdIdx >= 0 && !winnersWs.Cell(r, wIdIdx + 1).IsEmpty())
                    w.Id = (int)winnersWs.Cell(r, wIdIdx + 1).GetDouble();
                if (wRndIdx >= 0 && !winnersWs.Cell(r, wRndIdx + 1).IsEmpty())
                    w.RandomId = (int)winnersWs.Cell(r, wRndIdx + 1).GetDouble();
                winners.Add(w);
            }
        }

        Winners = winners;
        return null;
    }

    private IXLWorksheet? FindDrawSheet(XLWorkbook wb)
    {
        return wb.Worksheets.FirstOrDefault(s =>
            s.Visibility == XLWorksheetVisibility.Visible &&
            !s.Name.Equals(WinnersSheetName, StringComparison.OrdinalIgnoreCase));
    }

    private static byte[] RepairXlsx(byte[] bytes)
    {
        using var ms = new MemoryStream();
        ms.Write(bytes, 0, bytes.Length);
        ms.Position = 0;
        using (var doc = SpreadsheetDocument.Open(ms, true))
        {
            doc.Save();
        }
        return ms.ToArray();
    }
}
