using BloodSeeker.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Controllers.Admin
{
    internal class AdminLogController
    {
        private AdminLoginRep adminLogin;

        public AdminLogController()
        {
            adminLogin = new AdminLoginRep();
        }

        public bool Login(string username, string password)
        {

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty.");
                return false;
            }

            bool isValid = adminLogin.ValidateAdmin(username, password);
            if (isValid)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                return false;
            }
        }
    }
}