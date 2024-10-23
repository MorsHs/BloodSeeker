using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Controllers.Admin
{
    internal class AddClientController
    {


        private string firstname;
        private string lastname;
        private string address;
        private string emailadd;
        private string username;
        private string password;
        private string contactno;
        private DateTime birthdate;
        private string sex;

        public AddClientController(string username, string firstname, string lastname, string password, string emailadd, string contactno,
            string address, DateTime birthdate, string sex)
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.emailadd = emailadd;
            this.contactno = contactno;
            this.address = address;
            this.birthdate = birthdate;
            this.sex = sex;

        }

        public void addClient()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_createAccountForClient";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_first_name", firstname);
                global.sqlCommand.Parameters.AddWithValue("p_last_name", lastname);
                global.sqlCommand.Parameters.AddWithValue("p_address", address);
                global.sqlCommand.Parameters.AddWithValue("p_mobileNum", contactno);
                global.sqlCommand.Parameters.AddWithValue("p_emailAdd", emailadd);
                global.sqlCommand.Parameters.AddWithValue("p_birthDate", birthdate);
                global.sqlCommand.Parameters.AddWithValue("p_sex", sex);
                global.sqlCommand.Parameters.AddWithValue("p_username", username);
                global.sqlCommand.Parameters.AddWithValue("p_password", password);
                global.sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
    }
}
