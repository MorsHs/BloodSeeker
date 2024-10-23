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

namespace BloodSeeker.Components.Client_Information
{
    public partial class ClientStaffInformationTab : UserControl
    {
        private String _name;
        private String _sex;
        private String _email;
        private String _phone;
        public ClientStaffInformationTab(String name,String sex,String email,String phone)
        {
            InitializeComponent();
            _name = name;
            _sex = sex;
            _email = email;
            _phone = phone;
            setClientInformationTab();
        }
        public void setClientInformationTab()
        {
            clientnamelbl.Text = _name;
            clientsexlbl.Text = _sex;
            clientemaillbl.Text = _email;
            clientphonelbl.Text = _phone;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var viewMore = new AdminDashboard();
        }
    }
}
