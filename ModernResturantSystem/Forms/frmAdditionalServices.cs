using Bussiness;
using GolobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernResturantSystem.Forms
{
    public partial class frmAdditionalServices : Form
    {
        private GAdditionalServices Services = null; 


        private void FillServicesInForm()
        {
            Services = BLAdditionalServices.GetAdditionalServices();
            if (Services == null)
            {
                MessageBox.Show("Error Loading Services","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;   
            }  

            txtbDeliveryCost.Text=Services.DeliveryCost.ToString();
            txtbDiscountAsNumber.Text=Services.DiscountAsNumber.ToString();
            txtbDiscountAsPercent.Text=Services.DisCountAsPercent.ToString();   
            txtbService.Text=Services.Service.ToString();
            txtbTax.Text=Services.Tax.ToString();   
            chkbIsDisCountAsPercent.Checked = Services.IsDisCountAsPercent;
            chkbIsTaxIncluded.Checked = Services.IsTaxIncluded; 


        }




        public frmAdditionalServices()
        {
            InitializeComponent();
            FillServicesInForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbService.Text.Trim()) || string.IsNullOrWhiteSpace(txtbDiscountAsPercent.Text.Trim()) || string.IsNullOrWhiteSpace(txtbDiscountAsNumber.Text.Trim()) || string.IsNullOrWhiteSpace(txtbDeliveryCost.Text.Trim()) || string.IsNullOrWhiteSpace(txtbTax.Text.Trim()))
            {
                MessageBox.Show("You Must Fill All Values To Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            if(!decimal.TryParse(txtbDeliveryCost.Text.Trim(), out decimal delivery) || !decimal.TryParse(txtbDiscountAsNumber.Text.Trim(),out decimal Dnumber) ||!decimal.TryParse(txtbDiscountAsPercent.Text.Trim(),out decimal DPercent) || !decimal.TryParse(txtbService.Text.Trim(),out decimal service) || !decimal.TryParse(txtbTax.Text.Trim(),out decimal tax))
            {
                MessageBox.Show("All Values Must be Numbers .Please Refill All Fields With Suitable Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  
            }
            else
            {
                Services.Tax = tax;
                Services.Service = service; 
                Services.DeliveryCost = delivery;
                Services.DisCountAsPercent = DPercent;
                Services.DiscountAsNumber=Dnumber;
                Services.IsDisCountAsPercent=chkbIsDisCountAsPercent.Checked;
                Services.IsTaxIncluded=chkbIsTaxIncluded.Checked;   

                bool result= BLAdditionalServices.UpdateAdditionalServices(Services);    
                if(result)
                {
                    MessageBox.Show("Updated SuccessFully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Error While Saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
