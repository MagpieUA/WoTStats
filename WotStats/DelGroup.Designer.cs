namespace WotStats
{
    partial class DelGroup
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
            this.cboxGroup = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSubgroup = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cboxSubgroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxGroup
            // 
            this.cboxGroup.FormattingEnabled = true;
            this.cboxGroup.Location = new System.Drawing.Point(149, 11);
            this.cboxGroup.Name = "cboxGroup";
            this.cboxGroup.Size = new System.Drawing.Size(189, 21);
            this.cboxGroup.TabIndex = 12;
            this.cboxGroup.SelectionChangeCommitted += new System.EventHandler(this.cboxGroup_SelectionChangeCommitted);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(44, 104);
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
            this.lblSubgroup.Location = new System.Drawing.Point(19, 48);
            this.lblSubgroup.Name = "lblSubgroup";
            this.lblSubgroup.Size = new System.Drawing.Size(100, 20);
            this.lblSubgroup.TabIndex = 8;
            this.lblSubgroup.Text = "Подгруппа";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.Location = new System.Drawing.Point(19, 13);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(67, 20);
            this.lblGroup.TabIndex = 7;
            this.lblGroup.Text = "Группа";
            // 
            // cboxSubgroup
            // 
            this.cboxSubgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSubgroup.FormattingEnabled = true;
            this.cboxSubgroup.Location = new System.Drawing.Point(149, 47);
            this.cboxSubgroup.Name = "cboxSubgroup";
            this.cboxSubgroup.Size = new System.Drawing.Size(189, 21);
            this.cboxSubgroup.TabIndex = 13;
            // 
            // DelGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 139);
            this.Controls.Add(this.cboxSubgroup);
            this.Controls.Add(this.cboxGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSubgroup);
            this.Controls.Add(this.lblGroup);
            this.Name = "DelGroup";
            this.Text = "DelGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSubgroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cboxSubgroup;
    }
}