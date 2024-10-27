using BloodSeeker.Controllers;
using Google.Protobuf.WellKnownTypes;
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
    
    public partial class AcceptReject : Form
        
    {
        private int receivedValue;
        AdminAppointments appointments = new AdminAppointments();


        public AcceptReject(int value)
        {
            InitializeComponent();
            receivedValue = value;
           
        }

       

        private void btn_accept_Click(object sender, EventArgs e)
        {
            string text = btn_accept.Text;
            try
            {
              AcceptAppointment AcceptorReject = new AcceptAppointment(receivedValue,text);
                AcceptorReject.AcceptOrReject();
            }
            catch (Exception ex)
            {
             MessageBox.Show(ex + " ");
            }
            
            this.Dispose();
            
        }

        private void AcceptReject_Load(object sender, EventArgs e)
        {
            
            appointments.DisplayAppointment();
        }

        private void btn_rejct_Click(object sender, EventArgs e)
        {
            string text = btn_rejct.Text;
            try
            {
                AcceptAppointment AcceptorReject = new AcceptAppointment(receivedValue, text);
                AcceptorReject.AcceptOrReject();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }

            this.Dispose();
        }
    }
}
