using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using WinFormsApp1.DAO.Database;
using System.Diagnostics;

namespace WinFormsApp1.DAO
{
    internal class TaiKhoanDAO
    {
        //AppConfig appConfig = AppConfig.Instance;

        public TaiKhoanDAO()
        {
          
        }

        public void addTaiKhoan(string taiKhoan, string matKhau)
        {
            string query = "INSERT INTO tai_khoan (tai_khoan, mat_khau) VALUES (@TaiKhoan, @MatKhau)";
            try
            {
                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                AppConfig.Command.Parameters.AddWithValue("@MatKhau", matKhau);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
               
            }
        }

        public DataTable getAllTaiKhoan()
        {
            string query = "SELECT * FROM tai_khoan";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            return dataTable;
        }

        public bool authenticate(string taiKhoan, string password)
        {
            string query = "SELECT COUNT(*) FROM tai_khoan WHERE tai_khoan = @TaiKhoan AND mat_khau = @MatKhau";
            bool isAuthenticated = false;

            try
            {
                Debug.WriteLine($"Attempting to log in with username: {taiKhoan} and password: {password}");
                Debug.WriteLine("Opening Connection..");
                AppConfig.Command.CommandText = query;

                // Clear parameters before adding new ones to avoid conflicts  
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                AppConfig.Command.Parameters.AddWithValue("@MatKhau", password);

                Debug.WriteLine("Executing..");
                int count = (int)AppConfig.Command.ExecuteScalar();
                Debug.WriteLine($"Count: {count}");

                if (count > 0)
                {
                    Debug.WriteLine("Authentication successful.");
                    isAuthenticated = true;
                }
                else
                {
                    Debug.WriteLine("Authentication failed.");
                }

                return isAuthenticated;

            } catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine($"Error during authentication: {ex.Message}");
            }
            
            return isAuthenticated;
        }


    }
}
