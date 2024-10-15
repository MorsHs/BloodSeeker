using System;
using System.Drawing;
using System.Windows.Forms;

namespace BloodSeeker.Admin
{
    public partial class AdminDashboard : Form
    {
           
        public AdminDashboard()
        {
            InitializeComponent();
            btnHome.FillColor = Color.FromArgb(20, 132, 205);

        }
        public void changePanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.Show();
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
            pnl_appointment.Hide();
            pnl_clientInfo.Hide();
            pnl_history.Hide();
            pnl_inventory.Hide();
            pnl_settings.Hide();
            pnl_logout.Hide();
            changePanel(new Dashboard());
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            Application.Exit();
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_inventory.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(20, 132, 205);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
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

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAppointment_MouseHover(object sender, EventArgs e)
        {
            pnl_home.Show();
        }

        private void btnAppointment_MouseLeave(object sender, EventArgs e)
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

        private void btn_info_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(20, 132, 205);
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_inventory.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
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

        private void btn_inventory_MouseHover(object sender, EventArgs e)
        {
            pnl_inventory.Show();

        }

        private void btn_inventory_MouseLeave(object sender, EventArgs e)
        {
            pnl_inventory.Hide();
        }

    

        private void btn_appointment_Click(object sender, EventArgs e)
        {          
            btn_appointment.FillColor = Color.FromArgb(20, 132, 205);
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor= Color.FromArgb(83, 0, 0);
            btn_inventory.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btnHome_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_appointment_EnabledChanged(object sender, EventArgs e)
        {
           
        }

       
        private void btnHome_Click(object sender, EventArgs e)
        {
            changePanel(new Dashboard());
            btnHome.FillColor = Color.FromArgb(20, 132, 205);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_inventory.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(20, 132, 205);
            btn_inventory.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_inventory.FillColor = Color.FromArgb(20, 132, 205);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(83, 0, 0);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.FromArgb(83, 0, 0);
            btn_info.FillColor = Color.FromArgb(83, 0, 0);
            btn_history.FillColor = Color.FromArgb(83, 0, 0);
            btn_inventory.FillColor = Color.FromArgb(83, 0, 0);
            btn_logout.FillColor = Color.FromArgb(83, 0, 0);
            btn_settings.FillColor = Color.FromArgb(83, 0, 0);
            btnCreate.FillColor = Color.FromArgb(20, 132, 205);
            btn_aboutme.FillColor = Color.FromArgb(83, 0, 0);
            btn_appointment.FillColor = Color.FromArgb(83, 0, 0);
        }

        private void btn_aboutme_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            changePanel(new Dashboard());
        }

        private void btn_appointment_Click_1(object sender, EventArgs e)
        {
            changePanel(new AdminAppointments());
        }
    }
}
