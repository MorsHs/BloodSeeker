using BloodSeeker.Admin;
using System;
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
    public partial class ClientDashboard : Form
    {
        private int donorID; // Assuming you have this value stored

        public ClientDashboard(int loggedInDonorID)
        {
            InitializeComponent();
            donorID = loggedInDonorID;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }
        public void changePanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2Panel3.Controls.Clear();
            guna2Panel3.Controls.Add(form);
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            changePanel(new Dashboard());
            btnHome.FillColor = Color.FromArgb(20, 132, 205);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            changePanel(new ClientAppointment(donorID)); // Pass the donorID here
            btn_appointment.FillColor = Color.FromArgb(20, 132, 205);
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            changePanel(new ClientInformation());
            btn_info.FillColor = Color.FromArgb(20, 132, 205);
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            changePanel(new ClientHistory1());
            btn_history.FillColor = Color.FromArgb(20, 132, 205);
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            changePanel(new ClientInventory1());
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            changePanel(new ClientSettingsPanel());
            btn_settings.FillColor = Color.FromArgb(20, 132, 205);
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(20, 132, 205);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            pnl_home.Hide();
            pnl_appointment.Hide();
            pnl_clientInfo.Hide();
            pnl_history.Hide();
            pnl_settings.Hide();
            pnl_logout.Hide();
            changePanel(new Dashboard());
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            pnl_home.Show();
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            pnl_home.Hide();
        }

        private void btn_appointment_MouseHover(object sender, EventArgs e)
        {
            pnl_appointment.Show();
        }

        private void btn_appointment_MouseLeave(object sender, EventArgs e)
        {
            pnl_appointment.Hide();
        }

        private void btn_info_MouseHover(object sender, EventArgs e)
        {
            pnl_clientInfo.Show();
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

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}