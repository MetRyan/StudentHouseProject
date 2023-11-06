using StudentHouseProject.AdminAPage;
using StudentHouseProject.AdminPage;
using StudentHouseProject.StaffPage;
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

            //Application.Run(new MainMenu());

            MainMenu mainMenu = new MainMenu();
            mainMenu.WindowState = FormWindowState.Maximized; // ??t tr?ng thái c?a s? thành Maximized
            Application.Run(mainMenu);
        }
    }
}