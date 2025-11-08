using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolobalClasses;

namespace ModernResturantSystem
{
    public partial class OrderItemUC : UserControl
    {
        public GDish dish { get; set; }
        public FlowLayoutPanel MainPanel { get; set; } 
        public GOrderDetailsRecord OrderDetailsRecord { get; set; } 
        //دالة لارجاع سطر تفاصيل الطلب : 
        public GOrderDetailsRecord GetOrderDetailsRecord()
        {
            OrderDetailsRecord.Units = (short) ItemCounter.Value;
            OrderDetailsRecord.Total = OrderDetailsRecord.Units * OrderDetailsRecord.DishPrice;
            return OrderDetailsRecord;
        }

        private void FillUCData(GDish dish)
        {
            this.lbCurrency.Text = Settings.CurrencySymbol;
            this.dish = dish;
            this.lbItemName.Text = dish.DishName;
            this.lbPrice.Text = dish.DishPrice.ToString();
        }
        private void CountInvoiceTotalPrice()
        {
            Form1 frm = (Form1)this.FindForm();
            frm.CountTotalPrice();
        }



        public OrderItemUC(GDish newdish)
        {
            InitializeComponent(); 
            //ملئ تفاصيل الطبق فى اليوزر كونترول(السعر-الاسم 
            FillUCData(newdish);
            //اعداد سطر تفاصيل الطلب لارجاع كائن كامل  فى حال اجراء طلب 
            OrderDetailsRecord = new GOrderDetailsRecord(); 
            OrderDetailsRecord.DishID = newdish.DishID; 
            OrderDetailsRecord.DishPrice = newdish.DishPrice;
            OrderDetailsRecord.DishName=newdish.DishName;   
            OrderDetailsRecord.Units = 1;
            OrderDetailsRecord.Total = newdish.DishPrice;

        }

        private void pbDeleteItem_Click(object sender, EventArgs e)
        {
            //تم تقسيم الدالة الخاصة باعادة التجميع الي سطرين لانه لا يمكن ايجاد الفورم الرئيسي بعد 
            //حذف اليوزر كونترول الحالي 
            Form1 frm = (Form1)this.FindForm();
            GDish DishtoDelete = Settings.SelectedDishes.OfType<GDish>().FirstOrDefault(d =>d.DishID == dish.DishID); 
            if (DishtoDelete != null)
            {
                Settings.SelectedDishes.Remove(DishtoDelete);   
            } 
            MenuItemUserControl ItemToUnSelect= MainPanel.Controls.OfType<MenuItemUserControl>().FirstOrDefault(d=> d.dish.DishID == dish.DishID);   
            if (ItemToUnSelect != null)
            {
                ItemToUnSelect.SetSelected(false); 
            }
            this.Parent.Controls.Remove(this);

            this.Dispose(); 
            //يقوم بعمل اعادة حساب بعد انتهاء وجود الكائن 
            frm.CountTotalPrice();


        }

        private void ItemCounter_ValueChanged(object sender, EventArgs e)
        {
            OrderDetailsRecord.Total = OrderDetailsRecord.DishPrice * ItemCounter.Value;
            lbPrice.Text= OrderDetailsRecord.Total.ToString();
            CountInvoiceTotalPrice();

        }
    }
}
