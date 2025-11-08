using Bussiness;
using GolobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernResturantSystem
{
    public partial class frmLogin : Form
    {
        //دالتين لوضع القيم الافتراضية داخل التكست بوكس 
        bool IsUserNameDefault = true; 
        bool IsPasswordDefault = true;  
        private string UserPlaceHolder = "User Name";
        private string PassWordPlaceHoder = "PassWord"; 

        private void SetPlaceHoder(TextBox txt ,string PlaceHoder ,bool IsPassWord=false)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.ForeColor = Color.Gray;
                txt.Text = PlaceHoder;

                if (IsPassWord)
                {
                    txt.UseSystemPasswordChar = false; 
                    
                    IsPasswordDefault = true;
                }
                else
                {
                    IsUserNameDefault = true;
                }
            }
        }  

        private void SetConnectionString()
        {
            string newconnetionString = "";
            if (Properties.Settings.Default.Mode == "SQL")
            {
                newconnetionString = $@"Server={Properties.Settings.Default.Server};Database={Properties.Settings.Default.DataBase};Integrated security=false;User Id= {Properties.Settings.Default.UserID};Password ={Properties.Settings.Default.PassWord};";

            }
            else
            {
                newconnetionString = $@"Server={Properties.Settings.Default.Server};Database={Properties.Settings.Default.DataBase};Integrated security=true";
            }
            Settings.Connectionstring = newconnetionString;
        }
        private void RemovePlaceHoder(TextBox txt ,string PlaceHoder,bool IsPassWord = false)
        {
            if (txt.Text==PlaceHoder)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
                 if(IsPassWord)
                {
                    txt.UseSystemPasswordChar = true; 
                    IsPasswordDefault = false;   
                }
                else
                {
                    IsUserNameDefault = false;  
                } 
            }
        }




        public frmLogin()
        {
            InitializeComponent();
            //تمرير نص الاتصال الي طبقة الجلوبال لجلب البيانات 
            SetConnectionString();
            SetPlaceHoder(txtbUserName, UserPlaceHolder, false);
            SetPlaceHoder(txtPassWord, PassWordPlaceHoder, true);
        }

        private void txtbUserName_Enter(object sender, EventArgs e)
        {
            RemovePlaceHoder(txtbUserName, UserPlaceHolder, false); 
        }

        private void txtbUserName_Leave(object sender, EventArgs e)
        {
            SetPlaceHoder(txtbUserName, UserPlaceHolder, false); 
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            RemovePlaceHoder(txtPassWord, PassWordPlaceHoder, true);
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            SetPlaceHoder(txtPassWord, PassWordPlaceHoder, true); 
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;  
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        { 
            //التأكد من أن صناديق النص ليست فارغة ولا تحتوي القيم الافتراضية 
            if( IsPasswordDefault || IsUserNameDefault || string.IsNullOrEmpty(txtbUserName.Text)  || string.IsNullOrEmpty(txtPassWord.Text))
            {
                MessageBox.Show("Wether User Name Or Password Should not be Empty Value.Please Enter Valid Values.", "Wrong UserName Or Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(txtbUserName.Text.Trim()=="Admin" && txtPassWord.Text.Trim() == "Admin")
            {
                this.Hide();
                using (Forms.frmServer frm = new Forms.frmServer())
                {
                    frm.ShowDialog();
                    SetConnectionString();


                }
                this.Show();
                return; 
            }
            else
            {
                //التأكد من وجود مستخدم بنفس بيانات الدخول 
                Settings.LoggedInUser = BLUser.GetLoggedInUser(txtbUserName.Text.Trim(), txtPassWord.Text.Trim());
                if (Settings.LoggedInUser == null)
                {
                    MessageBox.Show("Sorry . There is No User With This Credentials .Please ReEnter Your Login Details", "Wrong User Name Or PassWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //التأكد من أن المستخدم نشط فى النظام 
                switch (Settings.LoggedInUser.IsActive)
                {
                    case true:
                        //تسجيل رقم الجلسة لاستخدامه لاحقا لتحديث المعلومات واضافة بيانات الخروج
                        Settings.CurrentSessionID = BLLoginRecords.InsertNewLoginRecord(new ReturantGolobalClasses.GLoginRecords() { LoginDateTime = DateTime.Now, LogoutDateTime = null, SessionDuration = null, UserID = Settings.LoggedInUser.UserID });

                        if (Settings.CurrentSessionID > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error Occured While Starting this Session", "Session Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        break;
                    case false:
                        MessageBox.Show("This User DeActivated By Admin. Please Contact Your Admin", "DeActivated User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show("There is UnKnown Error Occured ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }  



    }
}
