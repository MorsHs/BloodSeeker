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
    public partial class TransacitionHistory : Form
    {
        private Global global;
        private SomeProcedure someProcedure;

        public TransacitionHistory()
        {
            InitializeComponent();
            global = new Global();
            someProcedure = new SomeProcedure();

          
            if (global.fncConnectToDatabase())
            {
                LoadTransactionHistory();
            }
        }
        private void LoadTransactionHistory()
        {
            try
            {
                DataTable transactionData = someProcedure.fncDisplayTransactionHistory(); 
                if (transactionData != null && transactionData.Rows.Count > 0)
                {
                    Dgv_TransactionHistory.DataSource = transactionData; 
                }
                else
                {
                    MessageBox.Show("No transaction history available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction history: " + ex.Message);
            }
        }


        private void Dgv_TransactionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
