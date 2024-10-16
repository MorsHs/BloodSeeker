using BloodSeeker.Components.Client_Information;
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
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            LoadClientInfo(flowLayoutPanel1);
        }
        public void LoadClientInfo(FlowLayoutPanel panel)
        {
            ClientInformationTab tab;
            tab = new ClientInformationTab("Kent Lawrence Salarda", "Male", "kentsalarda@gail.com", "09452113248");
            panel.Controls.Add(tab);
            tab = new ClientInformationTab("Argie Pardillo", "Male", "argiezie@gail.com", "09452113248");
            panel.Controls.Add(tab);
        }
    }
}
