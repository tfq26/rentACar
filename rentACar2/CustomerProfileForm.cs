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
    public partial class CustomerProfileForm : System.Windows.Forms.Form
    {
        private HomeForm homeForm;
        private LoginForm loginForm;
        public Customer customer;

        public CustomerProfileForm(Customer c)
        {
            InitializeComponent();
            this.customer = c;
            displayCustomer();
        }

        public CustomerProfileForm()
        {
            InitializeComponent();
            this.customer = new Customer();
            displayCustomer();
        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
            this.lblDisplayEdit.Visible = false;
            this.btnDone.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        public void logout_Click(object sender, EventArgs e)
        {
            FormManager.loadLogin();
        }

        private void editToolStripMenuItemProfile_Click(object sender, EventArgs e)
        {
            this.ageBox.ReadOnly = false;
            this.idBox.ReadOnly = false;
            this.numberBox.ReadOnly = false;
            this.emailBox.ReadOnly = false;
            this.idBox.UseSystemPasswordChar = false;
            this.nameBox.ReadOnly = false;
            this.lblDisplayEdit.Visible = true;
            this.btnDone.Visible = true;
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lblDisplayEdit.Visible = false;
            this.btnDone.Visible = false;
            this.nameBox.ReadOnly = true;
            this.ageBox.ReadOnly = true;
            this.idBox.ReadOnly = true;
            this.numberBox.ReadOnly = true;
            this.emailBox.ReadOnly = true;
            this.idBox.UseSystemPasswordChar = true;
        }

        private void displayCustomer()
        {
            this.nameBox.Text = customer.getFirstName() + " " + customer.getLastName();
            this.ageBox.Text = customer.getAge().ToString();
            this.emailBox.Text = customer.getEmail();
            this.numberBox.Text = customer.getPhone();
            this.idBox.Text = customer.getId();
        }

        private void updateCustomer()
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            doneToolStripMenuItem_Click(sender, e);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.loadHome(customer);
        }
    }
}
