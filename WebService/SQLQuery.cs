using System;
using System.Data;
using System.Data.SqlClient;

namespace WebService
{
    public class SQLQuery
    {
        static string connectionString = @"Data Source=THANHTAN\SQLEXPRESS;Initial Catalog=Watch;Integrated Security=True";

        /// <summary>
        /// Executes a query that returns a DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        try
                        {
                            connection.Open();
                            adapter.Fill(dt);
                        }
                        catch (Exception ex)
                        {
                            // Log exception or handle it appropriately
                            throw;
                        }
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Executes a query that performs an action like Insert, Update, or Delete.
        /// </summary>
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        data = command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Log exception or handle it appropriately
                        throw;
                    }
                }
            }
            return data;
        }

        /// <summary>
        /// Executes a query that returns a single value.
        /// </summary>
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object data = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        data = command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle it appropriately
                        throw;
                    }
                }
            }
            return data;
        }

        /// <summary>
        /// Checks if a primary key exists in a table.
        /// </summary>
        public static bool HasExistPrimaryKey(string tableName, string primaryKeyName, object primaryKeyValue)
        {
            bool exists = false;
            string query = $"SELECT COUNT(1) FROM {tableName} WHERE {primaryKeyName} = @PrimaryKeyValue";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);

                    try
                    {
                        connection.Open();
                        exists = (int)command.ExecuteScalar() > 0;
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle it appropriately
                        throw;
                    }
                }
            }
            return exists;
        }

        /// <summary>
        /// Gets all rows from a specified table.
        /// </summary>
        public static DataTable GetTable(string tableName)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM {tableName}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        try
                        {
                            connection.Open();
                            adapter.Fill(dt);
                        }
                        catch (Exception ex)
                        {
                            // Log exception or handle it appropriately
                            throw;
                        }
                    }
                }
            }
            return dt;
        }
    }
}
