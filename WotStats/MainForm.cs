using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WotStats
{
    public partial class MainForm : Form
    {
        public struct Stats
        {
            public string name;
            public int GPL, GPLrate;
            public int WIN, WINrate;
            public int WpBrate;
            public int LOS, SRV;
            public int FRG, FRGrate;
            public int SPT, SPTrate;
            public int HitPerc;
            public int DMG, DMGrate;
            public int CPT, CPTrate;
            public int DPT, DPTrate;
            public int EXP, EXPrate;
            public int EpB, EpBrate;
            public int EXPmax;
            public int GR, GRrate;
            public DateTime time;
        }
        string tempfile = "tmp.txt";
        public Stats curstat = new Stats();

        static string serverAddress = @"localhost\SQLEXPRESS";
        public string connection = @"Data Source=" + serverAddress + ";Initial Catalog=WoTStats;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlayer objfrmAddPlayer = AddPlayer.GetChildInstance();
            objfrmAddPlayer.MdiParent = this;
            objfrmAddPlayer.Show();
            objfrmAddPlayer.BringToFront();
        }

        private void GetPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetPageFromWeb("146035-SewerJan");
        }

        public void GetPageFromWeb(string name)
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create("http://challenge.worldoftanks.ru/challenge/accounts/" + name + "/");
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            StreamReader myStreamReader = new StreamReader(
                myHttpWebResponse.GetResponseStream(), Encoding.GetEncoding("utf-8"));
            FileStream FS = new FileStream(tempfile, FileMode.Create);
            StreamWriter SW = new StreamWriter(FS, System.Text.Encoding.UTF8);
            SW.WriteLine(myStreamReader.ReadToEnd());
            SW.Close();
  //          MessageBox.Show("Страница получена");
        }

        public void GetStatsFromPage()
        {
            string s, sw, swres, swrate, s2, s3;
            string regexp1, regexp1_1;
            string regexp2, regexp3;
            FileStream FS = new FileStream(tempfile, FileMode.Open);
            FileStream Reg = new FileStream("regtest.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS, System.Text.Encoding.UTF8);
            StreamReader RegSR = new StreamReader(Reg, System.Text.Encoding.UTF8);
            regexp1 = RegSR.ReadLine();
            regexp2 = RegSR.ReadLine();
            regexp3 = RegSR.ReadLine();
            regexp1_1 = @"[а-яё0-9\%]{1,}";
         //   for (int i = 0; i < 350; i++) SR.ReadLine();
            RegSR.Close();
            while (!SR.EndOfStream)
            {
                s = SR.ReadLine().Trim();
            //    s = s.Replace("&nbsp;", " ");
            //    MessageBox.Show(s);
                if (Regex.IsMatch(s, regexp1,RegexOptions.IgnoreCase))
                {
                    s = s.Replace(" ", string.Empty);
                    MatchCollection matches = Regex.Matches(s, regexp1_1,RegexOptions.IgnoreCase);
                    sw = matches[0].Value.Trim();
                    s2 = SR.ReadLine().Trim();
                    s3 = SR.ReadLine().Trim();
                    s2 = s2.Replace("&nbsp;", string.Empty);
                    s3 = s3.Replace("&nbsp;", string.Empty);
                    MatchCollection results = Regex.Matches(s2, regexp1_1, RegexOptions.IgnoreCase);
                    MatchCollection rates = Regex.Matches(s3, regexp1_1, RegexOptions.IgnoreCase);
                    swres = results[0].Value;
                    swres = swres.Replace("%", string.Empty);
                    swrate = rates[0].Value;
               //     MessageBox.Show(sw);
               //     MessageBox.Show(sw + "-----" + swres + "-----" + swrate);
                    switch (sw)
                    {
                        case "Общийрейтинг":
                            curstat.GR = System.Convert.ToInt32(swres);
                            curstat.GRrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Процентпобед":
                            curstat.WpBrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Среднийопыт":
                            curstat.EpB = System.Convert.ToInt32(swres);
                            curstat.EpBrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Победы":
                            curstat.WIN = System.Convert.ToInt32(swres);
                            curstat.WINrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Проведенобоёв":
                            curstat.GPL = System.Convert.ToInt32(swres);
                            curstat.GPLrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Захватбазы":
                            curstat.CPT = System.Convert.ToInt32(swres);
                            curstat.CPTrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Нанесенныеповреждения":
                            curstat.DMG = System.Convert.ToInt32(swres);
                            curstat.DMGrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Защитабазы":
                            curstat.DPT = System.Convert.ToInt32(swres);
                            curstat.DPTrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Уничтоженоврагов":
                            curstat.FRG = System.Convert.ToInt32(swres);
                            curstat.FRGrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Обнаруженоврагов":
                            curstat.SPT = System.Convert.ToInt32(swres);
                            curstat.SPTrate = System.Convert.ToInt32(swrate);
                            break;
                        case "Общийопыт":
                            curstat.EXP = System.Convert.ToInt32(swres);
                            curstat.EXPrate = System.Convert.ToInt32(swrate);
                            break;
                        default:
                            break;
                    }
                }
                if (Regex.IsMatch(s, regexp2, RegexOptions.IgnoreCase))
                {
                    s = s.Replace(" ", string.Empty);
                    s2 = SR.ReadLine().Trim();
                    s2 = s2.Replace("&nbsp;", string.Empty);
                    s2 = s2.Replace(" ", string.Empty);
                    MatchCollection names = Regex.Matches(s, regexp1_1, RegexOptions.IgnoreCase);
                    MatchCollection matches = Regex.Matches(s2, regexp1_1, RegexOptions.IgnoreCase);
                    sw = names[0].Value.Trim().Replace(":", string.Empty);
                    swres = matches[0].Value;
                    swres = swres.Replace("%", string.Empty);
                 //   MessageBox.Show(s);
                 //   MessageBox.Show(sw + "-----" + swres);
                    switch (sw)
                    {
                        case "Проигрышей":
                            curstat.LOS = System.Convert.ToInt32(swres);
                            break;
                        case "Выжилвбитвах":
                            curstat.SRV = System.Convert.ToInt32(swres);
                            break;
                        case "Процентпопадания":
                            curstat.HitPerc = System.Convert.ToInt32(swres);
                            break;
                        case "Максимальныйопытзабой":
                            curstat.EXPmax = System.Convert.ToInt32(swres);
                            break;
                        default:
                            break;
                    }
                }
                if (Regex.IsMatch(s, regexp3, RegexOptions.IgnoreCase))
                {
                    s = s.Replace(" ", string.Empty);
                    s2 = SR.ReadLine().Trim();
                    MessageBox.Show(s + "______" + s2);
                }
                curstat.time = DateTime.Now;
            }
            FS.Close();
            Reg.Close();
        }

        private void AddGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroup objfrmAddGroup = AddGroup.GetChildInstance();
            objfrmAddGroup.MdiParent = this;
            objfrmAddGroup.Show();
            objfrmAddGroup.BringToFront();
        }

        private void тестРегэкспаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetStatsFromPage();
        }

        private void LoadDBSettings()
        {
            FileStream FS = new FileStream("settings.ini", FileMode.Open);
            StreamReader SR = new StreamReader(FS, System.Text.Encoding.UTF8);
            serverAddress = SR.ReadLine();
            FS.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDBSettings();
        }

        private void ProcessGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessGroup objfrmProcessGroup = ProcessGroup.GetChildInstance();
            objfrmProcessGroup.MdiParent = this;
            objfrmProcessGroup.Show();
            objfrmProcessGroup.BringToFront();
        }

        private void AddStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStatus objfrmAddStatus = AddStatus.GetChildInstance();
            objfrmAddStatus.MdiParent = this;
            objfrmAddStatus.Show();
            objfrmAddStatus.BringToFront();
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports_main objfrmReportsMain = Reports_main.GetChildInstance();
            objfrmReportsMain.MdiParent = this;
            objfrmReportsMain.Show();
            objfrmReportsMain.BringToFront();
        }

        private void PlsToGpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersToGroups objfrmPlsToGps = PlayersToGroups.GetChildInstance();
            objfrmPlsToGps.MdiParent = this;
            objfrmPlsToGps.Show();
            objfrmPlsToGps.BringToFront();
        }

        private void ReportsPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports_period objfrmReportsPeriod = Reports_period.GetChildInstance();
            objfrmReportsPeriod.MdiParent = this;
            objfrmReportsPeriod.Show();
            objfrmReportsPeriod.BringToFront();
        }

        private void DelGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelGroup objfrmDelGroup = DelGroup.GetChildInstance();
            objfrmDelGroup.MdiParent = this;
            objfrmDelGroup.Show();
            objfrmDelGroup.BringToFront();
        }

    }
}
