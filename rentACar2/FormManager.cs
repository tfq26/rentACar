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
            login.Hide();
            customer.Hide();
            rental.Hide();
            currentForm.Refresh();
            currentForm.Show();
        }

        public static void loadCustomer()
        {
            currentForm = customer;
            home.Hide();
            login.Hide();
            rental.Hide();
            currentForm.Refresh();
            currentForm.Show();
        }

        public static void loadLogin()
        {
            currentForm = login;
            currentForm.Show();
            currentForm.Refresh();
            home.Hide();
            customer.Hide();
            rental.Hide();
        }

        public static void loadRental(Vehicle v, Customer c)
        {
            rental.setCustomer(c);
            rental.setVehicle(v);
            currentForm = rental;
            currentForm.Refresh();
            home.Hide();
            login.Hide();
            customer.Hide();
        }
       /* private static void getCurrent()
        {
            if (currentForm != null)
            {
                if (currentForm == home)
                {
                    currentForm = home;
                }
                if (currentForm == rental)
                {
                    currentForm = rental;
                }
                if (currentForm == customer)
                {
                    currentForm = customer;
                }
                if (currentForm == login)
                {
                    currentForm = login;
                }
            }
        }*/
    }
}
