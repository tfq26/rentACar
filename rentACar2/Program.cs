namespace rentACar2
{
    internal static class Program
    {
        public static LoginForm loginForm = new LoginForm();
        public static RentalCarMainForm rentalCarForm = new RentalCarMainForm();
        public static CustomerProfileForm customerForm = new CustomerProfileForm();
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