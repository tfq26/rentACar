﻿
using RentalCarApplication.Properties;
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
using RentalCarApplication;

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
        private CloudManager cloudManager;

        public VehicleInventoryCloud()
        {
            cloudFilePath = @"cloudresx";
            cloudManager = new CloudManager(cloudFilePath);
            informationPath = @"dw";
            imagePath = @"dw\images";
            cloudManager.downloadContainer("vehicleInformation", informationPath);
            cloudManager.downloadContainer("vehicleInformation", imagePath);
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
                        }
                    }
                    vehicleList.Add(v);
                }
            }
            else
            {
                MessageBox.Show("Vehicle info file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
