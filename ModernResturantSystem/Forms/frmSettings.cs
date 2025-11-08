using Bussiness;
using GolobalClasses;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernResturantSystem.Forms
{
    public partial class frmSettings : Form
    {
        bool IsSidePanelExpands = true;
        private int SelectedUserID = 0;
        private void HideSearchControls()
        {
            pbSearch.Visible = false;
            dateTimePicker1.Visible = false;
            label2.Visible = false;
        }
        private void SetRedMark(Button btn)
        {
            if (btn != null)
            {
                RedMark.Top = btn.Top;
                RedMark.Height = btn.Height;
            }
        }
        private bool UIsUserHasPermissions()
        {
            SelectedUserID = Convert.ToInt32(MainDataGridView.CurrentRow.Cells[0].Value);

            if (Settings.LoggedInUser.Role.RoleID > BLUser.FindRoleIDByUserID(SelectedUserID))
            {
                MessageBox.Show("You Donot Have Permissions to do This Operation .You Need Higher Permissions", "Need Permissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void _AddNewUser()
        {
            if (Settings.LoggedInUser.Role.RoleID == 3)
            {
                MessageBox.Show("You Donot Haver Permissions to do This Operation .You Need Admin Permissions", "Need Permissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmAddUpdateUser frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();
            MainDataGridView.DataSource = BLUser.GetAllUserDetails();
        } 




        private void _UpdateUser()
        {
            if (UIsUserHasPermissions())
            {
                frmAddUpdateUser frm = new frmAddUpdateUser(SelectedUserID);
                frm.ShowDialog();
                MainDataGridView.DataSource = BLUser.GetAllUserDetails();
            }
        } 

        private void _DeleteUser()
        {

            //التحقق من صلاحيات المستخدم للحذف
            if (UIsUserHasPermissions())
            {
                //التحقق من أن المستخدم موجود بالفعل فى قاعدة البيانات
                if (BLUser.IsUserExists(SelectedUserID))
                {
                    if (MessageBox.Show("Are you Sure To delete This User ??", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        bool isDeleted = BLUser.DeleteUserByUserID(SelectedUserID);
                        if (isDeleted)
                        {
                            MessageBox.Show("Deleted SuccessFully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error Deleting User ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }



                    MainDataGridView.DataSource = BLUser.GetAllUserDetails();
                }
                else
                {
                    MessageBox.Show("User Is Not Exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void _DeleteDish()
        {
            if (MessageBox.Show("Are you Sure To Delete Selected Dish ?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (BLDish.DeleteDish(Convert.ToInt32(MainDataGridView.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Deleted SuccessFully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainDataGridView.DataSource = BLDish.GetAllDishesInMenue();
                }
                else
                {
                    MessageBox.Show("Failed To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        enum enMode { Users = 0, Dishes = 1, Invoices = 2 }
        private enMode Mode = enMode.Users;




        public frmSettings()
        {
            InitializeComponent();
            MainDataGridView.DataSource = BLUser.GetAllUserDetails(); 
            MainDataGridView.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;

            SetRedMark(btnUsers);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            MainMenuTimer.Start();
        }

        private void MainMenuTimer_Tick(object sender, EventArgs e)
        {
            if (IsSidePanelExpands)
            {
                SidePanel.Width -= 20;
                if (SidePanel.Width == SidePanel.MinimumSize.Width)
                {
                    MainMenuTimer.Stop();
                    IsSidePanelExpands = false;

                }
            }
            else
            {
                SidePanel.Width += 20;
                if (SidePanel.Width == SidePanel.MaximumSize.Width)
                {
                    MainMenuTimer.Stop();
                    IsSidePanelExpands = true;
                }
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            SetRedMark(btnUsers);
            HideSearchControls();
            Mode =enMode.Users;
            MainDataGridView.ContextMenuStrip = csmUsers;
            MainDataGridView.DataSource = BLUser.GetAllUserDetails();

        }

        private void btnDishes_Click(object sender, EventArgs e)
        {
            SetRedMark(btnDishes);
            HideSearchControls();

            Mode = enMode.Dishes;
            MainDataGridView.ContextMenuStrip = csmUsers;
            MainDataGridView.DataSource = BLDish.GetAllDishesInMenue(); 
          

        }

        private void btnAdditionalServices_Click(object sender, EventArgs e)
        {
            SetRedMark(btnAdditionalServices);
            HideSearchControls();

            MainDataGridView.ContextMenuStrip = csmUsers;
            frmAdditionalServices frm = new frmAdditionalServices();    
            frm.ShowDialog();

        }

        private void btnResturantInfo_Click(object sender, EventArgs e)
        {
            SetRedMark(btnResturantInfo);
            HideSearchControls();

            frmDetails frm = new frmDetails();   
            frm.ShowDialog();   

        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            SetRedMark(btnInvoices);
            HideSearchControls();

            pbSearch.Visible = true;
            dateTimePicker1.Visible = true;
            label2.Visible = true;
            Mode = enMode.Invoices;
            MainDataGridView.ContextMenuStrip = csmInvoices;
            MainDataGridView.DataSource = BLInvoice.GetLast100Invoice(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Mode == enMode.Users)
            {
                _AddNewUser(); 
                

            } else if (Mode == enMode.Dishes)
            {
                frmAddUpdateDish frm = new frmAddUpdateDish(-1);   
                frm.ShowDialog();
                MainDataGridView.DataSource = BLDish.GetAllDishesInMenue();
            }

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (Mode == enMode.Users)
            {
                _UpdateUser();
                

            }
            else if(Mode == enMode.Dishes)
            {
                frmAddUpdateDish frm = new frmAddUpdateDish(Convert.ToInt32(MainDataGridView.CurrentRow.Cells[0].Value));
                frm.ShowDialog();
                MainDataGridView.DataSource = BLDish.GetAllDishesInMenue();

            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.Users)
            {
                _DeleteUser(); 
            }else if(Mode == enMode.Dishes)
            {
                _DeleteDish();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InvoiceID = Convert.ToInt32(MainDataGridView.CurrentRow.Cells[0].Value);
            GInvoice invoice =BLInvoice.FindInvoiceByID(InvoiceID); 
            if(invoice != null)
            {
                List<GOrderDetailsRecord> Items = BLOrderDetails.GetAllOrderDetailsByOrderID(invoice.OrderID);
                if(Items != null)
                {
                    try
                    {
                        Settings.ResturantInfo = BLResturantInfo.GetResturantInfo();
                        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                        BLInvoiceDocument invoiceDocument = new BLInvoiceDocument(invoice,Items,true);
                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string FilePath = Path.Combine(desktopPath, "ArchiveInvoice.pdf");
                        invoiceDocument.GeneratePdf(FilePath);

                        MessageBox.Show("Invoice Exported to your Desktop SuccessFully", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }catch(Exception ex)
                    {
                        Logger.Log(ex.Message);
                        MessageBox.Show("Error Exporting Invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                }


            }
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            frmServer server= new frmServer();
            server.ShowDialog();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = BLInvoice.FindAllInvoicesInSpecificDate(dateTimePicker1.Value);
            if(dt == null)
            {
                MessageBox.Show("Error Finding Invoices","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);   
                return;
            }
            else
            {
                MainDataGridView.DataSource = dt;   
            }
        }
    }
}
