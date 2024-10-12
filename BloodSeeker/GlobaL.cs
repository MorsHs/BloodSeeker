using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BloodSeeker
{
    internal class GlobaL
    {
        public string servername;
        public string databasename;
        public string username;
        public string password;
        public string port;
        public MySqlConnection conBloodbank;
        public MySqlCommand slqCommand;
        public string strConnection;

        public bool fncConnectToDatabase()
        {
            try
            {
                servername = "localhost";
                databasename = "bloodbank";
                username = "root";
                password = "jamycalubay@@@22";
                port = "3306";


                //implement connection
                strConnection = "Server=" + servername + "; " +
                    "Database =" + databasename + "; " +
                    "User=" + username + "; " +
                    "Password=" + password + "; " +
                    "Port =" + port + "; " +
                    "Convert Zero Datetime =true";

                conBloodbank = new MySqlConnection(strConnection);
                slqCommand = new MySqlCommand(strConnection, conBloodbank);
                if (conBloodbank.State == ConnectionState.Closed)
                {
                    slqCommand.Connection = conBloodbank;
                    conBloodbank.Open();
                    return true;
                }
                else
                {
                    conBloodbank.Close();
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error Message RATATOWE " + err.Message);
            }
            return false;
        }

        public void checkDatabaseConnection()
        {
            if (fncConnectToDatabase().Equals("False"))
            {
                conBloodbank.Open();
            }
            else
            {
               
            }
        }

    }


}
