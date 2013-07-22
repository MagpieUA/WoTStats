using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WotStats
{
    public partial class ProcessGroup : Form
    {
        MainForm mf = new MainForm();
        public static ProcessGroup m_ProcessGroup;

        public static ProcessGroup GetChildInstance()
        {
            if (m_ProcessGroup == null)
                m_ProcessGroup = new ProcessGroup();
            return m_ProcessGroup;
        }

        public ProcessGroup()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT DISTINCT Name FROM Groups";
            SqlDataReader sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                cboxGroup.Items.Add(sdr["Name"].ToString().Trim());
            }
            cboxGroup.SelectedIndex = 0;
            conn.Close();
            sdr.Close();
            pbarProcess.Value = 0;
        }

        private void Processing()
        {
            int counter = 0;
            pbarProcess.Value = 0;
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT Id FROM Groups WHERE (Name = '" + cboxGroup.SelectedItem.ToString() +
                "') AND (Subname = '" + cboxSubgroup.SelectedItem.ToString() + "')";
            int groupID = (Int32)myCommand.ExecuteScalar();
            myCommand.CommandText = "SELECT Name, Number, ID FROM Players " +
            "JOIN  PlayersToGroups ON (Players.ID = PlayersToGroups.PlayerID) " +
            "WHERE PlayersToGroups.GroupID = " + groupID.ToString();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommand.CommandText, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            pbarProcess.Maximum = dt.Rows.Count;
            SqlParameter param = myCommand.Parameters.Add("@curTime", SqlDbType.DateTime);
            foreach (DataRow r in dt.Rows)
            {
                myCommand.CommandText = @"SELECT COUNT(*) FROM Stats
                                        WHERE floor(convert(float, time)) = floor(convert(float, @curtime))
                                        AND PlayerID = " + r[2];
                param.Value = DateTime.Now;
                int statCount = (Int32)myCommand.ExecuteScalar();
                if (statCount == 0)
                {
                    string name = r[1] + "-" + r[0].ToString().Trim();
                    mf.GetPageFromWeb(name);
                    mf.GetStatsFromPage();
                    mf.curstat.name = r[0].ToString();
                    myCommand.CommandText = "INSERT INTO Stats (PlayerID, GPL, GPLrate, WIN, WINrate, WpBrate, LOS, SRV, FRG, FRGrate," +
                        "SPT, SPTrate, HitPerc, DMG, DMGrate, CPT, CPTrate, DPT, DPTrate, EXP, EXPrate, EpB, EpBrate, EXPmax," +
                        "GR, GRrate, time) VALUES (" + r[2] + "," + mf.curstat.GPL + "," + mf.curstat.GPLrate + "," + mf.curstat.WIN + "," + mf.curstat.WINrate +
                        "," + mf.curstat.WpBrate + "," + mf.curstat.LOS + "," + mf.curstat.SRV + "," + mf.curstat.FRG + "," + mf.curstat.FRGrate +
                        "," + mf.curstat.SPT + "," + mf.curstat.SPTrate + "," + mf.curstat.HitPerc + "," + mf.curstat.DMG + "," + mf.curstat.DMGrate +
                        "," + mf.curstat.CPT + "," + mf.curstat.CPTrate + "," + mf.curstat.DPT + "," + mf.curstat.DPTrate + "," + mf.curstat.EXP +
                        "," + mf.curstat.EXPrate + "," + mf.curstat.EpB + "," + mf.curstat.EpBrate + "," + mf.curstat.EXPmax +
                        "," + mf.curstat.GR + "," + mf.curstat.GRrate + ", @curTime)";
                    param.Value = DateTime.Now;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = "SELECT COUNT(*) FROM LastStats WHERE PlayerID = " + r[2];
                    int updCount = (Int32)myCommand.ExecuteScalar();
                    if (updCount == 0)
                    {
                        myCommand.CommandText = "INSERT INTO LastStats (PlayerID, GPL, GPLrate, WIN, WINrate, WpBrate, LOS, SRV, FRG, FRGrate," +
                            "SPT, SPTrate, HitPerc, DMG, DMGrate, CPT, CPTrate, DPT, DPTrate, EXP, EXPrate, EpB, EpBrate, EXPmax," +
                            "GR, GRrate, time) VALUES (" + r[2] + "," + mf.curstat.GPL + "," + mf.curstat.GPLrate + "," + mf.curstat.WIN + "," + mf.curstat.WINrate +
                            "," + mf.curstat.WpBrate + "," + mf.curstat.LOS + "," + mf.curstat.SRV + "," + mf.curstat.FRG + "," + mf.curstat.FRGrate +
                            "," + mf.curstat.SPT + "," + mf.curstat.SPTrate + "," + mf.curstat.HitPerc + "," + mf.curstat.DMG + "," + mf.curstat.DMGrate +
                            "," + mf.curstat.CPT + "," + mf.curstat.CPTrate + "," + mf.curstat.DPT + "," + mf.curstat.DPTrate + "," + mf.curstat.EXP +
                            "," + mf.curstat.EXPrate + "," + mf.curstat.EpB + "," + mf.curstat.EpBrate + "," + mf.curstat.EXPmax +
                            "," + mf.curstat.GR + "," + mf.curstat.GRrate + ", @curTime)";
                    }
                    else
                        myCommand.CommandText = "UPDATE LastStats SET GPL = " + mf.curstat.GPL + ", GPLrate = " + mf.curstat.GPLrate +
                            ", WIN = " + mf.curstat.WIN + ", WINrate = " + mf.curstat.WINrate + ", WpBrate = " + mf.curstat.WpBrate +
                            ", LOS = " + mf.curstat.LOS + ", SRV = " + mf.curstat.SRV + ", FRG = " + mf.curstat.FRG +
                            ", FRGrate = " + mf.curstat.FRGrate + ", SPT = " + mf.curstat.SPT + ", SPTrate = " + mf.curstat.SPTrate +
                            ", HitPerc = " + mf.curstat.HitPerc + ", DMG = " + mf.curstat.DMG + ", DMGrate = " + mf.curstat.DMGrate +
                            ", CPT = " + mf.curstat.CPT + ", CPTrate = " + mf.curstat.CPTrate + ", DPT = " + mf.curstat.DPT +
                            ", DPTrate = " + mf.curstat.DPTrate + ", EXP = " + mf.curstat.EXP + ", EXPrate = " + mf.curstat.EXPrate +
                            ", EpB = " + mf.curstat.EpB + ", EpBrate = " + mf.curstat.EpBrate + ", EXPmax = " + mf.curstat.EXPmax +
                            ", GR = " + mf.curstat.GR + ", GRrate = " + mf.curstat.GRrate + ", time = @curtime " +
                            "WHERE PlayerID = " + r[2];
                    param.Value = DateTime.Now;
                    myCommand.ExecuteNonQuery();
                }
                pbarProcess.PerformStep();
                counter++;
                lblProcCounter.Text = counter.ToString() + "/" + dt.Rows.Count;
                this.Refresh();
            }
            //      MessageBox.Show(dt.Rows[0][0].ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Processing));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void cboxGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT Subname FROM Groups WHERE Name = '" + cboxGroup.SelectedItem.ToString() + "' ORDER BY Subname";
            SqlDataReader sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                cboxSubgroup.Items.Add(sdr["Subname"].ToString().Trim());
            }
            cboxSubgroup.SelectedIndex = 0;
            conn.Close();
            sdr.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProcessGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_ProcessGroup = null;
        }
    }
}
