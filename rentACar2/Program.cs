namespace rentACar2
{
    internal static class Program
    {
        public static FormManager formManager = new FormManager();
        
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(formManager.startUp());
        }
    }
}