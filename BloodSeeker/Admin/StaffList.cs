﻿using BloodSeeker.Components.Client_Information;
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
        public StaffList()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                tab = new ClientStaffInformationTab("Kent Salarda","Male","kentsalarda@gmail.com","09452113248");
                flowLayoutPanel1.Controls.Add(tab);
            }
        }
    }
}