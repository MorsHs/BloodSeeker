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
    public partial class ClientSettingsPanel : Form
    {
        private int clientId;
        public ClientSettingsPanel(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }
        bool menuExpand = false;

        public void changePanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Clear();
            guna2Panel1.Controls.Add(form);
            form.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btn_secu.FillColor = Color.FromArgb(155, 0, 0);
            btn_acc.FillColor = Color.OrangeRed;
            changePanel(new ClientSettings1(clientId));

        }

        private void ClientSettingsPanel_Load_1(object sender, EventArgs e)
        {
            btn_acc.FillColor = Color.OrangeRed;
            changePanel(new ClientSettings1(clientId));
        }

        private void btn_secu_Click_1(object sender, EventArgs e)
        {
            btn_secu.FillColor = Color.OrangeRed;
            btn_acc.FillColor = Color.FromArgb(155, 0, 0);
            changePanel(new ClientChangePass(clientId));

        }

        private void btn_acc_Click(object sender, EventArgs e)
        {
            btn_secu.FillColor = Color.FromArgb(155, 0, 0);
            btn_acc.FillColor = Color.OrangeRed;
            changePanel(new ClientSettings1(clientId));
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
