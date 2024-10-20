namespace rentACar2
{
    internal static class Program
    {
        public static LoginForm loginForm = new LoginForm();
        public static HomeForm hf = new HomeForm();
        
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(loginForm);
        }
    }
}