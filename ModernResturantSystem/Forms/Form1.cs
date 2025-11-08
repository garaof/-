using Bussiness;
using GolobalClasses;
using ModernResturantSystem.Forms;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Previewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernResturantSystem
{
    public partial class Form1 : Form
    {


        //منطقة البروبرتي والدوال العامة 


        bool IsSideBarExpands = true;
        bool IsOrderBarCollapsed = false; 
        public void CountNetValue(decimal total)
        {
            decimal initialtotal = total;   
            if(cbEatIn.Checked )
            {
                total = total + Settings.gAdditionalServices.Service;
            } 
            if(!cbEatIn.Checked && !cbTakeAway.Checked )
            {
                total = total + Settings.gAdditionalServices.DeliveryCost;
            }
           
            if (Settings.gAdditionalServices.IsDisCountAsPercent)
            {
                decimal discount = initialtotal * (Settings.gAdditionalServices.DisCountAsPercent/100);
                total = total - discount;
            }
            if(!Settings.gAdditionalServices.IsDisCountAsPercent)
            {
                total = total - Settings.gAdditionalServices.DiscountAsNumber;
            }
            if (!Settings.gAdditionalServices.IsTaxIncluded)
            {
                decimal tax = initialtotal * (Settings.gAdditionalServices.Tax / 100);
                    total = total + tax;
            } 

            Settings.CurrentOrderNetVAlue = total;  
            lbNetValue.Text = total.ToString();
        }
        public void CountTotalPrice()
        {
            decimal total = 0;
            foreach (OrderItemUC Uc in ItemContainer.Controls)
            {
                total = total + Uc.OrderDetailsRecord.Total;
            }
            Settings.CurrentOrderTotal = total;
            lbTotal.Text = total.ToString();
            CountNetValue(total);
        }
        public void FillMenueItems(int CategoryID)
        {
            this.flayoutMenuItems.Controls.Clear();

           DataTable ItemsTable= BLDish.GetAllDishesByCategoryID(CategoryID);   
            foreach(DataRow Row in ItemsTable.Rows)
            {
                GDish Newdish = new GDish()
                {
                    DishID = Convert.ToInt32(Row["DisheID"]),
                    DishName = Row["Name"].ToString(),
                    DishPrice = Convert.ToDecimal( Row["Price"]),
                    ImagePath =string.IsNullOrEmpty(Row["ImageLink"].ToString()) ? string.Empty : Row["ImageLink"].ToString(),
                    Description=string.IsNullOrEmpty( Row["Description"].ToString()) ?  "No Description" : Row["Description"].ToString(),
                    IsAvailable = Convert.ToBoolean(Row["IsAvailable"]),
                    CategoryID = Convert.ToInt32(Row["CategoryID"]) 
                }; 
                MenuItemUserControl Item= new MenuItemUserControl();
                Item.dish=Newdish;
                Item.OrderItemsPanel = ItemContainer;
                if(Settings.SelectedDishes.Any(d=> d.DishID == Newdish.DishID))
                {
                    Item.SetSelected(true);
                }
                
                    Item.FillDishIntoUC(); 
                
                this.flayoutMenuItems.Controls.Add(Item);
            }
        }
        private void SetRedMark(Button btn)
        {
            RedMark.Height = btn.Height; 
            RedMark.Top = btn.Top;
        }
        private void FillAdditionalServices()
        {
            Settings.gAdditionalServices = BLAdditionalServices.GetAdditionalServices();
            lbDeliveryCost.Text = Settings.gAdditionalServices.DeliveryCost.ToString();
            lbTax.Text = Settings.gAdditionalServices.Tax.ToString() + " %";
            lbIncluded.Visible = Settings.gAdditionalServices.IsTaxIncluded;
            lbService.Text = Settings.gAdditionalServices.Service.ToString();
            Settings.CurrentService = Settings.gAdditionalServices.Service; 
            if (Settings.gAdditionalServices.IsDisCountAsPercent)
            {
                lbDiscount.Text = Settings.gAdditionalServices.DisCountAsPercent.ToString() + " %";
            }
            else
            {
                lbDiscount.Text = Settings.gAdditionalServices.DisCountAsPercent.ToString() + Settings.CurrencySymbol;
            }
        } 
        private void SaveLogOut(object s ,FormClosingEventArgs e)
        {
            DateTime? Logindate = BLLoginRecords.GetLoginTimeByIdSession(Settings.CurrentSessionID);
            //تسجيل زمن الخروج فى قاعدة البيانات 
            if (Logindate != null)
            {
                TimeSpan difference = DateTime.Now - Logindate.Value;
                bool result= BLLoginRecords.UpdateLoginRecord(Settings.CurrentSessionID, DateTime.Now, (int)difference.TotalMinutes);
                if (!result)
                {
                    MessageBox.Show("Error While Logging out", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            
        }






        // استدعاء دوال من Windows API
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;






        //منطقة اطلاق الفورم ومكوناتها 



        public Form1()
        {
            InitializeComponent(); 
            //لتحميل جزء الأطعمة فى المنيو الرئيسي
            FillMenueItems(1); 
            //لتحميل البيانات الاضافية -ضريبة_خدمة صالة _خصم 
            FillAdditionalServices();
            UserNameLabel.Text = $" {Settings.LoggedInUser.UserName}"; 

            this.FormClosing += SaveLogOut;

        }




        //منطقة الأحداث والضغط علي الأزرار 
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void SideBarTimerTick(object sender, EventArgs e)
        {

            if (IsSideBarExpands)
            {
                SideBarContainer.Width -= 15; 
                if(SideBarContainer.Width == SideBarContainer.MinimumSize.Width)
                {
                    IsSideBarExpands = false;
                    SideBarTimer.Stop(); 
                }
            }
            else
            {
                SideBarContainer.Width += 15; 
                if(SideBarContainer.Width == SideBarContainer.MaximumSize.Width)
                {
                    IsSideBarExpands = true; 
                    SideBarTimer.Stop();    
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start(); 
        }

        private void OnOrderCollapse(object sender, EventArgs e)
        {
            if (IsOrderBarCollapsed)
            {
                OrdersMenu.Height +=30;
                if(OrdersMenu.Height ==OrdersMenu.MaximumSize.Height)
                {
                    IsOrderBarCollapsed = false; 
                    OrdersTimer.Stop();
                }
            }
            else
            {
                OrdersMenu.Height -=30;
                if(OrdersMenu.Height == OrdersMenu.MinimumSize.Height)
                {
                    IsOrderBarCollapsed = true; 
                    OrdersTimer.Stop(); 
                }
            }
        }

        private void btnOrdersMenu_Click(object sender, EventArgs e)
        {
            OrdersTimer.Start(); 
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            SetRedMark(btnFoods); 
            FillMenueItems(1);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            SetRedMark(btnDrinks);
            FillMenueItems(2);  
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            SetRedMark(btnDesserts);
            FillMenueItems(3);


        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            SetRedMark(btnExtras);
            FillMenueItems(4);

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            frmReports frm = new frmReports();
            frm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frm.Show();   
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
        private void cbEatIn_CheckedChanged(object sender, EventArgs e)
        {
           

            if (cbEatIn.Checked && !cbTakeAway.Checked)
            {
                lbDeliveryCost.Text = "0.00";
                Settings.CurrentDeliveryCost = 0; 

                lbService.Text = Settings.gAdditionalServices.Service.ToString();
                Settings.CurrentService = Settings.gAdditionalServices.Service;

            }
            if  (!cbEatIn.Checked && cbTakeAway.Checked)
            {
                lbDeliveryCost.Text = "0.00";
                lbService.Text = "0.00";
                Settings.CurrentDeliveryCost = 0;
                Settings.CurrentService = 0; 
            }
            if(!cbEatIn.Checked && !cbTakeAway.Checked)
            {
                lbDeliveryCost.Text=Settings.gAdditionalServices.DeliveryCost.ToString();
                Settings.CurrentDeliveryCost = Settings.gAdditionalServices.DeliveryCost;

                lbService.Text = "0.00";
                Settings.CurrentService = 0; 

            }
             if (cbEatIn.Checked && cbTakeAway.Checked)
            {
                MessageBox.Show("You Can Only Check One Option", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbEatIn.Checked = false;    
                cbTakeAway.Checked = false;
                lbDeliveryCost.Text = Settings.gAdditionalServices.DeliveryCost.ToString(); 
                Settings.CurrentDeliveryCost= Settings.gAdditionalServices.DeliveryCost;    

                lbService.Text = "0.00"; 
                Settings.CurrentService = 0;    

            }
           
                
            CountNetValue(Settings.CurrentOrderTotal);
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            int tablenumber = 0;
            //اختيار رقم الطاولة اذا كان الأكل داخلي : 
            if (cbEatIn.Checked)
            {
                frmChooseTable chooseTable = new frmChooseTable();

                if (chooseTable.ShowDialog() == DialogResult.OK)
                {
                    tablenumber = chooseTable.TableNumber;
                }
                else
                {
                    return;
                }
            }

            //اضافة طلب وارجاع الآي دي الخاص به : 
            Settings.CurrentOrderID = BLOrder.AddNewOrder(new GOrder() { EatIn = cbEatIn.Checked, TableNumber = (tablenumber == 0 ? -1 : tablenumber), UserID = Settings.LoggedInUser.UserID, OrderDate = DateTime.Now });
            if (Settings.CurrentOrderID > 0)
            {
                Settings.InvoiceItems.Clear();

                foreach (OrderItemUC Item in ItemContainer.Controls)
                {
                    //ارجاع سطر تفاصيل الطلب : 
                    GOrderDetailsRecord newrecord = Item.GetOrderDetailsRecord();
                    newrecord.OrderID = Settings.CurrentOrderID;
                    int newrecordID = BLOrderDetails.AddNewOrderDetailRecord(newrecord);
                    if (newrecordID <= 0)
                    {
                        MessageBox.Show($"Error Adding Item : {Item.dish.DishName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //اضافة كل سطر من تفاصيل الطلب الي الليست الجلوبال
                    Settings.InvoiceItems.Add(newrecord);

                }

                //فى حالةالنجاح : يتم انشاء فاتورة جديدة واضافتها الي جدول الفواتير 

                GInvoice invoice = new GInvoice()
                {
                    OrderID = Settings.CurrentOrderID,
                    DeliveryCost = Settings.CurrentDeliveryCost,
                    InvoiceDate = DateTime.Now,
                    Total = Settings.CurrentOrderTotal,
                    Tax = Settings.gAdditionalServices.Tax,
                    Service = Settings.CurrentService,
                    NetValue = Settings.CurrentOrderNetVAlue,
                    Discount = Settings.gAdditionalServices.IsDisCountAsPercent ? Settings.gAdditionalServices.DisCountAsPercent : Settings.gAdditionalServices.DiscountAsNumber,
                    InvoiceNumber = "",
                };
                int InvoiceID = BLInvoice.AddNewInvoice(invoice);
                if (InvoiceID <= 0)
                {
                    MessageBox.Show("Error While Adding New Invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                GInvoice INVOICE = BLInvoice.FindInvoiceByID(InvoiceID);
                //طباعة الفاتورة :  
                Settings.ResturantInfo = BLResturantInfo.GetResturantInfo();
                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                BLInvoiceDocument invoiceDocument = new BLInvoiceDocument(INVOICE,Settings.InvoiceItems);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string FilePath = Path.Combine(desktopPath, "Invoice.pdf");
                invoiceDocument.GeneratePdf(FilePath);

                MessageBox.Show("OrderAdded SuccessFully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error While Adding New Order ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }











        //منطقة خاصة بدوال سحب الفورم 

        // دالة مشتركة لإعادة الاستخدام
        private void DragForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();
        }

        private void flayoutMenuItems_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();

        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm(); 
        }

        private void ItemContainer_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();

        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm(); 
        }

        private void SideBarContainer_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm(); 
        }

        private void label11_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();

        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            DragForm();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSettings frm = new frmSettings();
            frm.FormClosed += (s, Args) =>
            {
                this.Show();
            };
            frm.ShowDialog();

            //تحديث البيانات الموجودة فى الفورم الأساسية لاحمتال تحديث معلومات أثناء استدعاء فورم الاعدادات
            FillMenueItems(1);
            SetRedMark(btnFoods);
            FillAdditionalServices();
        }

       
    }
}
