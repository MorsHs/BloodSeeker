using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker
{
    internal class SomeProcedure
    {
        private Global global = new Global();

        public DataTable fncDisplayInventory()
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_displayInvetory", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;
                            using (global.dataAdapter = new MySqlDataAdapter(global.sqlCommand))
                            {
                                global.dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
            return dataTable;
            }

        public DataTable fncDisplayTransactionHistory()
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_displayHistory", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;
                            using (global.dataAdapter = new MySqlDataAdapter(global.sqlCommand))
                            {
                                global.dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction history: " + ex.Message);
            }
            return dataTable;
             }

        public DataTable SearchInventoryById(int unitId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_searchInventoryById", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;
                            global.sqlCommand.Parameters.AddWithValue("@unitId", unitId);

                            using (global.dataAdapter = new MySqlDataAdapter(global.sqlCommand))
                            {
                                global.dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching inventory: " + ex.Message);
            }

            // Check for null or empty result set
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
            }

            return dataTable;
        }
        public DataTable fncSearchInventoryByBloodGroup(string bloodGroup)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_searchInventoryByBloodGroup", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;
                            global.sqlCommand.Parameters.AddWithValue("@bloodGroup", bloodGroup);
                            using (global.dataAdapter = new MySqlDataAdapter(global.sqlCommand))
                            {
                                global.dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching inventory: " + ex.Message);
            }
            return dataTable;
        }

        public DataTable fncDisplayAppointment()
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_displayAppointment", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;
                            using (global.dataAdapter = new MySqlDataAdapter(global.sqlCommand))
                            {
                                global.dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
            return dataTable;
        }

        public string fncUpdateAdminPassword(string currentPassword, string newPassword)
        {
            string resultMessage = "Password update failed."; 
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_updateAdminPass", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Add current and new password as parameters
                            global.sqlCommand.Parameters.AddWithValue("@p_currentPassword", currentPassword);
                            global.sqlCommand.Parameters.AddWithValue("@p_newPassword", newPassword);

                            int rowsAffected = global.sqlCommand.ExecuteNonQuery();
                            resultMessage = rowsAffected > 0 ? "Password updated successfully." : "Current password is incorrect.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                resultMessage = "Error updating password: " + ex.Message;
            }
            return resultMessage;
        }
        public string UpdateAdminInfo(int adminId, string firstName, string lastName, string address, string mobileNum, string emailAdd, string username, string photoPath)
        {
            string resultMessage = "Failed to update account information.";
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_editAdminInfo", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Set the parameters for the stored procedure
                            global.sqlCommand.Parameters.AddWithValue("p_admin_id", adminId);
                            global.sqlCommand.Parameters.AddWithValue("p_first_name", firstName);
                            global.sqlCommand.Parameters.AddWithValue("p_last_name", lastName);
                            global.sqlCommand.Parameters.AddWithValue("p_address", address);
                            global.sqlCommand.Parameters.AddWithValue("p_mobileNum", mobileNum);
                            global.sqlCommand.Parameters.AddWithValue("p_emailAdd", emailAdd);
                            global.sqlCommand.Parameters.AddWithValue("p_username", username);
                            global.sqlCommand.Parameters.AddWithValue("p_photo", photoPath);

                            // Execute the command
                            global.sqlCommand.ExecuteNonQuery();
                            resultMessage = "Account information updated successfully!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                resultMessage = "Error updating account information: " + ex.Message;
            }
            return resultMessage;
        }
        public DataTable GetAdminInfo(int adminId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_getAdminInfo", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;
                            global.sqlCommand.Parameters.AddWithValue("@p_admin_id", adminId);

                            using (global.dataAdapter = new MySqlDataAdapter(global.sqlCommand))
                            {
                                global.dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving admin information: " + ex.Message);
            }

            return dataTable;
        }
        public string CreateAccountForStaff(string firstName, string lastName, string address, string mobileNum, string emailAdd, DateTime birthDate, string sex, string username, string password)
        {
            string resultMessage = "Account creation failed.";
            try
            {
                if (global.fncConnectToDatabase())
                {
                    using (global.conBloodbank = new MySqlConnection(global.strConnection))
                    {
                        global.conBloodbank.Open();
                        using (global.sqlCommand = new MySqlCommand("prc_createAccountForStaff", global.conBloodbank))
                        {
                            global.sqlCommand.CommandType = CommandType.StoredProcedure;

                            global.sqlCommand.Parameters.AddWithValue("p_first_name", firstName);
                            global.sqlCommand.Parameters.AddWithValue("p_last_name", lastName);
                            global.sqlCommand.Parameters.AddWithValue("p_address", address);
                            global.sqlCommand.Parameters.AddWithValue("p_mobileNum", mobileNum);
                            global.sqlCommand.Parameters.AddWithValue("p_emailAdd", emailAdd);
                            global.sqlCommand.Parameters.AddWithValue("p_birthDate", birthDate);
                            global.sqlCommand.Parameters.AddWithValue("p_sex", sex);
                            global.sqlCommand.Parameters.AddWithValue("p_username", username);
                            global.sqlCommand.Parameters.AddWithValue("p_password", password);

                            int rowsAffected = global.sqlCommand.ExecuteNonQuery();
                            resultMessage = rowsAffected > 0 ? "Account created successfully!" : "Username is taken already.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                resultMessage = "Error creating account: " + ex.Message;
            }
            return resultMessage;
        }
    }

}
