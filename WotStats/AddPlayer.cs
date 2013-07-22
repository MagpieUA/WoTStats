using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WotStats
{
    public partial class AddPlayer : Form
    {
        MainForm mf = new MainForm();
        private static AddPlayer m_AddPlayer;

        public static AddPlayer GetChildInstance()
        {
            if (m_AddPlayer == null)
                m_AddPlayer = new AddPlayer();
            return m_AddPlayer;
        }

        public AddPlayer()
        {
            InitializeComponent();
            cboxGroup.Items.Add("Выберите группу");
            cboxSubgroup.Items.Add("Выберите подгруппу");
            cboxStatus.Items.Add("Выберите статус");
            cboxGroup.SelectedIndex = 0;
            cboxStatus.SelectedIndex = 0;
            cboxSubgroup.SelectedIndex = 0;
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
            conn.Close();
            sdr.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            m_AddPlayer = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((cboxGroup.SelectedIndex == 0) || (cboxSubgroup.SelectedIndex == 0) || (cboxStatus.SelectedIndex == 0))
            {
                MessageBox.Show("Не выбран один из обязательных параметров");
                return;
            }
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT COUNT(Name) FROM Players WHERE NAME = '" + txtName.Text.ToLower() + "'";
            int countEqual = (Int32)myCommand.ExecuteScalar();
            if ((countEqual == 0) & (txtName.Text.Trim() != "") & (txtIndex.Text.Trim() != ""))
            {
                myCommand.CommandText = "INSERT INTO Players (Name, Number) VALUES('" +
                    txtName.Text + "', " + Convert.ToInt32(txtIndex.Text) + ")";
                myCommand.ExecuteNonQuery();
                //    MessageBox.Show("Игрок " + txtName.Text + " добавлен в базу");
                myCommand.CommandText = "SELECT ID FROM Players WHERE Name = '" + txtName.Text + "'";
                int playerID = (Int32)myCommand.ExecuteScalar();
                myCommand.CommandText = "SELECT ID FROM Groups WHERE (Name = '" + cboxGroup.SelectedItem +
                    "' AND Subname = '" + cboxSubgroup.SelectedItem + "')";
                int groupID = (Int32)myCommand.ExecuteScalar();
                myCommand.CommandText = "SELECT ID FROM Status WHERE Title = '" + cboxStatus.SelectedItem + "'";
                int statusID = (Int32)myCommand.ExecuteScalar();
                myCommand.CommandText = "INSERT INTO PlayersToGroups (PlayerID, GroupID, StatusID) VALUES(" +
                    playerID + ", " + groupID + ", " + statusID + ")";
                myCommand.ExecuteNonQuery(); 
            }
            else
                MessageBox.Show("Ошибка. Игрок с таким ником уже занесен в базу либо неверно введен ник/индекс игрока");
            txtName.Clear();
            txtIndex.Clear();
            if (!cbxKeepGroup.Checked) cboxGroup.ResetText();
            if (!cbxKeepSubgroup.Checked) cboxSubgroup.ResetText();
            if (!cbxKeepStatus.Checked) cboxStatus.ResetText();
            txtName.Select();
            conn.Close();
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void txtIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, new EventArgs());
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
            conn.Close();
            sdr.Close();
        }

        private void AddPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_AddPlayer = null;
        }
    }
}
