using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using BloodSeeker;

namespace BloodSeeker
{
    internal class Global
    {
        private string servername;
        private string databasename;
        private string username;
        private string password;
        private string port;
        public MySqlConnection conBloodbank;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter dataAdapter;
        public string strConnection;



        //DOCUMENTATION OF USING SQL.JSON
        //MAKE A SQL.JSON AND PUT IT ON BLOODSEEKER/BLOODSEEKER THEN FILL IT WITH THIS FORMAT
        //{
        //  "SERVERNAME": "servername",
        //  "DATABASENAME": "datascema name",
        //  "USERNAME": "root",
        //  "PASSWORD": "password",
        //  "PORT": "3306 OR 3307 (depends on your assigned port on your mysql)"
        //}
        // AFTER THAT RIGHT CLICK THE sql.JSON then press "Include from Project"
        // RIGHT CLICK AND GO PROPERTIES
        // BUILD ACTION -> CONTENT
        // COPY TO OUTPUT DIRECTORY -> COPY IF NEWER
        public bool fncConnectToDatabase()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sql.json");
            try
            {
                var jsonContent = File.ReadAllText(jsonFilePath);
                var dbconfig = JObject.Parse(jsonContent);

                servername = dbconfig["SERVERNAME"].ToString();
                databasename = dbconfig["DATABASENAME"].ToString();
                username = dbconfig["USERNAME"].ToString();
                password = dbconfig["PASSWORD"].ToString();
                port = dbconfig["PORT"].ToString();
                try
                {
                    strConnection = "Server=" + servername + "; " +
                    "Database =" + databasename + "; " +
                    "User=" + username + "; " +
                    "Password=" + password + "; " +
                    "Port =" + port + "; " +
                    "Convert Zero Datetime =true";

                    conBloodbank = new MySqlConnection(strConnection);
                    sqlCommand = new MySqlCommand(strConnection, conBloodbank);
                    if (conBloodbank.State == ConnectionState.Closed)
                    {
                        sqlCommand.Connection = conBloodbank;
                        conBloodbank.Open();
                        return true;
                    }
                    else
                    {
                        conBloodbank.Close();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Database JSON Configuration not found " + e.Message);
            }
            return false;
        }

        public void checkDatabaseConnection()
        {
            if (fncConnectToDatabase() == false)
            {
                conBloodbank.Open();
            }
            else
            {

            }
        }
    }

}