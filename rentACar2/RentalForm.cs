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

        private void setVehicle(Vehicle v)
        {
            vehicle = v;
        }

        private void setCustomer(Customer c)
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
    }
}
