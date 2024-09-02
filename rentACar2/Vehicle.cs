using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace rentACar2
{
    public class Vehicle
    {
        private List<string> vehicleInformation;
        //private double rate;
        private Guid Id;
        private string make;
        private string model;
        private int year;
        private string type;
        private int mileage;
        private string condition;
        private string color;
        private string finance;
        private int totalRentalLife; // Keeps track of the number of days the vehicle has been rented in its life cycle
        private double averageRentalPeriod; // Tracks the average rental period for a specific vehicle

        public Vehicle()
        {
            vehicleInformation = new List<string>();
        }

        public Vehicle(string[] vehicleInfo)
        {
            vehicleInformation = new List<string>();
            this.Id = Guid.Parse(vehicleInfo[0]);
            this.make = vehicleInfo[1];
            this.model = vehicleInfo[2];
            this.year = Int32.Parse(vehicleInfo[3]);
            this.type = vehicleInfo[4];
            this.mileage = Int32.Parse(vehicleInfo[5]);
            this.condition = vehicleInfo[6];
            this.color = vehicleInfo[7];
        }

        //private vehicle(string[] vehicleInfo, Boolean testCase)
        //{
        //    vehicleInformation = new List<string>();
        //    int counter = 0;
        //    foreach (string s in vehicleInfo) { 
        //        vehicleInformation.Add("Line" + counter + ": " + s);
        //        counter++;
        //    }
        //}

        //public string getVehicleDetails()
        //{
        //    setVehicleDetails();
        //    string returnStr = "Vehicle Information\n\n";
        //    foreach (string str in vehicleInformation)
        //    {
        //        returnStr += str + "\n";
        //    }

        //    int count = vehicleInformation.Count;
        //    //returnStr += count.ToString();
        //    return returnStr;
        //}

        public string[] getVehicleDetails()
        {
            setVehicleDetails();

            String[] temp = vehicleInformation.ToArray();

            return temp;
        }

        public void setVehicleDetails()
        {
            vehicleInformation.Add("Make: " + this.make);
            vehicleInformation.Add("Model: " + this.model);
            vehicleInformation.Add("Year: " + this.year.ToString());
            vehicleInformation.Add("Type: " + this.type);
            vehicleInformation.Add("Mileage: " + $"{this.mileage:n0}");
            vehicleInformation.Add("Condition: " + this.condition);
            vehicleInformation.Add("Color: " + this.color);
           // vehicleInformation.Add("Count: " + setVehicleImage());
        }

        public String getMake() => make;
        public String getModel() => model;
        public String getYear() => year.ToString();
        public String getType() => type;
        public String getCondition() => condition;
        public String getColor() => color;
        public String getMiles() => mileage.ToString();
        public String getId() => Id.ToString();

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

        public Image getVehicleImage()
        {
            string imagePath = "Vehicle\\" + this.Id.ToString() + ".jpeg";
            if (File.Exists(imagePath))
            {
                var image = Image.FromFile(imagePath);
                return image;
            }
            else
                return null;
        }

        public void updateRentalLife(int d)
        {
            this.totalRentalLife += d;
        }

        private void updateAverageRentalPeriod()
        {
            
        }

    }
}
