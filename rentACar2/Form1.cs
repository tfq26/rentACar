using rentACar2.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class Carpick : Form
    {
        IVehicleInventory lot;
        customerList database = new customerList();
        int currentVehicleIndex = 0;

        public Carpick()
        {
            InitializeComponent();
            lot = new VehicleInventoryLocal();
            lot.loadInventory();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentVehicleIndex < lot.getInventoryCount() - 1)
            {
                currentVehicleIndex = currentVehicleIndex + 1;
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

        private void SetupVehicleDisplayInfo()
        {
            Vehicle veh = lot.getInventory()[currentVehicleIndex];

            carPictureBox.Image = veh.getVehicleImage();


            //lblDisplayVehicleTitle.Text = veh.getYear() + " " + veh.getMake() + " " + veh.getModel();

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupVehicleDisplayInfo();

            Dictionary<string, bool> makesList = new Dictionary<string, bool>();
            Dictionary<string, bool> typesList = new Dictionary<string, bool>();
            typesList.Add("", true);
            makesList.Add("", true);

            foreach (Vehicle veh in lot.getInventory())
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

        private void DisplayVehicleList()
        {
            Dictionary<string, bool> vehicleList = new Dictionary<string, bool>();

            foreach (Vehicle veh in lot.getInventory())
            {
                string vehicleDesc = $"{veh.getYear()} {veh.getMake()} {veh.getModel()}";

                if (veh.getMake() != comboMake.Text && comboMake.Text != "")
                {
                    continue;
                }

                if (veh.getType() != comboType.Text && comboType.Text != "")
                {
                    continue;
                }

                if (!vehicleList.ContainsKey(vehicleDesc))
                {
                    vehicleList.Add(vehicleDesc, true);
                }
            }

            listboxVehicles.Items.Clear();
            listboxVehicles.Items.AddRange(vehicleList.Keys.ToArray());
        }

        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point location = this.viewPanel.Location;

            this.viewPanel.Visible = false;

            //this.
        }

        private void comboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayVehicleList();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayVehicleList();
        }
    }
}
