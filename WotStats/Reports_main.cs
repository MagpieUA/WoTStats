using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
// using Microsoft.Office.Interop.Excel;

namespace WotStats
{
    public partial class Reports_main : Form
    {
        MainForm mf = new MainForm();
        public static Reports_main m_ReportsMain;

        public static Reports_main GetChildInstance()
        {
            if (m_ReportsMain == null)
                m_ReportsMain = new Reports_main();
            return m_ReportsMain;
        }

        public Reports_main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tscboxGroup.Items.Add("Выберите группу");
            tscboxSubgroup.Items.Add("Выберите подгруппу");
            tscboxStatus.Items.Add("Все члены группы");
            tscboxGroup.SelectedIndex = 0;
            tscboxSubgroup.SelectedIndex = 0;
            tscboxStatus.SelectedIndex = 0;
            tscboxNumber.SelectedIndex = 0;
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT DISTINCT Name FROM Groups";
            SqlDataReader sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                tscboxGroup.Items.Add(sdr["Name"].ToString().Trim());
            }
            sdr.Close();
            myCommand.CommandText = "SELECT DISTINCT Title FROM Status";
            sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                tscboxStatus.Items.Add(sdr["Title"].ToString().Trim());
            }
            conn.Close();
            sdr.Close();
        }

        private void tscboxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT Subname FROM Groups WHERE Name = '" + tscboxGroup.SelectedItem.ToString() + "' ORDER BY Subname";
            SqlDataReader sdr = myCommand.ExecuteReader();
            while (sdr.Read())
            {
                tscboxSubgroup.Items.Add(sdr["Subname"].ToString().Trim());
            }
            conn.Close();
            sdr.Close();
        }

        private void tvReport_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (tvReport.SelectedNode.Name)
            {
                case "nAvgDamage":
                    ReportSmthPerB("DMG)/GPL", tvReport.SelectedNode.Text);
                    break;
                case "nWinPercent":
                    ReportSmthPerB("WIN)/GPL", tvReport.SelectedNode.Text);
                    break;
                case "nEpB":
                    ReportSmthPerB("EXP)/GPL", tvReport.SelectedNode.Text);
                    break;
                case "nCPTpB":
                    ReportSmthPerB("CPT)/GPL", tvReport.SelectedNode.Text);
                    break;
                case "nDPTpB":
                    ReportSmthPerB("DPT)/GPL", tvReport.SelectedNode.Text);
                    break;
                case "nSPTpB":
                    ReportSmthPerB("SPT)/GPL", tvReport.SelectedNode.Text);
                    break;
                case "nFRGpB":
                    ReportSmthPerB("FRG)/GPL", tvReport.SelectedNode.Text);
                    break;
                case "nExpMax":
                    ReportSmthFull("EXPmax", tvReport.SelectedNode.Text);
                    break;
                case "nPlay":
                    ReportSmthFull("GPL", tvReport.SelectedNode.Text);
                    break;
                case "nFRG":
                    ReportSmthFull("FRG", tvReport.SelectedNode.Text);
                    break;
                case "nOld":
                    ReportOld();
                    break;
                case "nWin":
                    ReportSmthFull("WIN", tvReport.SelectedNode.Text);
                    break;
                case "nCPT":
                    ReportSmthFull("CPT", tvReport.SelectedNode.Text);
                    break;
                case "nDMG":
                    ReportSmthFull("DMG", tvReport.SelectedNode.Text);
                    break;
                case "nDPT":
                    ReportSmthFull("DPT", tvReport.SelectedNode.Text);
                    break;
                case "nSPT":
                    ReportSmthFull("SPT", tvReport.SelectedNode.Text);
                    break;
            }
        }

        private void ReportOld()
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT  ID FROM Groups WHERE Name = '" +
                tscboxGroup.SelectedItem + "' AND Subname = '" +
                tscboxSubgroup.SelectedItem + "'";
            int groupID = (Int32)myCommand.ExecuteScalar();
            myCommand.CommandText = "SELECT TOP " + tscboxNumber.SelectedItem +
                " Name, Number FROM Players " +
                "JOIN PlayersToGroups ON (PlayersToGroups.PlayerID = Players.ID) " +
                "WHERE PlayersToGroups.GroupID = " + groupID.ToString() +
                " ORDER BY (Number)";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommand.CommandText, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgvReportResult.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgvReportResult.DataSource = bs;
            dgvReportResult.ReadOnly = true;
            dgvReportResult.Columns[0].HeaderText = "Игрок";
            dgvReportResult.Columns[1].HeaderText = "Индекс регистрации";
            for (int i = 0; i < dgvReportResult.RowCount; i++)
            {
                dgvReportResult.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            dgvReportResult.RowHeadersWidth = 50;
            conn.Close();
        }

        private void tsExport_Click(object sender, EventArgs e)
        {
            ExportBBCurrent();
        }

        private void ExportBBCurrent()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string exportfile = "Reports\\Абсолют_" + tscboxGroup.SelectedItem + "_" +
                tscboxSubgroup.SelectedItem + "_" + tscboxNumber.Text + "_" +
                tvReport.SelectedNode.Text + "_" + dt.ToString("yyyyMMdd_HHmm") + ".txt";
            FileStream FS = new FileStream(exportfile, FileMode.OpenOrCreate);
            StreamWriter SW = new StreamWriter(FS, System.Text.Encoding.UTF8);
            SW.WriteLine("[table]");
            for (int i = 0; i < (dgvReportResult.RowCount - 2); i++)
            {
                SW.Write("[tr][td]" + (i+1).ToString() + "  [/td]");
                for (int j = 0; j < dgvReportResult.ColumnCount; j++)
                {
                    SW.Write("[td]" + dgvReportResult.Rows[i].Cells[j].Value.ToString() + "[/td]");
                }
                SW.Write("[/tr]");
                SW.WriteLine();
            }
            SW.WriteLine("[/table]");
            SW.Close();
            MessageBox.Show("Экспорт BB-кода произведен в файл " + exportfile);
        }








        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExportXMLAll();
        }

        private void ExportXMLAll()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string exportfile = "Reports\\Абсолют_" + tscboxGroup.SelectedItem + "_" +
                tscboxSubgroup.SelectedItem + "_" + tscboxNumber.Text + "_ALL_" + dt.ToString("yyyyMMdd_HHmm") + ".xml";
            //куча xml-кода, который будем писать в файл
            string header = @"<?xml version='1.0'?><Workbook xmlns='urn:schemas-microsoft-com:office:spreadsheet'
                                xmlns:o='urn:schemas-microsoft-com:office:office'
                                xmlns:x='urn:schemas-microsoft-com:office:excel'
                                xmlns:ss='urn:schemas-microsoft-com:office:spreadsheet'
                                xmlns:html='http://www.w3.org/TR/REC-html40'>
                                <ExcelWorkbook xmlns='urn:schemas-microsoft-com:office:excel'>
                                </ExcelWorkbook>";
            string styleDefault = @"<Styles>  <Style ss:ID='Default' ss:Name='Normal'>
                              <Alignment ss:Vertical='Bottom'/>
                              <Borders/>
                              <Font ss:FontName='Arial Cyr' x:CharSet='204'/>
                              <Interior/><NumberFormat/><Protection/></Style>";
            string styleOther = @"<Style ss:ID='s21'><Font ss:FontName='Arial Cyr' x:CharSet='204' ss:Size='16'/>
                                </Style>
                                <Style ss:ID='s22'>
                                <Borders>
                                <Border ss:Position='Bottom' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Left' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Right' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Top' ss:LineStyle='Continuous' ss:Weight='1'/>
                                </Borders>
                                <NumberFormat ss:Format='0.0000'/>
                                </Style>
                                <Style ss:ID='s23'>
                                <Borders>
                                <Border ss:Position='Bottom' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Left' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Right' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Top' ss:LineStyle='Continuous' ss:Weight='1'/>
                                </Borders>
                                <Interior ss:Color='#FFFF99' ss:Pattern='Solid'/>
                                </Style>
                                <Style ss:ID='s24'>
                                <Borders>
                                <Border ss:Position='Bottom' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Left' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Right' ss:LineStyle='Continuous' ss:Weight='1'/>
                                <Border ss:Position='Top' ss:LineStyle='Continuous' ss:Weight='1'/>
                                </Borders>
                                </Style></Styles>";

            //просто пишем файл
            FileStream FS = new FileStream(exportfile, FileMode.Create);
            StreamWriter theWriter = new StreamWriter(FS, System.Text.Encoding.UTF8);
            theWriter.WriteLine(header);
            theWriter.WriteLine(styleDefault);
            theWriter.WriteLine(styleOther);
            ReportSmthPerB("EXP)/GPL", "Средний опыт");
            WriteXMLWorksheet(theWriter, "22");
            ReportSmthPerB("FRG)/GPL", "Убито за бой");
            WriteXMLWorksheet(theWriter, "22");
            ReportSmthPerB("DMG)/GPL", "Средний дамаг");
            WriteXMLWorksheet(theWriter, "22");
            ReportSmthPerB("WIN)/GPL", "Процент побед");
            WriteXMLWorksheet(theWriter, "22");
            ReportSmthPerB("CPT)/GPL", "Средний захват");
            WriteXMLWorksheet(theWriter, "22");
            ReportSmthPerB("DPT)/GPL", "Средняя защита");
            WriteXMLWorksheet(theWriter, "22");
            ReportSmthPerB("SPT)/GPL", "Обнаружено за бой");
            WriteXMLWorksheet(theWriter, "22");
            ReportSmthFull("GPL", "Сыграно боев");
            WriteXMLWorksheet(theWriter, "24");
            ReportSmthFull("EXPmax", "Максимальный опыт");
            WriteXMLWorksheet(theWriter, "24");
            ReportSmthFull("FRG", "Убито врагов");
            WriteXMLWorksheet(theWriter, "24");
            ReportSmthFull("DMG", "Нанесенный дамаг");
            WriteXMLWorksheet(theWriter, "24");
            ReportSmthFull("WIN", "Кол-во пПобед");
            WriteXMLWorksheet(theWriter, "24");
            ReportSmthFull("CPT", "Захват базы");
            WriteXMLWorksheet(theWriter, "24");
            ReportSmthFull("DPT", "Защита базы");
            WriteXMLWorksheet(theWriter, "24");
            ReportSmthFull("SPT", "Обнаружено врагов");
            WriteXMLWorksheet(theWriter, "24");
            theWriter.Write("</Workbook>");
            theWriter.Close();
            MessageBox.Show("Экспорт XML-Файла произведен в файл " + exportfile);
        }

        private void WriteXMLWorksheet(StreamWriter theWriter, string style)
        {
            string s = "";
            string element = "";
            string worksheet_main = @"<Worksheet ss:Name='" + dgvReportResult.Columns[1].HeaderText + @"'>
                               <Table>
                               <Column ss:Width='50'/><Column ss:Width='150'/>
                               <Row ss:Height='20.25'>
                               <Cell ss:StyleID='s21'><Data ss:Type='String'>" +
                         dgvReportResult.Columns[1].HeaderText + @"</Data></Cell>
                               </Row>
                               <Row ss:Index='3'>
                               <Cell ss:StyleID='s23'><Data ss:Type='String'>Место</Data></Cell>
                               <Cell ss:StyleID='s23'><Data ss:Type='String'>Имя</Data></Cell>
                               <Cell ss:StyleID='s23'><Data ss:Type='String'>Значение</Data></Cell>
                               </Row>";
            string footer = @"</Table></Worksheet>";
            theWriter.WriteLine(worksheet_main);
            // Вывод значений по группе
            for (int i = 0; i < (dgvReportResult.RowCount - 2); i++)
            {
                s = dgvReportResult.Rows[i].Cells[1].Value.ToString();
                s = s.Replace(",", ".");
                element = @"<Row>
                            <Cell ss:StyleID='s24'><Data ss:Type='Number'>" + (i + 1).ToString() + @"</Data></Cell>
                            <Cell ss:StyleID='s22'><Data ss:Type='String'>" + dgvReportResult.Rows[i].Cells[0].Value.ToString() + @"</Data></Cell>
                            <Cell ss:StyleID='s" + style + "'><Data ss:Type='Number'>" + s + @"</Data></Cell>
                            </Row>";
                theWriter.WriteLine(element);
            }
            element = @"<Row></Row>";
            theWriter.WriteLine(element);
            // Вывод среднего значения
            int size = dgvReportResult.RowCount - 1;
            s = dgvReportResult.Rows[size].Cells[1].Value.ToString();
            s = s.Replace(",", ".");
            element = @"<Row>
                        <Cell></Cell>
                        <Cell ss:StyleID='s22'><Data ss:Type='String'>" + dgvReportResult.Rows[size].Cells[0].Value.ToString() + @"</Data></Cell>
                        <Cell ss:StyleID='s" + style + "'><Data ss:Type='Number'>" + s + @"</Data></Cell>
                        </Row>";
            theWriter.WriteLine(element);
            theWriter.WriteLine(footer);

        }

        private void Reports_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_ReportsMain = null;
        }

        private void tsExportAll_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string exportfile = "Reports\\Абсолют_" + tscboxGroup.SelectedItem + "_" +
                tscboxSubgroup.SelectedItem + "_" + tscboxNumber.Text + "_ALL_" + dt.ToString("yyyyMMdd_HHmm") + ".txt";
            FileStream FS = new FileStream(exportfile, FileMode.OpenOrCreate);
            StreamWriter SW = new StreamWriter(FS, System.Text.Encoding.UTF8);
            SW.WriteLine("Абсолютная статистика " + tscboxGroup.SelectedItem + "--" + tscboxSubgroup.SelectedItem);
            SW.WriteLine("[b]Средние показатели[/b]");
            ReportSmthPerB("EXP)/GPL", "Средний опыт");
            WriteTableToFile(SW);
            ReportSmthPerB("FRG)/GPL", "Убито за бой");
            WriteTableToFile(SW);
            ReportSmthPerB("DMG)/GPL", "Средний дамаг");
            WriteTableToFile(SW);
            ReportSmthPerB("WIN)/GPL", "Процент побед");
            WriteTableToFile(SW);
            ReportSmthPerB("CPT)/GPL", "Среднийз захват");
            WriteTableToFile(SW);
            ReportSmthPerB("DPT)/GPL", "Средняя защита");
            WriteTableToFile(SW);
            ReportSmthPerB("SPT)/GPL", "Обнаружено за бой");
            WriteTableToFile(SW);
            SW.WriteLine("[b]Абсолютные показатели[/b]");
            ReportSmthFull("GPL", "Сыграно боев");
            WriteTableToFile(SW);
            ReportSmthFull("EXPmax", "Максимальный опыт");
            WriteTableToFile(SW);
            ReportSmthFull("FRG", "Убито врагов");
            WriteTableToFile(SW);
            ReportSmthFull("DMG", "Нанесенный дамаг");
            WriteTableToFile(SW);
            ReportSmthFull("WIN", "Кол-во побед");
            WriteTableToFile(SW);
            ReportSmthFull("CPT", "Захват базы");
            WriteTableToFile(SW);
            ReportSmthFull("DPT", "Защита базы");
            WriteTableToFile(SW);
            ReportSmthFull("SPT", "Обнаружено врагов");
            WriteTableToFile(SW);
            SW.Close();
            MessageBox.Show("Экспорт BB-кода произведен в файл " + exportfile);
        }

        private void WriteTableToFile(StreamWriter file)
        {
            file.WriteLine("[spoiler=" + dgvReportResult.Columns[1].HeaderText + "]");
            file.WriteLine("[table]");
            for (int i = 0; i < dgvReportResult.RowCount - 2; i++)
            {
                file.Write("[tr][td]" + (i + 1).ToString() + "  [/td]");
                for (int j = 0; j < dgvReportResult.ColumnCount; j++)
                {
                    file.Write("[td]" + dgvReportResult.Rows[i].Cells[j].Value.ToString() + "[/td]");
                }
                file.Write("[/tr]");
                file.WriteLine();
            }
            file.WriteLine("[/table]");
            file.WriteLine("[/spoiler]");
        }

        private void ReportSmthPerB(string type, string header)
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT  ID FROM Groups WHERE Name = '" +
                tscboxGroup.SelectedItem + "' AND Subname = '" +
                tscboxSubgroup.SelectedItem + "'";
            int groupID = (Int32)myCommand.ExecuteScalar();
            myCommand.CommandText = "SELECT TOP " + tscboxNumber.SelectedItem +
                " Players.Name, CONVERT(numeric(10,4),(CONVERT(numeric(10), " + type + ")) FROM LastStats " +
                "JOIN Players ON (Players.ID = LastStats.PlayerID) " +
                "JOIN PlayersToGroups ON (PlayersToGroups.PlayerID = LastStats.PlayerID) " +
                "WHERE PlayersToGroups.GroupID = " + groupID.ToString() +
                " ORDER BY (CONVERT(numeric(10), " + type + ") DESC";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommand.CommandText, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgvReportResult.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dt.Rows.Add();
            dt.Rows.Add();
            dgvReportResult.DataSource = bs;
            dgvReportResult.ReadOnly = true;
            dgvReportResult.Columns[0].HeaderText = "Игрок";
            dgvReportResult.Columns[1].HeaderText = header;
            int size = dgvReportResult.RowCount - 1;
            decimal sum = 0;
            for (int i = 0; i < (dgvReportResult.RowCount-2); i++)
            {
                dgvReportResult.Rows[i].HeaderCell.Value = (i + 1).ToString();
                sum = sum + (decimal)dt.Rows[i]["Column1"];
            }
            decimal avg = sum / (size - 2);
            dgvReportResult.Rows[size].Cells[0].Value = "В среднем";
            dgvReportResult.Rows[size].Cells[1].Value = avg.ToString("0.0000");
            dgvReportResult.RowHeadersWidth = 50;
            conn.Close();
        }

        private void ReportSmthFull(string type, string header)
        {
            SqlConnection conn = new SqlConnection(mf.connection);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT  ID FROM Groups WHERE Name = '" +
                tscboxGroup.SelectedItem + "' AND Subname = '" +
                tscboxSubgroup.SelectedItem + "'";
            int groupID = (Int32)myCommand.ExecuteScalar();
            myCommand.CommandText = "SELECT TOP " + tscboxNumber.SelectedItem +
                " Players.Name, " + type + " FROM LastStats " +
                "JOIN Players ON (Players.ID = LastStats.PlayerID) " +
                "JOIN PlayersToGroups ON (PlayersToGroups.PlayerID = LastStats.PlayerID) " +
                "WHERE PlayersToGroups.GroupID = " + groupID.ToString() +
                " ORDER BY (" + type + ") DESC";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommand.CommandText, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgvReportResult.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dt.Rows.Add();
            dt.Rows.Add();
            dgvReportResult.DataSource = bs;
            dgvReportResult.ReadOnly = true;
            dgvReportResult.Columns[0].HeaderText = "Игрок";
            dgvReportResult.Columns[1].HeaderText = header;
            int size = dgvReportResult.RowCount - 1;
            Int32 sum = 0;
            for (int i = 0; i < (dgvReportResult.RowCount - 2); i++)
            {
                dgvReportResult.Rows[i].HeaderCell.Value = (i + 1).ToString();
                sum = sum + (Int32)dt.Rows[i][type];
            }
            Int32 avg = (Int32)Math.Round((decimal)(sum / (size - 2)));
            dgvReportResult.Rows[size].Cells[0].Value = "В среднем";
            dgvReportResult.Rows[size].Cells[1].Value = avg.ToString();
            dgvReportResult.RowHeadersWidth = 50;
            conn.Close();
        }
    }
}
