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
        private Customer c;

        public CustomerProfileForm()
        {
            InitializeComponent();
        }

        public CustomerProfileForm(HomeForm hf)
        {
            this.homeForm = hf;
            InitializeComponent();
        }

        public CustomerProfileForm(HomeForm hf, LoginForm lf)
        {
            this.loginForm = lf;
            this.homeForm = hf;
            InitializeComponent();
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
            this.nameBox.Text = c.getFirstName + " " + c.getLastName;
            this.ageBox.Text = c.getAge().ToString();
            this.emailBox.Text = c.getEmail();
            this.numberBox.Text = c.getPhone();
            this.idBox.Text = c.getId();
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
            FormManager.loadHome();
        }
    }
}
