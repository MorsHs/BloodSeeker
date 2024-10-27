using BloodSeeker.Admin;
using BloodSeeker.Components.Appointment_Bar;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Controllers
{
    internal class AcceptAppointment
    {

        public int id;
        public string stat;
              

        public AcceptAppointment(int appointmentid, string status) { 
            this.id = appointmentid;
            this.stat = status;
            

        }

        public void AcceptOrReject()
        {
            
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_accept";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_id", id);
                global.sqlCommand.Parameters.AddWithValue("p_stat", stat);
                global.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Updated Status!");
                AdminAppointments app = new AdminAppointments();
                app.InitializeDataGridView();
                app.DisplayAppointment();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }

          
        }
    }
}
