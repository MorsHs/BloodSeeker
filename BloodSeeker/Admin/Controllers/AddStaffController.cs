using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        private DateTime birthdate;
        private string sex;

        public AddStaffController(string username, string firstname, string lastname, string password, string emailadd, string contactno,
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

        public void addStaff()
        {
            Global global = new Global();
            global.fncConnectToDatabase();
            global.sqlCommand.Parameters.Clear();
            global.sqlCommand.CommandText = "prc_createStaff";
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

    }
    
}
