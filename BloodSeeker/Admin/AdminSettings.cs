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
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }
        bool menuExpand = false;

        private void button1_Click(object sender, EventArgs e)
        {
            changePanel(new AccountInfo());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void changePanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Clear();
            guna2Panel1.Controls.Add(form);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            //btn_account.BackColor = Color.FromArgb(57, 57, 57);
            btn_acc.FillColor = Color.OrangeRed;
            changePanel(new AccountInfo());
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btn_secu.FillColor = Color.FromArgb(155, 0, 0);
            btn_acc.FillColor = Color.OrangeRed;
            changePanel(new AccountInfo());

        }

        private void btn_secu_Click(object sender, EventArgs e)
        {
            btn_secu.FillColor = Color.OrangeRed;
            btn_acc.FillColor = Color.FromArgb(155, 0, 0);
            changePanel(new changePassAdmin());
        }
    }
}
