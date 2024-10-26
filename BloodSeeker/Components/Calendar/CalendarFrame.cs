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
        private int currentYear;
        private int currentMonth;
        private static FlowLayoutPanel _flowLayoutPanel;
        public event EventHandler<AppointmentEventArgs> AppointmentRequested;

        public CalendarFrame(FlowLayoutPanel flowpanel)
        {
            InitializeComponent();
            _flowLayoutPanel = flowpanel;
            currentMonth = DateTime.Now.Month;
            currentYear = DateTime.Now.Year;
            
            Button prevMonth = new Button
            {
                Text = "<",
                Size = new Size(30, 30),
                Location = new Point(10, 10),
                BackColor = Color.FromArgb(120, 0, 0),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            Button nextMonth = new Button
            {
                Text = ">",
                Size = new Size(30, 30),
                Location = new Point(monthlbl.Right + 120, 10),
                BackColor = Color.FromArgb(120, 0, 0),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            prevMonth.Click += (s, e) => NavigateMonth(-1);
            nextMonth.Click += (s, e) => NavigateMonth(1);

            Controls.Add(prevMonth);
            Controls.Add(nextMonth);

            UpdateCalendar();
        }

        private void NavigateMonth(int offset)
        {
            currentMonth += offset;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            else if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            UpdateCalendar();
        }

        private void UpdateCalendar()
        {
            flowLayoutPanel1.Controls.Clear();
            //_flowLayoutPanel.Controls.Clear();

            monthlbl.Text = new DateTimeFormatInfo().GetMonthName(currentMonth) + " " + currentYear.ToString();

            DateTime startOfMonth = new DateTime(currentYear, currentMonth, 1);
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int firstDayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

           
            for (int i = 1; i < firstDayOfWeek; i++)
            {
                CalendarButton emptyButton = new CalendarButton("");
                flowLayoutPanel1.Controls.Add(emptyButton);
            }

            
            for (int i = 1; i <= daysInMonth; i++)
            {
                CalendarButton dayButton = new CalendarButton(i.ToString());
                dayButton.DaySelected += OnDaySelected;
                flowLayoutPanel1.Controls.Add(dayButton);
            }

           
            //for (int i = 0; i < 10; i++)
            //{
                //Appointment appointment = new Appointment();
                //_flowLayoutPanel.Controls.Add(appointment);
            //}
        }

        private void OnDaySelected(object sender, DaySelectedEventArgs e)
        {
            var selectedDate = new DateTime(currentYear, currentMonth, int.Parse(e.Day));
            AppointmentRequested?.Invoke(this, new AppointmentEventArgs(selectedDate));
        }
    }

    
    public class AppointmentEventArgs : EventArgs
    {
        public DateTime SelectedDate { get; }
        public AppointmentEventArgs(DateTime selectedDate)
        {
            SelectedDate = selectedDate;
        }
    }

    public class DaySelectedEventArgs : EventArgs
    {
        public string Day { get; }
        public DaySelectedEventArgs(string day)
        {
            Day = day;
        }
    }
}
