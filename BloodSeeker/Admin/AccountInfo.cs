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
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
            this.adminId = adminId;  
            someProcedure = new SomeProcedure();
        }

        private int adminId; 
        private string photopath;  
        private SomeProcedure someProcedure;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Show();
            btn_cancel.Show();
        }

        private void btn_cancel_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btn_Submit.Hide();
            btn_cancel.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txt_username.Enabled = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txt_firstname.Enabled = true;
        }

        private void btn_editUsername_Click(object sender, EventArgs e)
        {
            txt_username.Enabled = true;
        }

        private void btn_editLN_Click(object sender, EventArgs e)
        {
            txt_lastname.Enabled = true;
        }

        private void btn_editAddress_Click(object sender, EventArgs e)
        {
            txt_address.Enabled = true;
        }

        private void btn_editCN_Click(object sender, EventArgs e)
        {
            txt_contactNo.Enabled = true;
        }

        private void btn_editEA_Click(object sender, EventArgs e)
        {
            txt_email.Enabled = true;
        }
        private void showButton()
        {
            btn_cancel.Show();
            btn_Submit.Show();
        }

        private void txt_username_TextChanged_1(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_contactNo_TextChanged(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            showButton();
        }

        
    

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            btn_cancel.Hide();
            btn_Submit.Hide();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            int adminId = 1; 

            string result = new SomeProcedure().UpdateAdminInfo(
                adminId,
                txt_firstname.Text.Trim(),
                txt_lastname.Text.Trim(),
                txt_address.Text.Trim(),
                txt_contactNo.Text.Trim(),
                txt_email.Text.Trim(),
                txt_username.Text.Trim(),
                photopath 
            );

            MessageBox.Show(result);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_Submit.Hide();
            btn_cancel.Hide();
            ResetFields();
        }
        private void ResetFields()
        {
         
            txt_username.Clear();
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_address.Clear();
            txt_contactNo.Clear();
            txt_email.Clear();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Select Photo",
                    FileName = ""
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    img_pfp.Image = Image.FromFile(openFileDialog1.FileName);
                    photopath = openFileDialog1.FileName;
                }
            }

            catch (Exception ex)
            {

            }
        }
    }
}
