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
    public partial class LoadData : Form
    {
        private Global global;
        public int receivedValue;
        public LoadData(int value)
        {
            InitializeComponent();
            receivedValue = value;
            LoadResult();

        }

        public void LoadResult()
        {
            try
            {

                Global global = new Global();


                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_adminPrintReceipt";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_unitID", receivedValue);
                global.sqlCommand.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                guna2DataGridView1.DataSource = data;
                adapter.Update(data);

                // adapter.Update(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Contact Number");
            dt.Columns.Add("Transaction Date");

            foreach (DataGridViewRow dgv in guna2DataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("TransactionReceipt.xml");

            Print pr = new Print();
            PrintTransactionReceipt tr = new PrintTransactionReceipt();
            tr.SetDataSource(ds);
            pr.crystalReportViewer1.ReportSource = tr;
            pr.crystalReportViewer1.Refresh();
            pr.Show();
        }
    }
}
