using BloodSeeker.Admin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.DashBoard_Display_Code
{
    internal class DashBoardDisplay
    {
        private Global global = new Global();
        public string bloodtype;
        Dashboard dash = new Dashboard();

        public DashBoardDisplay()
        {
            
        }
        public void getCountaplus(string bt)
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", bt);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dash.dgv_aplus.DataSource = data;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }
        public void getCountaminus(string bt)
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", bt);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dash.dgv_aminus.DataSource = data;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }
        public void getCountbplus(string bt)
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", bt);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dash.dgv_bplus.DataSource = data;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }
        public void getCountbminus(string bt)
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", bt);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dash.dgv_bminus.DataSource = data;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }
        public void getCountabplus(string bt)
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", bt);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dash.dgv_abplus.DataSource = data;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }
        public void getCountabminus(string bt)
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", bt);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dash.dgv_abminus.DataSource = data;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }
        public void getCountoplus(string bt)
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", bt);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dash.dgv_oplus.DataSource = data;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }
        public void getCountominus(string bt)
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_inventoryCount";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_bloodtype", bt);
                global.sqlCommand.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable data = new DataTable();
                adapter.SelectCommand = global.sqlCommand;
                data.Clear();
                adapter.Fill(data);
                dash.dgv_ominus.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }
    }
} 
