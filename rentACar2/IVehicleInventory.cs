using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal interface IVehicleInventory
    {
        public void addVehicle(Vehicle v);

        public Vehicle[] getInventory();

        public void removeVehicle(Vehicle v);

        public Boolean checkforVehicle(Vehicle v);

        public int getInventoryCount();

        public void loadInventory();

    }
}
