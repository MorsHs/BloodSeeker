using BloodSeeker.Model;
using System.Windows.Forms;
using System;

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

            // Attempt to verify user and 
            int? clientID = controller.verifyUser(txt_name.Text.ToString(), txt_pass.Text.ToString());

            if (clientID != null)
            {
                // Pass the to the ClientDashboard constructor
                ClientDashboard dash = new ClientDashboard(clientID.Value);
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