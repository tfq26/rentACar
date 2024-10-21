namespace rentACar2
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        private CustomerInventoryCloud customersCloud;
        private CustomerInventoryLocal customersLocal;

        public LoginForm()
        {
            customersCloud = new CustomerInventoryCloud();
            InitializeComponent();
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
            }
            else
            {
                checkLogin(boxUsernameLogin.Text, boxPasswordLogin.Text, false);
            }
        }

        private void checkLogin(string userEmail, string userPassword, Boolean bypass)
        {
            var customers = customersCloud;

            if (customers.checkforCustomer(userEmail, userPassword))
            {
                Customer temp = customers.getCustomer(userEmail, userPassword);

                FormManager.loadHome(temp);
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

        private void password_enter(object sender, EventArgs e)
        {
            checkLogin(false);
        }
    }
}
