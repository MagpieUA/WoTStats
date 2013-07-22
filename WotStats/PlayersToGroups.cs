using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WotStats
{
    public partial class PlayersToGroups : Form
    {
        MainForm mf = new MainForm();
        public static PlayersToGroups m_PlsToGps;

        public static PlayersToGroups GetChildInstance()
        {
            if (m_PlsToGps == null)
                m_PlsToGps = new PlayersToGroups();
            return m_PlsToGps;
        }

        public PlayersToGroups()
        {  
            InitializeComponent();
        //    LoadPlayers();
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT DISTINCT Name FROM Groups";
            SqlDataReader sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                cboxGroup.Items.Add(sdr["Name"].ToString().Trim());
            }
            sdr.Close();
            myCommand.CommandText = "SELECT DISTINCT Title FROM Status";
            sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                cboxStatus.Items.Add(sdr["Title"].ToString().Trim());
            }
            cboxGroup.SelectedIndex = 0;
            cboxSubgroup.SelectedIndex = 0;
            cboxStatus.SelectedIndex = 0;
            conn.Close();
            sdr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PlayersToGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_PlsToGps = null;
        }

        private void cboxGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboxSubgroup.Items.Clear();
            cboxSubgroup.Items.Add("Выберите подгруппу");
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

        private void LoadPlayers()
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT Name FROM Players ORDER BY Name";
            SqlDataReader sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                lstOut.Items.Add(sdr["Name"].ToString().Trim());
            //    txtOut.LineDown();
            }
        }

        private void cboxSubgroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((!cboxGroup.SelectedIndex.Equals(0)) & (!cboxSubgroup.SelectedIndex.Equals(0)))
                FindPlsToGps();
        }

        private void FindPlsToGps()
        {
            lstIn.Items.Clear();
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT ID FROM Groups WHERE (Name = '" +
                cboxGroup.SelectedItem.ToString() + "' AND Subname = '" +
                cboxSubgroup.SelectedItem.ToString() + "')";
            int groupID = (Int32)myCommand.ExecuteScalar();
            myCommand.CommandText = "SELECT Name FROM Players " +
            "JOIN  PlayersToGroups ON (Players.ID = PlayersToGroups.PlayerID) " +
            "WHERE PlayersToGroups.GroupID = " + groupID.ToString() + " ORDER BY NAME";
            SqlDataReader sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                lstIn.Items.Add(sdr["Name"].ToString().Trim());
            }
            sdr.Close();
            lstOut.Items.Clear();
            myCommand.CommandText = "SELECT DISTINCT Name FROM Players " +
            "LEFT JOIN  PlayersToGroups ON (Players.ID = PlayersToGroups.PlayerID) " +
            "WHERE ((SELECT COUNT(PlayerID) FROM PlayersToGroups WHERE " +
            "PlayersToGroups.GroupID = " + groupID.ToString() +
            " AND PlayersToGroups.PlayerID = Players.ID) = 0) ORDER BY NAME";
            sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                lstOut.Items.Add(sdr["Name"].ToString().Trim());
            }
            sdr.Close();
            conn.Close();
            lblCountOut.Text = lstOut.Items.Count.ToString();
            lblCountIn.Text = lstIn.Items.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT ID FROM Groups WHERE (Name = '" +
                cboxGroup.SelectedItem.ToString() + "' AND Subname = '" +
                cboxSubgroup.SelectedItem.ToString() + "')";
            int groupID = (Int32)myCommand.ExecuteScalar();
            myCommand.CommandText = "SELECT ID FROM Status WHERE Title = '" + cboxStatus.SelectedItem + "'";
            int statusID = (Int32)myCommand.ExecuteScalar();
            for (int i = 0; i < lstOut.Items.Count; i++)
            {
                if (lstOut.GetSelected(i) == true)
                {
                    myCommand.CommandText = "SELECT ID FROM Players WHERE Name = '" +
                        lstOut.Items[i] + "'";
                    int playerID = (Int32)myCommand.ExecuteScalar();
                    myCommand.CommandText = "INSERT INTO PlayersToGroups VALUES ("
                        + playerID + "," + groupID + "," + statusID + ")";
                    myCommand.ExecuteNonQuery();
          //          MessageBox.Show(playerID + "---->" + groupID + "--->" + statusID);
                    lstIn.Items.Add(lstOut.Items[i]);
                }
            }
            while (lstOut.SelectedItems.Count > 0)
                lstOut.Items.Remove(lstOut.SelectedItem);
            lblCountOut.Text = lstOut.Items.Count.ToString();
            lblCountIn.Text = lstIn.Items.Count.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT ID FROM Groups WHERE (Name = '" +
                cboxGroup.SelectedItem.ToString() + "' AND Subname = '" +
                cboxSubgroup.SelectedItem.ToString() + "')";
            int groupID = (Int32)myCommand.ExecuteScalar();
            for (int i = 0; i < lstIn.Items.Count; i++)
            {
                if (lstIn.GetSelected(i) == true)
                {
                    myCommand.CommandText = "SELECT ID FROM Players WHERE Name = '" +
                        lstIn.Items[i] + "'";
                    int playerID = (Int32)myCommand.ExecuteScalar();
                    myCommand.CommandText = "DELETE FROM PlayersToGroups WHERE PlayerID = " +
                        playerID + " AND GroupID = " + groupID;
                    myCommand.ExecuteNonQuery();
                }
            }
            while (lstIn.SelectedItems.Count > 0)
                lstIn.Items.Remove(lstIn.SelectedItem);
            lblCountOut.Text = lstOut.Items.Count.ToString();
            lblCountIn.Text = lstIn.Items.Count.ToString();
        }

    }
}
