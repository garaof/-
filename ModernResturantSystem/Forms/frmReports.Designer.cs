namespace ModernResturantSystem.Forms
{
    partial class frmReports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.RedMark = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.SideMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.FiltersPanel = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.chkboxcustomPeriod = new System.Windows.Forms.CheckBox();
            this.chkboxCustomDate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkboxToday = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbTotal = new System.Windows.Forms.Label();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.MinimizePanel.SuspendLayout();
            this.FiltersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.SidePanel.Controls.Add(this.button1);
            this.SidePanel.Controls.Add(this.RedMark);
            this.SidePanel.Controls.Add(this.btnSales);
            this.SidePanel.Controls.Add(this.MenuPanel);
            this.SidePanel.Controls.Add(this.btnEmployees);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.MaximumSize = new System.Drawing.Size(255, 798);
            this.SidePanel.MinimumSize = new System.Drawing.Size(75, 798);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(255, 798);
            this.SidePanel.TabIndex = 0;
            this.SidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SidePanel_MouseDown);
            // 
            // RedMark
            // 
            this.RedMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.RedMark.Location = new System.Drawing.Point(229, 138);
            this.RedMark.Name = "RedMark";
            this.RedMark.Size = new System.Drawing.Size(15, 86);
            this.RedMark.TabIndex = 2;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.MenuButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(255, 112);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.TopPanel.Controls.Add(this.TitlePanel);
            this.TopPanel.Controls.Add(this.MinimizePanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(255, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(961, 61);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitlePanel.Location = new System.Drawing.Point(245, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(501, 61);
            this.TitlePanel.TabIndex = 1;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(68, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(237, 48);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Reports Page";
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.BackColor = System.Drawing.SystemColors.Control;
            this.MinimizePanel.Controls.Add(this.pictureBox2);
            this.MinimizePanel.Controls.Add(this.pictureBox1);
            this.MinimizePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizePanel.Location = new System.Drawing.Point(746, 0);
            this.MinimizePanel.Name = "MinimizePanel";
            this.MinimizePanel.Size = new System.Drawing.Size(215, 61);
            this.MinimizePanel.TabIndex = 0;
            // 
            // SideMenuTimer
            // 
            this.SideMenuTimer.Interval = 10;
            this.SideMenuTimer.Tick += new System.EventHandler(this.SideMenuTimer_Tick);
            // 
            // FiltersPanel
            // 
            this.FiltersPanel.Controls.Add(this.lbDate);
            this.FiltersPanel.Controls.Add(this.chkboxcustomPeriod);
            this.FiltersPanel.Controls.Add(this.chkboxCustomDate);
            this.FiltersPanel.Controls.Add(this.label3);
            this.FiltersPanel.Controls.Add(this.pbSearch);
            this.FiltersPanel.Controls.Add(this.chkboxToday);
            this.FiltersPanel.Controls.Add(this.label2);
            this.FiltersPanel.Controls.Add(this.dtpFrom);
            this.FiltersPanel.Controls.Add(this.dtpTo);
            this.FiltersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FiltersPanel.Location = new System.Drawing.Point(258, 61);
            this.FiltersPanel.MaximumSize = new System.Drawing.Size(961, 162);
            this.FiltersPanel.Name = "FiltersPanel";
            this.FiltersPanel.Size = new System.Drawing.Size(958, 162);
            this.FiltersPanel.TabIndex = 2;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(198, 105);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(748, 51);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "label4";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxcustomPeriod
            // 
            this.chkboxcustomPeriod.AutoSize = true;
            this.chkboxcustomPeriod.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxcustomPeriod.Location = new System.Drawing.Point(30, 12);
            this.chkboxcustomPeriod.Name = "chkboxcustomPeriod";
            this.chkboxcustomPeriod.Size = new System.Drawing.Size(205, 39);
            this.chkboxcustomPeriod.TabIndex = 10;
            this.chkboxcustomPeriod.Text = "Custom Period";
            this.chkboxcustomPeriod.UseVisualStyleBackColor = true;
            this.chkboxcustomPeriod.CheckedChanged += new System.EventHandler(this.chkboxcustomPeriod_CheckedChanged_1);
            // 
            // chkboxCustomDate
            // 
            this.chkboxCustomDate.AutoSize = true;
            this.chkboxCustomDate.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxCustomDate.Location = new System.Drawing.Point(30, 57);
            this.chkboxCustomDate.Name = "chkboxCustomDate";
            this.chkboxCustomDate.Size = new System.Drawing.Size(188, 39);
            this.chkboxCustomDate.TabIndex = 9;
            this.chkboxCustomDate.Text = " Custom Date";
            this.chkboxCustomDate.UseVisualStyleBackColor = true;
            this.chkboxCustomDate.CheckedChanged += new System.EventHandler(this.chkboxCustomDate_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "To : ";
            // 
            // chkboxToday
            // 
            this.chkboxToday.AutoSize = true;
            this.chkboxToday.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxToday.Location = new System.Drawing.Point(30, 117);
            this.chkboxToday.Name = "chkboxToday";
            this.chkboxToday.Size = new System.Drawing.Size(106, 39);
            this.chkboxToday.TabIndex = 8;
            this.chkboxToday.Text = "Today";
            this.chkboxToday.UseVisualStyleBackColor = true;
            this.chkboxToday.CheckedChanged += new System.EventHandler(this.chkboxToday_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "From : ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(396, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 36);
            this.dtpFrom.TabIndex = 11;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(658, 26);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 36);
            this.dtpTo.TabIndex = 12;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.MainDataGridView.Location = new System.Drawing.Point(321, 223);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.RowHeadersWidth = 51;
            this.MainDataGridView.RowTemplate.Height = 24;
            this.MainDataGridView.Size = new System.Drawing.Size(865, 478);
            this.MainDataGridView.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 30);
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(361, 735);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(745, 51);
            this.lbTotal.TabIndex = 17;
            this.lbTotal.Text = "label4";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::ModernResturantSystem.Properties.Resources.icons8_search;
            this.pbSearch.Location = new System.Drawing.Point(875, 7);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(53, 55);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 15;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ModernResturantSystem.Properties.Resources.icons8_minimize_window_100;
            this.pictureBox2.Location = new System.Drawing.Point(38, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModernResturantSystem.Properties.Resources.icons8_close_window_100__2_;
            this.pictureBox1.Location = new System.Drawing.Point(125, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back            ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = global::ModernResturantSystem.Properties.Resources.Sales1;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 245);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(252, 84);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Sales           ";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.Location = new System.Drawing.Point(12, 36);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(45, 50);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 1;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = global::ModernResturantSystem.Properties.Resources.EmployeesIcon1;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 139);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(252, 84);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "    Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 798);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.FiltersPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmReports_MouseDown);
            this.SidePanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.MinimizePanel.ResumeLayout(false);
            this.FiltersPanel.ResumeLayout(false);
            this.FiltersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SideMenuTimer;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel RedMark;
        private System.Windows.Forms.Panel MinimizePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel FiltersPanel;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.CheckBox chkboxcustomPeriod;
        private System.Windows.Forms.CheckBox chkboxCustomDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.CheckBox chkboxToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}