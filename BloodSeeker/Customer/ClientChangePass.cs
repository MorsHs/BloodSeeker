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
    public partial class ClientChangePass : Form
    {

        private int clientId;

        public ClientChangePass()
        {
            InitializeComponent();
        }

        private void chc_currentPass_CheckedChanged(object sender, EventArgs e)
        {
            string passwordholder;
            passwordholder = txt_currentPass.Text.ToString();
            if (chc_currentPass.Checked == true)
            {
                txt_currentPass.PasswordChar = '\0';
            }
            else
            {
                txt_currentPass.PasswordChar = '*';
            }
        }

        private void chc_ConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            string passwordholder;
            passwordholder = txt_confirmPass.Text.ToString();
            if (chc_ConfirmPass.Checked == true)
            {
                txt_confirmPass.PasswordChar = '\0';
            }
            else
            {
                txt_confirmPass.PasswordChar = '*';
            }
        }

        private void chk_newPass_CheckedChanged(object sender, EventArgs e)
        {
            string passwordholder;
            passwordholder = txt_newPass.Text.ToString();
            if (chk_newPass.Checked == true)
            {
                txt_newPass.PasswordChar = '\0';
            }
            else
            {
                txt_newPass.PasswordChar = '*';
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_currentPass.Clear();
            txt_newPass.Clear();
            txt_confirmPass.Clear();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            clientId = 3;
            SomeProcedure someProcedure = new SomeProcedure();

            string currentPassword = txt_currentPass.Text.Trim();
            string newPassword = txt_newPass.Text.Trim();
            string confirmPassword = txt_confirmPass.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultMessage = someProcedure.fncUpdateClientPassword(currentPassword, newPassword, clientId);

            MessageBox.Show(resultMessage, "Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_currentPass.Clear();
            txt_newPass.Clear();
            txt_confirmPass.Clear();
        }
    }
}
