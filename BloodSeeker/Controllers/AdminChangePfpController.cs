using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Controllers
{
    internal class AdminChangePfpController
    {
        private string username;
        private string photo;

        public AdminChangePfpController(string username, string photo)
        {
            this.username = username;
            this.photo = photo;
        }

        public void changepfp()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_adminChangePfp";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_username", username);
                global.sqlCommand.Parameters.AddWithValue("p_photo", photo);
                global.sqlCommand.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
