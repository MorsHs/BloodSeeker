using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BloodSeeker.Client
{
    public partial class ClientInformation : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=bloodbank;Uid=root;Pwd=jonald123456;";

        public ClientInformation()
        {
            InitializeComponent();
            this.Load += ClientInformation_Load;
        }

        private void ClientInformation_Load(object sender, EventArgs e)
        {
            LoadClientInfo();
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
                                lblDonorId.Text = reader["client_id"].ToString();
                                lblFname.Text = reader["first_name"].ToString();
                                lblLname.Text = reader["last_name"].ToString();
                                lblBirthdate.Text = reader["birthDate"].ToString();
                                lblBloodType.Text = reader["blood_group"].ToString();
                                lblAddress.Text = reader["address"].ToString();
                                lblMobilenum.Text = reader["mobileNum"].ToString();
                                lblSex.Text = reader["sex"].ToString();
                                lblEmail.Text = reader["emailAdd"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading client information: " + ex.Message);
                }
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}