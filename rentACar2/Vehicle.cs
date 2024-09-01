using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rentACar2
{
    internal class vehicle
    {
        private List<string> vehicleInformation;
        //private double rate;
        private string make;
        private string model;
        private int year;
        private string type;
        private int mileage;
        private string condition;
        private string color;
        private bool finance;
        private int totalRentalLife; // Keeps track of the number of days the vehicle has been rented in its life cycle
        private double averageRentalPeriod; // Tracks the average rental period for a specific vehicle

        public vehicle()
        {
            vehicleInformation = new List<string>();
        }

        public vehicle(string make, string model, int year, string type, int miles, string condition,
            string color, bool financable)
        {
            vehicleInformation = new List<string>();
            this.make = make;
            this.model = model;
            this.year = year;
            this.type = type;
            this.mileage = miles;
            this.condition = condition;
            this.color = color;
            this.finance = financable;
        }

        public vehicle(string[] vehicleInfo)
        {
            vehicleInformation = new List<string>();
            this.make = vehicleInfo[0];
            this.model = vehicleInfo[1];
            this.year = Int32.Parse(vehicleInfo[2]);
            this.type = vehicleInfo[3];
            this.mileage = Int32.Parse(vehicleInfo[4]);
            this.condition = vehicleInfo[5];
            this.color = vehicleInfo[6];
            this.finance = bool.Parse(vehicleInfo[7]);
        }

        private vehicle(string[] vehicleInfo, Boolean testCase)
        {
            vehicleInformation = new List<string>();
            int counter = 0;
            foreach (string s in vehicleInfo) { 
                vehicleInformation.Add("Line" + counter + ": " + s);
                counter++;
            }
        }

        public string getVehicleDetails()
        {
            setVehicleDetails();
            string returnStr = "Vehicle Information\n";
            foreach (string str in vehicleInformation)
            {
                returnStr += str + "\n";
            }

            int count = vehicleInformation.Count;
            //returnStr += count.ToString();
            return returnStr;
        }

        public void setVehicleDetails()
        {
            vehicleInformation.Add("Make: " + this.make);
            vehicleInformation.Add("Model: " + this.model);
            vehicleInformation.Add("Year: " + this.year.ToString());
            vehicleInformation.Add("Type: " + this.type);
            vehicleInformation.Add("Mileage: " + this.mileage);
            vehicleInformation.Add("Condition: " + this.condition);
            vehicleInformation.Add("Color: " + this.color);
            vehicleInformation.Add("Financeable: " + this.finance);
        }

        public String getMake() => make;
        public String getModel() => model;
        public String getYear() => year.ToString();
        public String getType() => type;
        //public double getRate() => rate;

        public void setMake(String newMake)
        {
            make = newMake;
        }

        public void setLastName(String newModel)
        {
            model = newModel;
        }

        public void setYear(int y)
        {
            year = y;
        }

        public void setType(String newType)
        {
            type = newType;
        }

        //public void setRate(double rate)
        //{
        //    this.rate = rate;
        //}

        public void updateRentalLife(int d)
        {
            this.totalRentalLife += d;
        }

        private void updateAverageRentalPeriod()
        {
            
        }

    }
}
