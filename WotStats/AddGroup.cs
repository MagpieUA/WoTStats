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
    public partial class AddGroup : Form
    {
        MainForm mf = new MainForm();
        private static AddGroup m_AddGroup;

        public static AddGroup GetChildInstance()
        {
            if (m_AddGroup == null)
                m_AddGroup = new AddGroup();
            return m_AddGroup;
        }

        public AddGroup()
        {
            InitializeComponent();
            cboxGroup.Items.Add("Введите группу");
            cboxGroup.SelectedIndex = 0;
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
            conn.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "INSERT INTO Groups (Name,Subname) VALUES ('" +
                cboxGroup.Text +"', '" + txtSubgroup.Text + "')";
            myCommand.ExecuteNonQuery();
            MessageBox.Show("Группа " + cboxGroup.Text + " ---> " + txtSubgroup.Text + " добавлена в базу");
            cboxGroup.SelectedIndex = 0;
            txtSubgroup.Clear();
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            m_AddGroup = null;
        }

        private void AddGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_AddGroup = null;
        }
    }
}
