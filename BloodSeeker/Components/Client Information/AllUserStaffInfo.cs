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
    public partial class AllUserStaffInfo : Form
    {
        private string _firstname { get; set; }
        private string _lastname { get; set; }
        private string _sex { get; set; }
        private string _phone { get; set;  }
        private string _email { get; set; }
        private string _address { get; set; }
        private DateTime _birthday { get; set; }

        public AllUserStaffInfo()
        {
            InitializeComponent();
        }
        public AllUserStaffInfo(string firstname,string lastname,string sex,string phone,string email,string address,DateTime birthdate)
        {
            InitializeComponent();
            _firstname = firstname;
            _lastname = lastname;
            _sex = sex;
            _phone = phone;
            _email = email;
            _address = address;
            _birthday = birthdate;
            setAllCreds();
        }
        private void setAllCreds()
        {
            txt_firstname.Text = _firstname;
            txt_lastname.Text = _lastname;
            txt_sex.Text = _sex;
            txt_phone.Text = _phone;
            txt_email.Text = _email;
            txt_address.Text = _address;
            txt_birthdate.Text = _birthday.Date.ToString("MM/dd/yyyy");
        }

        private void AllUserStaffInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
