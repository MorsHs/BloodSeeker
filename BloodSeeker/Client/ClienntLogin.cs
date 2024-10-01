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
        SignUpPage signUp = new SignUpPage();
       
        public ClienntLogin()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            signUp.Show();
            this.Hide();
        }
    }
}
