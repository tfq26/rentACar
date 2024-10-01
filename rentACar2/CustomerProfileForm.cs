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
        private HomeForm homeForm = LoginForm.homeForm;
        private LoginForm loginForm = LoginForm.loginForm;

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
            lblDisplayState.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        public void logout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Visible = false;
        }

        private void homeToolStripMenuItemProfile_Click(object sender, EventArgs e)
        {
            homeForm.Visible = true;
            this.Visible = false;
        }

        public void editToolStripMenuItemProfile_Click(object sender, EventArgs e)
        {
            this.ageBox.ReadOnly = false;
            this.emailBox.ReadOnly = false;
            this.idBox.ReadOnly = false;
            this.numberBox.ReadOnly = false;
            this.nameBox.ReadOnly = false;
            this.lblDisplayState.Text = "*EDITING MODE*";
            this.lblDisplayState.Visible = true;
            this.doneToolStripMenuItem.Visible = true;
            this.btnDoneEditing.Visible = true;
            idBox.PasswordChar = '\0';
        }

        private void Box_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.ReadOnly = true;
        }

        public void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doneToolStripMenuItem.Visible = false;
            ageBox.ReadOnly = true;
            emailBox.ReadOnly = true;
            idBox.ReadOnly = true;
            numberBox.ReadOnly = true;
            nameBox.ReadOnly = true;
            lblDisplayState.Visible = false;
            idBox.PasswordChar = '*';
        }

        private void btnDoneEditing_Click(object sender, EventArgs e)
        {
            doneToolStripMenuItem_Click(sender, e);
            this.btnDoneEditing.Visible = false;
        }
    }
}
