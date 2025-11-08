namespace ModernResturantSystem
{
    partial class Form1
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
            this.SideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.OrdersMenu = new System.Windows.Forms.Panel();
            this.RedMark = new System.Windows.Forms.Panel();
            this.btnExtras = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnFoods = new System.Windows.Forms.Button();
            this.btnOrdersMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.OrdersTimer = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ItemContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbNetValue = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbService = new System.Windows.Forms.Label();
            this.lbIncluded = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbDeliveryCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbTakeAway = new System.Windows.Forms.CheckBox();
            this.cbEatIn = new System.Windows.Forms.CheckBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.flayoutMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SideBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.OrdersMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBarContainer
            // 
            this.SideBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.SideBarContainer.Controls.Add(this.panel1);
            this.SideBarContainer.Controls.Add(this.OrdersMenu);
            this.SideBarContainer.Controls.Add(this.panel2);
            this.SideBarContainer.Controls.Add(this.panel3);
            this.SideBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarContainer.Location = new System.Drawing.Point(0, 0);
            this.SideBarContainer.MaximumSize = new System.Drawing.Size(206, 806);
            this.SideBarContainer.MinimumSize = new System.Drawing.Size(58, 806);
            this.SideBarContainer.Name = "SideBarContainer";
            this.SideBarContainer.Size = new System.Drawing.Size(206, 806);
            this.SideBarContainer.TabIndex = 0;
            this.SideBarContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SideBarContainer_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 94);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Image = global::ModernResturantSystem.Properties.Resources.Lines;
            this.MenuButton.Location = new System.Drawing.Point(4, 22);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(45, 50);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // OrdersMenu
            // 
            this.OrdersMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.OrdersMenu.Controls.Add(this.RedMark);
            this.OrdersMenu.Controls.Add(this.btnExtras);
            this.OrdersMenu.Controls.Add(this.btnDesserts);
            this.OrdersMenu.Controls.Add(this.btnDrinks);
            this.OrdersMenu.Controls.Add(this.btnFoods);
            this.OrdersMenu.Controls.Add(this.btnOrdersMenu);
            this.OrdersMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdersMenu.Location = new System.Drawing.Point(3, 103);
            this.OrdersMenu.MaximumSize = new System.Drawing.Size(196, 366);
            this.OrdersMenu.MinimumSize = new System.Drawing.Size(196, 73);
            this.OrdersMenu.Name = "OrdersMenu";
            this.OrdersMenu.Size = new System.Drawing.Size(196, 366);
            this.OrdersMenu.TabIndex = 1;
            // 
            // RedMark
            // 
            this.RedMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.RedMark.Location = new System.Drawing.Point(179, 82);
            this.RedMark.Name = "RedMark";
            this.RedMark.Size = new System.Drawing.Size(14, 65);
            this.RedMark.TabIndex = 1;
            // 
            // btnExtras
            // 
            this.btnExtras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtras.FlatAppearance.BorderSize = 0;
            this.btnExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtras.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtras.ForeColor = System.Drawing.Color.White;
            this.btnExtras.Image = global::ModernResturantSystem.Properties.Resources.Exstras;
            this.btnExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtras.Location = new System.Drawing.Point(0, 289);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(196, 70);
            this.btnExtras.TabIndex = 2;
            this.btnExtras.Text = "  Extras";
            this.btnExtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtras.UseVisualStyleBackColor = true;
            this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
            // 
            // btnDesserts
            // 
            this.btnDesserts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesserts.FlatAppearance.BorderSize = 0;
            this.btnDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesserts.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesserts.ForeColor = System.Drawing.Color.White;
            this.btnDesserts.Image = global::ModernResturantSystem.Properties.Resources.Dessert;
            this.btnDesserts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesserts.Location = new System.Drawing.Point(0, 219);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(196, 70);
            this.btnDesserts.TabIndex = 2;
            this.btnDesserts.Text = "  Desserts";
            this.btnDesserts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesserts.UseVisualStyleBackColor = true;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrinks.FlatAppearance.BorderSize = 0;
            this.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinks.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.ForeColor = System.Drawing.Color.White;
            this.btnDrinks.Image = global::ModernResturantSystem.Properties.Resources.Drinks;
            this.btnDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinks.Location = new System.Drawing.Point(0, 149);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(196, 70);
            this.btnDrinks.TabIndex = 2;
            this.btnDrinks.Text = "  Drinks";
            this.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnFoods
            // 
            this.btnFoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoods.FlatAppearance.BorderSize = 0;
            this.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoods.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoods.ForeColor = System.Drawing.Color.White;
            this.btnFoods.Image = global::ModernResturantSystem.Properties.Resources.Chicken;
            this.btnFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoods.Location = new System.Drawing.Point(0, 79);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Size = new System.Drawing.Size(196, 70);
            this.btnFoods.TabIndex = 2;
            this.btnFoods.Text = "  Foods";
            this.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoods.UseVisualStyleBackColor = true;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // btnOrdersMenu
            // 
            this.btnOrdersMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdersMenu.FlatAppearance.BorderSize = 0;
            this.btnOrdersMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersMenu.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdersMenu.ForeColor = System.Drawing.Color.White;
            this.btnOrdersMenu.Image = global::ModernResturantSystem.Properties.Resources.Order;
            this.btnOrdersMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdersMenu.Location = new System.Drawing.Point(0, 0);
            this.btnOrdersMenu.Name = "btnOrdersMenu";
            this.btnOrdersMenu.Size = new System.Drawing.Size(196, 79);
            this.btnOrdersMenu.TabIndex = 2;
            this.btnOrdersMenu.Text = "  Orders";
            this.btnOrdersMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdersMenu.UseVisualStyleBackColor = true;
            this.btnOrdersMenu.Click += new System.EventHandler(this.btnOrdersMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Location = new System.Drawing.Point(3, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 76);
            this.panel2.TabIndex = 1;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::ModernResturantSystem.Properties.Resources.Reports;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 6);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(190, 65);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "  Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSettings);
            this.panel3.Location = new System.Drawing.Point(3, 557);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 76);
            this.panel3.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::ModernResturantSystem.Properties.Resources.Settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(190, 65);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimerTick);
            // 
            // OrdersTimer
            // 
            this.OrdersTimer.Interval = 10;
            this.OrdersTimer.Tick += new System.EventHandler(this.OnOrderCollapse);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(206, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1629, 39);
            this.panel4.TabIndex = 1;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.UserNameLabel);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(500, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1129, 39);
            this.panel10.TabIndex = 1;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(656, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 41);
            this.label11.TabIndex = 2;
            this.label11.Text = "LoggedUser : ";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label11_MouseDown);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserNameLabel.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.UserNameLabel.Location = new System.Drawing.Point(864, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(265, 39);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Home Page";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(136, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 41);
            this.label10.TabIndex = 0;
            this.label10.Text = "Home Page";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Location = new System.Drawing.Point(137, 37);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(165, 213);
            this.panel8.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ItemContainer);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1514, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 767);
            this.panel5.TabIndex = 2;
            // 
            // ItemContainer
            // 
            this.ItemContainer.AutoScroll = true;
            this.ItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ItemContainer.Location = new System.Drawing.Point(0, 115);
            this.ItemContainer.Name = "ItemContainer";
            this.ItemContainer.Size = new System.Drawing.Size(321, 327);
            this.ItemContainer.TabIndex = 3;
            this.ItemContainer.WrapContents = false;
            this.ItemContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemContainer_MouseDown);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnPlaceOrder);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.lbTotal);
            this.panel9.Controls.Add(this.lbNetValue);
            this.panel9.Controls.Add(this.lbDiscount);
            this.panel9.Controls.Add(this.lbService);
            this.panel9.Controls.Add(this.lbIncluded);
            this.panel9.Controls.Add(this.lbTax);
            this.panel9.Controls.Add(this.lbDeliveryCost);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 442);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(321, 325);
            this.panel9.TabIndex = 2;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseDown);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnPlaceOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(0, 259);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(319, 64);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(10, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Net Value :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(1, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "ToTal  : ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(5, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "-------------";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(2, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "-------------";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(2, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Discount  : ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Service  : ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(1, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tax  : ";
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.lbTotal.Location = new System.Drawing.Point(118, 16);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(185, 29);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "0.00";
            // 
            // lbNetValue
            // 
            this.lbNetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.lbNetValue.Location = new System.Drawing.Point(135, 218);
            this.lbNetValue.Name = "lbNetValue";
            this.lbNetValue.Size = new System.Drawing.Size(181, 29);
            this.lbNetValue.TabIndex = 0;
            this.lbNetValue.Text = "0.00";
            // 
            // lbDiscount
            // 
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.lbDiscount.Location = new System.Drawing.Point(123, 159);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(185, 29);
            this.lbDiscount.TabIndex = 0;
            this.lbDiscount.Text = "0.00";
            // 
            // lbService
            // 
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.lbService.Location = new System.Drawing.Point(117, 127);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(185, 29);
            this.lbService.TabIndex = 0;
            this.lbService.Text = "0.00";
            // 
            // lbIncluded
            // 
            this.lbIncluded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncluded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.lbIncluded.Location = new System.Drawing.Point(187, 100);
            this.lbIncluded.Name = "lbIncluded";
            this.lbIncluded.Size = new System.Drawing.Size(132, 29);
            this.lbIncluded.TabIndex = 0;
            this.lbIncluded.Text = "#Included";
            // 
            // lbTax
            // 
            this.lbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.lbTax.Location = new System.Drawing.Point(68, 100);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(113, 29);
            this.lbTax.TabIndex = 0;
            this.lbTax.Text = "0.00 %";
            // 
            // lbDeliveryCost
            // 
            this.lbDeliveryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeliveryCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.lbDeliveryCost.Location = new System.Drawing.Point(171, 69);
            this.lbDeliveryCost.Name = "lbDeliveryCost";
            this.lbDeliveryCost.Size = new System.Drawing.Size(131, 29);
            this.lbDeliveryCost.TabIndex = 0;
            this.lbDeliveryCost.Text = "0.00";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delivery Cost : ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 58);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 57);
            this.panel7.TabIndex = 1;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Order";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.cbTakeAway);
            this.panel6.Controls.Add(this.cbEatIn);
            this.panel6.Controls.Add(this.pbClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 58);
            this.panel6.TabIndex = 0;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            // 
            // cbTakeAway
            // 
            this.cbTakeAway.AutoSize = true;
            this.cbTakeAway.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTakeAway.Location = new System.Drawing.Point(105, 13);
            this.cbTakeAway.Name = "cbTakeAway";
            this.cbTakeAway.Size = new System.Drawing.Size(155, 39);
            this.cbTakeAway.TabIndex = 4;
            this.cbTakeAway.Text = "Take Away";
            this.cbTakeAway.UseVisualStyleBackColor = true;
            this.cbTakeAway.CheckedChanged += new System.EventHandler(this.cbEatIn_CheckedChanged);
            // 
            // cbEatIn
            // 
            this.cbEatIn.AutoSize = true;
            this.cbEatIn.Checked = true;
            this.cbEatIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEatIn.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEatIn.Location = new System.Drawing.Point(6, 12);
            this.cbEatIn.Name = "cbEatIn";
            this.cbEatIn.Size = new System.Drawing.Size(100, 39);
            this.cbEatIn.TabIndex = 4;
            this.cbEatIn.Text = "Eat In";
            this.cbEatIn.UseVisualStyleBackColor = true;
            this.cbEatIn.CheckedChanged += new System.EventHandler(this.cbEatIn_CheckedChanged);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::ModernResturantSystem.Properties.Resources.icons8_close_window_100__2_;
            this.pbClose.Location = new System.Drawing.Point(271, 10);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(41, 39);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // flayoutMenuItems
            // 
            this.flayoutMenuItems.AutoScroll = true;
            this.flayoutMenuItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.flayoutMenuItems.Location = new System.Drawing.Point(493, 39);
            this.flayoutMenuItems.Name = "flayoutMenuItems";
            this.flayoutMenuItems.Padding = new System.Windows.Forms.Padding(5);
            this.flayoutMenuItems.Size = new System.Drawing.Size(1021, 767);
            this.flayoutMenuItems.TabIndex = 3;
            this.flayoutMenuItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flayoutMenuItems_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 806);
            this.Controls.Add(this.flayoutMenuItems);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SideBarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.SideBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.OrdersMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SideBarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Panel OrdersMenu;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.Button btnOrdersMenu;
        private System.Windows.Forms.Timer OrdersTimer;
        private System.Windows.Forms.Panel RedMark;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lbDeliveryCost;
        public System.Windows.Forms.FlowLayoutPanel ItemContainer;
        public System.Windows.Forms.Label lbTax;
        public System.Windows.Forms.Label lbDiscount;
        public System.Windows.Forms.Label lbService;
        public System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        public System.Windows.Forms.FlowLayoutPanel flayoutMenuItems;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbNetValue;
        private System.Windows.Forms.CheckBox cbEatIn;
        public System.Windows.Forms.Label lbIncluded;
        private System.Windows.Forms.CheckBox cbTakeAway;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label11;
    }
}

