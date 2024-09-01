using rentACar2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
internal class inventory
{
    public List<vehicle> vehicles;
    public string testStr;

    public inventory()
    {
        vehicles = new List<vehicle>();
        createInventory();
    }

    public inventory(List<vehicle> vehicles)
    {
        this.vehicles = vehicles;
            createInventory();
    }

    public void addVehicle(vehicle v)
    {
        vehicles.Add(v); 
    }

    public vehicle[] getInventory()
    {
        vehicle[] arr = vehicles.ToArray();
        return arr; 
    }

    public void removeVehicle(vehicle v)
    {
        vehicles.Remove(v);
    }

    public Boolean checkforVehicle(vehicle v)
    {
        if (vehicles.Contains(v))
        {
            return true;
        }
        return false;
    }

    public int getInventoryCount()
    {
        return vehicles.Count;
    }

    public void createInventory()
    {
        string returnStr = string.Empty;
        string[] lines = File.ReadAllLines("C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\Vehicle\\VehicleInformation.txt");
            
            foreach (string line in lines)
            
            {
                vehicles.Add(new vehicle(line.Split(",")));
            }            
        }
    }
}
