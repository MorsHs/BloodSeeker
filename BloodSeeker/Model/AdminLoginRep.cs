using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BloodSeeker.Model.Admin
{
    internal class AdminLoginRep
    {
        public bool ValidateAdmin(string username, string password)
        {
            bool isValid = false;

            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_adminLogin";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("@p_username", username);
                global.sqlCommand.Parameters.AddWithValue("@p_password", password);

                MySqlDataReader reader = global.sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    isValid = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Error while validating admin login: " + ex.Message);
            }

            return isValid;
        }
    }
}
