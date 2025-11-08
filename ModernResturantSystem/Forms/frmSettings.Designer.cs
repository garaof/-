namespace ModernResturantSystem.Forms
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.RedMark = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.csmUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.csmInvoices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.btnResturantInfo = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAdditionalServices = new System.Windows.Forms.Button();
            this.btnDishes = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.csmUsers.SuspendLayout();
            this.csmInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.SidePanel.Controls.Add(this.btnServer);
            this.SidePanel.Controls.Add(this.button1);
            this.SidePanel.Controls.Add(this.RedMark);
            this.SidePanel.Controls.Add(this.btnInvoices);
            this.SidePanel.Controls.Add(this.panel2);
            this.SidePanel.Controls.Add(this.btnResturantInfo);
            this.SidePanel.Controls.Add(this.btnUsers);
            this.SidePanel.Controls.Add(this.btnAdditionalServices);
            this.SidePanel.Controls.Add(this.btnDishes);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.MaximumSize = new System.Drawing.Size(257, 802);
            this.SidePanel.MinimumSize = new System.Drawing.Size(109, 802);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(257, 802);
            this.SidePanel.TabIndex = 0;
            // 
            // RedMark
            // 
            this.RedMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.RedMark.Location = new System.Drawing.Point(239, 132);
            this.RedMark.Name = "RedMark";
            this.RedMark.Size = new System.Drawing.Size(15, 82);
            this.RedMark.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 117);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(257, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 54);
            this.panel1.TabIndex = 1;
            // 
            // MainMenuTimer
            // 
            this.MainMenuTimer.Interval = 10;
            this.MainMenuTimer.Tick += new System.EventHandler(this.MainMenuTimer_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(257, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 130);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.pbSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(58, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(952, 130);
            this.panel4.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 36);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Invoices : ";
            this.label2.Visible = false;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.ContextMenuStrip = this.csmUsers;
            this.MainDataGridView.Location = new System.Drawing.Point(280, 184);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.RowHeadersWidth = 51;
            this.MainDataGridView.RowTemplate.Height = 24;
            this.MainDataGridView.Size = new System.Drawing.Size(920, 618);
            this.MainDataGridView.TabIndex = 3;
            // 
            // csmUsers
            // 
            this.csmUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csmUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.csmUsers.Name = "csmUsers";
            this.csmUsers.Size = new System.Drawing.Size(247, 76);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.addNewToolStripMenuItem.Text = "Add New ";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.updateToolStripMenuItem.Text = "Update Selected Element";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.deleteToolStripMenuItem.Text = "Delete Selected  Element";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1240, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(27, 618);
            this.panel5.TabIndex = 4;
            // 
            // csmInvoices
            // 
            this.csmInvoices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csmInvoices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.csmInvoices.Name = "csmInvoices";
            this.csmInvoices.Size = new System.Drawing.Size(225, 28);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.printToolStripMenuItem.Text = "Print  Selected Invoice";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::ModernResturantSystem.Properties.Resources.icons8_search;
            this.pbSearch.Location = new System.Drawing.Point(654, 51);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(53, 38);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 16;
            this.pbSearch.TabStop = false;
            this.pbSearch.Visible = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // btnServer
            // 
            this.btnServer.FlatAppearance.BorderSize = 0;
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.Image = global::ModernResturantSystem.Properties.Resources.icons8_server_60;
            this.btnServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServer.Location = new System.Drawing.Point(3, 596);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(236, 76);
            this.btnServer.TabIndex = 7;
            this.btnServer.Text = "Server";
            this.btnServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 84);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back            ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.ForeColor = System.Drawing.Color.White;
            this.btnInvoices.Image = global::ModernResturantSystem.Properties.Resources.icons8_invoices_60;
            this.btnInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoices.Location = new System.Drawing.Point(3, 505);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(236, 76);
            this.btnInvoices.TabIndex = 6;
            this.btnInvoices.Text = " Invoices";
            this.btnInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenu.Image = global::ModernResturantSystem.Properties.Resources.Lines;
            this.pbMenu.Location = new System.Drawing.Point(15, 33);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(45, 50);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 2;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // btnResturantInfo
            // 
            this.btnResturantInfo.FlatAppearance.BorderSize = 0;
            this.btnResturantInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResturantInfo.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResturantInfo.ForeColor = System.Drawing.Color.White;
            this.btnResturantInfo.Image = global::ModernResturantSystem.Properties.Resources.icons8_details_60;
            this.btnResturantInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResturantInfo.Location = new System.Drawing.Point(3, 413);
            this.btnResturantInfo.Name = "btnResturantInfo";
            this.btnResturantInfo.Size = new System.Drawing.Size(236, 76);
            this.btnResturantInfo.TabIndex = 5;
            this.btnResturantInfo.Text = "Details";
            this.btnResturantInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResturantInfo.UseVisualStyleBackColor = true;
            this.btnResturantInfo.Click += new System.EventHandler(this.btnResturantInfo_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::ModernResturantSystem.Properties.Resources.icons8_users_60;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(3, 137);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(236, 76);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAdditionalServices
            // 
            this.btnAdditionalServices.FlatAppearance.BorderSize = 0;
            this.btnAdditionalServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdditionalServices.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditionalServices.ForeColor = System.Drawing.Color.White;
            this.btnAdditionalServices.Image = global::ModernResturantSystem.Properties.Resources.icons8_services_60;
            this.btnAdditionalServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdditionalServices.Location = new System.Drawing.Point(3, 321);
            this.btnAdditionalServices.Name = "btnAdditionalServices";
            this.btnAdditionalServices.Size = new System.Drawing.Size(236, 76);
            this.btnAdditionalServices.TabIndex = 4;
            this.btnAdditionalServices.Text = " Services";
            this.btnAdditionalServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdditionalServices.UseVisualStyleBackColor = true;
            this.btnAdditionalServices.Click += new System.EventHandler(this.btnAdditionalServices_Click);
            // 
            // btnDishes
            // 
            this.btnDishes.FlatAppearance.BorderSize = 0;
            this.btnDishes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishes.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDishes.ForeColor = System.Drawing.Color.White;
            this.btnDishes.Image = global::ModernResturantSystem.Properties.Resources.icons8_wok_60;
            this.btnDishes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDishes.Location = new System.Drawing.Point(3, 229);
            this.btnDishes.Name = "btnDishes";
            this.btnDishes.Size = new System.Drawing.Size(236, 76);
            this.btnDishes.TabIndex = 3;
            this.btnDishes.Text = " Dishes";
            this.btnDishes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDishes.UseVisualStyleBackColor = true;
            this.btnDishes.Click += new System.EventHandler(this.btnDishes_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 802);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.SidePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.csmUsers.ResumeLayout(false);
            this.csmInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDishes;
        private System.Windows.Forms.Button btnAdditionalServices;
        private System.Windows.Forms.Button btnResturantInfo;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Timer MainMenuTimer;
        private System.Windows.Forms.Panel RedMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.ContextMenuStrip csmUsers;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ContextMenuStrip csmInvoices;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}