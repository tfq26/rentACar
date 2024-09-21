﻿using rentACar2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class CustomerInventoryCloud : ICustomerInventory
    {
        public List<Customer> CustomerList = new List<Customer>();
        public Dictionary<string, string> customerLoginDetails = new Dictionary<string, string>();
        public string testStr;

        public CustomerInventoryCloud()
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

        public Boolean checkforCustomer(Guid id)
        {
            foreach (Customer c in CustomerList)
            {
                if (c.getId() == id)
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean checkforCustomer(string email, string password)
        {
            if (customerLoginDetails.ContainsKey(email))
                if (customerLoginDetails.ContainsValue(password))
                    return true;
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
                    if (line.StartsWith("GUID"))
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