using System;
using System.Windows.Forms;

namespace BloodSeeker.Admin.Controllers
{
    internal class AddStaffController
    {


        private string firstname;
        private string lastname;
        private string address;
        private string emailadd;
        private string username;
        private string password;
        private string contactno;
        private string sex;
        private DateTime birthdate;

        public AddStaffController(string username, string firstname, string lastname, string password, string emailadd, string contactno,
            string address, string sex, DateTime birthdate)
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.emailadd = emailadd;
            this.contactno = contactno;
            this.address = address;
            this.sex = sex;
            this.birthdate = birthdate;

        }

        public void addStaff()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_createAccountForStaff";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_first_name", firstname);
                global.sqlCommand.Parameters.AddWithValue("p_last_name", lastname);
                global.sqlCommand.Parameters.AddWithValue("p_address", address);
                global.sqlCommand.Parameters.AddWithValue("p_mobileNum", contactno);
                global.sqlCommand.Parameters.AddWithValue("p_emailAdd", emailadd);
                global.sqlCommand.Parameters.AddWithValue("p_sex", sex);
                global.sqlCommand.Parameters.AddWithValue("p_birthDate", birthdate);
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
