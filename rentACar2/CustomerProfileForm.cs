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
        public CustomerProfileForm()
        {
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
            Program.loginForm.Visible = true;
        }
    }
}
