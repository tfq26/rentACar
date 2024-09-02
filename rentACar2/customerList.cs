using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
internal class customerList
{
        public List<Customer> database;
        public string testStr;

        public customerList()
        {
            database = new List<Customer>();
            createDatabase();
        }

        public customerList(List<Customer> customers)
        {
            this.database = customers;
            createDatabase();
        }

        public void addCustomer(Customer v)
        {
            database.Add(v);
        }

        public Customer[] getDatabase()
        {
            Customer[] arr = database.ToArray();
            return arr;
        }

        public void removeCustomer(Customer v)
        {
            database.Remove(v);
        }

        public Boolean checkforCustomer(Customer v)
        {
            if (database.Contains(v))
            {
                return true;
            }
            return false;
        }

        public int getDatabaseCount()
        {
            return database.Count;
        }

        public void createDatabase()
        {
            string returnStr = string.Empty;
            string filePath = "Customer\\CustomerInformation.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)

                {
                    database.Add(new Customer(line.Split(",")));
                }
            }
        }
    }
}
