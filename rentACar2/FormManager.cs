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
        

        public FormManager()
        {
            home = new HomeForm();
            customer = new CustomerProfileForm();
            rental = new rentalForm();
            login = new LoginForm();
        }

        public Form startUp()
        {
            return login;
        }

        public static void loadHome()
        {
            currentForm = home;
            login.Hide();
            customer.Hide();
            rental.Hide();
            currentForm.Refresh();
            currentForm.Show();
        }
        public static void loadHome(Customer c)
        {
            currentForm = home;
            login.Hide();
            customer.Hide();
            customer.setCustomer(c);
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
    }
}
