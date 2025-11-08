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
    public partial class frmAddUpdateDish : Form
    {

        private GDish Dish= null;
        private bool IsThereRequiredValuesNull()
        {
              return (string.IsNullOrWhiteSpace(txtbDishName.Text) || string.IsNullOrWhiteSpace(txtbPrice.Text) || string.IsNullOrWhiteSpace(cmbCategory.SelectedItem.ToString()));
        }
        private string imagepath = null;
        private int DishID = -1;
        private bool IsModeAddNew = true;
        private void _AddNewDish()
        {
            Dish = new GDish()
            {
                DishID = -1,
                DishName = txtbDishName.Text.Trim(),
                DishPrice = Convert.ToDecimal(txtbPrice.Text.Trim()),
                Description = string.IsNullOrWhiteSpace(rchbDescription.Text.Trim()) ? "" : rchbDescription.Text.Trim(),
                IsAvailable = chkbIsAvailable.Checked,
                // التحقق من أن مسار الصورة ليس خالي ثم التحقق من نجاح نقل الصورة الي الملف المخصص ثم تخزين المسار الجديد
                ImagePath = imagepath == null ? null : (ImageHandling.CopyImageToImagesFile(ref imagepath) ? imagepath : null),
                CategoryID = cmbCategory.SelectedIndex + 1,
                IsDeleted = false
            };

            Dish.DishID = BLDish.AddNewDish(Dish);
            if (Dish.DishID <= 0)
            {
                lbDishID.Text = Dish.DishID.ToString();
                IsModeAddNew=false; 
                MessageBox.Show("Error Adding New Dish ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Added SuccessFully  ", "Succeed ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbDishID.Text = Dish.DishID.ToString();
                return;
            }

        }
        private void _LoadDishInfoInForm()
        {
            Dish = BLDish.GetDishByID(DishID);
            if (Dish == null)
            {
                MessageBox.Show("Error  Can not Find Dish", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            } 

            lbDishID.Text=Dish.DishID.ToString();
            txtbDishName.Text = Dish.DishName;
            txtbPrice.Text=Dish.DishPrice.ToString();
            cmbCategory.SelectedIndex = Dish.CategoryID-1;   
            rchbDescription.Text = Dish.Description;    
            if(Dish.ImagePath== null)
            {
                pbPhoto.Image = Properties.Resources.DefaultFood;
            }
            else
            {
                lbRemove.Enabled = true;
                lbAdd.Enabled = false;
                try
                {
                    using (var fs = new FileStream(Dish.ImagePath, FileMode.Open, FileAccess.Read))
                    {
                        pbPhoto.Image = Image.FromStream(fs);
                    }
                    imagepath = Dish.ImagePath;
                }
                catch
                {
                    pbPhoto.Image = Properties.Resources.DefaultFood;
                }
            } 


           chkbIsAvailable.Checked = Dish.IsAvailable;  

        }

        private void _UpdateDish()
        {
            Dish.DishName = txtbDishName.Text;
            Dish.DishPrice = Convert.ToDecimal(txtbPrice.Text.Trim());
            Dish.Description = string.IsNullOrWhiteSpace(rchbDescription.Text.Trim()) ? "" : rchbDescription.Text.Trim();
            Dish.IsAvailable = chkbIsAvailable.Checked;


            if ( imagepath != Dish.ImagePath) 
            {
                if (!string.IsNullOrEmpty(Dish.ImagePath) && File.Exists(Dish.ImagePath) ) 
                {
                    try
                    {
                        File.Delete(Dish.ImagePath);
                    }
                    catch(Exception e)
                    {
                        Logger.Log(e.ToString());
                        MessageBox.Show("Error Deleting Old Photo" ,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }


                if (!string.IsNullOrEmpty(imagepath))
                {
                    bool result =ImageHandling.CopyImageToImagesFile( ref imagepath);
                    if (!result)
                    {
                        MessageBox.Show("Error Copying New Photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                } 


                Dish.ImagePath = imagepath; 
            }
            
            Dish.CategoryID = cmbCategory.SelectedIndex + 1;

            bool Updated = BLDish.UpdateDish(Dish); 
            if (Updated)
            {
                MessageBox.Show("Updated SuccessFully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Error Updating Dish ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public frmAddUpdateDish(int dishid)
        {
            InitializeComponent();
            cmbCategory.DataSource = BLDishCategory.GetAllDishCategories(); 
            DishID=dishid;
            if (dishid > 0)
            {
                IsModeAddNew = false;
                _LoadDishInfoInForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsThereRequiredValuesNull())
            {
                MessageBox.Show("(Name,Price,Category) Are Required Information ,Can not be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Category Before Continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsModeAddNew)
            {
                _AddNewDish();
            }
            else
            {
                _UpdateDish();
            }

            
        }

        private void lbAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.gif;*.png;*.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;  
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                try
                {
                    using (var fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read))
                    {
                        pbPhoto.Image = Image.FromStream(fs);
                    }
                    lbRemove.Enabled = true;
                }catch (Exception ex)
                {
                    Logger.Log(ex.ToString());

                }
               
            } 



        }

        private void lbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            pbPhoto.Image = Properties.Resources.DefaultFood;
            imagepath = null;
            lbAdd.Enabled = true;
            lbRemove.Enabled = false; 
        }
    }
}
