using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DatabaseReaderApp
{
    public class DatabaseReader
    {
        public string getConnStr()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Directory.GetParent(Directory.GetParent(currentDirectory).Parent.FullName).FullName;
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={projectRootDirectory}\Pulzz_Database.mdf;Integrated Security=True";
            return connectionString;
        }

        public void runQuery(string query)
        {
            // Creating the Connection string object
            SqlConnection conn = new SqlConnection(getConnStr());

            // Using regular expression to replace double quotes inside the string
            if (query.Contains("\""))
            {
                query = Regex.Replace(query, @"(?<!\\)""", "'");
            }
            else
            {
                // Using regular expressions to find and replace values without single quotes
                string pattern = @"(?<=\b(?:UPDATE|SET|DELETE|VALUES|WHERE|INSERT)\b\s*|(?<!\w)'?)(?<!\b(?:UPDATE|FROM|INTO)\b\s+)(?![\w.-]+@[\w.-]+|""[^""]*"")\b(?!(?:UPDATE|SET|DELETE|FROM|VALUES|WHERE|INSERT|INTO)\b)(?<!\b\w+@\w+\.\w+\b)(?<!')\b\w+\b'?(?!')(?!\s*(?:=|'|;))";
                query = Regex.Replace(query, pattern, "'$&'");
            }


            // Creating the command
            SqlCommand cmd = new SqlCommand(query, conn);

            // Executing the command
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string lastMsg(int id)
        {
            // Creating the Connection string object
            SqlConnection conn = new SqlConnection(getConnStr());

            // Declaring variables
            string msg = "";

            // Creating the query
            string query = $"SELECT LastMsg FROM AnyData WHERE EmployeeId='{id}';";

            // Creating the command
            SqlCommand cmd = new SqlCommand(query, conn);

            // Executing the command
            try
            {
                conn.Open();
                SqlDataReader data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    data.Read();
                    msg = data["LastMsg"].ToString();
                }

                conn.Close();
                return msg;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return msg;
            }
        }

        public void UpdateLastMsg(int id, string msg)
        {
            // Creating the Connection string object
            SqlConnection conn = new SqlConnection(getConnStr());

            // Creating the query
            string query = $"UPDATE AnyData SET LastMsg='{msg}' WHERE EmployeeId='{id}';";

            // Creating the command
            SqlCommand cmd = new SqlCommand(query, conn);

            // Executing the command
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string readDatabase()
        {
            DatabaseReader reader = new DatabaseReader();
            string databaseContent = reader.allDatabase(getConnStr());
            return databaseContent;
        }

        public string allDatabase(string _connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // Create a StringBuilder to store the combined results
                    StringBuilder sb = new StringBuilder();

                    // Get the list of tables in the database
                    DataTable schemaTable = connection.GetSchema("Tables");

                    // Iterate over each table
                    foreach (DataRow row in schemaTable.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();

                        // Use dynamic SQL to select all rows from the current table
                        string query = $"SELECT * FROM [{tableName}]";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Read the rows for the current table
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            sb.AppendLine($"Table: {tableName}");

                            // Read each row and append to StringBuilder
                            while (reader.Read())
                            {
                                StringBuilder rowBuilder = new StringBuilder();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    rowBuilder.Append(reader[i]);
                                    if (i < reader.FieldCount - 1)
                                        rowBuilder.Append(", ");
                                }

                                sb.AppendLine(rowBuilder.ToString());
                            }

                            sb.AppendLine();
                        }
                    }

                    // Return the combined results as a string
                    return sb.ToString();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("An error occurred while reading the database.", ex);
            }
        }

    }
}



