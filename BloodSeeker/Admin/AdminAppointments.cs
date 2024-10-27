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
        private static int _year, _month;
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

        private void AdminAppointments_Load(object sender, EventArgs e)
        {
            panel_acceptReject.Hide();
            InitializeDataGridView();
            DisplayAppointments();

        }

        private void InitializeDataGridView()
        {
            // Set DataPropertyName for each manually added column
            dgv_Appointments.Columns["appointmentID"].DataPropertyName = "appointment_id";
            dgv_Appointments.Columns["name"].DataPropertyName = "clientname";
            dgv_Appointments.Columns["address"].DataPropertyName = "address";
            dgv_Appointments.Columns["mobileNum"].DataPropertyName = "mobileNum";
            dgv_Appointments.Columns["bloodGroup"].DataPropertyName = "bloodgroup";
            dgv_Appointments.Columns["date"].DataPropertyName = "date";
            dgv_Appointments.Columns["status"].DataPropertyName = "status";
        }

        private void dgv_Appointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Appointments.Columns["status"].Index && e.RowIndex >= 0)
            {
                panel_acceptReject.Show();
                changePanel(new AcceptReject());
            }
        }

        private void DisplayAppointments()
        {
            try
            {
                SomeProcedure procedure = new SomeProcedure();
                DataTable dtAppointment = procedure.fncDisplayAppointments();

                if (dtAppointment != null && dtAppointment.Rows.Count > 0)
                {
                    dgv_Appointments.DataSource = dtAppointment;
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

        public void changePanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_acceptReject.Controls.Clear();
            panel_acceptReject.Controls.Add(form);
            form.Show();
        }

    }
}
