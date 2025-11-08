namespace ModernResturantSystem
{
    partial class OrderItemUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemCounter = new System.Windows.Forms.NumericUpDown();
            this.lbItemName = new System.Windows.Forms.Label();
            this.pbDeleteItem = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCurrency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteItem)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemCounter
            // 
            this.ItemCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(76)))), ((int)(((byte)(57)))));
            this.ItemCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCounter.ForeColor = System.Drawing.Color.White;
            this.ItemCounter.Location = new System.Drawing.Point(203, 12);
            this.ItemCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ItemCounter.Name = "ItemCounter";
            this.ItemCounter.Size = new System.Drawing.Size(94, 41);
            this.ItemCounter.TabIndex = 0;
            this.ItemCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ItemCounter.ValueChanged += new System.EventHandler(this.ItemCounter_ValueChanged);
            // 
            // lbItemName
            // 
            this.lbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemName.ForeColor = System.Drawing.Color.White;
            this.lbItemName.Location = new System.Drawing.Point(3, 0);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(194, 66);
            this.lbItemName.TabIndex = 1;
            this.lbItemName.Text = "Chicken Invadors With Mikl";
            this.lbItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbDeleteItem
            // 
            this.pbDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteItem.Image = global::ModernResturantSystem.Properties.Resources.recyclepin;
            this.pbDeleteItem.Location = new System.Drawing.Point(8, 60);
            this.pbDeleteItem.Name = "pbDeleteItem";
            this.pbDeleteItem.Size = new System.Drawing.Size(49, 42);
            this.pbDeleteItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteItem.TabIndex = 2;
            this.pbDeleteItem.TabStop = false;
            this.pbDeleteItem.Click += new System.EventHandler(this.pbDeleteItem_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(86, 66);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(134, 29);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "17465373";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCurrency
            // 
            this.lbCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrency.ForeColor = System.Drawing.Color.White;
            this.lbCurrency.Location = new System.Drawing.Point(221, 69);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(74, 29);
            this.lbCurrency.TabIndex = 1;
            this.lbCurrency.Text = "?????";
            this.lbCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(76)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.pbDeleteItem);
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.ItemCounter);
            this.Name = "OrderItemUC";
            this.Size = new System.Drawing.Size(303, 105);
            ((System.ComponentModel.ISupportInitialize)(this.ItemCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NumericUpDown ItemCounter;
        public System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.PictureBox pbDeleteItem;
        public System.Windows.Forms.Label lbPrice;
        public System.Windows.Forms.Label lbCurrency;
    }
}
