using rentACar2.Properties;
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

        }

        

        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point location = this.viewPanel.Location;

            this.viewPanel.Visible = false;

            this.
        }
    }
}
