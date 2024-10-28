using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BloodSeeker.Model
{
    internal class ClientLoginController
    {
        private string connectionString = "Server=127.0.0.1;Database=bloodbank;Uid=root;Pwd=jonald123456;";

        public ClientLoginController()
        {
        }

        public int? verifyUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT client_id FROM tblclient WHERE username = @username AND password = @password", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return null;
        }
    }
}
