using Bussiness;
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
using System.Data.SqlClient;

namespace ModernResturantSystem.Forms
{
    public partial class frmServer : Form
    {

        private bool TestConnectionString(ref string initialstring)
        {
            if (rbSql.Checked)
            {
              initialstring= $@"Server={txtServer.Text.Trim()};
                                Database={txtDataBase.Text.Trim()};
                                Integrated security=false;
                                User Id= {txtUserName.Text.Trim()};
                                Password ={txtPassWord.Text.Trim()};";
            }
            else
            {
                initialstring= $@"Server={txtServer.Text.Trim()};
                                  Database={txtDataBase.Text.Trim()};
                                  Integrated security=true";
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(initialstring))
                {
                    connection.Open();
                }
                return true; 
            }catch (Exception ex)
            {
                Logger.Log(ex.Message); 
                return false;   
            }
           


        }
        public frmServer()
        {
            InitializeComponent(); 
            //عرض بيانات الاتصال عند البدء
            txtServer.Text =Properties.Settings.Default.Server;
            txtDataBase.Text = Properties.Settings.Default.DataBase;
            
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbSql.Checked = true; 
                txtUserName.Text = Properties.Settings.Default.UserID;

                txtPassWord.Text = Properties.Settings.Default.PassWord;
            }
            else
            {
                rbWindows.Checked = true;
                txtUserName.Enabled = false; 
                txtPassWord.Enabled = false;   
                
            }
        }

        //منطقة النسخ الاحتياطي لقاعدة البيانات 
        private void btnPath_Click(object sender, EventArgs e)
        {

            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtbPath.Text=folderBrowserDialog1.SelectedPath;
            }
        }

        private  async void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbPath.Text))
            {
                MessageBox.Show("Please Choose Folder Fisrt", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            btnBackup.Enabled = false;
            pbgif.Visible = true; 
            string FileName = $@"{txtbPath.Text}\FastFoodsDataCopy_{DateTime.Now.ToShortDateString().Replace('/','-')}_{DateTime.Now.ToLongTimeString().Replace(':','-')}.bak";  


            bool result= await Task.Run(() =>
            {
                return BLDbBackup.MakeAcopyFromDB(FileName);
            });

            btnBackup.Enabled = true ;
            pbgif.Visible = false;
            if (result)
            {
                MessageBox.Show("BackUp Made SuccessFulley", "SuccessFullOperation", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }
            else
            {
                MessageBox.Show("Error Making Data Copy", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }



        //منطقة استرجاع نسخة احتياطية 
        private void btnChooseFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd=new OpenFileDialog(); 
            if(fd.ShowDialog() == DialogResult.OK)
            {
               txtbFilePath.Text = fd.FileName;
            }
        }

        private async void btnRestoreDataBase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbFilePath.Text))
            {
                MessageBox.Show("Please Choose DataBase To Restore ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            btnRestoreDataBase.Enabled = false;
            pbgif.Visible = true;

            bool result = await Task.Run(() =>
            {
                return BLDbBackup.RestoreDataBaseOldCopy(txtbFilePath.Text);
            }); 

            btnRestoreDataBase.Enabled = true ;
            pbgif.Visible = false;  

            if (result)
            {
                MessageBox.Show("Restored SuccessFully ", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed To Restore DataBase", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        //زر الاغلاق 
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        //منطقة الاتصال بالسيرفير 
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string newconnetionString = "";
            pbgif.Visible = true;
            btnSave.Enabled = false;
            bool testreuslt = false;

            await Task.Run(() =>
            {
                testreuslt = TestConnectionString(ref newconnetionString);
            });

            btnSave.Enabled = true; 
            pbgif.Visible = false; 

            if (testreuslt)
            {
                pbgif.Visible = false; 
                Settings.Connectionstring = newconnetionString;
                Properties.Settings.Default.Server = txtServer.Text.Trim();
                Properties.Settings.Default.DataBase = txtDataBase.Text.Trim();
                //تعديل اليوزر والباسورد فقط اذا كان المود المختار هو اس كيو ال سيرفر
                if (rbSql.Checked)
                {
                    Properties.Settings.Default.UserID = txtUserName.Text.Trim();
                    Properties.Settings.Default.PassWord = txtPassWord.Text.Trim();
                }
                Properties.Settings.Default.Mode = rbSql.Checked ? "SQL" : "WINDOWS";
                Properties.Settings.Default.Save(); 
                MessageBox.Show("Saved SuccessFully ","Succeed",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error While Connection With DataBase .Please Enter Valid Values", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 

            }

            

        }

        private void rbSql_CheckedChanged(object sender, EventArgs e)
        {
            txtPassWord.Enabled = rbSql.Checked;
            txtUserName.Enabled = rbSql.Checked;    
        }
    }
}
