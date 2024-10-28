using BloodSeeker.Admin.Controllers;
using BloodSeeker.Class;
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
                    controller.getClientList()[i].firstname,
                    controller.getClientList()[i].lastname,
                    controller.getClientList()[i].sex,
                    controller.getClientList()[i].phone,
                    controller.getClientList()[i].email,
                    controller.getClientList()[i].address,
                    controller.getClientList()[i].birthdate,
                    controller.getClientList()[i].photo
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

        private void tb_searchClient_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_searchClient.Text.Trim();
            List<Person> searchResults = new List<Person>();

            if (string.IsNullOrEmpty(searchText))
            {
                flowLayoutPanel1.Controls.Clear();

                var allClients = controller.getClientList();
                foreach (var client in allClients)
                {
                    var tab = new ClientStaffInformationTab(
                        client.firstname,
                        client.lastname,
                        client.sex,
                        client.phone,
                        client.email,
                        client.address,
                        client.birthdate,
                        client.photo
                    );
                    tab.BackColor = Color.FromArgb(36, 36, 36);
                    flowLayoutPanel1.Controls.Add(tab);
                }
                return;
            }

            if (int.TryParse(searchText, out int clientId))
            {
                searchResults = controller.searchClientById(clientId);
            }
            else
            {
                var nameParts = searchText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (nameParts.Length == 1)
                {
                    searchResults.AddRange(controller.searchClientByFirstName(nameParts[0]));
                    searchResults.AddRange(controller.searchClientByLastName(nameParts[0]));
                }
                else
                {
                    searchResults.AddRange(controller.searchClientByFirstName(nameParts[0]));

                    if (nameParts.Length > 1)
                    {
                        searchResults.AddRange(controller.searchClientByLastName(nameParts[1]));
                    }
                }
            }

            searchResults = searchResults.Distinct().ToList();

            flowLayoutPanel1.Controls.Clear();
            foreach (var client in searchResults)
            {
                var tab = new ClientStaffInformationTab(
                    client.firstname,
                    client.lastname,
                    client.sex,
                    client.phone,
                    client.email,
                    client.address,
                    client.birthdate,
                    client.photo
                );
                tab.BackColor = Color.FromArgb(36, 36, 36);
                flowLayoutPanel1.Controls.Add(tab);
            }
        }
    }
}
