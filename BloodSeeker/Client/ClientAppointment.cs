﻿using BloodSeeker.Components.Calendar;
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
    public partial class ClientAppointment : Form
    {
        public ClientAppointment()
        {
            InitializeComponent();
        }

        private void ClientAppointment_Load(object sender, EventArgs e)
        {
            CalendarFrame calendarFrame = new CalendarFrame(flowPanel2);
            splitContainer1.Panel1.Controls.Add(calendarFrame);
        }
    }
}
