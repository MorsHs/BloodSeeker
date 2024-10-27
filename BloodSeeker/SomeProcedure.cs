using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker
{
    internal class SomeProcedure
    {
        private Global global = new Global();

        public DataTable fncDisplayInventory()
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_displayInvetory", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;
                            using (global.dataAdapter = new MySqlDataAdapter(global.sqlCommand))
                            {
                                global.dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
            return dataTable;
            }   
        }
}
