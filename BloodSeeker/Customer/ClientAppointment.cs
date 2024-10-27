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
        private DateTime selectedDate;

        public ClientAppointment()
        {
            InitializeComponent();
        }



        private void ClientAppointment_Load(object sender, EventArgs e)
        {
            CalendarFrame calendarFrame = new CalendarFrame(flowPanel2);
            splitContainer1.Panel1.Controls.Add(calendarFrame);
            calendarFrame.AppointmentRequested += OnAppointmentRequested;
            btn_Submit.Click += btn_Submit_Click;
        }



        private void OnAppointmentRequested(object sender, AppointmentEventArgs e)
        {
            selectedDate = e.SelectedDate;
        }



        private void btn_Submit_Click(object sender, EventArgs e)
        {
            btn_Submit.Enabled = false;

            if (selectedDate != null)
            {
                string appointmentTime = DateTime.Now.ToString("hh:mm tt");
                string appointmentDate = selectedDate.ToString("dddd, MMMM dd yyyy");


                bool duplicate = false;
                foreach (FlowLayoutPanel existingAppointment in flowPanel2.Controls)
                {
                    Label existingTimeLabel = existingAppointment.Controls.OfType<Label>().FirstOrDefault(l => l.Text == appointmentTime);
                    Label existingDateLabel = existingAppointment.Controls.OfType<Label>().FirstOrDefault(l => l.Text == appointmentDate);

                    if (existingTimeLabel != null && existingDateLabel != null)
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (!duplicate)
                {
                    FlowLayoutPanel appointmentEntry = new FlowLayoutPanel();
                    appointmentEntry.AutoSize = true;

                    Label appointmentTimeLabel = new Label();
                    appointmentTimeLabel.Text = appointmentTime;
                    appointmentTimeLabel.Font = new Font("Arial", 12);
                    appointmentTimeLabel.ForeColor = Color.Black;
                    appointmentTimeLabel.AutoSize = true;

                    Label appointmentDetailsLabel = new Label();
                    appointmentDetailsLabel.Text = "Appointment";
                    appointmentDetailsLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                    appointmentDetailsLabel.ForeColor = Color.Black;
                    appointmentDetailsLabel.AutoSize = true;

                    appointmentEntry.Controls.Add(appointmentTimeLabel);
                    appointmentEntry.Controls.Add(appointmentDetailsLabel);
                    appointmentEntry.Controls.Add(new Label() { Text = "at", Font = new Font("Arial", 10) });

                    Label appointmentDateLabel = new Label();
                    appointmentDateLabel.Text = appointmentDate;
                    appointmentDateLabel.Font = new Font("Arial", 12);
                    appointmentDateLabel.ForeColor = Color.Black;
                    appointmentDateLabel.AutoSize = true;
                    appointmentEntry.Controls.Add(appointmentDateLabel);

                    flowPanel2.Controls.Add(appointmentEntry);
                }
                else
                {
                    MessageBox.Show("Appointment Added!.");
                }
            }
            else
            {
                MessageBox.Show("Please select a date for the appointment.");
            }
            btn_Submit.Enabled = true;
        }

    }


}