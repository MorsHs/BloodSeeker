using BloodSeeker.Controllers.Admin;
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
        AdminDashboard admindash = new AdminDashboard();
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
                admindash.Show();
                this.Hide();
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
