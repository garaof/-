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
    public partial class frmAddUpdateUser : Form
    {
        
        private bool IsThereNullValues()
        {
            return (string.IsNullOrWhiteSpace(txtbFirstName.Text) || string.IsNullOrWhiteSpace(txtbLastName.Text) || string.IsNullOrWhiteSpace(txtbEmail.Text) || string.IsNullOrWhiteSpace(txtbPhone.Text)
                    || string.IsNullOrWhiteSpace(txtbJobTitle.Text) || string.IsNullOrWhiteSpace(txtbPassWord.Text) || string.IsNullOrWhiteSpace(txtbUserName.Text) || string.IsNullOrWhiteSpace(rchbAddress.Text));
        } 


        private bool IsPhoneNumberValid(string phone)
        {
            if (phone.StartsWith("+"))
                phone = phone.Substring(1); 

            foreach(char c in phone)
            {
                if(!char.IsDigit(c)) 
                    return false; 
            }
            return phone.Length > 7 && phone.Length < 15; 
        } 

        private void AddNewUser()
        {
            if (BLUser.IsThereAnotherUserWithUserName(txtbUserName.Text.Trim()))
            {
                MessageBox.Show("There is Another User With Same UserName .Please Choose Another Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            GPerson p = new GPerson()
            {
                PersonID = -1,
                FirstName = txtbFirstName.Text.Trim(),
                LastName = txtbLastName.Text.Trim(),
                Phone = txtbPhone.Text.Trim(),
                Email = txtbEmail.Text.Trim(),
                Address = rchbAddress.Text.Trim(),
                JobTitle = txtbJobTitle.Text.Trim()
            };


            p.PersonID = BLPeople.AddNewPerson(p);

            if (p.PersonID <= 0)
            {
                MessageBox.Show("Error While Adding New Person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GUser U = new GUser()
            {
                UserID = -1,
                UserName = txtbUserName.Text.Trim(),
                Password = txtbPassWord.Text.Trim(),
                Role = BLRole.FindUserRoleWithName(cmbRole.Text),
                IsActive = chkbIsActive.Checked,
                Person = p

            };

            if (U.Role == null)
            {
                MessageBox.Show("Error Finding Role You Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //حذف الشخص المضاف فى حال الفشل لمنع تكرار البيانات عند اعادة الادخال
                BLPeople.DeletePerson(p.PersonID);
                return;
            }

            int UserId = BLUser.AddNewUser(U);
            if (UserId <= 0)
            {
                MessageBox.Show("Error While Adding New User ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //حذف الشخص المضاف فى حال الفشل لمنع تكرار البيانات عند اعادة الادخال
                BLPeople.DeletePerson(p.PersonID);
                return;
            }

             UserToUpdate = U;
            _ModeIsAddNew = false;
            MessageBox.Show("User Added SuccessFully ", "SuccessFull Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            lbUserID.Text=UserId.ToString();    
        }
        private void FillComboBox()
        {
            List<string> list = BLRole.GetAllRoles();
            if (list.Count == 0)
            {
                return; 
            }
            if (Settings.LoggedInUser.Role.RoleName== "SuperAdmin")
            {
                cmbRole.DataSource = list;
                cmbRole.SelectedIndex = 0;

            }
            else if (Settings.LoggedInUser.Role.RoleName == "Admin")
            {
                cmbRole.DataSource = list.Where(r => r!= "SuperAdmin").ToList();
                cmbRole.SelectedIndex = 0;

            }
            else
            {
                cmbRole.Enabled = false;    
            } 

        }
        private void FillUsersDatilsInForm()
        {
            UserToUpdate = BLUser.FindUserByUserID(_UserID); 
            
            if (UserToUpdate == null)
            {
                MessageBox.Show("User Is Not Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 

            } 

            lbUserID.Text = UserToUpdate.UserID.ToString();
            txtbFirstName.Text = UserToUpdate.Person.FirstName; 
            txtbLastName.Text = UserToUpdate.Person.LastName; 
            txtbPhone.Text = UserToUpdate.Person.Phone; 
            txtbEmail.Text = UserToUpdate.Person.Email; 
            txtbJobTitle.Text = UserToUpdate.Person.JobTitle;  
            rchbAddress.Text = UserToUpdate.Person.Address;
            if (Settings.LoggedInUser.UserID == UserToUpdate.UserID ||Settings.LoggedInUser.Role.RoleID==1)
            {
                txtbPassWord.Text = UserToUpdate.Password;
            }
            else
            {
                txtbPassWord.Text = "PassWordIsHidden";
                txtbPassWord.UseSystemPasswordChar = true;
                txtbPassWord.Enabled = false;   
            }
            txtbUserName.Text = UserToUpdate.UserName;
            
            chkbIsActive.Checked = UserToUpdate.IsActive;
            int Index = cmbRole.FindStringExact(UserToUpdate.Role.RoleName); 
            if (Index >= 0)
            {
                cmbRole.SelectedIndex= Index;

            }

        } 
        private void UpdateUser()
        {
            GPerson tempperson = new GPerson
            {
                PersonID = UserToUpdate.Person.PersonID,
                FirstName = UserToUpdate.Person.FirstName,
                LastName = UserToUpdate.Person.LastName,
                Phone = UserToUpdate.Person.Phone,
                Email = UserToUpdate.Person.Email,
                JobTitle = UserToUpdate.Person.JobTitle,
                Address = UserToUpdate.Person.Address
            };

            UserToUpdate.Person.FirstName=txtbFirstName.Text.Trim();
            UserToUpdate.Person.LastName=txtbLastName.Text.Trim();  
            UserToUpdate.Person.Phone=txtbPhone.Text.Trim();    
            UserToUpdate.Person.Email=txtbEmail.Text.Trim();
            UserToUpdate.Person.JobTitle=txtbJobTitle.Text.Trim();  
            UserToUpdate.Person.Address=rchbAddress.Text.Trim();

            bool result =BLPeople.UpdatePerson(UserToUpdate.Person);
            if (!result)
            {
                MessageBox.Show("Error While Updating Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            UserToUpdate.UserName=txtbUserName.Text.Trim();
            if (Settings.LoggedInUser.UserID == UserToUpdate.UserID ||Settings.LoggedInUser.Role.RoleID==1)
            {
                UserToUpdate.Password=txtbPassWord.Text.Trim(); 
            }

            switch (cmbRole.SelectedItem.ToString())
            {
                case "SuperAdmin":
                    UserToUpdate.Role.RoleID=1;
                    break;
                case "Admin": 
                    UserToUpdate.Role.RoleID=2; 
                    break;
                case "Worker":
                    UserToUpdate.Role.RoleID=3; 
                    break;
                default:
                    MessageBox.Show("Error Finding Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    break; 
            }
            if (!chkbIsActive.Checked)
            {
               if( MessageBox.Show("Are you Sure to DeActivate this User ?? He Will Not be Able To Login again .", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    UserToUpdate.IsActive = chkbIsActive.Checked;

                }
                else
                {
                    return;
                }

            }


            bool userUp=BLUser.UpdateUser(UserToUpdate);
            if (userUp)
            {
                MessageBox.Show("Updated SuccessFully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error While Updating User ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BLPeople.UpdatePerson(tempperson);
                return;
            }

        }
       
        private bool _ModeIsAddNew=true;
        private int _UserID = 0;
        private GUser UserToUpdate = null; 

        public frmAddUpdateUser(int UserID) 
        {
            InitializeComponent();
            FillComboBox(); 
            _UserID = UserID;    
            if(_UserID > 0)
            {
                _ModeIsAddNew=false;
                FillUsersDatilsInForm();
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsThereNullValues())
            {
                MessageBox.Show("You Should Fill All Fields In The form .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
           
            if (!IsPhoneNumberValid(txtbPhone.Text))
            {
                MessageBox.Show("Phone Number is Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (_ModeIsAddNew)
            {
                AddNewUser();

            }
            else
            {
                UpdateUser();
            } 






        } 





    }
}
