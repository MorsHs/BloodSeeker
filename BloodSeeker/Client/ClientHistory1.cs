using BloodSeeker.Components.Calendar;
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
    public partial class ClientHistory1 : Form
    {
        public ClientHistory1()
        {
            InitializeComponent();
        }

        private void ClientHistory1_Load(object sender, EventArgs e)
        {
            CalendarFrame calendarFrame = new CalendarFrame(flowPanel1);
            flowPanel1.Controls.Add(calendarFrame);
        }
    }
}
