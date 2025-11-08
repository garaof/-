namespace ModernResturantSystem
{
    partial class frmLogin
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.pnUserNameLine = new System.Windows.Forms.Panel();
            this.txtbUserName = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnUserLogIng = new System.Windows.Forms.Panel();
            this.lbUserLogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMain.SuspendLayout();
            this.pnUserLogIng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.btnClose);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Controls.Add(this.txtPassWord);
            this.pnMain.Controls.Add(this.pnUserNameLine);
            this.pnMain.Controls.Add(this.pictureBox2);
            this.pnMain.Controls.Add(this.pictureBox1);
            this.pnMain.Controls.Add(this.txtbUserName);
            this.pnMain.Controls.Add(this.btnLogIn);
            this.pnMain.Controls.Add(this.pnUserLogIng);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(476, 617);
            this.pnMain.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(349, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 49);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Exit ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(104, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 2);
            this.panel1.TabIndex = 8;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.White;
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassWord.Location = new System.Drawing.Point(104, 299);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(321, 41);
            this.txtPassWord.TabIndex = 7;
            this.txtPassWord.Enter += new System.EventHandler(this.txtPassWord_Enter);
            this.txtPassWord.Leave += new System.EventHandler(this.txtPassWord_Leave);
            // 
            // pnUserNameLine
            // 
            this.pnUserNameLine.BackColor = System.Drawing.Color.Black;
            this.pnUserNameLine.Location = new System.Drawing.Point(98, 221);
            this.pnUserNameLine.Name = "pnUserNameLine";
            this.pnUserNameLine.Size = new System.Drawing.Size(321, 2);
            this.pnUserNameLine.TabIndex = 6;
            // 
            // txtbUserName
            // 
            this.txtbUserName.BackColor = System.Drawing.Color.White;
            this.txtbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUserName.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUserName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbUserName.Location = new System.Drawing.Point(98, 179);
            this.txtbUserName.Name = "txtbUserName";
            this.txtbUserName.Size = new System.Drawing.Size(321, 41);
            this.txtbUserName.TabIndex = 2;
            this.txtbUserName.Enter += new System.EventHandler(this.txtbUserName_Enter);
            this.txtbUserName.Leave += new System.EventHandler(this.txtbUserName_Leave);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(57, 448);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(364, 75);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pnUserLogIng
            // 
            this.pnUserLogIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.pnUserLogIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUserLogIng.Controls.Add(this.lbUserLogin);
            this.pnUserLogIng.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUserLogIng.Location = new System.Drawing.Point(0, 0);
            this.pnUserLogIng.Name = "pnUserLogIng";
            this.pnUserLogIng.Size = new System.Drawing.Size(474, 91);
            this.pnUserLogIng.TabIndex = 0;
            // 
            // lbUserLogin
            // 
            this.lbUserLogin.AutoEllipsis = true;
            this.lbUserLogin.AutoSize = true;
            this.lbUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUserLogin.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserLogin.ForeColor = System.Drawing.Color.White;
            this.lbUserLogin.Location = new System.Drawing.Point(76, 20);
            this.lbUserLogin.Name = "lbUserLogin";
            this.lbUserLogin.Size = new System.Drawing.Size(316, 59);
            this.lbUserLogin.TabIndex = 0;
            this.lbUserLogin.Text = "L O G I N    U S E R";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ModernResturantSystem.Properties.Resources.Lock;
            this.pictureBox2.Location = new System.Drawing.Point(56, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModernResturantSystem.Properties.Resources.Person;
            this.pictureBox1.Location = new System.Drawing.Point(52, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 617);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.pnUserLogIng.ResumeLayout(false);
            this.pnUserLogIng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnUserLogIng;
        private System.Windows.Forms.Label lbUserLogin;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnUserNameLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnClose;
    }
}