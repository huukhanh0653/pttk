using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Data;


namespace WinFormsApp1.DAO.Database
{
    public class AppConfig
    {
        // Updated to enable trusted certification  
        public static string ConnectionString { get; set; } = "Server=localhost,1433;Database=pttk;User Id=sa;Password=Khanh076942542;TrustServerCertificate=True;";
        private static SqlCommand command;
        private static SqlConnection connection;
        private static SqlDataAdapter adapter;

        private AppConfig()
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(command);
            connection.Open();
        }

        ~AppConfig()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }

        public static SqlCommand Command
        {
            get { return command; }
            set { command = value; }
        }

        public static SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public static SqlDataAdapter Adapter
        {
            get { return adapter; }
            set { adapter = value; }
        }

        private static AppConfig instance;

        public static AppConfig Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppConfig();
                }
                return instance;
            }
        }
    }
}
