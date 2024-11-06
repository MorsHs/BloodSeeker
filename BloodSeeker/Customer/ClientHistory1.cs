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
        private int clientId;
        public ClientHistory1(int clientId)
        {
            InitializeComponent();
            this.Load += ClientHistory1_Load;
            this.clientId = clientId;
        }

        private void ClientHistory1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            DisplayAppointment();
        }

        public void InitializeDataGridView()
        {
            dgv_appointments.Columns["appointmentID"].DataPropertyName = "appointment_id";
            dgv_appointments.Columns["name"].DataPropertyName = "clientname";
            dgv_appointments.Columns["address"].DataPropertyName = "address";
            dgv_appointments.Columns["mobilenum"].DataPropertyName = "mobileNum";
            dgv_appointments.Columns["bloodgroup"].DataPropertyName = "bloodgroup";
            dgv_appointments.Columns["date"].DataPropertyName = "date";
            dgv_appointments.Columns["status"].DataPropertyName = "status";
        }

        public void DisplayAppointment()
        {
            
            try
            {
                SomeProcedure procedure = new SomeProcedure();
                DataTable dtAppointments = procedure.fncDisplayClientAppointment(clientId); 

                if (dtAppointments != null && dtAppointments.Rows.Count > 0)
                {
                    dgv_appointments.DataSource = dtAppointments;
                }
                else
                {
                    MessageBox.Show("No appointments available for this client.", "Data Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_appointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
