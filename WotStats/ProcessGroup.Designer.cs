namespace WotStats
{
    partial class ProcessGroup
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSubgroup = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cboxGroup = new System.Windows.Forms.ComboBox();
            this.cboxSubgroup = new System.Windows.Forms.ComboBox();
            this.pbarProcess = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(234, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(37, 135);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSubgroup
            // 
            this.lblSubgroup.AutoSize = true;
            this.lblSubgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubgroup.Location = new System.Drawing.Point(12, 44);
            this.lblSubgroup.Name = "lblSubgroup";
            this.lblSubgroup.Size = new System.Drawing.Size(100, 20);
            this.lblSubgroup.TabIndex = 7;
            this.lblSubgroup.Text = "Подгруппа";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.Location = new System.Drawing.Point(12, 9);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(67, 20);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "Группа";
            // 
            // cboxGroup
            // 
            this.cboxGroup.FormattingEnabled = true;
            this.cboxGroup.Location = new System.Drawing.Point(162, 7);
            this.cboxGroup.Name = "cboxGroup";
            this.cboxGroup.Size = new System.Drawing.Size(169, 21);
            this.cboxGroup.TabIndex = 12;
            this.cboxGroup.SelectionChangeCommitted += new System.EventHandler(this.cboxGroup_SelectionChangeCommitted);
            // 
            // cboxSubgroup
            // 
            this.cboxSubgroup.FormattingEnabled = true;
            this.cboxSubgroup.Location = new System.Drawing.Point(162, 42);
            this.cboxSubgroup.Name = "cboxSubgroup";
            this.cboxSubgroup.Size = new System.Drawing.Size(169, 21);
            this.cboxSubgroup.TabIndex = 13;
            // 
            // pbarProcess
            // 
            this.pbarProcess.Location = new System.Drawing.Point(16, 78);
            this.pbarProcess.Name = "pbarProcess";
            this.pbarProcess.Size = new System.Drawing.Size(315, 13);
            this.pbarProcess.Step = 1;
            this.pbarProcess.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Обработано:";
            // 
            // lblProcCounter
            // 
            this.lblProcCounter.AutoSize = true;
            this.lblProcCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProcCounter.Location = new System.Drawing.Point(104, 98);
            this.lblProcCounter.Name = "lblProcCounter";
            this.lblProcCounter.Size = new System.Drawing.Size(27, 15);
            this.lblProcCounter.TabIndex = 16;
            this.lblProcCounter.Text = "0/0";
            // 
            // ProcessGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 170);
            this.Controls.Add(this.lblProcCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbarProcess);
            this.Controls.Add(this.cboxSubgroup);
            this.Controls.Add(this.cboxGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSubgroup);
            this.Controls.Add(this.lblGroup);
            this.Name = "ProcessGroup";
            this.Text = "Получение данных...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessGroup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSubgroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.ComboBox cboxSubgroup;
        private System.Windows.Forms.ProgressBar pbarProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProcCounter;
    }
}