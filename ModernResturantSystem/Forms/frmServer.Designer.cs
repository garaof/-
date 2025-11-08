namespace ModernResturantSystem.Forms
{
    partial class frmServer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBackup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRestoreDataBase = new System.Windows.Forms.Button();
            this.btnChooseFilePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbFilePath = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbgif = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.rbSql = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 54);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(729, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bakup /Restore DataBase /Connection String Details";
            // 
            // txtbPath
            // 
            this.txtbPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtbPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPath.Enabled = false;
            this.txtbPath.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.txtbPath.Location = new System.Drawing.Point(255, 126);
            this.txtbPath.Name = "txtbPath";
            this.txtbPath.Size = new System.Drawing.Size(777, 35);
            this.txtbPath.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose Path";
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(145, 126);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(104, 35);
            this.btnPath.TabIndex = 15;
            this.btnPath.Text = "......";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(408, 180);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(232, 45);
            this.btnBackup.TabIndex = 16;
            this.btnBackup.Text = " BackUp Copy";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.panel2.Location = new System.Drawing.Point(33, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 2);
            this.panel2.TabIndex = 17;
            // 
            // btnRestoreDataBase
            // 
            this.btnRestoreDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDataBase.Location = new System.Drawing.Point(386, 384);
            this.btnRestoreDataBase.Name = "btnRestoreDataBase";
            this.btnRestoreDataBase.Size = new System.Drawing.Size(291, 45);
            this.btnRestoreDataBase.TabIndex = 21;
            this.btnRestoreDataBase.Text = "Restore DataBase";
            this.btnRestoreDataBase.UseVisualStyleBackColor = true;
            this.btnRestoreDataBase.Click += new System.EventHandler(this.btnRestoreDataBase_Click);
            // 
            // btnChooseFilePath
            // 
            this.btnChooseFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFilePath.Location = new System.Drawing.Point(240, 330);
            this.btnChooseFilePath.Name = "btnChooseFilePath";
            this.btnChooseFilePath.Size = new System.Drawing.Size(104, 35);
            this.btnChooseFilePath.TabIndex = 20;
            this.btnChooseFilePath.Text = "......";
            this.btnChooseFilePath.UseVisualStyleBackColor = true;
            this.btnChooseFilePath.Click += new System.EventHandler(this.btnChooseFilePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Choose DataBase File";
            // 
            // txtbFilePath
            // 
            this.txtbFilePath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtbFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbFilePath.Enabled = false;
            this.txtbFilePath.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.txtbFilePath.Location = new System.Drawing.Point(353, 330);
            this.txtbFilePath.Name = "txtbFilePath";
            this.txtbFilePath.Size = new System.Drawing.Size(671, 35);
            this.txtbFilePath.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.panel3.Location = new System.Drawing.Point(49, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 2);
            this.panel3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Restore Data Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 37);
            this.label5.TabIndex = 24;
            this.label5.Text = "Make Abackup Copy";
            // 
            // pbgif
            // 
            this.pbgif.Image = global::ModernResturantSystem.Properties.Resources.icons8_spinner;
            this.pbgif.Location = new System.Drawing.Point(423, 254);
            this.pbgif.Name = "pbgif";
            this.pbgif.Size = new System.Drawing.Size(186, 160);
            this.pbgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbgif.TabIndex = 25;
            this.pbgif.TabStop = false;
            this.pbgif.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 37);
            this.label6.TabIndex = 26;
            this.label6.Text = "Server Connection";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Server Name";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServer.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.txtServer.Location = new System.Drawing.Point(148, 548);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(317, 35);
            this.txtServer.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "Data Base";
            // 
            // txtDataBase
            // 
            this.txtDataBase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDataBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataBase.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.txtDataBase.Location = new System.Drawing.Point(148, 615);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(317, 35);
            this.txtDataBase.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(562, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 28);
            this.label9.TabIndex = 34;
            this.label9.Text = "Password";
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.txtPassWord.Location = new System.Drawing.Point(699, 612);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(317, 35);
            this.txtPassWord.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(562, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 32;
            this.label10.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.txtUserName.Location = new System.Drawing.Point(699, 545);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(317, 35);
            this.txtUserName.TabIndex = 31;
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWindows.Location = new System.Drawing.Point(140, 693);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(267, 32);
            this.rbWindows.TabIndex = 35;
            this.rbWindows.Text = "Windows  Authentication";
            this.rbWindows.UseVisualStyleBackColor = true;
            // 
            // rbSql
            // 
            this.rbSql.AutoSize = true;
            this.rbSql.Checked = true;
            this.rbSql.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSql.Location = new System.Drawing.Point(513, 693);
            this.rbSql.Name = "rbSql";
            this.rbSql.Size = new System.Drawing.Size(277, 32);
            this.rbSql.TabIndex = 36;
            this.rbSql.TabStop = true;
            this.rbSql.Text = "SQl Server  Authentication";
            this.rbSql.UseVisualStyleBackColor = true;
            this.rbSql.CheckedChanged += new System.EventHandler(this.rbSql_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(884, 780);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 52);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::ModernResturantSystem.Properties.Resources.icons8_close_window_100__2_;
            this.pbClose.Location = new System.Drawing.Point(991, 60);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(41, 39);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 38;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 866);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbSql);
            this.Controls.Add(this.rbWindows);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDataBase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbgif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRestoreDataBase);
            this.Controls.Add(this.btnChooseFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbFilePath);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbPath);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestoreDataBase;
        private System.Windows.Forms.Button btnChooseFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbFilePath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbgif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.RadioButton rbSql;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbClose;
    }
}