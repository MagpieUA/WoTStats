namespace WotStats
{
    partial class Reports_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports_main));
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Средний опыт");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Фрагов на битву");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Средний дамаг");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Процент побед");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Очков захвата на битву");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Очков защиты на битву");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Обнаружено на битву");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Средние значения", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Кол-во боев");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Максимальный опыт");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Кол-во фрагов");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Нанесенный дамаг");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Кол-во побед");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Захват базы");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Защита базы");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Обнаружено врагов");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Старожилы");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Абсолютные значения", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Чарты по группам", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode37});
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsFile = new System.Windows.Forms.ToolStrip();
            this.tsExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsExportAll = new System.Windows.Forms.ToolStripButton();
            this.tscboxNumber = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscboxGroup = new System.Windows.Forms.ToolStripComboBox();
            this.tscboxSubgroup = new System.Windows.Forms.ToolStripComboBox();
            this.tscboxStatus = new System.Windows.Forms.ToolStripComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvReport = new System.Windows.Forms.TreeView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReportResult = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tsFile.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsFile);
            this.panel1.Controls.Add(this.tscboxNumber);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 53);
            this.panel1.TabIndex = 0;
            // 
            // tsFile
            // 
            this.tsFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExport,
            this.tsExportAll,
            this.toolStripButton1});
            this.tsFile.Location = new System.Drawing.Point(0, 25);
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(806, 25);
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
            // 
            // tscboxStatus
            // 
            this.tscboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscboxStatus.Name = "tscboxStatus";
            this.tscboxStatus.Size = new System.Drawing.Size(200, 25);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(2, 55);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(806, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 417);
            this.panel2.TabIndex = 2;
            // 
            // tvReport
            // 
            this.tvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvReport.Location = new System.Drawing.Point(0, 0);
            this.tvReport.Name = "tvReport";
            treeNode20.Name = "nEpB";
            treeNode20.Text = "Средний опыт";
            treeNode21.Name = "nFRGpB";
            treeNode21.Text = "Фрагов на битву";
            treeNode22.Name = "nAvgDamage";
            treeNode22.Text = "Средний дамаг";
            treeNode23.Name = "nWinPercent";
            treeNode23.Text = "Процент побед";
            treeNode24.Name = "nCPTpB";
            treeNode24.Text = "Очков захвата на битву";
            treeNode25.Name = "nDPTpB";
            treeNode25.Text = "Очков защиты на битву";
            treeNode26.Name = "nSPTpB";
            treeNode26.Text = "Обнаружено на битву";
            treeNode27.Name = "nAvgCharts";
            treeNode27.Text = "Средние значения";
            treeNode28.Name = "nPlay";
            treeNode28.Text = "Кол-во боев";
            treeNode29.Name = "nExpMax";
            treeNode29.Text = "Максимальный опыт";
            treeNode30.Name = "nFRG";
            treeNode30.Text = "Кол-во фрагов";
            treeNode31.Name = "nDMG";
            treeNode31.Text = "Нанесенный дамаг";
            treeNode32.Name = "nWin";
            treeNode32.Text = "Кол-во побед";
            treeNode33.Name = "nCPT";
            treeNode33.Text = "Захват базы";
            treeNode34.Name = "nDPT";
            treeNode34.Text = "Защита базы";
            treeNode35.Name = "nSPT";
            treeNode35.Text = "Обнаружено врагов";
            treeNode36.Name = "nOld";
            treeNode36.Text = "Старожилы";
            treeNode37.Name = "nTopCharts";
            treeNode37.Text = "Абсолютные значения";
            treeNode38.Name = "nGroupCharts";
            treeNode38.Text = "Чарты по группам";
            this.tvReport.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode38});
            this.tvReport.Size = new System.Drawing.Size(200, 417);
            this.tvReport.TabIndex = 0;
            this.tvReport.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvReport_AfterSelect);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(202, 58);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 417);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvReportResult);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(205, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 417);
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
            this.dgvReportResult.Size = new System.Drawing.Size(603, 417);
            this.dgvReportResult.TabIndex = 0;
            // 
            // Reports_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "Reports_main";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Отчеты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_main_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsFile.ResumeLayout(false);
            this.tsFile.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResult)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripButton tsExportAll;

    }
}