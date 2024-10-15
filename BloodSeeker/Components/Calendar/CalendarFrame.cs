using BloodSeeker.Components.Appointment_Bar;
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

namespace BloodSeeker.Components.Calendar
{
    public partial class CalendarFrame : UserControl
    {
        private static int _year,_month;
        private static FlowLayoutPanel _flowLayoutPanel;
        public CalendarFrame(FlowLayoutPanel flowpanel)
        {
            InitializeComponent();
            _flowLayoutPanel = flowpanel;
            addDay(DateTime.Now.Month, DateTime.Now.Year);
        }
        private void addDay(int month, int year)
        {
            monthlbl.Text = new DateTimeFormatInfo().GetMonthName(month).ToString() + " " + year.ToString();
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;
            DateTime start_of_month = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(start_of_month.DayOfWeek.ToString("d"));
            for (int i = 1; i < week; i++)
            {
                CalendarButton calendarButton = new CalendarButton("");
                flowLayoutPanel1.Controls.Add(calendarButton);

            }
            for (int i = 1; i < day; i++)
            {
                CalendarButton calendarButton = new CalendarButton(i + "");
                flowLayoutPanel1.Controls.Add(calendarButton);
            }

            for (int i = 0; i < 10; i++)
            {
                Appointment appointment = new Appointment();
                _flowLayoutPanel.Controls.Add(appointment);
            }
        }
    }
}
