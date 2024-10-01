using System.Reflection.Metadata.Ecma335;

namespace rentACar2
{
    public class CustomerInventoryLocal : ICustomerInventory
    {
        public List<Customer> Customers = new List<Customer>();
        public Dictionary<string, string> customerLoginDetails = new Dictionary<string, string>();
        public string testStr;
        private string customerPath = @"Customer";
        

        public CustomerInventoryLocal()
        {
            loadInventory();
            loadLogin(true);
        }

        public void addCustomer(Customer c)
        {
            Customers.Add(c);
        }

        public Customer[] getInventory()
        {
            loadInventory();
            
            Customer[] arr = Customers.ToArray();
            return arr;
        }

        public void removeCustomer(Customer c)
        {
            Customers.Remove(c);
        }

        public Boolean checkforCustomer(string id)
        {
            foreach (Customer c in Customers)
            {
                if(c.getId().Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean checkforCustomer(string email, string password)
        {
            if (customerLoginDetails.ContainsKey(email))
                if(customerLoginDetails.ContainsValue(password)) 
                    return true;
            return false;
        }

        public int getInventoryCount()
        {
            return Customers.Count;
        }

        private void loadLogin(Boolean temp)
        {
            customerLoginDetails.Add("Admin", "Admin123");
        }

        private void loadLogin()
        {
            string loginPath = @"Customer\UserLoginInformation.txt";
            if (File.Exists(loginPath))
            {
                 string[] lines = File.ReadAllLines(loginPath);

                foreach (string line in lines)
                {
                    if (line.StartsWith("GUID"))
                        continue;

                    customerLoginDetails.Add(line.Split(',')[1], line.Split(',')[2]);
                }
            }
            else
            {
                MessageBox.Show("Login info file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public Customer getCustomer(string email, string password)
        {
            Customer customer = null;
            if(checkforCustomer(email, password))
            {
                IEnumerator<Customer> enumerator = Customers.GetEnumerator();
                Customer temp = enumerator.Current;
                 if(temp.getEmail() != email)
                {
                    enumerator.MoveNext();
                } else
                {
                    customer = enumerator.Current;
                }
            }
            return customer;
        }

        public void loadInventory()
        {
            string informationPath = @"Customer\CustomerInformation.txt";
            if (File.Exists(informationPath))
            {
                string[] lines = File.ReadAllLines(informationPath);

                foreach (string line in lines)
                {
                    if (line.StartsWith("GUID"))
                        continue;

                    Customers.Add(new Customer(line.Split(",")));
                }
            }
            else
            {
                MessageBox.Show("Customer info file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
