using rentACar2.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class HomeForm : System.Windows.Forms.Form
    {
        public List<Vehicle> lot;
        public List<Vehicle> currentLot;
        public List<Customer> database;
        static VehicleInventoryCloud vehiclesCloud;
        static VehicleInventoryLocal vehiclesLocal;
        int currentVehicleIndex = 0;
        private Dictionary<Vehicle, String> matchVehicles = new Dictionary<Vehicle, String>();
        private CustomerProfileForm customerProfileForm;
        private LoginForm loginForm;

        public HomeForm()
        {
            InitializeComponent();
            lot = new List<Vehicle>();
            database = new List<Customer>();
            vehiclesCloud = new VehicleInventoryCloud();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (currentVehicleIndex < matchVehicles.Keys.Count - 1)
            {
                currentVehicleIndex++;
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

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loginForm = LoginForm.loginForm;
            customerProfileForm = LoginForm.customerProfileForm;

            var vehicles = vehiclesCloud;

            foreach (Vehicle v in vehicles.getInventory())
            {
                lot.Add(v);
                string veh2Desc = $"{v.getYear()} {v.getMake()} {v.getModel()}";
                matchVehicles.Add(v, veh2Desc);
            }

            SetupVehicleDisplayInfo();

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

        private void SetupVehicleDisplayInfo()
        {
            Vehicle veh = matchVehicles.Keys.ToArray()[currentVehicleIndex];
            carPictureBox.Image = veh.getVehicleImage();

            lblDisplayVehicleTitle.Text = veh.getTitle();
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

        private void DisplayVehicleList()
        {
            listboxVehicles.Items.Clear();
            matchVehicles.Clear();
            currentVehicleIndex = 0;

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

                if (!matchVehicles.ContainsKey(veh))
                {
                    string veh2Desc = $"{veh.getYear()} {veh.getMake()} {veh.getModel()}";
                    matchVehicles.Add(veh, veh2Desc);
                    listboxVehicles.Items.Add(veh2Desc);
                }
            }
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
            //getVehicleFromDescription();
            currentVehicleIndex = listboxVehicles.SelectedIndex;
            SetupVehicleDisplayInfo();
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerProfileForm.Visible = true;
            this.Visible = false;
        }

        private void homeToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            homeToolStripMenuItem.DropDown.Close();
            BrowsePanel.Visible = true;
        }

        private void listboxVehicles_SelectedValueChanged(object sender, EventArgs e)
        {
            //getVehicleFromDescription();
            currentVehicleIndex = listboxVehicles.SelectedIndex;
            SetupVehicleDisplayInfo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm.Visible = true;
            this.Visible = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerProfileForm.Visible = true;
            customerProfileForm.editToolStripMenuItemProfile_Click(sender, e);
            this.Visible = false;
        }
    }
}
