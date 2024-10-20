using rentACar2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using System.IO;
using System.DirectoryServices;
using System.IO.Enumeration;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace rentACar2
{
    public class VehicleInventoryCloud : IVehicleInventory
    {
        public List<Vehicle> vehicleList = new List<Vehicle>();
        public string testStr;
        private string connectionString = string.Empty;
        private string cloudFilePath;
        private string imagePath;
        private string informationPath;

        public VehicleInventoryCloud()
        {
            blobManager();
        }

        private void blobManager()
        {

            cloudFilePath = "C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\dw";
            //Enumerator to read through the connectionString File and find the correct connectionString file
            foreach (string f in Directory.EnumerateFiles("C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\cloudresx\\", "*.txt"))
            {
                connectionString = File.ReadAllText(f).Trim();
            }

            //connectionString = "DefaultEndpointsProtocol=https;AccountName=storage2608;AccountKey=4bFTW2bjmXSdoKcwTtLdvFTUdsexC9d0/yogv4TNWGQZz+bIn9RIVbtTH1m1gHcvR8SrPp7VxCxg+AStMmakww==;EndpointSuffix=core.windows.net";
            var blobServiceClient = new BlobServiceClient(connectionString.ToString());

            BlobContainerClient vehicleInformationContainer = new BlobContainerClient(connectionString, "null");
            BlobContainerClient vehicleImagesContainer = new BlobContainerClient(connectionString, "null");

            try

            {
                vehicleImagesContainer = blobServiceClient.GetBlobContainerClient("vehicleimages");
                vehicleInformationContainer = blobServiceClient.GetBlobContainerClient("vehicleinformation");
            }
            
            catch (Exception ex)
            
            {
                MessageBox.Show("Error accessing Vehicle Information");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
           
            informationPath = cloudFilePath + "\\cloudFile.txt";
            imagePath = cloudFilePath + "\\images";

            if (!File.Exists(informationPath))
            {
                DialogResult result = MessageBox.Show("Vehicle info file not found, would you like to create it?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    File.CreateText(informationPath);
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            foreach (BlobItem item in vehicleInformationContainer.GetBlobs())
            
            {
                BlobClient informationClient = new BlobClient(connectionString, vehicleInformationContainer.Name, item.Name);
                informationClient.DownloadTo(informationPath);

            }

            foreach (BlobItem item in vehicleImagesContainer.GetBlobs())
            {
                BlobClient imagesClient = new BlobClient(connectionString, vehicleImagesContainer.Name, item.Name);
                try
                {
                    if (!File.Exists((imagePath + "\\" + imagesClient.Name)))
                        imagesClient.DownloadTo(File.Create(imagePath + "\\" + imagesClient.Name));

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error loading Vehicle images from cloud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            loadInventory(informationPath, imagePath);

            File.CreateText(informationPath).Close();
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
            loadInventory(informationPath, imagePath);
        }
        private void loadInventory(string vehicleInfomationPath, string vehicleImagePath)
        {
            if (File.Exists(vehicleInfomationPath))
            {
                string[] lines = File.ReadAllLines(vehicleInfomationPath);

                Vehicle v = null;

                foreach (string line in lines)
                {
                    v = null;
                    if (line.StartsWith("Id"))
                        continue;
                    v = new Vehicle(line.Split(","));
                    foreach (string file in Directory.GetFiles(vehicleImagePath))
                    {
                        if (file.Contains(v.getId()))
                        {
                            v.setVehicleImage(Image.FromFile(file));
                            vehicleList.Add(v);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vehicle info file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
