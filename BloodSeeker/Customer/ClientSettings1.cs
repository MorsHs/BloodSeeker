﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Client
{
    
    public partial class ClientSettings1 : Form
    {
        private int clientId; 
        private string photopath;  
        private SomeProcedure someProcedure;
        public ClientSettings1(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            someProcedure = new SomeProcedure();
            btn_Submit.Hide();
            btn_cancel.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            btn_cancel.Show();
            btn_Submit.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txt_username.Enabled = true;
        }

        private void showButton()
        {
            btn_cancel.Show();
            btn_Submit.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txt_firstname.Enabled = true;
        }

        private void btn_editUsername_Click_1(object sender, EventArgs e)
        {
            txt_username.Enabled = true;
            showButton();
        }

        private void btn_editFN_Click(object sender, EventArgs e)
        {
            txt_firstname.Enabled = true;
            showButton();

        }

        private void btn_editLN_Click_1(object sender, EventArgs e)
        {
            txt_lastname.Enabled = true;
            showButton();

        }

        private void btn_editAddress_Click_1(object sender, EventArgs e)
        {
            txt_address.Enabled = true;
            showButton();

        }

        private void btn_editCN_Click_1(object sender, EventArgs e)
        {
            txt_contactNo.Enabled = true;
            showButton();

        }

        private void btn_editEA_Click_1(object sender, EventArgs e)
        {
            txt_email.Enabled = true;
            showButton();

        }


        private void txt_username_TextChanged_1(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_firstname_TextChanged_1(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_lastname_TextChanged_1(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_address_TextChanged_1(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_contactNo_TextChanged_1(object sender, EventArgs e)
        {
            showButton();
        }

        private void txt_email_TextChanged_1(object sender, EventArgs e)
        {
            showButton();
        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
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
        private void ResetFields()
        {

            txt_username.Enabled = false;
            txt_firstname.Enabled = false;
            txt_lastname.Enabled = false;
            txt_address.Enabled = false;
            txt_contactNo.Enabled = false;
            txt_email.Enabled = false;
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            

            string result = new SomeProcedure().UpdateClientInfo(
                clientId,
                txt_firstname.Text.Trim(),
                txt_lastname.Text.Trim(),
                txt_address.Text.Trim(),
                txt_contactNo.Text.Trim(),
                txt_email.Text.Trim(),
                txt_username.Text.Trim(),
                cmb_bloodGroup.Text.Trim(),
                photopath
            );

            MessageBox.Show(result);
            ResetFields();
        }
        private void LoadClientInfo()
        {
       
            DataTable ClientInfo = someProcedure.GetClientInfo(clientId);
            if (ClientInfo != null && ClientInfo.Rows.Count > 0)
            {
                
                txt_firstname.Text = ClientInfo.Rows[0]["first_name"].ToString();
                txt_lastname.Text = ClientInfo.Rows[0]["last_name"].ToString();
                txt_address.Text = ClientInfo.Rows[0]["address"].ToString();
                txt_contactNo.Text = ClientInfo.Rows[0]["mobileNum"].ToString();
                txt_email.Text = ClientInfo.Rows[0]["emailAdd"].ToString();
                txt_username.Text = ClientInfo.Rows[0]["username"].ToString();
                cmb_bloodGroup.Text = ClientInfo.Rows[0]["bloodGroup"].ToString();
                string photoPath = ClientInfo.Rows[0]["photo"].ToString();
                if (!string.IsNullOrEmpty(photoPath))
                {
                    img_pfp.Image = Image.FromFile(photoPath);
                    photopath = photoPath;
                }
            }
            else
            {
                MessageBox.Show("No client information found.");
            }
        }
       

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_Submit.Hide();
            btn_cancel.Hide();
            ResetFields();
        }

        private void ClientSettings1_Load(object sender, EventArgs e)
        {
            
            LoadClientInfo();
            btn_Submit.Hide();
            btn_cancel.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
