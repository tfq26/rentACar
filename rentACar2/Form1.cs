using rentACar2.Properties;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class Form1 : Form
    {
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
            this.TopMost = true;
            //  this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
           
            int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            //rentalPanel.Width = (int)(screenWidth * 0.3);
            //rentalPanel.Height = (int)(screenHeight * 0.85);
            //vehicleInfoTabs.Width = rentalPanel.Width;
            //vehicleInfoTabs.Height = rentalPanel.Height;

            //controlPanel.Top = 34;
            //controlPanel.Left = rentalPanel.Width;

            //controlPanel.Width = (int)(screenWidth * 0.5);
            //controlPanel.Height = (int)(screenHeight * 0.85);

            //controlPanel.Controls.Add(carPictureBox);
            //controlPanel.Controls.Add(nextBtn);
            //controlPanel.Controls.Add(rentBtn);
            //controlPanel.Controls.Add(prevBtn);

            //carPictureBox.Width = controlPanel.Width;
            //carPictureBox.Height = controlPanel.Height;

           /* rentalPanel.Width = (int)(screenWidth * 0.2);
            rentalPanel.Height = (int)(screenHeight * 0.92);
            vehicleInfoTabs.Width = rentalPanel.Width;
            vehicleInfoTabs.Height = rentalPanel.Height;

            //controlPanel.Left = rentalPanel.Width + 20;

            viewPanel.Width = (int)(screenWidth * 0.4); 
            viewPanel.Height = (int)(screenHeight * 0.8);
           // viewPanel.Controls.Add(carPictureBox);
          //  viewPanel.Controls.Add(controlPanel);
            viewPanel.BorderStyle = BorderStyle.Fixed3D;

            carPictureBox.Width = viewPanel.Width;
            carPictureBox.Height = (int)(viewPanel.Height * 0.5);
            controlPanel.Top = (int)(carPictureBox.Top + (carPictureBox.Height * 1.7));
            
            controlPanel.Controls.Add(nextBtn);
            controlPanel.Controls.Add(rentBtn);
            controlPanel.Controls.Add(prevBtn);
            controlPanel.Height = 10;


            controlPanel.BorderStyle = BorderStyle.FixedSingle;
          

            foreach (Control control in rentalPanel.Controls)
            {
                control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            }

            foreach (Control control in viewPanel.Controls)
            {
                control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
*/

            //Left off trying to change the panel heights to match display

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
            loadRentalInfoTab();
        }

        private void loadRentalInfoTab()
        {
            readFromDatabase reader = new readFromDatabase("C:\\Users\\taufe\\source\\repos\\rentACar2\\rentACar2\\resx\\database.txt.txt");

            string[] vehicleInfo = reader.getText();

            rentalPage.Width = 100;
            vehicleInfoTabs.Width = rentalPage.Width;
            vehiclePage.Width = rentalPage.Width;
            vehicleInfoTabs.SelectedIndex = 0;
            TabPage RentalTab = vehicleInfoTabs.SelectedTab;
            //Vehicle v1 = new Vehicle("Honda", "Civic", 2022, "Sedan");
            Vehicle v2 = new Vehicle(vehicleInfo);
            Label l1 = new Label();
            l1.MaximumSize = new Size(RentalTab.Width, 0);
            l1.AutoSize = true;
            Rental r1 = new Rental(v2, "John", "Nolan", DateTime.Now, 10);
            l1.Text = r1.getRentalDetails();
            RentalTab.Controls.Add(l1);
            loadVehicleInfoTab(v2);
            vehicleInfoTabs.SelectedIndex = 0;

        }

        private void loadVehicleInfoTab(Vehicle v)
        {
            vehicleInfoTabs.SelectedIndex = 1;
            TabPage vehicleTab = vehicleInfoTabs.SelectedTab;
            Label l1 = new Label();
            l1.MaximumSize = new Size(vehicleTab.Width, 0);
            l1.AutoSize = true;
            l1.Text = v.getVehicleDetails();
            vehicleTab.Controls.Add(l1);
        }
    }
}
