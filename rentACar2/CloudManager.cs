using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace RentalCarApplication
{
    internal class CloudManager
    {

        private string connectionStr = string.Empty;
        private string cloudResxPath = string.Empty;
        private string path = string.Empty;

        public CloudManager(string cloudResxPath)
        {
            this.cloudResxPath = cloudResxPath;
            //connectionStr = File.ReadAllText(cloudResxPath + "*.txt").Trim();
            //connectionStr = "DefaultEndpointsProtocol=https;AccountName=storage2608;AccountKey=4bFTW2bjmXSdoKcwTtLdvFTUdsexC9d0/yogv4TNWGQZz+bIn9RIVbtTH1m1gHcvR8SrPp7VxCxg+AStMmakww==;EndpointSuffix=core.windows.net";
        }

        public void downloadContainer(string ContainerName, string path)
        {
            ContainerName = ContainerName.ToLower();

            this.path = path;

            var blobServiceClient = new BlobServiceClient(connectionStr);

            BlobContainerClient Container = new BlobContainerClient(connectionStr, "null");

            try

            {
                Container = blobServiceClient.GetBlobContainerClient(ContainerName);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error downloading from Container" + ex.Message);
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            foreach (BlobItem item in Container.GetBlobs())

            {
                BlobClient containerClient = new BlobClient(connectionStr, Container.Name, item.Name);

                try
                {
                    Directory.Exists(Path.Combine(path, item.Name));
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show("Local Directory does not exist\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                }

                try
                {
                    File.CreateText(Path.Combine(path, item.Name)).Dispose();
                    containerClient.DownloadTo(Path.Combine(path, containerClient.Name));
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show("Error downloading Information locally from cloud\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    if (result == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void downloadContainer(string ContainerName, string path, string blobName)
        {
            this.path = path;

            var blobServiceClient = new BlobServiceClient(connectionStr);

            BlobContainerClient Container = new BlobContainerClient(connectionStr, "null");

            try

            {
                Container = blobServiceClient.GetBlobContainerClient(ContainerName);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error accessing Container" + ex.Message);
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            foreach (BlobItem item in Container.GetBlobs())
            {
                if (item.Name == blobName)
                {

                    BlobClient containerClient = new BlobClient(connectionStr, Container.Name, item.Name);

                    try
                    {
                        if (!File.Exists((path + "\\" + containerClient.Name)))
                            containerClient.DownloadTo(File.Create(path + "\\" + containerClient.Name));

                    }
                    catch (Exception e)
                    {
                        DialogResult result = MessageBox.Show("Error loading Information from cloud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        public void uploadContainer(string ContainerName, string uploadPath)
        {
            var blobServiceClient = new BlobServiceClient(connectionStr);

            BlobContainerClient Container = null;

            try

            {
                Container = new BlobContainerClient(connectionStr, ContainerName);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error uploading to Container" + ex.Message);
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            foreach (BlobItem item in Container.GetBlobs())
            {
                BlobClient containerClient = new BlobClient(connectionStr, Container.Name, item.Name);

                try
                {
                    if (!File.Exists((uploadPath)))
                        containerClient.Upload(uploadPath);
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show("Error uploading local Information to cloud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
