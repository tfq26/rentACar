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

        public CustomerProfileForm()
        {
            InitializeComponent();
        }

        public CustomerProfileForm(HomeForm hf, LoginForm lf)
        {
            this.homeForm = hf;
            this.loginForm = lf;
            InitializeComponent();
        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        public void logout_Click(object sender, EventArgs e)
        {
            loginForm.Visible = true;
            this.Visible = false;
        }
    }
}
