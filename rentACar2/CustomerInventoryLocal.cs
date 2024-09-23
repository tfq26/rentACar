namespace rentACar2
{
    internal class CustomerInventoryLocal : ICustomerInventory
    {
        public List<Customer> CustomerList = new List<Customer>();
        public Dictionary<string, string> customerLoginDetails = new Dictionary<string, string>();
        public string testStr;
        private string customerPath = @"Customer";
        

        public CustomerInventoryLocal()
        {

        }

        public void addCustomer(Customer c)
        {
            CustomerList.Add(c);
        }

        public Customer[] getInventory()
        {
            loadInventory();
            loadLogin(true);
            Customer[] arr = CustomerList.ToArray();
            return arr;
        }

        //public Customer[] GetActiveRentals()
        //{
        //    List<Customer> arr = new List<Customer>();
        //    foreach (Customer c in CustomerList)
        //    {
        //        if (c.active)
        //            return arr;
        //    }
        //}

        public void removeCustomer(Customer c)
        {
            CustomerList.Remove(c);
        }

        public Boolean checkforCustomer(Guid id)
        {
            foreach (Customer c in CustomerList)
            {
                if(c.getId() == id)
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
            return CustomerList.Count;
        }

        private void loadLogin(Boolean temp)
        {
            customerLoginDetails.Add("Admin", "Admin123");
        }

        private void loadLogin()
        {
            string loginPath = "C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\Customer\\UserLoginInformation.txt";
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

        public void loadInventory()
        {
            string informationPath = "Customer\\CustomerInformation.txt";
            if (File.Exists(informationPath))
            {
                string[] lines = File.ReadAllLines(informationPath);

                foreach (string line in lines)
                {
                    if (line.StartsWith("GUID"))
                        continue;

                    CustomerList.Add(new Customer(line.Split(",")));
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
