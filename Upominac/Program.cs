namespace Upominac
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
            //Application.Run(new PrimaryForm());

            
            //naètení/inicializace dat (ze souborù, parametry atd.)
            PrimaryForm primaryForm = new PrimaryForm();


            if (AppOptions.StartTray)
                Application.Run();
            if (!AppTrayIcon.TrayExited)
                Application.Run(primaryForm);






        }
    }
}