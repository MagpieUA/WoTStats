namespace WotStats
{
    partial class AddPlayer
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblSubgroup = new System.Windows.Forms.Label();
            this.cboxGroup = new System.Windows.Forms.ComboBox();
            this.cboxSubgroup = new System.Windows.Forms.ComboBox();
            this.cbxKeepGroup = new System.Windows.Forms.CheckBox();
            this.cbxKeepSubgroup = new System.Windows.Forms.CheckBox();
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxKeepStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(12, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ник игрока";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIndex.Location = new System.Drawing.Point(12, 45);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(132, 20);
            this.lblIndex.TabIndex = 1;
            this.lblIndex.Text = "Индекс игрока";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(168, 44);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(85, 20);
            this.txtIndex.TabIndex = 3;
            this.txtIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIndex_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(53, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(328, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.Location = new System.Drawing.Point(12, 71);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(67, 20);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "Группа";
            // 
            // lblSubgroup
            // 
            this.lblSubgroup.AutoSize = true;
            this.lblSubgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubgroup.Location = new System.Drawing.Point(12, 97);
            this.lblSubgroup.Name = "lblSubgroup";
            this.lblSubgroup.Size = new System.Drawing.Size(100, 20);
            this.lblSubgroup.TabIndex = 7;
            this.lblSubgroup.Text = "Подгруппа";
            // 
            // cboxGroup
            // 
            this.cboxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGroup.FormattingEnabled = true;
            this.cboxGroup.Location = new System.Drawing.Point(168, 68);
            this.cboxGroup.Name = "cboxGroup";
            this.cboxGroup.Size = new System.Drawing.Size(174, 21);
            this.cboxGroup.TabIndex = 8;
            this.cboxGroup.SelectionChangeCommitted += new System.EventHandler(this.cboxGroup_SelectionChangeCommitted);
            // 
            // cboxSubgroup
            // 
            this.cboxSubgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSubgroup.FormattingEnabled = true;
            this.cboxSubgroup.Location = new System.Drawing.Point(168, 95);
            this.cboxSubgroup.Name = "cboxSubgroup";
            this.cboxSubgroup.Size = new System.Drawing.Size(174, 21);
            this.cboxSubgroup.TabIndex = 9;
            // 
            // cbxKeepGroup
            // 
            this.cbxKeepGroup.AutoSize = true;
            this.cbxKeepGroup.Location = new System.Drawing.Point(349, 73);
            this.cbxKeepGroup.Name = "cbxKeepGroup";
            this.cbxKeepGroup.Size = new System.Drawing.Size(115, 17);
            this.cbxKeepGroup.TabIndex = 10;
            this.cbxKeepGroup.Text = "Сохранять группу";
            this.cbxKeepGroup.UseVisualStyleBackColor = true;
            // 
            // cbxKeepSubgroup
            // 
            this.cbxKeepSubgroup.AutoSize = true;
            this.cbxKeepSubgroup.Location = new System.Drawing.Point(349, 99);
            this.cbxKeepSubgroup.Name = "cbxKeepSubgroup";
            this.cbxKeepSubgroup.Size = new System.Drawing.Size(133, 17);
            this.cbxKeepSubgroup.TabIndex = 11;
            this.cbxKeepSubgroup.Text = "Сохранять подгруппу";
            this.cbxKeepSubgroup.UseVisualStyleBackColor = true;
            // 
            // cboxStatus
            // 
            this.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Location = new System.Drawing.Point(168, 123);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(174, 21);
            this.cboxStatus.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(12, 124);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Статус";
            // 
            // cbxKeepStatus
            // 
            this.cbxKeepStatus.AutoSize = true;
            this.cbxKeepStatus.Location = new System.Drawing.Point(349, 126);
            this.cbxKeepStatus.Name = "cbxKeepStatus";
            this.cbxKeepStatus.Size = new System.Drawing.Size(115, 17);
            this.cbxKeepStatus.TabIndex = 14;
            this.cbxKeepStatus.Text = "Сохранять статус";
            this.cbxKeepStatus.UseVisualStyleBackColor = true;
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 209);
            this.Controls.Add(this.cbxKeepStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.cbxKeepSubgroup);
            this.Controls.Add(this.cbxKeepGroup);
            this.Controls.Add(this.cboxSubgroup);
            this.Controls.Add(this.cboxGroup);
            this.Controls.Add(this.lblSubgroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblName);
            this.Name = "AddPlayer";
            this.Text = "AddPlayer";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPlayer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblSubgroup;
        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.ComboBox cboxSubgroup;
        private System.Windows.Forms.CheckBox cbxKeepGroup;
        private System.Windows.Forms.CheckBox cbxKeepSubgroup;
        private System.Windows.Forms.ComboBox cboxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbxKeepStatus;
    }
}