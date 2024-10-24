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
        public bool getUser(string _username,string _password)
        {
            try
            {
                global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_clientLogin";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_username", _username);
                global.sqlCommand.Parameters.AddWithValue("p_password", _password);
                MySqlDataReader reader = global.sqlReader;
                reader = global.sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader.GetString("username");
                    string password = reader.GetString("password");
                    if (username == _username && password == _password)
                    {
                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }

    }
}
