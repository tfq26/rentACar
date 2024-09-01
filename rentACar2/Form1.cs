using rentACar2.Properties;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class Form1 : Form
    {
        inventory lot = new inventory();
        //inventory lot;
        private int carCount = 1;
        private Label vehicleLabel;
        private Label customerLabel;


        public Form1()
        {
            InitializeComponent();
            programStart();
        }

        private void programStart()
        {
            carPictureBox.Image = carPictureBox.InitialImage;
            rentalPanel.Controls.Add(vehicleInfoTabs);
            loadInfoIntoTabs();

            //this.lot.createInventory();

            this.TopMost = true;

            this.WindowState = FormWindowState.Maximized;

            int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;

            int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            vehicleInfoTabs.Width = rentalPanel.Width;

            viewPanel.BorderStyle = BorderStyle.FixedSingle;
            viewPanel.Left = rentalPanel.Width + 20;
            viewPanel.Visible = true;
            viewPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            viewPanel.Width = (int)(screenWidth * 0.59);
            viewPanel.Height = (int)(screenHeight * 0.8);

            carPictureBox.Visible = true;
            carPictureBox.Left = 0;
            carPictureBox.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox.Width = viewPanel.Width;
            carPictureBox.Height = viewPanel.Height;

            controlPanel.Top = carPictureBox.Bottom - 65;
            controlPanel.Controls.Add(nextBtn);
            controlPanel.Controls.Add(rentBtn);
            controlPanel.Controls.Add(prevBtn);
            controlPanel.Visible = true;
            controlPanel.Left = viewPanel.Left + 100;

            rentalPanel.Height = screenHeight;
            rentalPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
        }

        private void loadInfoIntoTabs()
        {
            loadVehicleInfoTab();
            loadCustomerInfoTab();

        }

        private void loadCustomerInfoTab()
        {
            rentalPage.Width = 185;
            vehicleInfoTabs.SelectedIndex = 0;
            TabPage RentalTab = vehicleInfoTabs.SelectedTab;
            customerLabel = new Label();
            customerLabel.MaximumSize = new Size(RentalTab.Width, 0);
            customerLabel.AutoSize = true;
            customer c1 = new customer("John", "Nolan", 48, 1234567890, "john_nolan@rookies.com", "555-123-4567");
            customerLabel.Text = c1.getCustomerDetails();
            RentalTab.Controls.Add(customerLabel);

            // customerLabel.Refresh();
        }

        private void loadVehicleInfoTab()
        {
            //vehicleInfoTabs.Width = rentalPage.Width;
            //vehiclePage.Width = rentalPage.Width;
            ////vehicleInfoTabs.SelectedIndex = 1;
            //vehicleLabel = new Label();
            //TabPage vehicleTab = vehicleInfoTabs.SelectedTab;
            //vehicleLabel.AutoSize = true;

            //vehicleTab.Controls.Add(vehicleLabel);
            vehicleLabel = new Label();

            vehicleInfoTabs.SelectedIndex = 1;
            TabPage vehicleTab = vehicleInfoTabs.SelectedTab;

            vehicleLabel.MaximumSize = new Size(vehicleTab.Width, 0);
            vehicleLabel.AutoSize = true;
            //customer c1 = new customer("John", "Nolan", 48, 1234567890, "john_nolan@rookies.com", "555-123-4567");
            //vehicleLabel.Text = c1.getCustomerDetails();
            vehicleLabel.Text += getVehicleFromLot();
            vehicleLabel.Refresh();
            vehicleTab.Controls.Add(vehicleLabel);

        }

        public string getVehicleFromLot()
        {
            string returnStr = string.Empty;

            var arr = lot.getInventory();

            var len = arr.Length;

            returnStr += arr[carCount].getVehicleDetails();

            return returnStr;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            var len = lot.getInventory().Length;
            if (carCount < len)
            {
                carCount++;
            }
            vehicleLabel.Refresh();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            var len = lot.getInventory().Length;
            if (carCount < len)
            {
                carCount--;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
