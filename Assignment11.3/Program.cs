namespace Assignment11._3
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

            // Create movies.db and its tables (plus seed data) on first run.
            using (var db = new MovieContext())
            {
                db.Database.EnsureCreated();
            }

            Application.Run(new Form1());
        }
    }
}