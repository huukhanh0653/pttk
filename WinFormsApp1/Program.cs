using WinFormsApp1;
using WinFormsApp1.DAO.Database;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppConfig app = AppConfig.Instance;
            Application.Run(MainForm.Instance);
        }
    }
}