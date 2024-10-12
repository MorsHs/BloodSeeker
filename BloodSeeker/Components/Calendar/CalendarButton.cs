using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Components.Calendar
{
    public partial class CalendarButton : UserControl
    {
        private string day;
        public CalendarButton(String day)
        {
            InitializeComponent();
            this.day = day;
            label1.Text = this.day;
            positionMover();
        }
        public void positionMover()
        {
            if (day == "")
            {
                label1.Text = this.day;
            }
            else if (Convert.ToInt32(day) < 10)
            {
                label1.Location = new Point(13, 12);
            }
            else
            {
                label1.Location = new Point(7, 12);
            }
        }
    }
}
