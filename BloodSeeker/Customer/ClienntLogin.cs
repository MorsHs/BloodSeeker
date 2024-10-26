using BloodSeeker.Model;
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
    public partial class ClienntLogin : Form
    {
       
        public ClienntLogin()
        {
            InitializeComponent();
      

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
 
            this.Hide();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            ClientLoginController controller = new ClientLoginController();
            if (controller.verifyUser(txt_name.Text.ToString(),txt_pass.Text.ToString()) == true)
            {
                ClientDashboard dash = new ClientDashboard();
                dash.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("User doesn't exist");
            }
        }

        private void chk_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showpass.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }
    }
}
