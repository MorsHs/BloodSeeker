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


    internal class ClientRepository
    {
        private List<Person> person = new List<Person>();

        public ClientRepository()
        {
            getClientFromDatabase();
        }

        public List<Person> getPeople()
        {
            return person;
        }
        public void addPerson(Person person)
        {
            this.person.Add(person);
        }

        private void getClientFromDatabase()
        {
            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_displayClient";
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
                    Person client = new Person(username, null, first_name, last_name, email, phone, address, sex, birthDate);
                    //TODO Staff Photo
                    addPerson(client);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Person> searchClientById(int clientId)
        {
            List<Person> results = new List<Person>();


            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_searchClientById";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("@p_client_id", clientId);
                MySqlDataReader reader = global.sqlCommand.ExecuteReader();

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
                    Person client = new Person(username, null, first_name, last_name, email, phone, address, sex, birthDate);
                    results.Add(client);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return results;
        }

        public List<Person> searchClientByFirstName(string firstName)
        {
            List<Person> results = new List<Person>();
            firstName = firstName.Trim();

            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_searchClientByFirstName";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("@p_first_name", firstName);
                MySqlDataReader reader = global.sqlCommand.ExecuteReader();

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
                    Person client = new Person(username, null, first_name, last_name, email, phone, address, sex, birthDate);
                    results.Add(client);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return results;
        }

        public List<Person> searchClientByLastName(string lastName)
        {
            List<Person> results = new List<Person>();
            lastName = lastName.Trim();

            try
            {
                Global global = new Global();
                global.fncConnectToDatabase();
                global.sqlCommand.Parameters.Clear();
                global.sqlCommand.CommandText = "prc_SearchClientByLastName";
                global.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                global.sqlCommand.Parameters.AddWithValue("@p_last_name", lastName);
                MySqlDataReader reader = global.sqlCommand.ExecuteReader();

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
                    Person client = new Person(username, null, first_name, last_name, email, phone, address, sex, birthDate);
                    results.Add(client);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return results;
         }
        }
    }
