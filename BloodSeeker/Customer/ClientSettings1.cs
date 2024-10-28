using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BloodSeeker.Client
{
    public partial class ClientSettings1 : Form
    {
        private readonly string connectionString = "Server=127.0.0.1;Database=bloodbank;Uid=root;Pwd=Jonald12345;";
        private string photopath;
        private int currentClientId; // To store the current client's ID

        public ClientSettings1()
        {
            InitializeComponent();
            this.Load += ClientSettings1_Load;
        }

        private void ClientSettings1_Load(object sender, EventArgs e)
        {
            btn_cancel.Hide();
            btn_Submit.Hide();
            DisableAllTextBoxes();
            LoadClientInfo();
        }

        private void DisableAllTextBoxes()
        {
            txt_username.Enabled = false;
            txt_firstname.Enabled = false;
            txt_lastname.Enabled = false;
            txt_address.Enabled = false;
            txt_contactNo.Enabled = false;
            txt_email.Enabled = false;
        }

        private void LoadClientInfo()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("GetClientsInfo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentClientId = Convert.ToInt32(reader["client_id"]);
                                txt_username.Text = reader["username"].ToString();
                                txt_firstname.Text = reader["first_name"].ToString();
                                txt_lastname.Text = reader["last_name"].ToString();
                                txt_address.Text = reader["address"].ToString();
                                txt_contactNo.Text = reader["mobileNum"].ToString();
                                txt_email.Text = reader["emailAdd"].ToString();

                                // Load photo if exists
                                if (reader["photo"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["photo"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        img_pfp.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading client information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("UpdateClientInfo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@p_client_id", currentClientId);
                        cmd.Parameters.AddWithValue("@p_username", txt_username.Text);
                        cmd.Parameters.AddWithValue("@p_first_name", txt_firstname.Text);
                        cmd.Parameters.AddWithValue("@p_last_name", txt_lastname.Text);
                        cmd.Parameters.AddWithValue("@p_address", txt_address.Text);
                        cmd.Parameters.AddWithValue("@p_mobile_num", txt_contactNo.Text);
                        cmd.Parameters.AddWithValue("@p_email", txt_email.Text);

                        // Handle photo upload
                        if (!string.IsNullOrEmpty(photopath))
                        {
                            byte[] imageData = File.ReadAllBytes(photopath);
                            cmd.Parameters.AddWithValue("@p_photo", imageData);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@p_photo", DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset UI state
                        DisableAllTextBoxes();
                        btn_Submit.Hide();
                        btn_cancel.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // Reset the form
            LoadClientInfo();
            DisableAllTextBoxes();
            btn_Submit.Hide();
            btn_cancel.Hide();
        }

        // Your existing event handlers
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

        private void showButton()
        {
            btn_cancel.Show();
            btn_Submit.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    openFileDialog1.Title = "Select Photo";
                    openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog1.FileName = "";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        img_pfp.Image = Image.FromFile(openFileDialog1.FileName);
                        photopath = openFileDialog1.FileName;
                        showButton();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
