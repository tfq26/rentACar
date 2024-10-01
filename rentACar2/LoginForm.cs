using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentACar2
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public CustomerInventoryCloud customersCloud;
        public CustomerInventoryLocal customersLocal;
        private HomeForm homeForm;
        private CustomerProfileForm customerProfileForm;
        private Boolean bypass = false;
        public static Customer user;
        public LoginForm()
        {
            customersLocal = new CustomerInventoryLocal();
            InitializeComponent();
            this.customerProfileForm = new CustomerProfileForm(homeForm, this);
            this.homeForm = new HomeForm(customerProfileForm, this);
        }

        public LoginForm(CustomerProfileForm cf, HomeForm rf)
        {
            customersLocal = new CustomerInventoryLocal();
            InitializeComponent();
            this.customerProfileForm = cf;
            this.homeForm = rf;
        }

        public LoginForm(CustomerInventoryCloud customerInventory)
        {
            customersCloud = customerInventory;
            InitializeComponent();
            this.customerProfileForm = new CustomerProfileForm(homeForm, this);
            this.homeForm = new HomeForm(customerProfileForm, this);
        }

        private void checkLogin(string userEmail, string userPassword)
        {
            var customers = customersLocal;

            if (customers.checkforCustomer(userEmail, userPassword) || bypass)
            {
                customers.getCustomer(userEmail, userPassword);
                this.Visible = false;
                homeForm.Show();
            }
            else if (customers != null && customersCloud.checkforCustomer(userEmail, userPassword) || bypass)
            {
                this.Visible = false;
                homeForm.Show();
            }
            else
            {
                lblDisplayError.Visible = true;
                lblDisplayError.Text = "User not found";
            }
        }

        private void boxPasswordLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkLogin(boxUsernameLogin.Text, boxPasswordLogin.Text);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            checkLogin(boxUsernameLogin.Text, boxPasswordLogin.Text);
        }

        private void exitBtnLogin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginDebugbtn_Click(object sender, EventArgs e)
        {
            bypass = true;
            checkLogin(" ", " ");
        }
    }
}
