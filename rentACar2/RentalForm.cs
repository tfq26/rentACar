using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class rentalForm : Form
    {
        Vehicle vehicle = new Vehicle();
        Customer customer = new Customer();
        public rentalForm()
        {
            InitializeComponent();
        }

        public void setVehicle(Vehicle v)
        {
            vehicle = v;
        }

        public void setCustomer(Customer c)
        {
            customer = c;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        private void rentalForm_Load(object sender, EventArgs e)
        {
            displayVehiclePictureBox.Image = vehicle.getVehicleImage();
            lblVehicleRentalLink.Text = vehicle.getTitle();
            lblCustomerLink.Text = customer.getFirstName() + " " + customer.getLastName();
        }

        private void lblVehicleRentalLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Go to home page and load vehicle in home page
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.loadHome();
        }
    }
}
