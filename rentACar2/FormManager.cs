using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class FormManager
    {
        public static HomeForm home;
        public static CustomerProfileForm customer;
        public static LoginForm login;
        public static rentalForm rental;
        public static Form currentForm;

        public FormManager(HomeForm hf, CustomerProfileForm cf, rentalForm rf, LoginForm lf)
        {
            home = hf;
            customer = cf;
            rental = rf;
            login = lf;
            currentForm = null;
        }

        public static void loadHome()
        {
            home.database = login.GetCustomers().ToList();
            currentForm = home;
            getCurrent();
        }

        public static void loadCustomer()
        {
            currentForm = customer;
            currentForm.Show();
            getCurrent();

        }

        public static void loadLogin()
        {
            currentForm = login;
            currentForm.Show();
            getCurrent();

        }

        public static void loadRental()
        {
            currentForm = rental;
            currentForm.Show();
            getCurrent();
        }
        private static void getCurrent()
        {
            if (currentForm != null)
            {
                if (currentForm == home)
                {
                    rental.Hide();
                    customer.Hide();
                    login.Hide();
                }
                if (currentForm == rental)
                {
                    home.Hide();
                    customer.Hide();
                    login.Hide();
                }
                if (currentForm == customer)
                {
                    rental.Hide();
                    home.Hide();
                    login.Hide();
                }
                if (currentForm == login)
                {
                    rental.Hide();
                    customer.Hide();
                    customer.Hide();
                }
            }
            currentForm.Show();
        }
    }
}
