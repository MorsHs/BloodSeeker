using BloodSeeker.Components.Client_Information;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
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

         public void buttonColor(Guna2CircleButton button)
        {
           List<Control> a =GetAllCircleButton(guna2Panel1);
            for(int i = 0; i < a.Count; i++)
            {
                Guna2CircleButton currentButton = a[i] as Guna2CircleButton;
                if(button == currentButton)
                {
                    currentButton.FillColor = Color.FromArgb(20, 132, 205);
                }
                else
                {
                    currentButton.FillColor = Color.FromArgb(83, 0, 0);
                }
            }
            
        }
        public List<Control> GetAllCircleButton(Guna2Panel panel)
        {
            List<Control>list = new List<Control>();
            foreach(Control button in panel.Controls)
            {
                if(button.GetType() == typeof(Guna2CircleButton))
                {
                    list.Add(button);
                }
               
            }
            return list;
        }
        //USED
        private void guna2CircleButton8_MouseHover(object sender, EventArgs e)
        {
            pnl_clientInfo.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Global globe = new Global();
            globe.fncConnectToDatabase();
            pnl_home.Hide();
            pnl_appointment.Hide();
            pnl_clientInfo.Hide();
            pnl_history.Hide();
            pnl_inventory.Hide();
            pnl_settings.Hide();
            pnl_logout.Hide();
            changePanel(new Dashboard());
        }

        //USED
        private void btn_settings_MouseHover(object sender, EventArgs e)
        {
            pnl_settings.Show();
            buttonColor(btn_settings);
        }

        //USED
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

        //USED
        private void btnAppointment_MouseHover(object sender, EventArgs e)
        {
            pnl_home.Show();
        }

        //USED
        private void btnAppointment_MouseLeave(object sender, EventArgs e)
        {
            pnl_home.Hide();
        }
        //USED
        private void btn_appointment_MouseHover(object sender, EventArgs e)
        {
            pnl_appointment.Show();
        }
        //USED
        private void btn_appointment_MouseLeave(object sender, EventArgs e)
        {
            pnl_appointment.Hide();
        }
        //USED
        private void btn_info_Click(object sender, EventArgs e)
        {
            Guna2CircleButton button = sender as Guna2CircleButton;
            buttonColor(button);
            changePanel(new ClientInfo());
        }

        private void btn_info_MouseHover(object sender, EventArgs e)
        {
            pnl_clientInfo.Show();
        }

        //USED
        private void btn_info_MouseLeave(object sender, EventArgs e)
        {
            pnl_clientInfo.Hide();
        }
        //USED
        private void btn_history_MouseHover(object sender, EventArgs e)
        {
            pnl_history.Show();
        }
        //USED
        private void btn_history_MouseLeave(object sender, EventArgs e)
        {
            pnl_history.Hide();
        }

        //USED
        private void btn_inventory_MouseHover(object sender, EventArgs e)
        {
            pnl_inventory.Show();

        }
        //USED
        private void btn_inventory_MouseLeave(object sender, EventArgs e)
        {
            pnl_inventory.Hide();
        }

       //USED
        private void btnHome_Click(object sender, EventArgs e)
        {
            Guna2CircleButton button = sender as Guna2CircleButton;
            buttonColor(button);
            changePanel(new Dashboard());
           
        }
        //USED
        private void btn_history_Click(object sender, EventArgs e)
        {
          Guna2CircleButton button = sender as Guna2CircleButton;
            buttonColor(button);
            changePanel(new TransacitionHistory());
        }
        //USED
        private void btn_inventory_Click(object sender, EventArgs e)
        {
            Guna2CircleButton button = sender as Guna2CircleButton;
            buttonColor(button);
            changePanel(new Inventory());
        }
        //USED
        private void btn_appointment_Click_1(object sender, EventArgs e)
        {
            Guna2CircleButton button = sender as Guna2CircleButton;
            buttonColor(button);
            changePanel(new AdminAppointments());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
