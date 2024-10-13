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
        public ClientDashboard()
        {
            InitializeComponent();
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
            changePanel(new ClienntLogin());
        }
    }
}
