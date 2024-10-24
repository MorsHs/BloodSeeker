using BloodSeeker.Admin.Controllers;
using BloodSeeker.Components.Client_Information;
using BloodSeeker.Controllers.Admin;
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

namespace BloodSeeker.Admin
{
    public partial class ClientInfo : Form
    {
        ClientStaffInformationTab tab;
        ClientListController controller;
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
           
            controller = new ClientListController();
            for (int i = 0; i < controller.getClientLength(); i++)
            {
                tab = new ClientStaffInformationTab(
                    controller.getClientList()[i].firstname + " " + controller.getClientList()[i].lastname,
                    controller.getClientList()[i].sex,
                    controller.getClientList()[i].email,
                    controller.getClientList()[i].phone
                    );
                tab.BackColor = Color.FromArgb(36, 36, 36);
                flowLayoutPanel1.Controls.Add(tab);
            }
        }
        public void LoadClientInfo(FlowLayoutPanel panel)
        {
       
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
