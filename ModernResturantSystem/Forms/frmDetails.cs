using Bussiness;
using GolobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernResturantSystem.Forms
{
    public partial class frmDetails : Form
    {
         string imagechosenlink = null;
         GResturantInfo Info = null;    

        private void FillDetailsInForm()
        {
            Info = BLResturantInfo.GetResturantInfo(); 

            if(Info == null)
            {
                MessageBox.Show("Error Loading Resturant Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

            txtbResturantName.Text = Info.ResturantName;
            rchbAddress.Text = Info.ResturantAddress;   

            if(Info.LogoPath != string.Empty)
            {
                try
                {
                    using (FileStream fs = new FileStream(Info.LogoPath, FileMode.Open, FileAccess.Read))
                    {
                        pbPhoto.Image = Image.FromStream(fs);
                        lbAdd.Enabled = false;
                        lbRemove.Enabled = true;
                    }
                }
                catch(Exception ex) 
                {
                    Logger.Log(ex.Message);
                    pbPhoto.Image = Properties.Resources.DefaultFood;
                }
            }

            if (Info.Slogan != string.Empty)
            {
                txtbSlogan.Text = Info.Slogan;  

            }
        }

        public frmDetails()
        {
            InitializeComponent();
            FillDetailsInForm();  


        }










        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(); 
        }

        private void lbAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files |*.jpg;*.jpeg;*.gif;*.png;*.bmp";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        pbPhoto.Image = Image.FromStream(fs);
                    }
                    imagechosenlink = ofd.FileName;
                    lbAdd.Enabled = false;
                    lbRemove.Enabled = true;
                } catch (Exception ex)
                {
                    Logger.Log(ex.Message); 
                    MessageBox.Show("Error Loading Photo","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            }
        }

        private void lbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPhoto.Image= Properties.Resources.DefaultFood;    
            imagechosenlink = null; 
            lbRemove.Enabled = false;   
            lbAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrWhiteSpace(txtbResturantName.Text.Trim()) || string.IsNullOrWhiteSpace(rchbAddress.Text.Trim()))
            {
                MessageBox.Show("Resturant Name ,Address Can not Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            } 



            Info.ResturantName = txtbResturantName.Text.Trim(); 
            Info.ResturantAddress = rchbAddress.Text.Trim();
            Info.Slogan = string.IsNullOrWhiteSpace(txtbSlogan.Text)? null : txtbSlogan.Text.Trim();
            if(imagechosenlink != Info.LogoPath)
            {
                if (Info.LogoPath != null && File.Exists(Info.LogoPath))
                {
                    try
                    {
                        File.Delete(Info.LogoPath);
                    }
                    catch (Exception Ex)
                    {
                        Logger.Log(Ex.Message);
                        MessageBox.Show("Error Deleting Previous Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                } 

                if(imagechosenlink != null && File.Exists(imagechosenlink))
                {
                    bool result = ImageHandling.CopyImageToImagesFile(ref imagechosenlink);
                    if (!result)
                    {
                        MessageBox.Show("Error Error Copying New Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    } 


                }

                Info.LogoPath = imagechosenlink;



            }

           bool saved= BLResturantInfo.UpdateResturantInfo(Info); 
            if(saved)
            {
                MessageBox.Show("Updated SuccessFully " ,"Succeed",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Saving Updates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
