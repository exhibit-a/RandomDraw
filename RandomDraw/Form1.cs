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
        public frmDraw()
        {
            InitializeComponent();
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
                        this.lblRandomNumber.Text = pair.Rnd.ToString();
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
            drawDataSet.DrawRow dr = this.drawDataSet1.Draw.Select("RandomID=" + lblRandomNumber.Text).First() as drawDataSet.DrawRow;
            this.winnersTableAdapter1.InsertWinner(dr.ID, dr.NameSurname, dr.EmplNo.ToString(), dr.RandomID, dr.Region);
            this.winnersTableAdapter1.Fill(this.drawDataSet1.Winners);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblRandomNumber.Text = new Random().Next(this.drawDataSet1.Draw.Rows.Count).ToString();
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
