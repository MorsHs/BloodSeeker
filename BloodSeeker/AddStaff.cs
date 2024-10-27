using BloodSeeker.Admin.Controllers;
using Guna.UI2.AnimatorNS;
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

namespace BloodSeeker
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        public String checkboxChecker()
        {
            if (malecmbx.Checked) return "Male";
            else return "Female";
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                       AddStaffController addstaff = new AddStaffController(txt_username.Text.ToString(),
                                                                  txt_firstname.Text.ToString(),
                                                                  txt_lastname.Text.ToString(),
                                                                  txt_pass.Text.ToString(),
                                                                  txt_email.Text.ToString(),
                                                                  txt_contact.Text.ToString(),
                                                                  txt_address.Text.ToString(),
                                                                  pickerDate.Value.Date,
                                                                  checkboxChecker()
                                                                  );
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

        private void malecmbx_CheckedChanged(object sender, EventArgs e)
        {
            if (malecmbx.Checked) {
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

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                txt_confirmpass.PasswordChar = '\0';
            }
            else
            {
                txt_confirmpass.PasswordChar = '*';
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
