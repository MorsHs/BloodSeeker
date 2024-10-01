using BloodSeeker.Admin;
using BloodSeeker.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker
{
    public partial class SignUpPage : Form
    {
       
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void cmb_option_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminLogin adminlog = new AdminLogin();
            ClienntLogin clientlog = new ClienntLogin();
            if (cmb_option.Text == "Admin")
            {
                adminlog.Show();
                this.Hide();
            }
            else if (cmb_option.Text == "Client")
            {
                clientlog.Show();
                this.Hide();
            }
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            cmb_option.Hide();
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmb_option.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
