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
using MySql.Data.MySqlClient;

namespace BloodSeeker.Customer
{
    public partial class CDashboard : Form
    {
        public CDashboard()
        {
            InitializeComponent();
            store1();
            getCountaplus();
            getCountbplus();
            getCountbminus();
            getCountabplus();
            getCountabminus();
            getCountoplus();
            getCountominus();
        }

        private void CDashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void store1()
        {

            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", "A-");
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dgv_aminus.DataSource = data;
                var cellValue = Convert.ToString(dgv_aminus.Rows[0].Cells[1].Value);
                lbl_AminnusCount.Text = cellValue;

            }
            catch (Exception ex)
            {

            }
        }

        public void getCountaplus()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", "A+");
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dgv_aplus.DataSource = data;
                var cellValue = Convert.ToString(dgv_aplus.Rows[0].Cells[1].Value);
                lbl_AplusCount.Text = cellValue;

            }
            catch (Exception ex)
            {

            }
        }
        public void getCountbplus()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", "B+");
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dgv_bplus.DataSource = data;
                var cellValue = Convert.ToString(dgv_bplus.Rows[0].Cells[1].Value);
                lbl_BplusCount.Text = cellValue;
            }
            catch (Exception ex)
            {

            }
        }
        public void getCountbminus()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", "B-");
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dgv_bminus.DataSource = data;
                var cellValue = Convert.ToString(dgv_bminus.Rows[0].Cells[1].Value);
                lbl_BminusCount.Text = cellValue;

            }
            catch (Exception ex)
            {

            }
        }
        public void getCountabplus()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", "AB+");
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dgv_abplus.DataSource = data;
                var cellValue = Convert.ToString(dgv_abplus.Rows[0].Cells[1].Value);
                lbl_ABplusCount.Text = cellValue;
            }
            catch (Exception ex)
            {

            }
        }
        public void getCountabminus()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", "AB-");
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dgv_abminus.DataSource = data;
                var cellValue = Convert.ToString(dgv_abminus.Rows[0].Cells[1].Value);
                lbl_ABminusCount.Text = cellValue;
            }
            catch (Exception ex)
            {

            }
        }
        public void getCountoplus()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", "O+");
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dgv_oplus.DataSource = data;
                var cellValue = Convert.ToString(dgv_oplus.Rows[0].Cells[1].Value);
                lbl_OplusCount.Text = cellValue;

            }
            catch (Exception ex)
            {

            }
        }
        public void getCountominus()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", "O-");
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dgv_ominus.DataSource = data;
                var cellValue = Convert.ToString(dgv_ominus.Rows[0].Cells[1].Value);
                lbl_OminusCount.Text = cellValue;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
