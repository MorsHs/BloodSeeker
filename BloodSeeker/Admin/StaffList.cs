using BloodSeeker.Components.Client_Information;
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
    public partial class StaffList : Form
    {
        ClientStaffInformationTab tab;
        public StaffList()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                tab = new ClientStaffInformationTab("Kent Salarda","Male","kentsalarda@gmail.com","09452113248");
                tab.BackColor = Color.FromArgb(36,36,36);
                flowLayoutPanel1.Controls.Add(tab);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            changePanel(new AddStaff());
        }
        public void changePanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Controls.Clear();
            guna2CustomGradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
