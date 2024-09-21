using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class loginHandler
    {
        private class loginDetails
        {
            public string userName { get; set; }
            public string password { get; set; }

            public loginDetails(string userName, string password)
            {
                this.userName = userName;
                this.password = password;
            }
        }

        ICustomerInventory customerInventory;
        Dictionary<loginDetails, Customer> login;
        public loginHandler(CustomerInventoryLocal local)
        {
            customerInventory = local;
            login = new Dictionary<loginDetails, Customer>();
        }

        public loginHandler(CustomerInventoryCloud cloud)
        {
            customerInventory = cloud;
            login = new Dictionary<loginDetails, Customer>();
        }

        public Boolean checkLogin(string userEmail, string userPassword)
        {
            foreach (var login in login)
            {
                loginDetails details = login.Key;

                if (details.userName == userEmail)
                    if (details.password == userPassword)
                        return true;
            }
            return false;
        }

        public ReadOnlyDictionary<loginDetails, Customer> getLogins()
        {
            ReadOnlyDictionary<String, Customer> returnDict = login.AsReadOnly();
            return returnDict;
        }

        private void loadLogin()
        {
            string informationPath = "Customer\\userLoginInformation.txt";
            if (File.Exists(informationPath))
            {
                string[] lines = File.ReadAllLines(informationPath);
                
                foreach (string line in lines)
                {
                    if (line.StartsWith("Email"))
                        continue;

                    string[] temp = line.Split(',');

                    foreach(Customer customer in customerInventory.getInventory())
                    {
                        if(customer.getId() == new Guid(temp[0]))
                        {
                            login.Add(new loginDetails(temp[1].ToLower(), temp[2]), customer);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("User Login info file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
