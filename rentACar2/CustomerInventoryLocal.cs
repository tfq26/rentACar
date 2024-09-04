using rentACar2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class CustomerInventoryLocal : ICustomerInventory
    {
        public List<Customer> CustomerList = new List<Customer>();
        public string testStr;

        public CustomerInventoryLocal()
        {

        }

        public void addCustomer(Customer c)
        {
            CustomerList.Add(c);
        }

        public Customer[] getInventory()
        {
            Customer[] arr = CustomerList.ToArray();
            return arr;
        }

        public void removeCustomer(Customer c)
        {
            CustomerList.Remove(c);
        }

        public Boolean checkforCustomer(Customer c)
        {
            if (CustomerList.Contains(c))
            {
                return true;
            }
            return false;
        }

        public int getInventoryCount()
        {
            return CustomerList.Count;
        }

        public void loadInventory()
        {
            string returnStr = string.Empty;
            string filePath = "Vehicle\\VehicleInformation.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (line.StartsWith("Id"))
                        continue;

                    CustomerList.Add(new Customer(line.Split(",")));
                }
            }
            else
            {
                MessageBox.Show("Vehicle info file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
