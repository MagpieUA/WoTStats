namespace WotStats
{
    partial class Reports_period
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports_period));
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Средний опыт");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Фрагов на битву");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Средний дамаг");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Процент побед");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Средний захват");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Средняя защита");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Обнаружено за бой");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Средние значения", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Кол-во боев");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Максимальный опыт");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Кол-во фрагов");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Нанесенный дамаг");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Кол-во побед");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Захват базы");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Защита базы");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Обнаружено врагов");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Абсолютные значения", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Чарты по группам", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode35});
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtPickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dtPickerBegin = new System.Windows.Forms.DateTimePicker();
            this.tsDate = new System.Windows.Forms.ToolStrip();
            this.tscboxNumber = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscboxGroup = new System.Windows.Forms.ToolStripComboBox();
            this.tscboxSubgroup = new System.Windows.Forms.ToolStripComboBox();
            this.tscboxStatus = new System.Windows.Forms.ToolStripComboBox();
            this.tsFile = new System.Windows.Forms.ToolStrip();
            this.tsExport = new System.Windows.Forms.ToolStripButton();
            this.tsExportAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvReport = new System.Windows.Forms.TreeView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReportResult = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tsFile.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtPickerEnd);
            this.panel1.Controls.Add(this.dtPickerBegin);
            this.panel1.Controls.Add(this.tsDate);
            this.panel1.Controls.Add(this.tscboxNumber);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 77);
            this.panel1.TabIndex = 0;
            // 
            // dtPickerEnd
            // 
            this.dtPickerEnd.Location = new System.Drawing.Point(250, 25);
            this.dtPickerEnd.Name = "dtPickerEnd";
            this.dtPickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dtPickerEnd.TabIndex = 4;
            this.dtPickerEnd.ValueChanged += new System.EventHandler(this.dtPickerEnd_ValueChanged);
            // 
            // dtPickerBegin
            // 
            this.dtPickerBegin.Location = new System.Drawing.Point(44, 25);
            this.dtPickerBegin.Name = "dtPickerBegin";
            this.dtPickerBegin.Size = new System.Drawing.Size(200, 20);
            this.dtPickerBegin.TabIndex = 3;
            this.dtPickerBegin.ValueChanged += new System.EventHandler(this.dtPickerBegin_ValueChanged);
            // 
            // tsDate
            // 
            this.tsDate.Location = new System.Drawing.Point(0, 25);
            this.tsDate.Name = "tsDate";
            this.tsDate.Size = new System.Drawing.Size(806, 25);
            this.tsDate.TabIndex = 2;
            this.tsDate.Text = "toolStrip2";
            // 
            // tscboxNumber
            // 
            this.tscboxNumber.FormattingEnabled = true;
            this.tscboxNumber.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
            this.tscboxNumber.Location = new System.Drawing.Point(613, 3);
            this.tscboxNumber.Name = "tscboxNumber";
            this.tscboxNumber.Size = new System.Drawing.Size(73, 21);
            this.tscboxNumber.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscboxGroup,
            this.tscboxSubgroup,
            this.tscboxStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tscboxGroup
            // 
            this.tscboxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscboxGroup.Name = "tscboxGroup";
            this.tscboxGroup.Size = new System.Drawing.Size(200, 25);
            this.tscboxGroup.SelectedIndexChanged += new System.EventHandler(this.tscboxGroup_SelectedIndexChanged);
            // 
            // tscboxSubgroup
            // 
            this.tscboxSubgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscboxSubgroup.Name = "tscboxSubgroup";
            this.tscboxSubgroup.Size = new System.Drawing.Size(200, 25);
            this.tscboxSubgroup.SelectedIndexChanged += new System.EventHandler(this.tscboxSubgroup_SelectedIndexChanged);
            // 
            // tscboxStatus
            // 
            this.tscboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscboxStatus.Name = "tscboxStatus";
            this.tscboxStatus.Size = new System.Drawing.Size(200, 25);
            // 
            // tsFile
            // 
            this.tsFile.Dock = System.Windows.Forms.DockStyle.None;
            this.tsFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExport,
            this.tsExportAll,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsbtnRefresh});
            this.tsFile.Location = new System.Drawing.Point(2, 51);
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(139, 25);
            this.tsFile.TabIndex = 2;
            this.tsFile.Text = "toolStrip2";
            // 
            // tsExport
            // 
            this.tsExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExport.Image = ((System.Drawing.Image)(resources.GetObject("tsExport.Image")));
            this.tsExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExport.Name = "tsExport";
            this.tsExport.Size = new System.Drawing.Size(23, 22);
            this.tsExport.Text = "Экспорт";
            this.tsExport.Click += new System.EventHandler(this.tsExport_Click);
            // 
            // tsExportAll
            // 
            this.tsExportAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExportAll.Image = ((System.Drawing.Image)(resources.GetObject("tsExportAll.Image")));
            this.tsExportAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExportAll.Name = "tsExportAll";
            this.tsExportAll.Size = new System.Drawing.Size(23, 22);
            this.tsExportAll.Text = "Экспорт всех запросов";
            this.tsExportAll.ToolTipText = "Экспорт всех запросов";
            this.tsExportAll.Click += new System.EventHandler(this.tsExportAll_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "XML-экспорт всех запросов";
            this.toolStripButton1.ToolTipText = "XML-экспорт всех запросов";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRefresh.Text = "toolStripButton2";
            this.tsbtnRefresh.ToolTipText = "Обновить";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(2, 79);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(806, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 393);
            this.panel2.TabIndex = 2;
            // 
            // tvReport
            // 
            this.tvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvReport.Location = new System.Drawing.Point(0, 0);
            this.tvReport.Name = "tvReport";
            treeNode19.Name = "nEpB";
            treeNode19.Text = "Средний опыт";
            treeNode20.Name = "nFRGpB";
            treeNode20.Text = "Фрагов на битву";
            treeNode21.Name = "nAvgDamage";
            treeNode21.Text = "Средний дамаг";
            treeNode22.Name = "nWinPercent";
            treeNode22.Text = "Процент побед";
            treeNode23.Name = "nCPTpB";
            treeNode23.Text = "Средний захват";
            treeNode24.Name = "nDPTpB";
            treeNode24.Text = "Средняя защита";
            treeNode25.Name = "nSPTpB";
            treeNode25.Text = "Обнаружено за бой";
            treeNode26.Name = "nAvgCharts";
            treeNode26.Text = "Средние значения";
            treeNode27.Name = "nPlay";
            treeNode27.Text = "Кол-во боев";
            treeNode28.Name = "nExpMax";
            treeNode28.Text = "Максимальный опыт";
            treeNode29.Name = "nFRG";
            treeNode29.Text = "Кол-во фрагов";
            treeNode30.Name = "nDMG";
            treeNode30.Text = "Нанесенный дамаг";
            treeNode31.Name = "nWin";
            treeNode31.Text = "Кол-во побед";
            treeNode32.Name = "nCPT";
            treeNode32.Text = "Захват базы";
            treeNode33.Name = "nDPT";
            treeNode33.Text = "Защита базы";
            treeNode34.Name = "nSPT";
            treeNode34.Text = "Обнаружено врагов";
            treeNode35.Name = "nTopCharts";
            treeNode35.Text = "Абсолютные значения";
            treeNode36.Name = "nGroupCharts";
            treeNode36.Text = "Чарты по группам";
            this.tvReport.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode36});
            this.tvReport.Size = new System.Drawing.Size(200, 393);
            this.tvReport.TabIndex = 0;
            this.tvReport.Visible = false;
            this.tvReport.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvReport_AfterSelect);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(202, 82);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 393);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvReportResult);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(205, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 393);
            this.panel3.TabIndex = 4;
            // 
            // dgvReportResult
            // 
            this.dgvReportResult.AllowUserToAddRows = false;
            this.dgvReportResult.AllowUserToDeleteRows = false;
            this.dgvReportResult.AllowUserToOrderColumns = true;
            this.dgvReportResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportResult.Location = new System.Drawing.Point(0, 0);
            this.dgvReportResult.Margin = new System.Windows.Forms.Padding(5);
            this.dgvReportResult.Name = "dgvReportResult";
            this.dgvReportResult.Size = new System.Drawing.Size(603, 393);
            this.dgvReportResult.TabIndex = 0;
            // 
            // Reports_period
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 477);
            this.Controls.Add(this.tsFile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "Reports_period";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Отчеты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_period_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tsFile.ResumeLayout(false);
            this.tsFile.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscboxGroup;
        private System.Windows.Forms.ToolStripComboBox tscboxSubgroup;
        private System.Windows.Forms.ToolStripComboBox tscboxStatus;
        private System.Windows.Forms.TreeView tvReport;
        private System.Windows.Forms.ComboBox tscboxNumber;
        private System.Windows.Forms.DataGridView dgvReportResult;
        private System.Windows.Forms.ToolStrip tsFile;
        private System.Windows.Forms.ToolStripButton tsExport;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DateTimePicker dtPickerEnd;
        private System.Windows.Forms.DateTimePicker dtPickerBegin;
        private System.Windows.Forms.ToolStrip tsDate;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsExportAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}