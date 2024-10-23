using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BloodSeeker
{
    internal class SignUpController
    {
        private string username { get; set; }
        private string password { get; set; }
        private string firstname { get; set; }
        private string lastname { get; set; }
        private string email { get; set; }
        private string phone { get; set; }
        private string address { get; set; }
        private string sex { get; set; }
        private DateTime birthdate { get; set; }

        Global global;
        public SignUpController(string firstname, string lastname, string password, string username, string email, string phone,
            string address, string sex, DateTime birthdate)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.sex = sex;
            this.birthdate = birthdate;
        }

        public String registerUser()
        {
             global = new Global();
            try
            {
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                //Dissapointing na dle nako makuha pa ang clear ug command text into one method kay wla koy time and lazy to do
                global.sqlCommand.CommandText = "prc_createAccountForAdminStaffClient";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("p_first_name", firstname);
                global.sqlCommand.Parameters.AddWithValue("p_last_name", lastname);
                global.sqlCommand.Parameters.AddWithValue("p_address", address);
                global.sqlCommand.Parameters.AddWithValue("p_mobileNum", phone);
                global.sqlCommand.Parameters.AddWithValue("p_emailAdd", email);
                global.sqlCommand.Parameters.AddWithValue("p_birthDate", birthdate);
                global.sqlCommand.Parameters.AddWithValue("p_sex", sex);
                global.sqlCommand.Parameters.AddWithValue("p_username", username);
                global.sqlCommand.Parameters.AddWithValue("p_password", password);
                return duplicateMessage(global);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public String duplicateMessage(Global global)
        {
            try
            {
                global.sqlReader = global.sqlCommand.ExecuteReader();
                while (global.sqlReader.Read())
                {
                    if (global.sqlReader["error_message"] != DBNull.Value)
                    {
                        return global.sqlReader["error_message"].ToString();
                    }
                }
                global.fncConnectToDatabase();
            }
            catch(Exception e)
            {
                //If no "error_message" do nothing
            }
            return null;
        }
    }
}