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
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Show();
            btn_cancel.Show();
        }

        private void btn_cancel_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btn_Submit.Hide();
            btn_cancel.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txt_username.Enabled = true;
        }
    }
}
