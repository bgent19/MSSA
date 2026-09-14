using Microsoft.EntityFrameworkCore;

namespace Assignment10._3
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

            // Create the database / apply migrations before the form opens.
            using (var db = new CarContext())
            {
                db.Database.Migrate();
            }

            Application.Run(new Form1());
        }
    }
}