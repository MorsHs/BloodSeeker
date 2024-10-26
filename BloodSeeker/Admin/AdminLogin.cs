using BloodSeeker.Controllers.Admin;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Admin
{
    public partial class AdminLogin : Form
    {
        private AdminLogController adminLogController;
       
       
        public AdminLogin()
        {
            InitializeComponent();
            adminLogController = new AdminLogController();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text;
            string password = txt_pass.Text;
           

            bool isLoggedIn = adminLogController.Login(username, password);

            if (isLoggedIn)
            {
                AdminDashboard dash = new AdminDashboard();
                dash.Username = username;
                dash.Show();
                this.Hide();
            }
        }

       

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showpass.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*'; 
            }
        }
    }
}
