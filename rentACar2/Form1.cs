using rentACar2.Properties;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class Form1 : Form
    {
        inventory lot = new inventory();
        customerList database = new customerList();
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            programStart();
        }

        private void programStart()
        {
           setupPanels();
        }

        private void setupPanels()
        {
            carPictureBox.Image = carPictureBox.InitialImage;
            rentalPanel.Controls.Add(InfoTabs);
            loadInfoIntoTabs();

            this.TopMost = true;

            this.WindowState = FormWindowState.Maximized;

            int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;

            int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            InfoTabs.Width = rentalPanel.Width;

            viewPanel.BorderStyle = BorderStyle.FixedSingle;
            viewPanel.Left = rentalPanel.Width + 20;
            viewPanel.Visible = true;
            viewPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            viewPanel.Width = (int)(carPictureBox.Image.Width);
            viewPanel.Height = (int)(screenHeight * 0.8);
            viewPanel.Top = 35;
            viewPanel.ForeColor = Color.Green;
            viewPanel.BackColor = Color.Transparent;

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
            controlPanel.Left = (int)(viewPanel.Left * 1.5);
            

            rentalPanel.Height = screenHeight;
            rentalPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            nextBtn.ForeColor = Color.Green;
            rentBtn.ForeColor =  Color.Blue;
            prevBtn.ForeColor = Color.YellowGreen;
            exitBtn.ForeColor = Color.DarkRed;
        }

        private void loadInfoIntoTabs()
        {
            loadVehicleInfoTab();
            loadCustomerInfoTab();

        }

        private void loadCustomerInfoTab()
        {
            InfoTabs.SelectedIndex = 0;
            TabPage customerTab = InfoTabs.SelectedTab;

            List<Label> customerLabels = setupCustomerLabels();

            int top = 0;

            customerLabels[0].ForeColor = Color.Green;

            foreach (Label l in customerLabels)
            {
                l.MaximumSize = new Size(customerTab.Width, 0);
                l.AutoSize = true;
                l.Top = top * 30;
                top ++;
                customerTab.Controls.Add(l);
            }

        }

        private void loadVehicleInfoTab()
        {
            InfoTabs.SelectedIndex = 1;
            TabPage vehicleTab = InfoTabs.SelectedTab;

            List<Label> vehicleLabels = setupVehicleLabels();

            int top = 0;

            foreach(Label l in vehicleLabels)
            {
                l.MaximumSize = new Size(vehicleTab.Width, 0);
                l.AutoSize = true;
                l.Top = top * 30;
                top++;
                vehicleTab.Controls.Add(l);
            }
        }

        private List<Label> setupVehicleLabels()
        {
            vehicle vehicle = getVehicleFromLot();

            List<Label> vehicleLabels = setupLabels(vehicle.getVehicleDetails());

            if(Int32.Parse(vehicle.getMiles) >= 30000) vehicleLabels[4].ForeColor = Color.Goldenrod;

            if (Int32.Parse(vehicle.getMiles) >= 60000) vehicleLabels[4].ForeColor = Color.DarkRed;

            if (Int32.Parse(vehicle.getYear()) <= 2010) vehicleLabels[2].ForeColor = Color.Goldenrod;

            if (Int32.Parse(vehicle.getMiles) <= 2000) vehicleLabels[2].ForeColor = Color.DarkRed;

            carPictureBox.Image = vehicle.setVehicleImage();

            return vehicleLabels;
        }

        private List<Label> setupCustomerLabels()
        {
            customer customer = getCustomerFromDatabase();

            List<Label> customerLabels = setupLabels(customer.getCustomerDetails());

            if (customer.getAge() < 21)
            {
                customerLabels[2].Font = new Font(customerLabels[2].Font.FontFamily, 15, FontStyle.Bold);
                customerLabels[2].ForeColor = Color.DarkRed;
            }
            return customerLabels;
        }

        private List<Label> setupLabels(string[] details)
        {
            List<Label> labels = new List<Label>();

            foreach(string str in details)
            {
                Label temp = new Label();
                temp.Text = str;
                labels.Add(temp);
            }
            return labels;
        }

        public vehicle getVehicleFromLot()
        {
            var arr = lot.getInventory();

            return arr[count];

        }

        //public string getVehicleFromLot() //Old Implementation
        //{
        //    string returnStr = string.Empty;

        //    var arr = lot.getInventory();

        //    var len = arr.Length;

        //    returnStr += arr[count].getVehicleDetails();

        //    return returnStr;
        //}

        public customer getCustomerFromDatabase()
        {
            var arr = database.getDatabase();

            return arr[count];
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            var len = lot.getInventory().Length;
            if (count < len)
            {
                count++;
            }
            
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            var len = lot.getInventory().Length;
            if (count < len)
            {
                count--;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
