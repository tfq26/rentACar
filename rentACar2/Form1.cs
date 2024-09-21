using rentACar2.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class Carpick : Form
    {
        public List<Vehicle> lot;
        public List<Customer> database;
        public List<int> indices;
        int currentVehicleIndex = 0;
        private Dictionary<Vehicle, String> matchVehicles = new Dictionary<Vehicle, String>();
        VehicleInventoryLocal localVeh = new VehicleInventoryLocal();
        //VehicleInventoryCloud localVeh = new VehicleInventoryCloud();
        CustomerInventoryLocal localCus = new CustomerInventoryLocal();


        public Carpick()
        {
            InitializeComponent();
            lot = new List<Vehicle>();
            database = new List<Customer>();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (currentVehicleIndex < indices.Count)
            {
                count++;
                currentVehicleIndex = indices[count];
            }
            SetupVehicleDisplayInfo();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentVehicleIndex > 0)
            {
                currentVehicleIndex = currentVehicleIndex - 1;
            }
            SetupVehicleDisplayInfo();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupSplashInfo();
            foreach (Vehicle v in localVeh.getInventory())
            {
                lot.Add(v);
            }

            foreach (Customer c in localCus.getInventory())
            {
                database.Add(c);
            }

            SetupVehicleDisplayInfo();
            SetupProfileDisplayInfo();

            Dictionary<string, bool> makesList = new Dictionary<string, bool>();
            Dictionary<string, bool> typesList = new Dictionary<string, bool>();
            typesList.Add("", true);
            makesList.Add("", true);

            foreach (Vehicle veh in lot)
            {
                if (!typesList.ContainsKey(veh.getType()))
                {
                    typesList.Add(veh.getType(), true);
                }
                if (!makesList.ContainsKey(veh.getMake()))
                {
                    makesList.Add(veh.getMake(), true);
                }
            }

            comboMake.Items.Clear();
            comboMake.Items.AddRange(makesList.Keys.ToArray());

            comboType.Items.Clear();
            comboType.Items.AddRange(typesList.Keys.ToArray());

            DisplayVehicleList();
        }

        private void setupSplashInfo()
        {
            lblDisplayError.Visible = false;
            mainPanel.Controls.Add(BrowsePanel);
            mainPanel.Controls.Add(MainMenuStrip);
            mainPanel.Controls.Add(listPanel);
            mainPanel.Controls.Add(MenuBar);
            mainPanel.Controls.Add(splashPanel);

            foreach (Control item in mainPanel.Controls)
            {
                if (item != splashPanel)
                {
                    item.Visible = false;
                }
            }
        }

        private void checkLogin(string userEmail, string userPassword)
        {
            if (localCus.checkforCustomer(userEmail, userPassword))
            {
                foreach (Control item in mainPanel.Controls)
                {
                    if ((item != splashPanel))
                    {
                        item.Visible = true;
                        item.Enabled = true;
                    }
                }
                splashPanel.Visible = false;
            }
            else
            {
                lblDisplayError.Visible = true;
                lblDisplayError.Text = "User not found";
            }
        }

        private void SetupVehicleDisplayInfo()
        {
            //Vehicle veh = (Vehicle)lot[currentVehicleIndex];
            Vehicle veh = (Vehicle)lot[0];
            carPictureBox.Image = veh.getVehicleImage();

            lblDisplayVehicleTitle.Text = veh.getErrorMsg();
            lblDisplayType.Text = veh.getType();
            lblDisplayMileage.Text = veh.getMiles();
            lblDisplayColor.Text = veh.getColor();
            lblDisplayDrivetrain.Text = veh.getDrivetrain();

            lblDisplaySeats.Text = veh.getSeats();
            lblDisplayPassengers.Text = veh.getPassengers();
            lblDisplayStorage.Text = veh.getStorage();
            lblDisplayDrivetrain.Text = veh.getDrivetrain();
            lblDisplayRange.Text = veh.getRange();

            lblCombo1.Text = "Make";
            lblCombo2.Text = "Type";
        }

        private void SetupProfileDisplayInfo()
        {
            Customer cus = (Customer)database[0];

            //carPictureBox.Image = cus.getVehicleImage();

            lblDisplayFirst.Text = cus.getFirstName();
            lblDisplayLast.Text = cus.getLastName();
            lblDisplayAge.Text = cus.getAge().ToString();
            lblDisplayPhone.Text = cus.getPhone();
            lblDisplayEmail.Text = cus.getEmail();
            boxDisplayID.Text = cus.getIdNum().ToString();

        }

        private void DisplayVehicleList()
        {
            listboxVehicles.Items.Clear();
            matchVehicles.Clear();
            Dictionary<Vehicle, int> vehicleList = new Dictionary<Vehicle, int>();
            int count = 0;
            foreach (Vehicle veh in lot)
            {

                if (veh.getMake() != comboMake.Text && comboMake.Text != "")
                {
                    continue;
                }

                if (veh.getType() != comboType.Text && comboType.Text != "")
                {
                    continue;
                }

                if (!vehicleList.ContainsKey(veh))
                {
                    int temp = lot.IndexOf(veh);
                    vehicleList.Add(veh, temp);
                }
            }

            foreach (int index in vehicleList.Values)
            {
                Vehicle veh2 = lot[index];
                string veh2Desc = $"{veh2.getYear()} {veh2.getMake()} {veh2.getModel()}";
                matchVehicles.Add(veh2, veh2Desc);
            }
            //matchVehicles.Add(new Vehicle(), "");
            listboxVehicles.Items.AddRange(matchVehicles.Values.ToArray());
            indices = vehicleList.Values.ToList();
            if (indices.Count > 0)
                currentVehicleIndex = indices[0];
        }

        private void DisplayCustomerList()
        {
            Dictionary<Customer, String> customerList = new Dictionary<Customer, String>();

            foreach (Customer cus in database)
            {
                string vehicleDesc = $"{cus.getFirstName()} {cus.getLastName()}";

                if (!customerList.ContainsKey(cus))
                {
                    customerList.Add(cus, vehicleDesc);
                }
            }

            listboxVehicles.Items.Clear();
            listboxVehicles.Items.AddRange(customerList.Values.ToArray());
            database.Clear();
            database = customerList.Keys.ToList();
            currentVehicleIndex = 0;
        }

        private void comboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayVehicleList();
            SetupVehicleDisplayInfo();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayVehicleList();
            SetupVehicleDisplayInfo();
        }

        private void listboxVehicles_Click(object sender, EventArgs e)
        {
            getVehicleFromDescription();
            currentVehicleIndex = listboxVehicles.SelectedIndex;
        }

        private void getVehicleFromDescription()
        {
            for (int i = 0; i < lot.Count; i++)
            {
                string selectedVehicleDetails = listboxVehicles.Items[listboxVehicles.SelectedIndex].ToString();
                if (selectedVehicleDetails.Contains(lot[i].getMake()) && selectedVehicleDetails.Contains(lot[i].getModel()))
                {
                    currentVehicleIndex = i;

                    lblDisplayRange.Text = i.ToString();
                }
            }
            SetupVehicleDisplayInfo();
        }


        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowsePanel.Visible = true;
            profilePanel.Visible = false;
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowsePanel.Visible = true;
            profilePanel.Visible = false;
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = true;
        }

        private void homeToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            homeToolStripMenuItem.DropDown.Close();
            BrowsePanel.Visible = true;
            profilePanel.Visible = false;
        }

        private void listboxVehicles_SelectedValueChanged(object sender, EventArgs e)
        {
            getVehicleFromDescription();
            SetupVehicleDisplayInfo();
        }

        private void lblDisplayRentalNum_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDisplayAge_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayLast_Click(object sender, EventArgs e)
        {

        }

        private void checkLogin(object sender, EventArgs e)
        {
            checkLogin(boxUsernameLogin.Text, boxPasswordLogin.Text);
        }

        private void enterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkLogin(boxUsernameLogin.Text, boxPasswordLogin.Text);
            }
        }
    }
}
