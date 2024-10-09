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
        private CustomerInventoryCloud customersCloud;
        private CustomerInventoryLocal customersLocal;
        public HomeForm homeForm;
        public Customer user;
        public rentalForm rentalForm;
        public CustomerProfileForm profileForm;
        private FormManager formManager;
        public LoginForm()
        {
            customersLocal = new CustomerInventoryLocal();
            customersCloud = new CustomerInventoryCloud();
            InitializeComponent();
            homeForm = new HomeForm();
            profileForm = new CustomerProfileForm();
            rentalForm = new rentalForm();
            formManager = new FormManager(homeForm, profileForm, rentalForm, this);
        }

        public LoginForm(CustomerInventoryCloud customerInventory)
        {
            customersCloud = customerInventory;
            InitializeComponent();
            homeForm = new HomeForm();
        }

        public Customer[] GetCustomers()
        {
            if (customersCloud == null)
            {
                return this.customersLocal.getInventory();
            }
            else
            {
                return customersCloud.getInventory();
            }
        }

        public void checkLogin(Boolean bypass)
        {
            if (bypass)
            {
                checkLogin(" ", " ", true);
            } else
            {
                checkLogin(boxUsernameLogin.Text, boxPasswordLogin.Text, false);
            }
        }

        private void checkLogin(string userEmail, string userPassword, Boolean bypass)
        {
            var customers = customersLocal;

            if (customers.checkforCustomer(userEmail, userPassword))
            {
                customers.getCustomer(userEmail, userPassword);
                FormManager.loadHome();
            }
            
            else if (customers != null && customersCloud.checkforCustomer(userEmail, userPassword))
            {
                FormManager.loadHome();
            } 
            
            else if (bypass)
            {
                FormManager.loadHome();
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
                checkLogin(boxUsernameLogin.Text, boxPasswordLogin.Text, false);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            checkLogin(false);
        }

        private void exitBtnLogin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginDebugbtn_Click(object sender, EventArgs e)
        {
            checkLogin(true);
        }
    }
}
