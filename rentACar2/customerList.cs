using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
internal class customerList
{
        public List<customer> database;
        public string testStr;

        public customerList()
        {
            database = new List<customer>();
            createDatabase();
        }

        public customerList(List<customer> customers)
        {
            this.database = customers;
            createDatabase();
        }

        public void addCustomer(customer v)
        {
            database.Add(v);
        }

        public customer[] getDatabase()
        {
            customer[] arr = database.ToArray();
            return arr;
        }

        public void removeCustomer(customer v)
        {
            database.Remove(v);
        }

        public Boolean checkforCustomer(customer v)
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
            string[] lines = File.ReadAllLines("C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\Customer\\CustomerInformation.txt");

            foreach (string line in lines)

            {
                database.Add(new customer(line.Split(",")));
            }
        }
    }
}
