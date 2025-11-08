using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolobalClasses;

namespace ModernResturantSystem
{
    public partial class MenuItemUserControl : UserControl
    {
        bool IsItemChoosen = false; 

        public GDish dish {  get; set; }     
        public FlowLayoutPanel OrderItemsPanel { get; set; }
        private void CountInvoiceTotalPrice()
        {
            Form1 frm = (Form1)this.FindForm();
            frm.CountTotalPrice();
        }








        public MenuItemUserControl()
        {
            InitializeComponent();
        }


        public void SetSelected(bool selected)
        {
            if (selected)
            {
                btnAdd.FlatAppearance.BorderSize = 2;
                btnAdd.Image = Properties.Resources.correct;
                IsItemChoosen=true;
            }
            else
            {
                btnAdd.FlatAppearance.BorderSize = 0;
                btnAdd.Image = null;
                IsItemChoosen = false;
            }
            
        }
        // to fill details into user control from GDish object : 
        public void FillDishIntoUC()
        {
            this.lbName.Text = dish.DishName;
            this.lbPrice.Text=dish.DishPrice.ToString() + Settings.CurrencySymbol;

            if(string.IsNullOrEmpty(dish.ImagePath) || !System.IO.File.Exists(dish.ImagePath))
            {
                this.pbItemPhoto.Image = Properties.Resources.DefaultFood;

            } 
            else
            {
                using(FileStream Fs= new FileStream(dish.ImagePath, FileMode.Open, FileAccess.Read))
                {
                    this.pbItemPhoto.Image = Image.FromStream(Fs);

                }
            } 
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsItemChoosen)
            {
                SetSelected(false); 
                //ازالة الطبق من القائمة الجلوبال للأطباق المختارة 
                GDish dishtoremove = Settings.SelectedDishes.OfType<GDish>().FirstOrDefault(d =>d.DishID == dish.DishID);
                if (dishtoremove != null) 
                {
                    Settings.SelectedDishes.Remove(dishtoremove);
                    if (OrderItemsPanel != null)
                    {
                        //ازالة اليوزر كونترول من البانل الجانبي  
                        var toremove = OrderItemsPanel.Controls.OfType<OrderItemUC>().FirstOrDefault(c => c.dish.DishID == dish.DishID);
                        if (toremove != null)
                        {
                            OrderItemsPanel.Controls.Remove(toremove);
                            toremove.Dispose();
                            CountInvoiceTotalPrice();
                        }
                    }
                }
                


            }
            else
            {
                SetSelected(true); 
                //اضافة طبق للقائمة جلوبال واضافة يوزر كونترول للبانل الجانبي 
                if ( !Settings.SelectedDishes.Any(d=>d.DishID == dish.DishID))
                {
                    Settings.SelectedDishes.Add(dish);
                    if (OrderItemsPanel != null)
                    {
                        OrderItemUC Item = new OrderItemUC(dish);
                        Item.MainPanel = (FlowLayoutPanel)this.Parent;
                        OrderItemsPanel.Controls.Add(Item);
                        CountInvoiceTotalPrice();
                    }

                }


            }
        }
    }
}
