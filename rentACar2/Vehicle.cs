using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace RentalCarApplication
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
        private int seats;
        private int passengers;
        private int storage;
        private string drivetrain; 
        private int range;
        private int totalRentalLife; // Keeps track of the number of days the vehicle has been rented in its life cycle
        private double averageRentalPeriod; // Tracks the average rental period for a specific vehicle
        private string title;
        private Image vehcileImage;

        public Vehicle()
        {
            this.Id = Guid.Empty;
            this.make = "";
            this.model = "";
            this.year = 0;
            this.type = "";
            this.mileage = 0;
            this.condition = "";
            this.color = "";
            this.seats = 0;
            this.passengers = 0;
            this.storage = 0;
            this.drivetrain = "";
            this.range = 0;
            this.vehcileImage = RentalCarApplication.Properties.Resources.image_missing;
        }

        public Vehicle(string[] vehicleInfo)
        {
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
        }

        public Vehicle(string[] vehicleInfo, Image vehicleImage)
        {
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
            this.vehcileImage = vehicleImage;
        }

        //public string[] getVehicleDetails()
        //{
        //    String[] temp = vehicleInformation.ToArray();

        //    return temp;
        //}

        public String getMake() => make.Trim();
        public String getModel() => model.Trim();
        public String getYear() => year.ToString().Trim();
        public String getType() => type.Trim();
        public String getCondition() => condition.Trim();
        public String getColor() => color.Trim();
        public String getMiles() => mileage.ToString().Trim();
        public String getId() => Id.ToString().Trim().ToUpper();
        public String getSeats() => seats.ToString().Trim();
        public String getPassengers() => passengers.ToString().Trim();
        public String getStorage() => storage.ToString().Trim();
        public String getDrivetrain() => drivetrain.Trim();
        public String getRange() => range.ToString().Trim();
        public String getTitle() => (this.getYear() + " " + this.getMake() + " " + this.getModel());

        //public double getRate() => rate;

        public void setVehicleImage(string path)
        {
            try
            {
                vehcileImage = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error With setting new Image from path\n" + ex.ToString(), "Error in Vehicle Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vehcileImage = RentalCarApplication.Properties.Resources.image_missing;
            }
        }

        public void setVehicleImage(Image userImage)
        {
           try
            {
                vehcileImage = userImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error With setting new Image from image\n" + ex.Message, "Error in Vehicle Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Image getVehicleImage()
        {
            return vehcileImage;
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
