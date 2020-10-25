using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Inventory_Tracker
{
    class SQL_Commands
    {
        private readonly string connection;
        
        private Parts part = new Parts();

        public SQL_Commands(string Connection)
        {
            this.connection = Connection;
        }

        public bool PartExists(string SearchType, Parts Part, string TableName = "Allocated")
        {
            this.part = Part;

            if (SearchType == "Query Part") // checks to see if parts are inventory
            {
                string sqlCommand = "SELECT * FROM " + TableName + " WHERE Part_Number='" + part.PartNumber + "'";

                MySqlConnection connect = new MySqlConnection(this.connection);
                MySqlCommand command = new MySqlCommand(sqlCommand, connect);

                connect.Open();
                MySqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.Read())
                {
                    connect.Close();
                    return true;
                }
                else
                {
                    connect.Close();
                    return false;
                }
            }
            else if (SearchType == "Query Serial") // checks to see if a part is in inventory before consuming
            {
                string sqlCommand = "SELECT * FROM " + TableName + " WHERE Part_Number='" + part.PartNumber + "' AND Serial_Number='" + part.SerialNumber + "'";

                OleDbConnection connect = new OleDbConnection(this.connection);
                OleDbCommand command = new OleDbCommand(sqlCommand, connect);

                connect.Open();
                OleDbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.Read())
                {
                    connect.Close();
                    return true;
                }
                else
                {
                    connect.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Unhandled search type requested.", "Error");
                return false;
            }
        }

        public void AddToDB(Parts Part, string TableName = "Inventory")
        {
            this.part = Part;

            if (!PartExists("Query Serial", part, part.Status))
            {
                string sqlCommand = "INSERT INTO " + TableName + " (Part_Number, Serial_Number, Status, Tech_Name) " +
                                                 "VALUES (@Part_Number, @Serial_Number, @Status, @Tech_Name)";

                OleDbConnection connect = new OleDbConnection(this.connection);
                OleDbCommand command = new OleDbCommand(sqlCommand, connect);

                connect.Open();

                if (connect.State == ConnectionState.Open)
                {
                    command.Parameters.Add("@Part_Number", OleDbType.VarChar).Value = part.PartNumber;
                    command.Parameters.Add("@Serial_Number", OleDbType.VarChar).Value = part.SerialNumber;
                    command.Parameters.Add("@Status", OleDbType.VarChar).Value = part.Status;
                    command.Parameters.Add("@Tech_Name", OleDbType.VarChar).Value = part.TechName;
                    
                    command.ExecuteNonQuery(); // error unknown column "Part_Number unknown"
                    command.Parameters.Clear();
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Connection Failed!", "Error");
                }
            }
            else
            {
                MessageBox.Show("This part already exists! Please check and re-enter the" +
                              "\npart and serial numbers.","Warning");
            }
        }

        public void EditDB(Parts Part, string TableName = "Inventory")
        {
            string sqlCommand = "SELECT * FROM Inventory";

            this.part = Part;

            OleDbConnection connect = new OleDbConnection(this.connection);
            OleDbCommand command = new OleDbCommand(sqlCommand, connect);

            connect.Open();
            if (connect.State == ConnectionState.Open)
            {
                command.CommandText = "UPDATE " + TableName + " SET Part_Number=@Part_Number, Serial_Number=@Serial_Number, Status=@Status, Tech_Name=@Tech_Name " +
                                      "WHERE Part_Number='" + part.PartNumber + "' AND Serial_Number='" + part.SerialNumber + "'";

                command.Parameters.AddWithValue("@Part_Number", part.PartNumber);
                command.Parameters.AddWithValue("@Serial_Number", part.SerialNumber);
                command.Parameters.AddWithValue("@Status", part.Status);
                command.Parameters.AddWithValue("@Tech_Name", part.TechName);

                command.ExecuteNonQuery();
                command.Parameters.Clear();
                connect.Close();
            }
            else
            {
                MessageBox.Show("Connection Failed! \nFailed in EditDB()","Error");
            }
        }

        public void DeleteFromDB(Parts Part, string TableName = "Allocated")
        {
            this.part = Part;
            string sqlCommand = "SELECT * FROM " + TableName + "";

            OleDbConnection connect = new OleDbConnection(this.connection);
            OleDbCommand command = new OleDbCommand(sqlCommand, connect);

            connect.Open();

            connect.Open();
            if (connect.State == ConnectionState.Open)
            {
                command.CommandText = "DELETE FROM " + TableName + " WHERE Part_Number='" + part.PartNumber + "' AND Serial_Number='" + part.SerialNumber + "'";
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                connect.Close();
            }
            else
            {
                MessageBox.Show("Connection Failed! \nFailed in Deletion.", "Error");
            }
        }

        public void PostConsumtion(Parts Part)
        {
            this.part = Part;

            OleDbConnection connect = new OleDbConnection(this.connection);

            connect.Open();
            if (connect.State == ConnectionState.Open)
            {
                if (PartExists("Query Serial", part))
                {
                    switch (this.part.Status)
                    {
                        /// CASE 1
                        case "Allocated":

                            MessageBox.Show("You cannot allocate a part that is already allocated!", "Error");

                            break;

                        /// CASE 2
                        case "Installed":

                            AddToDB(part,"Installed");
                            EditDB(part);
                            DeleteFromDB(part);

                            break;

                        /// CASE 3
                        case "DOA":
                            
                            AddToDB(part, "DOA");
                            EditDB(part);
                            DeleteFromDB(part);

                            break;

                        /// CASE 4
                        case "Damaged":
                            
                            AddToDB(part, "Damaged");
                            EditDB(part);
                            DeleteFromDB(part);

                            break;
                    }
                }
                else
                {
                    MessageBox.Show("That part could not be found! Please check your entries for accuracy.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Connection Failed! \nFailed in PostConsumption().","Error");
            }
        }
    }
}
