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
        private Boolean checker;
        public CalendarButton(String day)
        {
            InitializeComponent();
            this.day = day;
            buttonDisabler();
            label1.Text = this.day;
            checkboxProperties();
            positionMover();
        }

        public void buttonDisabler()
        {
            if(day == "")
            {
                panel1.Enabled = false;
                label1.Enabled = false;
                checkboxclicked.Enabled = false;
            }
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
        public void checkboxProperties()
        {
            checkboxclicked.Hide();
        }
        public void checkBoxBorder()
        {
            if(checkboxclicked.Checked == true)
            {
                checkboxclicked.Checked = false;
                this.BackColor = Color.White;
            }
            else
            {
                checkboxclicked.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79); 
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            checkBoxBorder();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightGray;
            panel1.BackColor = Color.LightGray;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(240, 240, 240);
            panel1.BackColor = Color.FromArgb(240, 240, 240);
        }
    }
}
