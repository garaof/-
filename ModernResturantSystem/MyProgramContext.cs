using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernResturantSystem
{
    public  class MyProgramContext : ApplicationContext
    {

        public MyProgramContext()
        {  
            frmLogin MyLoginFrom= new frmLogin();
            MyLoginFrom.FormClosed += OnLoginFormClosed;
            MyLoginFrom.Show();

        } 


        private void OnLoginFormClosed(object sender, FormClosedEventArgs e)
        {
            if((sender as  frmLogin).DialogResult == DialogResult.OK)
            {
                Form1 frmMain = new Form1();
                frmMain.FormClosed += (s, args) => ExitThread();
                frmMain.Show();
            }
            else
            {
                ExitThread(); 
            }
        }
    }
}
