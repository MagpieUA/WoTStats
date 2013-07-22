namespace WotStats
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlsToGpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестРегэкспаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.PlayersToolStripMenuItem,
            this.обработкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // PlayersToolStripMenuItem
            // 
            this.PlayersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPlayerToolStripMenuItem,
            this.AddGroupToolStripMenuItem,
            this.AddStatusToolStripMenuItem,
            this.PlsToGpsToolStripMenuItem,
            this.удалениToolStripMenuItem});
            this.PlayersToolStripMenuItem.Name = "PlayersToolStripMenuItem";
            this.PlayersToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.PlayersToolStripMenuItem.Text = "Игроки";
            // 
            // AddPlayerToolStripMenuItem
            // 
            this.AddPlayerToolStripMenuItem.Name = "AddPlayerToolStripMenuItem";
            this.AddPlayerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.AddPlayerToolStripMenuItem.Text = "Добавить игрока";
            this.AddPlayerToolStripMenuItem.Click += new System.EventHandler(this.AddPlayerToolStripMenuItem_Click);
            // 
            // AddGroupToolStripMenuItem
            // 
            this.AddGroupToolStripMenuItem.Name = "AddGroupToolStripMenuItem";
            this.AddGroupToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.AddGroupToolStripMenuItem.Text = "Добавить группу";
            this.AddGroupToolStripMenuItem.Click += new System.EventHandler(this.AddGroupToolStripMenuItem_Click);
            // 
            // AddStatusToolStripMenuItem
            // 
            this.AddStatusToolStripMenuItem.Name = "AddStatusToolStripMenuItem";
            this.AddStatusToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.AddStatusToolStripMenuItem.Text = "Добавить статус";
            this.AddStatusToolStripMenuItem.Click += new System.EventHandler(this.AddStatusToolStripMenuItem_Click);
            // 
            // PlsToGpsToolStripMenuItem
            // 
            this.PlsToGpsToolStripMenuItem.Name = "PlsToGpsToolStripMenuItem";
            this.PlsToGpsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.PlsToGpsToolStripMenuItem.Text = "Игроки -> Группы";
            this.PlsToGpsToolStripMenuItem.Click += new System.EventHandler(this.PlsToGpsToolStripMenuItem_Click);
            // 
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetPageToolStripMenuItem,
            this.тестРегэкспаToolStripMenuItem,
            this.ProcessGroupToolStripMenuItem,
            this.ReportsToolStripMenuItem,
            this.ReportsPeriodToolStripMenuItem});
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            // 
            // GetPageToolStripMenuItem
            // 
            this.GetPageToolStripMenuItem.Name = "GetPageToolStripMenuItem";
            this.GetPageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.GetPageToolStripMenuItem.Text = "Получить страницу";
            this.GetPageToolStripMenuItem.Click += new System.EventHandler(this.GetPageToolStripMenuItem_Click);
            // 
            // тестРегэкспаToolStripMenuItem
            // 
            this.тестРегэкспаToolStripMenuItem.Name = "тестРегэкспаToolStripMenuItem";
            this.тестРегэкспаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.тестРегэкспаToolStripMenuItem.Text = "Тест регэкспа";
            this.тестРегэкспаToolStripMenuItem.Click += new System.EventHandler(this.тестРегэкспаToolStripMenuItem_Click);
            // 
            // ProcessGroupToolStripMenuItem
            // 
            this.ProcessGroupToolStripMenuItem.Name = "ProcessGroupToolStripMenuItem";
            this.ProcessGroupToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ProcessGroupToolStripMenuItem.Text = "Обработать группу";
            this.ProcessGroupToolStripMenuItem.Click += new System.EventHandler(this.ProcessGroupToolStripMenuItem_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ReportsToolStripMenuItem.Text = "Отчеты...";
            this.ReportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItem_Click);
            // 
            // ReportsPeriodToolStripMenuItem
            // 
            this.ReportsPeriodToolStripMenuItem.Name = "ReportsPeriodToolStripMenuItem";
            this.ReportsPeriodToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ReportsPeriodToolStripMenuItem.Text = "Отчеты за период...";
            this.ReportsPeriodToolStripMenuItem.Click += new System.EventHandler(this.ReportsPeriodToolStripMenuItem_Click);
            // 
            // удалениToolStripMenuItem
            // 
            this.удалениToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelGroupToolStripMenuItem});
            this.удалениToolStripMenuItem.Name = "удалениToolStripMenuItem";
            this.удалениToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.удалениToolStripMenuItem.Text = "Удалить...";
            // 
            // DelGroupToolStripMenuItem
            // 
            this.DelGroupToolStripMenuItem.Name = "DelGroupToolStripMenuItem";
            this.DelGroupToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.DelGroupToolStripMenuItem.Text = "Удалить группу";
            this.DelGroupToolStripMenuItem.Click += new System.EventHandler(this.DelGroupToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 388);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WoT Stats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестРегэкспаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProcessGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlsToGpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportsPeriodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelGroupToolStripMenuItem;
    }
}

