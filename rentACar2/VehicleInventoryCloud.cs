using rentACar2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using System.IO;

namespace rentACar2
{
    internal class VehicleInventoryCloud : IVehicleInventory
    {
        public List<Vehicle> vehicleList = new List<Vehicle>();
        public string testStr;
        private string connectionString;

        public VehicleInventoryCloud()
        {
            blobManager();
        }

        private void blobManager()
        {
            var filename = @"C:\temp\connectionStr.txt";

            // Read connection string
            connectionString = File.ReadAllText(filename);

            var blobServiceClient = new BlobServiceClient(
        new Uri("https://<storage-account-name>.blob.core.windows.net"),
        new DefaultAzureCredential());

            BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, "null");

            try
            
            { 
                blobContainerClient = blobServiceClient.GetBlobContainerClient("vehicleinformation");
            }
            
            catch (Exception ex)
            
            {
                MessageBox.Show("Error accessing Vehicle Information");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

             string downloadFilePath = "cloudresx\\";

            foreach (BlobItem item in blobContainerClient.GetBlobs())
            
            {
                BlobClient blobClient = new BlobClient(connectionString, blobContainerClient.Name, item.Name);
                
                //blobClient.Upload()
            }

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
            //blobManager();
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
