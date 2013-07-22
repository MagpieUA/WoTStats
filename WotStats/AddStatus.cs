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
    public partial class AddStatus : Form
    {
        MainForm mf = new MainForm();
        private static AddStatus m_AddStatus;

        public static AddStatus GetChildInstance()
        {
            if (m_AddStatus == null)
                m_AddStatus = new AddStatus();
            return m_AddStatus;
        }

        public AddStatus()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT COUNT(Title) FROM Status WHERE Title = '" + txtStatus.Text.Trim() + "'";
            int count = (Int32)myCommand.ExecuteScalar();
            if (count == 0)
            {
                myCommand.CommandText = "INSERT INTO Status (Title) VALUES('" + txtStatus.Text.Trim() + "')";
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Статус '" + txtStatus.Text.Trim() + "' добавлен в БД");
                txtStatus.Clear();
            }
            else
                MessageBox.Show("Такой статус уже существует");
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_AddStatus = null;
        }
    }
}
