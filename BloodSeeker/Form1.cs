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
        SignUpController controller;

        public Form1()
        {
            InitializeComponent();
        }

        public String checkboxChecker()
        {
            if (malecmbx.Checked) return "Male";
            else return "Female";
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            //Evil IF Nesting incoming
            if (txt_pass.Text.ToString() == txt_confirmpass.Text.ToString())
            {
                if (txt_firstname.Text != "" &&
                    txt_lastname.Text != "" &&
                    txt_username.Text != "" &&
                    txt_pass.Text != "" &&
                    txt_confirmpass.Text != "" &&
                    txt_email.Text != "" &&
                    txt_address.Text != "" &&
                    malecmbx.Checked || femalecmbx.Checked
                    )
                {
                    if (pickerDate.Value.Date <= DateTime.Now.Date)
                    {
                        controller = new SignUpController(txt_firstname.Text.ToString(), txt_lastname.Text.ToString(),
                txt_pass.Text.ToString(), txt_username.Text.ToString(), txt_email.Text.ToString(),
                txt_contact.Text.ToString(), txt_address.Text.ToString(), checkboxChecker(), pickerDate.Value.Date);
                    }
                    else
                    {
                        MessageBox.Show("Today is " + DateTime.Now.Date + " its not possible to put " + pickerDate.Value.Date);
                        pickerDate.Value = DateTime.Now.Date;
                    }

                }
                else MessageBox.Show("Please Fill out the missing forms");
            }
            else
            {
                MessageBox.Show("Password and Confirm Password did not match.");
                txt_confirmpass.Text = txt_pass.Text = "";
            }

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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void malecmbx_CheckedChanged(object sender, EventArgs e)
        {
            if (malecmbx.Checked)
            {
                femalecmbx.Checked = false;
            }
        }

        private void femalecmbx_CheckedChanged(object sender, EventArgs e)
        {
            if (femalecmbx.Checked)
            {
                malecmbx.Checked = false;
            }
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}