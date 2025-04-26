 using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Data;


namespace WinFormsApp1
{
    public static class AppConfig
    {
        public static string ConnectionString { get; set; } = "Server=localhost,1433;Database=master;User Id=sa;Password=Kh@nh076942542;";
    }

    public static class DataAccess
    {
        public static bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";

            using (SqlConnection connection = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count == 1;
            }
        }

        public static DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
