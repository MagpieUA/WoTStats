namespace WotStats
{
    partial class PlayersToGroups
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
            this.cboxSubgroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.lstIn = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.lblCountOut = new System.Windows.Forms.Label();
            this.lblCountIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxGroup
            // 
            this.cboxGroup.FormattingEnabled = true;
            this.cboxGroup.Items.AddRange(new object[] {
            "Выберите группу"});
            this.cboxGroup.Location = new System.Drawing.Point(127, 20);
            this.cboxGroup.Name = "cboxGroup";
            this.cboxGroup.Size = new System.Drawing.Size(217, 21);
            this.cboxGroup.TabIndex = 0;
            this.cboxGroup.SelectionChangeCommitted += new System.EventHandler(this.cboxGroup_SelectionChangeCommitted);
            // 
            // cboxSubgroup
            // 
            this.cboxSubgroup.FormattingEnabled = true;
            this.cboxSubgroup.Items.AddRange(new object[] {
            "Выберите подгруппу"});
            this.cboxSubgroup.Location = new System.Drawing.Point(127, 50);
            this.cboxSubgroup.Name = "cboxSubgroup";
            this.cboxSubgroup.Size = new System.Drawing.Size(217, 21);
            this.cboxSubgroup.TabIndex = 1;
            this.cboxSubgroup.SelectionChangeCommitted += new System.EventHandler(this.cboxSubgroup_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подгруппа";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(223, 292);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(326, 510);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 25);
            this.button4.TabIndex = 9;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(12, 124);
            this.lstOut.Name = "lstOut";
            this.lstOut.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstOut.Size = new System.Drawing.Size(200, 342);
            this.lstOut.TabIndex = 10;
            // 
            // lstIn
            // 
            this.lstIn.FormattingEnabled = true;
            this.lstIn.Location = new System.Drawing.Point(305, 124);
            this.lstIn.Name = "lstIn";
            this.lstIn.Size = new System.Drawing.Size(200, 342);
            this.lstIn.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статус";
            // 
            // cboxStatus
            // 
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Location = new System.Drawing.Point(127, 80);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(217, 21);
            this.cboxStatus.TabIndex = 13;
            // 
            // lblCountOut
            // 
            this.lblCountOut.AutoSize = true;
            this.lblCountOut.Location = new System.Drawing.Point(85, 473);
            this.lblCountOut.Name = "lblCountOut";
            this.lblCountOut.Size = new System.Drawing.Size(13, 13);
            this.lblCountOut.TabIndex = 14;
            this.lblCountOut.Text = "0";
            // 
            // lblCountIn
            // 
            this.lblCountIn.AutoSize = true;
            this.lblCountIn.Location = new System.Drawing.Point(386, 473);
            this.lblCountIn.Name = "lblCountIn";
            this.lblCountIn.Size = new System.Drawing.Size(13, 13);
            this.lblCountIn.TabIndex = 15;
            this.lblCountIn.Text = "0";
            // 
            // PlayersToGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 559);
            this.Controls.Add(this.lblCountIn);
            this.Controls.Add(this.lblCountOut);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstIn);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxSubgroup);
            this.Controls.Add(this.cboxGroup);
            this.Name = "PlayersToGroups";
            this.Text = "PlayersToGroups";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayersToGroups_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.ComboBox cboxSubgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.ListBox lstIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxStatus;
        private System.Windows.Forms.Label lblCountOut;
        private System.Windows.Forms.Label lblCountIn;
    }
}