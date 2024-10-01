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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void guna2CircleButton8_MouseHover(object sender, EventArgs e)
        {
            pnl_clientInfo.Show();
        }

        private void guna2CircleButton1_MouseHover(object sender, EventArgs e)
        {
            pnl_home.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            pnl_home.Hide();
            pnl_Appointmen.Hide();
            pnl_clientInfo.Hide();
            pnl_history.Hide();
            pnl_inventory.Hide();
            pnl_logout.Hide();
            pnl_settings.Hide();
           
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_MouseLeave(object sender, EventArgs e)
        {
            pnl_home.Hide();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_clientInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {

        }

        private void btn_appointment_MouseHover(object sender, EventArgs e)
        {
            pnl_Appointmen.Show();
        }

        private void btn_appointment_MouseLeave(object sender, EventArgs e)
        {
            pnl_Appointmen.Hide();
        }

        private void btn_info_MouseLeave(object sender, EventArgs e)
        {
            pnl_clientInfo.Hide();
        }

        private void btn_history_MouseHover(object sender, EventArgs e)
        {
            pnl_history.Show();
        }

        private void btn_history_MouseLeave(object sender, EventArgs e)
        {
            pnl_history.Hide();
        }

        private void btn_inventory_MouseHover(object sender, EventArgs e)
        {
            pnl_inventory.Show();
        }

        private void btn_inventory_MouseLeave(object sender, EventArgs e)
        {
            pnl_inventory.Hide();
        }

        private void btn_settings_MouseHover(object sender, EventArgs e)
        {
            pnl_settings.Show();
        }

        private void btn_settings_MouseLeave(object sender, EventArgs e)
        {
            pnl_settings.Hide();
        }

        private void btn_logout_MouseHover(object sender, EventArgs e)
        {
            pnl_logout.Show();
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            pnl_logout.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
