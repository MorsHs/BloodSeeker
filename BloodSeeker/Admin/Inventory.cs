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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            this.Load += Inventory_Load;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            LoadInventoryData();
        }

        private void InitializeDataGridView()
        {
            // Set DataPropertyName for each manually added column
            Dgv_Inventory.Columns["UnitId"].DataPropertyName = "unit_id";
            Dgv_Inventory.Columns["BloodGroup"].DataPropertyName = "bloodgroup";
            Dgv_Inventory.Columns["DonationDate"].DataPropertyName = "donation_date";
            Dgv_Inventory.Columns["ExpiryDate"].DataPropertyName = "expiry_date";
            Dgv_Inventory.Columns["Capacity"].DataPropertyName = "capacity";
        }

        private void LoadInventoryData()
        {
            try
            {
                SomeProcedure procedure = new SomeProcedure();
                DataTable dtInventory = procedure.fncDisplayInventory();

                if (dtInventory != null && dtInventory.Rows.Count > 0)
                {
                    Dgv_Inventory.DataSource = dtInventory;
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
        private void Dgv_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
