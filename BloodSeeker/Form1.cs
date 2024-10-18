using BloodSeeker.Admin;
using BloodSeeker.Client;
using Guna.UI2.AnimatorNS;
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
    public partial class Form1 : Form
    {
        AdminLogin adminlog = new AdminLogin();
        ClienntLogin clientlog = new ClienntLogin();
        SignupController controller;
        Global globe;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
           controller = new SignupController(txt_lastname.Text.ToString(),txt_firstname.Text.ToString(),txt_contact.Text.ToString(),
               txt_email.Text.ToString(),txt_pass.Text.ToString(),txt_confirmpass.Text.ToString());
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmb_option.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            globe = new Global();
            globe.fncConnectToDatabase();
            cmb_option.Hide();
        }

        private void cmb_option_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if(cmb_option.Text == "Admin")
            {
                adminlog.Show();
                this.Hide();
            }
            else if(cmb_option.Text == "Client")
            {
                clientlog.Show();
                this.Hide();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
