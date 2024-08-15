using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class Vehicle
    {
        public List<string> vehicleInformation;
        private double rate;

        public Vehicle()
        {
            vehicleInformation = new List<string>();
        }

        public Vehicle(string make, string model, int year, string type)
        {
            vehicleInformation = new List<string>();
            vehicleInformation.Add("Make: " + make);
            vehicleInformation.Add("Model: " + model);
            vehicleInformation.Add("Year: " + year.ToString());
            vehicleInformation.Add("Type: " + type);
        }

        public Vehicle(string[] vehicleInfo)
        {
            vehicleInformation = new List<string>();
            vehicleInformation.Add("Make: " + vehicleInfo[0]);
            vehicleInformation.Add("Model: " + vehicleInfo[1]);
            vehicleInformation.Add("Year: " + Int32.Parse(vehicleInfo[2]));
            vehicleInformation.Add("Type: " + vehicleInfo[3]);
        }

        public string getVehicleDetails()
        {
            string returnStr = string.Empty;

            foreach (string str in vehicleInformation)
            {
                returnStr += str;
                returnStr += "\n";
            }
            
            return returnStr;
        }

        public double getRate()
        {
            return rate;
        }

        public void setRate(double rate)
        {
            this.rate = rate;
        }

    }
}
