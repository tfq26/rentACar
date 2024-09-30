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
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public static CustomerInventoryCloud customersCloud;
        public static CustomerInventoryLocal customersLocal;
        private RentalCarMainForm rentalCarMainForm = Program.rentalCarForm;
        private Boolean bypass = false;
        public static Customer user;
        public LoginForm()
        {
            customersLocal = new CustomerInventoryLocal();
            //customersCloud = new CustomerInventoryCloud();
           
            InitializeComponent();
        }



        public LoginForm(CustomerInventoryCloud customerInventory)
        {
            customersCloud = customerInventory;
            InitializeComponent();
        }

        private void checkLogin(string userEmail, string userPassword)
        {
            var customers = customersLocal;

            if (customers.checkforCustomer(userEmail, userPassword) || bypass)
            {
                customers.getCustomer(userEmail, userPassword);
                this.Visible = false;
                rentalCarMainForm.Show();
            }
            else if (customers != null && customersCloud.checkforCustomer(userEmail, userPassword) || bypass)
            {
                this.Visible = false;
                rentalCarMainForm.Show();
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginDebugbtn_Click(object sender, EventArgs e)
        {
            bypass = true;
            checkLogin(" ", " ");
        }
    }
}
