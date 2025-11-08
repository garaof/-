using Bussiness;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolobalClasses; 

namespace ModernResturantSystem.Forms
{
    public partial class frmReports : Form
    {
        // استدعاء دوال من Windows API
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;



        //------------------------------------------
        bool isSidePanelExpands = true; 
        enum enMode { Users=0 ,Sales=1} 
        enMode Mode { get; set; }
        private void SetRedMark(Button btn)
        {
            RedMark.Top = btn.Top; 
            RedMark.Height=btn.Height;
        }

        private void DragForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
        
        
        

        
        public frmReports()
        {
            InitializeComponent();  

            chkboxToday.Checked = true;
            MainDataGridView.DataSource = BlReports.GetTotalWorkPeriodForUsersByDate(DateTime.Now);
            lbDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbTotal.Text = "";
            MainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtpTo.Enabled = false;
            dtpFrom.Enabled = false;
            pbSearch.Enabled = false;
            Mode = enMode.Users;
            dtpFrom.MaxDate = DateTime.Today;
            dtpTo.MaxDate = DateTime.Today;

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SideMenuTimer.Start(); 
        }

        private void SideMenuTimer_Tick(object sender, EventArgs e)
        {
            if (isSidePanelExpands)
            {
                SidePanel.Width -= 30; 
                if(SidePanel.Width == SidePanel.MinimumSize.Width)
                {
                    isSidePanelExpands=false;
                    SideMenuTimer.Stop(); 
                }
            }
            else
            {
                SidePanel.Width += 30; 
                if(SidePanel.Width== SidePanel.MaximumSize.Width)
                {
                    isSidePanelExpands=true;    
                    SideMenuTimer.Stop();   
                } 
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            SetRedMark(btnEmployees);
            lbTotal.Text = "";
            Mode = enMode.Users;
            if (chkboxToday.Checked)
            {
                MainDataGridView.DataSource = BlReports.GetTotalWorkPeriodForUsersByDate(DateTime.Now);
            }
            else
            {
                chkboxToday.Checked = true;
            }
        } 




        private void btnSales_Click(object sender, EventArgs e)
        {
            SetRedMark(btnSales);
            Mode = enMode.Sales;
            if(chkboxToday.Checked)
            {
                MainDataGridView.DataSource=BlReports.GetTotalSalesForUsersByDate(DateTime.Now); 
                
                lbTotal.Text = $"Total Sales : {BlReports.GetTotalSalesByDate(DateTime.Now).ToString()}";
            }
            else
            {
                chkboxToday.Checked = true;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(); 
        }






        //Form Draging : 
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();

        }

        private void frmReports_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();

        }

        private void SidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm(); 
        }

        private void MenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm();

        }

        

        

        private void chkboxToday_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkboxToday.Checked)
            {
                chkboxcustomPeriod.Checked = false;
                chkboxCustomDate.Checked = false;
                dtpFrom.Enabled=false;
                dtpTo.Enabled=false;
                pbSearch.Enabled=false;
                lbDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

                if (Mode == enMode.Users)
                {
                    MainDataGridView.DataSource = BlReports.GetTotalWorkPeriodForUsersByDate(DateTime.Now);
                }
                else
                {
                    MainDataGridView.DataSource=BlReports.GetTotalSalesForUsersByDate(DateTime.Now);
                    lbTotal.Text = $"Total Sales : {BlReports.GetTotalSalesByDate(DateTime.Now).ToString()}";

                }
            }
        }

        private void chkboxCustomDate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkboxCustomDate.Checked)
            {
                chkboxcustomPeriod.Checked = false;
                chkboxToday.Checked = false;
                dtpFrom.Enabled = true; 
                pbSearch.Enabled = true;    
            }
        }

        private void chkboxcustomPeriod_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkboxcustomPeriod.Checked)
            {
                chkboxCustomDate.Checked = false;
                chkboxToday.Checked = false;
                dtpTo.Enabled = true;
                dtpFrom.Enabled = true;
                pbSearch.Enabled = true;    
            }
        }

        private void pbSearch_Click_1(object sender, EventArgs e)
        {
            DateTime From;
            DateTime To;

            if (Mode == enMode.Users)
            {
                if (dtpFrom.Enabled && !dtpTo.Enabled)
                {
                    From = dtpFrom.Value;
                    MainDataGridView.DataSource = BlReports.GetTotalWorkPeriodForUsersByDate(From);
                    lbDate.Text = $"Report For  : {dtpFrom.Value.ToString("yyyy-MM-dd")} ";
                }
                else if (dtpFrom.Enabled && dtpTo.Enabled)
                {
                    From = dtpFrom.Value;
                    To = dtpTo.Value;
                    if (To < From)
                    {
                        MessageBox.Show("The Final Date Must be Bigger Than The Initial Date ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    lbDate.Text = $"Report From : {dtpFrom.Value.ToString("yyyy-MM-dd")}  To : {dtpTo.Value.ToString("yyyy-MM-dd")}";

                    MainDataGridView.DataSource = BlReports.GetTotalWorkPeriodForUsersByTwoDates(From, To);
                }
            }
            else
            {
                if (dtpFrom.Enabled && !dtpTo.Enabled)
                {
                    From = dtpFrom.Value;
                    MainDataGridView.DataSource = BlReports.GetTotalSalesForUsersByDate(From);
                    lbDate.Text = $"Report For  : {dtpFrom.Value.ToString("yyyy-MM-dd")} ";
                    lbTotal.Text = $"Total Sales : {BlReports.GetTotalSalesByDate(From).ToString()}";

                }
                else if (dtpFrom.Enabled && dtpTo.Enabled)
                {
                    From = dtpFrom.Value;
                    To = dtpTo.Value;
                    if (To < From)
                    {
                        MessageBox.Show("The Final Date Must be Bigger Than The Initial Date ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    lbDate.Text = $"Report From : {dtpFrom.Value.ToString("yyyy-MM-dd")}  To : {dtpTo.Value.ToString("yyyy-MM-dd")}";
                    lbTotal.Text = $"Total Sales : {BlReports.GetTotalSalesByTwoDates(From,To).ToString()}";

                    MainDataGridView.DataSource = BlReports.GetTotalSalesForUsersByTwoDates(From, To); 

                }
            }

            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Title = "";
            try
            {
                List<DataGridViewColumn> dgvcloumns = MainDataGridView.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible && !string.IsNullOrWhiteSpace(c.HeaderText)).ToList();
                List<DataGridViewRow> dgvrows = MainDataGridView.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow && r.Visible).ToList();
                Settings.ResturantInfo = BLResturantInfo.GetResturantInfo();
                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                if (Mode == enMode.Users)
                {
                    Title = "Users Report";
                }
                else
                {
                    Title = "Sales Report";
                }
                BlPrintReports report = new BlPrintReports(dgvcloumns, dgvrows, Title, lbDate.Text,lbTotal.Text);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string FilePath = Path.Combine(desktopPath, "FastFoodReport.pdf");
                report.GeneratePdf(FilePath);
                MessageBox.Show("Your Report Exported To Your Desktop Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            }catch (Exception ex)
            {
                Logger.Log(ex.ToString());
                MessageBox.Show("Error While Exporting Your PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }


        }
    }
}
