using rentACar2.Properties;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class Form1 : Form
    {
        IVehicleInventory lot;
        customerList database = new customerList();
        int currentVehicleIndex = 0;

        public Form1()
        {
            InitializeComponent();
            programStart();
            lot = new VehicleInventoryLocal();
            lot.loadInventory();
        }

        private void programStart()
        {
            setupPanels();
        }

        private void setupPanels()
        {
            carPictureBox.Image = carPictureBox.InitialImage;
            //rentalPanel.Controls.Add(InfoTabs);
            //loadInfoIntoTabs();

            this.TopMost = true;

            //this.WindowState = FormWindowState.Maximized;

            //int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;

            //int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            //InfoTabs.Width = rentalPanel.Width;

            //viewPanel.BorderStyle = BorderStyle.FixedSingle;
            //viewPanel.Left = rentalPanel.Width + 20;
            //viewPanel.Visible = true;
            //viewPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            ////viewPanel.Width = (int)(carPictureBox.Image.Width * 2);
            ////viewPanel.Height = (int)(screenHeight * 0.8);
            //viewPanel.Top = 35;
            //viewPanel.ForeColor = Color.Green;
            //viewPanel.BackColor = Color.Transparent;

            //carPictureBox.Visible = true;
            //carPictureBox.Left = 0;
            //carPictureBox.BorderStyle = BorderStyle.FixedSingle;
            //carPictureBox.Width = viewPanel.Width;
            //carPictureBox.Height = viewPanel.Height;


            //controlPanel.Top = carPictureBox.Bottom - 65;
            //controlPanel.Controls.Add(nextBtn);
            //controlPanel.Controls.Add(rentBtn);
            //controlPanel.Controls.Add(prevBtn);
            //controlPanel.Visible = true;
            //controlPanel.Left = (int)(viewPanel.Left * 1.5);


            //rentalPanel.Height = screenHeight;
            //rentalPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            nextBtn.ForeColor = Color.Green;
            rentBtn.ForeColor = Color.Blue;
            prevBtn.ForeColor = Color.YellowGreen;
            exitBtn.ForeColor = Color.DarkRed;
        }

        private void loadInfoIntoTabs()
        {
            //loadVehicleInfoTab();
            //loadCustomerInfoTab();

        }

        //private void loadCustomerInfoTab()
        //{
        //    InfoTabs.SelectedIndex = 0;
        //    TabPage customerTab = InfoTabs.SelectedTab;

        //    List<Label> customerLabels = setupCustomerLabels();

        //    int top = 0;

        //    customerLabels[0].ForeColor = Color.Green;

        //    foreach (Label l in customerLabels)
        //    {
        //        l.MaximumSize = new Size(customerTab.Width, 0);
        //        l.AutoSize = true;
        //        l.Top = top * 30;
        //        top++;
        //        customerTab.Controls.Add(l);
        //    }

        //}

        //private void loadVehicleInfoTab()
        //{
        //    InfoTabs.SelectedIndex = 1;
        //    TabPage vehicleTab = InfoTabs.SelectedTab;

        //    List<Label> vehicleLabels = setupVehicleLabels();

        //    int top = 0;

        //    foreach (Label l in vehicleLabels)
        //    {
        //        l.MaximumSize = new Size(vehicleTab.Width, 0);
        //        l.AutoSize = true;
        //        l.Top = top * 30;
        //        top++;
        //        vehicleTab.Controls.Add(l);
        //    }
        //}

        //private List<Label> setupVehicleLabels()
        //{
        //    Vehicle vehicle = getVehicleFromLot();

        //    List<Label> vehicleLabels = setupLabels(vehicle.getVehicleDetails());

        //    if (Int32.Parse(vehicle.getMiles) >= 30000) vehicleLabels[4].ForeColor = Color.Goldenrod;

        //    if (Int32.Parse(vehicle.getMiles) >= 60000) vehicleLabels[4].ForeColor = Color.DarkRed;

        //    if (Int32.Parse(vehicle.getYear()) <= 2010) vehicleLabels[2].ForeColor = Color.Goldenrod;

        //    if (Int32.Parse(vehicle.getMiles) <= 2000) vehicleLabels[2].ForeColor = Color.DarkRed;

        //    carPictureBox.Image = vehicle.setVehicleImage();

        //    return vehicleLabels;
        //}

        //private List<Label> setupCustomerLabels()
        //{
        //    Customer customer = getCustomerFromDatabase();

        //    List<Label> customerLabels = setupLabels(customer.getCustomerDetails());

        //    if (customer.getAge() < 21)
        //    {
        //        customerLabels[2].Font = new Font(customerLabels[2].Font.FontFamily, 15, FontStyle.Bold);
        //        customerLabels[2].ForeColor = Color.DarkRed;
        //    }
        //    return customerLabels;
        //}

        //private List<Label> setupLabels(string[] details)
        //{
        //    List<Label> labels = new List<Label>();

        //    foreach (string str in details)
        //    {
        //        Label temp = new Label();
        //        temp.Text = str;
        //        labels.Add(temp);
        //    }
        //    return labels;
        //}


        //public Customer getCustomerFromDatabase()
        //{
        //    var arr = database.getDatabase();

        //    return arr[count];
        //}

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
            lblDisplayMake.Text = veh.getMake();
            lblDisplayModel.Text = veh.getModel();
            lblDisplayYear.Text = veh.getYear();
            lblDisplayType.Text = veh.getType();
            lblDisplayMileage.Text = veh.getMiles();
            lblDisplayCondition.Text = veh.getCondition();
            lblDisplayColor.Text = veh.getColor();

            carPictureBox.Image = veh.getVehicleImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupVehicleDisplayInfo();

            
        }
    }
}
