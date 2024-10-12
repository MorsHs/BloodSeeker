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
        }
    }
}
