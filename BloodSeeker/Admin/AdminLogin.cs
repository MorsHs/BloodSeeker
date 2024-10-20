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
        AdminDashboard admindash = new AdminDashboard();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            admindash.Show();
            this.Hide();
        }
    }
}
