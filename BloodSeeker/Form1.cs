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
    public partial class Form1 : Form
    {
        AdminLogin adminlog = new AdminLogin();
        ClienntLogin clientlog = new ClienntLogin();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {

        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmb_option.Show();
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
