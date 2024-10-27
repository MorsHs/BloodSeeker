using BloodSeeker.Components.Calendar;
using Guna.UI2.WinForms;
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
using BloodSeeker.Components.Appointment_Bar;
namespace BloodSeeker.Admin
{
    public partial class AdminAppointments : Form
    {
       
        public AdminAppointments()
        {
            InitializeComponent();
            this.Load += AdminAppointments_Load;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AdminAppointments_Load(object sender, EventArgs e)
        {
           
            InitializeDataGridView();
            DisplayAppointment();
            timer1.Enabled = true;

        }

        public void InitializeDataGridView()
        {
            // Set DataPropertyName for each manually added column
            dgv_appointments.Columns["appointmentID"].DataPropertyName = "appointment_id";
            dgv_appointments.Columns["name"].DataPropertyName = "clientname";
            dgv_appointments.Columns["address"].DataPropertyName = "address";
            dgv_appointments.Columns["mobilenum"].DataPropertyName = "mobileNum";
            dgv_appointments.Columns["bloodgroup"].DataPropertyName = "bloodgroup";
            dgv_appointments.Columns["date"].DataPropertyName = "date";
            dgv_appointments.Columns["status"].DataPropertyName = "status";
        }

        private void dgv_appointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_appointments.Columns["status"].Index && e.RowIndex >= 0)
            {
                var cellvalue = Convert.ToInt32(dgv_appointments.Rows[e.RowIndex].Cells[0].Value);
                AcceptReject AR = new AcceptReject(cellvalue);
                AR.Show();
                
            }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void DisplayAppointment()
        {
            try
            {
                SomeProcedure procedure = new SomeProcedure();
                DataTable dtAppointmets = procedure.fncDisplayAppointment();

                if (dtAppointmets != null && dtAppointmets.Rows.Count > 0)
                {
                    dgv_appointments.DataSource = dtAppointmets;
                }
                else
                {
                    MessageBox.Show("No data available to display.", "Data Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
