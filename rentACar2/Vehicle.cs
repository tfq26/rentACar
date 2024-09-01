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
    public class vehicle
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
        private string finance;
        private int totalRentalLife; // Keeps track of the number of days the vehicle has been rented in its life cycle
        private double averageRentalPeriod; // Tracks the average rental period for a specific vehicle

        public vehicle()
        {
            vehicleInformation = new List<string>();
        }

        public vehicle(string make, string model, int year, string type, int miles, string condition,
            string color, string financable)
        {
            vehicleInformation = new List<string>();
            this.make = make;
            this.model = model;
            this.year = year;
            this.type = type;
            this.mileage = miles;
            this.condition = condition;
            this.color = color;
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
            bool isFin = bool.Parse(vehicleInfo[7]);
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
        public string getMiles => mileage.ToString();

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

        public Image setVehicleImage()
        {
            string str = string.Empty;
            int count = 0;
            var files = Directory.GetFiles("C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\Vehicle\\");
            var image = Image.FromFile(files[0]);
            return image;
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
