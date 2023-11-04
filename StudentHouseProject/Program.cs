using StudentHouseProject.AdminAPage;
using UI;

namespace StudentHouseProject
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
            //Application.Run(new MainMenu());
            //Application.Run(new AdminAssignServiceToStaffs());
            Application.Run(new LoginForm());
        }
    }
}