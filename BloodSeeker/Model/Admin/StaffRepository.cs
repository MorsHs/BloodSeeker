using BloodSeeker.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Model.Admin
{
    internal class StaffRepository
    {
        private List<Person> person = new List<Person>();
        
        public StaffRepository()
        { 
            getStaffFromDatabase();
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
    }
}
