﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Components.Client_Information
{
    public partial class ClientStaffInformationTab : UserControl
    {
        private String _firstname;
        private string _lastname;
        private String _sex;
        private String _email;
        private String _phone;
        private String _address;    
        private DateTime _birthday;
        private string photo;
        public ClientStaffInformationTab(String firstname,string lastname,string sex,string phone,string email,string address,DateTime birthDate, string photo)
        {
            InitializeComponent();
            _firstname = firstname;
            _lastname = lastname;
            _sex = sex;
            _email = email;
            _phone = phone;
            _address = address;
            _birthday = birthDate;
            this.photo = photo;
            convertImage();
            setClientInformationTab();
        }
        public void setClientInformationTab()
        {
            clientnamelbl.Text = _firstname+" "+_lastname;
            clientsexlbl.Text = _sex;
            clientemaillbl.Text = _email;
            clientphonelbl.Text = _phone;
        }

        public void convertImage()
        {
            try
            {
                byte[] base_64_image = Convert.FromBase64String(photo);
                using (MemoryStream ms = new MemoryStream())
                {
                    avatar.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex) {
                //Image is null
                 
            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (AllUserStaffInfo uu = new AllUserStaffInfo(_firstname,_lastname,_sex,_phone,_email,_address,_birthday))
                {
                    background.StartPosition = FormStartPosition.CenterScreen;
                    background.FormBorderStyle = FormBorderStyle.None;
                    background.Opacity = .70d;
                    background.BackColor = Color.Black;
                    background.WindowState = FormWindowState.Maximized;
                    background.Location = this.Location;
                    background.ShowInTaskbar = false;
                    background.Show();

                    uu.Owner = background;
                    uu.ShowDialog();
                    background.Dispose();

                }
            }
            catch(Exception ex) {
            MessageBox.Show(ex.Message);
            }
            finally
            {
                background.Dispose();
            }
            
        }
    }
}
