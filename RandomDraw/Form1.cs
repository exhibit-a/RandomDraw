using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
// removed unused threading/usings after switching to sequential processing

namespace RandomDraw
{
    public partial class frmDraw : Form
    {
        private int[] reelPositions = new int[5];
        private int[] reelSpeeds = { 20, 18, 16, 14, 12 }; // Different speeds for each reel
        private Label[] reelLabels = new Label[5];
        private const int reelHeight = 60;
        private const int digitHeight = 50;
        
        public frmDraw()
        {
            InitializeComponent();
            
            // Hide the original label and create 5 reel labels
            lblRandomNumber.Visible = false;
            
            // Create 5 reel labels anchored to bottom left
            int startX = 20; // Left margin from form edge
            int bottomMargin = 20; // Margin from bottom
            int spacing = 50;
            
            for (int i = 0; i < 5; i++)
            {
                reelLabels[i] = new Label
                {
                    Font = new Font("Arial", 32, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Width = 45,
                    Height = reelHeight,
                    Left = startX + (i * spacing),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = "0",
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left
                };
                this.Controls.Add(reelLabels[i]);
                reelLabels[i].BringToFront();
            }
            
            // Position reels at bottom of form after form is sized
            this.Load += (s, e) => {
                int startY = this.ClientSize.Height - reelHeight - bottomMargin;
                for (int i = 0; i < 5; i++)
                {
                    reelLabels[i].Top = startY;
                }
            };
        }



        private void frmDraw_Load(object sender, EventArgs e)
        {
            this.drawTableAdapter1.Fill(this.drawDataSet1.Draw);
            this.winnersTableAdapter1.Fill(this.drawDataSet1.Winners);

            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RandomDraw.Properties.Settings.drawConnectionString1"].ConnectionString;
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select distinct region from draw";
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cbRegion.Items.Add(rdr[0].ToString());
            }

            cn.Close();
            
            // Disable pick winner button at startup
            btnPick.Enabled = false;
            
            // Initialize all reels to 0
            for (int i = 0; i < 5; i++)
            {
                reelLabels[i].Text = "0";
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            List<Int32> lst = new List<Int32>();

            //Clear old values
            if (cbRegion.Text == "")
            {
                this.drawTableAdapter1.ClearRandomIDs();
            }
            else
            {
                this.drawTableAdapter1.ClearRandomIDsByRegion(cbRegion.Text);
            }

            // Build randomized integer list (preserve original approach)
            var guids = new Dictionary<string, int>();
            var randomInts = new List<int>();
            int k = 0;
            for (int j = 0; j < drawDataSet1.Draw.Rows.Count; j++)
            {
                guids.Add(System.Guid.NewGuid().ToString(), k++);
            }
            foreach (var kvp in guids.OrderBy(c => c.Key))
            {
                randomInts.Add(kvp.Value);
            }

            // Build list of (ID, RandomID) pairs to update
            var idRndPairs = new List<(int Id, int Rnd)>();
            k = 0;
            foreach (DataRow dr in this.drawDataSet1.Draw.Rows)
            {
                int id = (Int32)dr["ID"];
                int rnd = randomInts[k++];
                idRndPairs.Add((id, rnd));
            }

            // Prepare UI progress
            this.progressBar1.Maximum = idRndPairs.Count;
            this.progressBar1.Value = 0;
            this.lblProgress.Text = "0 of " + idRndPairs.Count;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RandomDraw.Properties.Settings.drawConnectionString1"].ConnectionString;

            int completed = 0;

            try
            {
                using (var cn = new OleDbConnection(connectionString))
                {
                    cn.Open();

                    // Sequential update over the shared connection
                    foreach (var pair in idRndPairs)
                    {
                        using (var cmd = cn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE Draw SET RandomID = ? WHERE ID = ?";
                            cmd.Parameters.AddWithValue("?", pair.Rnd);
                            cmd.Parameters.AddWithValue("?", pair.Id);
                            cmd.ExecuteNonQuery();
                        }

                        lst.Add(pair.Rnd);

                        completed++;

                        // Update UI directly (we are on the UI thread)
                        if (completed <= this.progressBar1.Maximum)
                        {
                            this.progressBar1.Value = completed;
                        }
                        this.lblProgress.Text = string.Format("Record {0} of {1}", completed, idRndPairs.Count);
                        Application.DoEvents();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Update table (back on UI thread)
            this.lblProgress.Text = "UPDATING TABLE";
            if (cbRegion.Text == "")
            {
                this.drawTableAdapter1.Fill(this.drawDataSet1.Draw);
            }
            else
            {
                this.drawTableAdapter1.FillByRegion(this.drawDataSet1.Draw, cbRegion.Text);
            }

            this.lblProgress.Text = "DONE";
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            
            // Get the number from all 5 reels
            string fullNumber = string.Join("", reelLabels.Select(l => l.Text));
            
            drawDataSet.DrawRow dr = this.drawDataSet1.Draw.Select("RandomID=" + fullNumber).First() as drawDataSet.DrawRow;
            string region = dr.IsRegionNull() ? "" : dr.Region;
            this.winnersTableAdapter1.InsertWinner(dr.ID, dr.NameSurname, dr.EmplNo.ToString(), dr.RandomID, region);
            this.winnersTableAdapter1.Fill(this.drawDataSet1.Winners);
            
            // Reset all reels to normal color
            for (int i = 0; i < 5; i++)
            {
                reelLabels[i].ForeColor = Color.Black;
            }
            
            // Disable pick button after picking a winner
            btnPick.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            
            // Reset all reel positions
            for (int i = 0; i < 5; i++)
            {
                reelPositions[i] = 0;
            }
            
            // Enable pick button when starting number generator
            btnPick.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int maxNumber = this.drawDataSet1.Draw.Rows.Count;
            
            // Generate random number and pad to 5 digits
            int currentNumber = new Random().Next(maxNumber);
            string numberString = currentNumber.ToString().PadLeft(5, '0');
            
            // Update each reel independently
            for (int i = 0; i < 5; i++)
            {
                // Update reel position with its specific speed
                reelPositions[i] += reelSpeeds[i];
                
                // Calculate offset for smooth scrolling effect
                int offset = reelPositions[i] % digitHeight;
                float offsetRatio = (float)offset / digitHeight;
                
                // Set the digit for this reel
                reelLabels[i].Text = numberString[i].ToString();
                
                // Add visual feedback with color change during spin
                // Each reel has slightly different timing for variety
                int colorPhase = (reelPositions[i] + (i * 20)) % 120;
                if (colorPhase < 60)
                {
                    int colorValue = 100 + (int)(offsetRatio * 155);
                    reelLabels[i].ForeColor = Color.FromArgb(colorValue, colorValue, 0);
                }
                else
                {
                    reelLabels[i].ForeColor = Color.Black;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.drawDataSet1.Draw.Clear();
            this.drawTableAdapter1.FillByRegion(this.drawDataSet1.Draw, cbRegion.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Delete previous winners
            this.winnersTableAdapter1.DeletePreviousWinners();
            this.winnersTableAdapter1.Fill(this.drawDataSet1.Winners);
        }


    }
}
