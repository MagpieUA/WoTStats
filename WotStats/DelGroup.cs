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
    public partial class DelGroup : Form
    {
        MainForm mf = new MainForm();
        private static DelGroup m_DelGroup;

        public static DelGroup GetChildInstance()
        {
            if (m_DelGroup == null)
                m_DelGroup = new DelGroup();
            return m_DelGroup;
        }

        public DelGroup()
        {
            InitializeComponent();
            DataReload();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            m_DelGroup = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((cboxGroup.SelectedIndex == 0) || (cboxSubgroup.SelectedIndex == 0))
            {
                MessageBox.Show("Не выбран один из обязательных параметров");
                return;
            }
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = @"SELECT ID FROM Groups
                    WHERE name = '" + cboxGroup.SelectedItem.ToString() + @"' AND
                    subname = '" + cboxSubgroup.SelectedItem.ToString() + "'";
            int groupID = (Int32)myCommand.ExecuteScalar();
      //      MessageBox.Show(groupID.ToString());
            myCommand.CommandText = "DELETE FROM PlayersToGroups WHERE GroupID = '" + groupID + "'";
            myCommand.ExecuteNonQuery();
            myCommand.CommandText = "DELETE FROM Groups WHERE ID = '" + groupID + "'";
            myCommand.ExecuteNonQuery();
            MessageBox.Show("Группа " + cboxGroup.SelectedItem.ToString() + " ---> " +
                cboxSubgroup.SelectedItem.ToString() + " удалена");
            conn.Close();
            DataReload();
        }

        private void cboxGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboxSubgroup.Items.Clear();
            cboxSubgroup.Items.Add("Выберите подгруппу");
            cboxSubgroup.SelectedIndex = 0;
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

        private void DataReload()
        {
            cboxGroup.Items.Clear();
            cboxSubgroup.Items.Clear();
            cboxGroup.Items.Add("Выберите группу");
            cboxSubgroup.Items.Add("Выберите подгруппу");
            cboxGroup.SelectedIndex = 0;
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
        }

    }
}
