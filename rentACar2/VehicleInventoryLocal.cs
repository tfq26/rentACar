using rentACar2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class VehicleInventoryLocal : IVehicleInventory
    {
        public List<Vehicle> vehicleList = new List<Vehicle>();
        public string testStr;

        public VehicleInventoryLocal()
        {
            
        }

        public void addVehicle(Vehicle v)
        {
            vehicleList.Add(v); 
        }

        public Vehicle[] getInventory()
        {
            Vehicle[] arr = vehicleList.ToArray();
            return arr; 
        }

        public void removeVehicle(Vehicle v)
        {
            vehicleList.Remove(v);
        }

        public Boolean checkforVehicle(Vehicle v)
        {
            if (vehicleList.Contains(v))
            {
                return true;
            }
            return false;
        }

        public int getInventoryCount()
        {
            return vehicleList.Count;
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

                    vehicleList.Add(new Vehicle(line.Split(",")));
                }
            }
            else
            {
                MessageBox.Show("Vehicle info file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
