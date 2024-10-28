using MySql.Data.MySqlClient;
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
        public int val;
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

        public void LoadResult()
        {
            try
            {

                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_printReceipt";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_unitID", val);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                Dgv_TransactionHistory.DataSource = data;
                adapter.Update(data);
                MessageBox.Show("Print " + val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Dgv_TransactionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgv_TransactionHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_TransactionHistory.Columns["print"].Index && e.RowIndex >= 0)
            {
                var cellvalue = Convert.ToInt32(Dgv_TransactionHistory.Rows[e.RowIndex].Cells[1].Value);
                LoadData LD = new LoadData(cellvalue);
                LD.Show();


            }
        }
    }
}
