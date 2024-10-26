using BloodSeeker.Admin;
using BloodSeeker.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Model.Admin
{
    internal class StaffRepository
    {
        private List<Person> person = new List<Person>();
        private List<Staff> staffList = new List<Staff>();

        public StaffRepository()
        { 
            getStaffFromDatabase();
        }
        public List<Staff> getStaff()
        {
            return staffList;
        }

        public void addStaff(Staff staff)
        {
            this.staffList.Add(staff);
        }


        public List<Person> getPeople()
        {
            return person;
        }
        public void addPerson(Person person)
        {
            this.person.Add(person);
        }

        private void getStaffFromDatabase()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_displayStaff";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlDataReader reader = global.sqlReader;
                reader = global.sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader.GetString("username");
                    string first_name = reader.GetString("first_name");
                    string last_name = reader.GetString("last_name");
                    string sex = reader.GetString("sex");
                    string email = reader.GetString("emailAdd");
                    string phone = reader.GetString("mobileNum");
                    string address = reader.GetString("address");
                    DateTime birthDate = reader.GetDateTime("birthDate");
                    Person staff = new Person(username, null, first_name, last_name, email, phone, address, sex, birthDate);
                    //TODO Staff Photo
                    addPerson(staff);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        public List<Staff> searchStaff(int? staffId = null, string firstName = null, string lastName = null)
        {
            List<Staff> result = new List<Staff>();

            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_searchStaff"; 
                global.sqlCommand.CommandType = CommandType.StoredProcedure;

                global.sqlCommand.Parameters.AddWithValue("@p_staff_id", staffId.HasValue ? (object)staffId.Value : DBNull.Value);
                global.sqlCommand.Parameters.AddWithValue("@p_first_name", string.IsNullOrEmpty(firstName) ? (object)DBNull.Value : firstName);
                global.sqlCommand.Parameters.AddWithValue("@p_last_name", string.IsNullOrEmpty(lastName) ? (object)DBNull.Value : lastName);

                using (MySqlDataReader reader = global.sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var staff = new Staff(
                            reader.GetString("username"),
                            null,
                            reader.GetString("first_name"),
                            reader.GetString("last_name"),
                            reader.GetString("emailAdd"),
                            reader.GetString("mobileNum"),
                            reader.GetString("address"),
                            reader.GetString("sex"),
                            reader.GetDateTime("birthDate"),
                            reader.GetInt32("staff_id")
                        );
                        result.Add(staff);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }



    }
}
