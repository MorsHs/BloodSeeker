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
        private readonly string connectionString = "Server=127.0.0.1;Database=bloodbank;Uid=root;Pwd=Risingup1924;";

        public ClientInformation()
        {
            InitializeComponent();
            this.Load += ClientInformation_Load;
            this.clientId =  clientId;
        }

        private int clientId;


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

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            clientId = 3;

                            if (dt.Rows.Count > 0)
                            {
                                DataRow row = dt.Rows[0];

                                // Update labels with null checking

                                lblDonorId.Text = GetSafeString(row["client_id"]);
                                lblFname.Text = GetSafeString(row["first_name"]);
                                lblLname.Text = GetSafeString(row["last_name"]);
                                lblBirthdate.Text = GetSafeDateTime(row["birthDate"]);
                                lblBloodType.Text = GetSafeString(row["blood_group"]);
                                lblAddress.Text = GetSafeString(row["address"]);
                                lblMobilenum.Text = GetSafeString(row["mobileNum"]);
                                lblSex.Text = GetSafeString(row["sex"]);
                                lblEmail.Text = GetSafeString(row["emailAdd"]);
                            }
                            else
                            {
                                MessageBox.Show("No client information found.");
                                ClearLabels();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading client information: {ex.Message}");
                    ClearLabels();
                }
            }
        }
        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private string GetSafeString(object value)
        {
            return value == DBNull.Value ? "-" : value.ToString();
        }

        private string GetSafeDateTime(object value)
        {
            if (value == DBNull.Value) return "-";
            return DateTime.TryParse(value.ToString(), out DateTime result)
                ? result.ToString("yyyy-MM-dd")
                : "-";
        }

        private void ClearLabels()
        {
            lblDonorId.Text = "-";
            lblFname.Text = "-";
            lblLname.Text = "-";
            lblBirthdate.Text = "-";
            lblBloodType.Text = "-";
            lblAddress.Text = "-";
            lblMobilenum.Text = "-";
            lblSex.Text = "-";
            lblEmail.Text = "-";
        }
    }
}