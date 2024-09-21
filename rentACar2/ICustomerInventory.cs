using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal interface ICustomerInventory
    {
        public void addCustomer(Customer c);

        public Customer[] getInventory();

        public void removeCustomer(Customer c);

        public Boolean checkforCustomer(Guid id);

        public int getInventoryCount();

        public void loadInventory();

        public Boolean checkforCustomer(string email, string password);

    }
}
