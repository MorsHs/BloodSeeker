using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Model
{
    internal class ClientLoginRepo
    {
        Global global;
        public ClientLoginRepo()
        { 
        
        }
        public bool getUser(string username, string password)
        {
            try
            {
                global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_clientLogin";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_username", username);
                global.sqlCommand.Parameters.AddWithValue("p_password", password);

                using (MySqlDataReader reader = global.sqlCommand.ExecuteReader())
                {
                    
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
