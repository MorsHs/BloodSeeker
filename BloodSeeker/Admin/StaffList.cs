﻿using BloodSeeker.Admin.Controllers;
using BloodSeeker.Components.Client_Information;
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
    public partial class StaffList : Form
    {
        ClientStaffInformationTab tab;
        StaffListController controller;
        public StaffList()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_Load(object sender, EventArgs e)
        {
            controller = new StaffListController();
            for (int i = 0; i < controller.getStaffLength(); i++)
            {
                tab = new ClientStaffInformationTab(
                    controller.getStaffList()[i].firstname,
                    controller.getStaffList()[i].lastname,
                    controller.getStaffList()[i].sex,
                    controller.getStaffList()[i].phone,
                    controller.getStaffList()[i].email,
                    controller.getStaffList()[i].address,
                    controller.getStaffList()[i].birthdate
                    );
                tab.BackColor = Color.FromArgb(36, 36, 36);
                flowLayoutPanel1.Controls.Add(tab);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            changePanel(new AddStaff());
        }
        public void changePanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Controls.Clear();
            guna2CustomGradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
