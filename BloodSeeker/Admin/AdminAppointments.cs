using BloodSeeker.Components.Calendar;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodSeeker.Components.Appointment_Bar;
namespace BloodSeeker.Admin
{
    public partial class AdminAppointments : Form
    {
        private static int _year, _month;
        public AdminAppointments()
        {
            InitializeComponent();
           
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminAppointments_Load(object sender, EventArgs e)
        {
            CalendarFrame calendarFrame = new CalendarFrame(flowPanel2);
            splitContainer1.Panel1.Controls.Add(calendarFrame);
          
        }

        
      
    }
}
