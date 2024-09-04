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
    public class CustomerList
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
        private int seats;
        private int passengers;
        private int storage;
        private string drivetrain;
        private int range;
        private int totalRentalLife; // Keeps track of the number of days the vehicle has been rented in its life cycle
        private double averageRentalPeriod; // Tracks the average rental period for a specific vehicle
        private string errorMsg;

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
            this.seats = Int32.Parse(vehicleInfo[8]);
            this.passengers = Int32.Parse(vehicleInfo[9]);
            this.storage = Int32.Parse(vehicleInfo[10]);
            this.drivetrain = vehicleInfo[11];
            this.range = Int32.Parse(vehicleInfo[12]);
            this.errorMsg = string.Empty;
        }

        public string[] getVehicleDetails()
        {
            String[] temp = vehicleInformation.ToArray();

            return temp;
        }

        public String getMake() => make.Trim();
        public String getModel() => model.Trim();
        public String getYear() => year.ToString().Trim();
        public String getType() => type.Trim();
        public String getCondition() => condition.Trim();
        public String getColor() => color.Trim();
        public String getMiles() => mileage.ToString().Trim();
        public String getId() => Id.ToString().Trim();
        public String getSeats() => seats.ToString().Trim();
        public String getPassengers() => passengers.ToString().Trim();
        public String getStorage() => storage.ToString().Trim();
        public String getDrivetrain() => drivetrain.Trim();
        public String getRange() => range.ToString().Trim();
        public String getErrorMsg() => this.errorMsg;

        //public double getRate() => rate;
        public void setErrorMsg(String message)
        {
            this.errorMsg = message;
        }

        public Image getVehicleImage()
        {
            string imagePath = "Vehicle\\" + this.Id.ToString() + ".jpeg"; 
            Image image = null;
            
            try
            {
                image = Image.FromFile(imagePath);
                setErrorMsg(this.getYear() + " " + this.getMake() + " " + this.getModel());
                return image;
            }
            catch (Exception ex)
            {
                setErrorMsg("Error With Loading Image");
                return image;
            }
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
