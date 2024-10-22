using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using RentalCarApplication.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    public class CustomerInventoryCloud : ICustomerInventory
    {
        public List<Customer> Customers = new List<Customer>();
        public Dictionary<string, string> customerLoginDetails = new Dictionary<string, string>();
        private string informationPath;
        private string imagesPath;
        public string testStr;
        private string connectionString = string.Empty;
        private string cloudFilePath;

        public CustomerInventoryCloud()
        {
            loadCloud();
            loadInventory();
        }

        private void loadCloud()
        {
            if (File.Exists(informationPath))
            {
                File.Delete(informationPath);
            }

            if (Directory.Exists(imagesPath))
            {
                Directory.Delete(imagesPath);
            }

            cloudFilePath = "C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\dw";
            //Enumerator to read through the connectionString File and find the correct connectionString file
            foreach (string f in Directory.EnumerateFiles("C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\cloudresx\\", "*.txt"))
            {
                connectionString = File.ReadAllText(f).Trim();
            }

            var blobServiceClient = new BlobServiceClient(connectionString);

            BlobContainerClient customerInformationContainer = null;
            BlobContainerClient customerImagesContainer = null;

            try
            {
                customerImagesContainer = blobServiceClient.GetBlobContainerClient("customerimages");
                customerInformationContainer = blobServiceClient.GetBlobContainerClient("customerinformation");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Accessing Customer Blobs");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            informationPath = cloudFilePath + "\\customerCloudFile.txt";
            imagesPath = cloudFilePath + "\\customerImages";

            if (!File.Exists(informationPath))
            {
                DialogResult result = MessageBox.Show("Customer info file not found, would you like to create it?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    File.CreateText(informationPath);
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            if (!Directory.Exists(imagesPath))
            {
                DialogResult result = MessageBox.Show("Customer Image Directory not found, would you like to create it?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.CreateDirectory(imagesPath);

                        if (Directory.Exists(imagesPath))
                        {
                            MessageBox.Show("Images Directory Exists");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error creating directory: {ex.Message}");
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            foreach (BlobItem item in customerInformationContainer.GetBlobs())

            {
                BlobClient informationClient = new BlobClient(connectionString, customerInformationContainer.Name, item.Name);

                informationClient.DownloadTo(informationPath);

            }

            foreach (BlobItem item in customerImagesContainer.GetBlobs())
            {
                BlobClient imagesClient = new BlobClient(connectionString, customerImagesContainer.Name, item.Name);
                try
                { 
                    if (!File.Exists((imagesPath + "\\" + imagesClient.Name)))
                        imagesClient.DownloadTo(File.Create(imagesPath + "\\" + imagesClient.Name));

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error loading Customer images from cloud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            loadInventory(informationPath, imagesPath);
        }

        public void addCustomer(Customer c)
        {
            Customers.Add(c); 
        }

        private void addCustomerDetails(Customer c)
        {
            if (checkforCustomer(c))
            {
                customerLoginDetails.Add(c.getEmail().Trim(), c.getPassword().Trim());
            }
        }

        public Customer[] getInventory()
        {
            Customer[] arr = Customers.ToArray();
            return arr; 
        }

        public void removeCustomer(Customer c)
        {
            Customers.Remove(c);
        }

        public Boolean checkforCustomer(Customer c)
        {
            if (Customers.Contains(c))
            {
                return true;
            }
            return false;
        }

        public Boolean checkforCustomer(string id)
        {
            foreach (Customer c in Customers)
            {
                if (c.getId().Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean checkforCustomer(string email, string password)
        {
            if (customerLoginDetails.ContainsKey(email))
                if (customerLoginDetails.ContainsValue(password))
                    return true;
            return false;
        }

        public int getInventoryCount()
        {
            return Customers.Count;
        }

        public void loadInventory()
        {
            loadInventory(informationPath, imagesPath);
        }

        public void uploadCustomer(Customer c)
        {

        }

        public Customer getCustomer(string email, string password)
        {
            foreach(Customer c in Customers)
            {
                if (c.getEmail().Trim().Equals(email))
                {
                    return c;
                }
            }

            return new Customer();
        }

        private void loadInventory(string customerInfomationPath, string customerImagePath)
        {
            Customers.Clear();
            customerLoginDetails.Clear();

            if (File.Exists(customerInfomationPath))
            {
                string[] lines = File.ReadAllLines(customerInfomationPath);

                Customer c = null;

                foreach (string line in lines)
                {
                    c = null;
                    if (line.StartsWith("GUID"))
                        continue;
                    c = new Customer(line.Split(","));
                    Customers.Add(c);
                    addCustomerDetails(c);
                    if (File.Exists(customerInfomationPath))
                    {
                        foreach (string file in Directory.GetFiles(customerImagePath))
                        {
                            if (file.Contains(c.getId().ToUpper()) || file.Contains(c.getFirstName().ToUpper()))
                            {
                                c.setCustomerImage(Image.FromFile(file));
                            }
                        }
                    } else
                    
                    {
                        MessageBox.Show("Customer Image Directory Not Found");
                    }
                }
            }
            else
            {
                MessageBox.Show("Customer info file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
