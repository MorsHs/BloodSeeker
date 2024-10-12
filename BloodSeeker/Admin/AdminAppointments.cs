using BloodSeeker.Components.Calendar;
using Guna.UI2.WinForms;
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
    public partial class AdminAppointments : Form
    {
        private static int _year, _month;
        public AdminAppointments()
        {
            InitializeComponent();
        }

        private void AdminAppointments_Load(object sender, EventArgs e)
        {
            addDay(DateTime.Now.Month,DateTime.Now.Year);
        }
        
        private void addDay(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;
            DateTime start_of_month = new DateTime(year,month,1);
            int day = DateTime.DaysInMonth(year,month);
            int week = Convert.ToInt32(start_of_month.DayOfWeek.ToString("d"));
            for(int i = 1;i < week; i++)
            {
                MessageBox.Show(week+"");
                CalendarButton calendarButton = new CalendarButton("");
                flowLayoutPanel1.Controls.Add(calendarButton);
                
            }
            for (int i = 1; i < day; i++)
            {
                CalendarButton calendarButton = new CalendarButton(i + "");
                flowLayoutPanel1.Controls.Add(calendarButton);
            }
        }
    }
}
