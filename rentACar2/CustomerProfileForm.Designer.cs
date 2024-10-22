namespace rentACar2
{
    partial class CustomerProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProfileForm));
            profilePanel = new Panel();
            lblDisplayEdit = new Label();
            btnDone = new Button();
            nameBox = new TextBox();
            cusPictureBox = new PictureBox();
            numberBox = new TextBox();
            emailBox = new TextBox();
            ageBox = new TextBox();
            idBox = new TextBox();
            lblDisplayID = new Label();
            menuStrip1 = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            rentalsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblDisplayPhone = new Label();
            lblDisplayEmail = new Label();
            lblDisplayAge = new Label();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cusPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // profilePanel
            // 
            profilePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            profilePanel.BackColor = Color.BlanchedAlmond;
            profilePanel.Controls.Add(lblDisplayAge);
            profilePanel.Controls.Add(lblDisplayEmail);
            profilePanel.Controls.Add(lblDisplayPhone);
            profilePanel.Controls.Add(lblDisplayEdit);
            profilePanel.Controls.Add(btnDone);
            profilePanel.Controls.Add(nameBox);
            profilePanel.Controls.Add(cusPictureBox);
            profilePanel.Controls.Add(numberBox);
            profilePanel.Controls.Add(emailBox);
            profilePanel.Controls.Add(ageBox);
            profilePanel.Controls.Add(idBox);
            profilePanel.Controls.Add(lblDisplayID);
            profilePanel.ForeColor = SystemColors.HotTrack;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(950, 750);
            profilePanel.TabIndex = 34;
            // 
            // lblDisplayEdit
            // 
            lblDisplayEdit.AutoSize = true;
            lblDisplayEdit.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayEdit.ForeColor = Color.MediumSeaGreen;
            lblDisplayEdit.Location = new Point(702, 316);
            lblDisplayEdit.Name = "lblDisplayEdit";
            lblDisplayEdit.Size = new Size(143, 38);
            lblDisplayEdit.TabIndex = 66;
            lblDisplayEdit.Text = "Editing";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.PeachPuff;
            btnDone.FlatAppearance.BorderColor = Color.Red;
            btnDone.FlatAppearance.BorderSize = 3;
            btnDone.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDone.ForeColor = Color.Coral;
            btnDone.Location = new Point(673, 400);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(200, 61);
            btnDone.TabIndex = 65;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.BlanchedAlmond;
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.ForeColor = Color.Black;
            nameBox.Location = new Point(66, 69);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "21";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(513, 45);
            nameBox.TabIndex = 64;
            nameBox.Text = "First Last";
            nameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cusPictureBox
            // 
            cusPictureBox.BackColor = Color.Black;
            cusPictureBox.BorderStyle = BorderStyle.FixedSingle;
            cusPictureBox.ErrorImage = RentalCarApplication.Properties.Resources.defaultPFP;
            cusPictureBox.Image = RentalCarApplication.Properties.Resources.defaultPFP;
            cusPictureBox.InitialImage = RentalCarApplication.Properties.Resources.defaultPFP;
            cusPictureBox.Location = new Point(673, 70);
            cusPictureBox.Name = "cusPictureBox";
            cusPictureBox.Size = new Size(200, 200);
            cusPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cusPictureBox.TabIndex = 30;
            cusPictureBox.TabStop = false;
            cusPictureBox.Tag = "Customer";
            // 
            // numberBox
            // 
            numberBox.BackColor = Color.Snow;
            numberBox.Font = new Font("Verdana", 14.25F);
            numberBox.ForeColor = Color.Black;
            numberBox.Location = new Point(231, 298);
            numberBox.Name = "numberBox";
            numberBox.PlaceholderText = "555-555-5555";
            numberBox.ReadOnly = true;
            numberBox.Size = new Size(234, 31);
            numberBox.TabIndex = 61;
            numberBox.Text = "555-555-5555";
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.Snow;
            emailBox.Font = new Font("Verdana", 14.25F);
            emailBox.ForeColor = Color.Black;
            emailBox.Location = new Point(231, 247);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "test@carpick.net";
            emailBox.ReadOnly = true;
            emailBox.Size = new Size(321, 31);
            emailBox.TabIndex = 60;
            emailBox.Text = "test@carpick.net";
            // 
            // ageBox
            // 
            ageBox.BackColor = Color.Snow;
            ageBox.Font = new Font("Verdana", 14.25F);
            ageBox.ForeColor = Color.Black;
            ageBox.Location = new Point(231, 190);
            ageBox.Name = "ageBox";
            ageBox.PlaceholderText = "21";
            ageBox.ReadOnly = true;
            ageBox.Size = new Size(63, 31);
            ageBox.TabIndex = 59;
            ageBox.Text = "21";
            // 
            // idBox
            // 
            idBox.BackColor = Color.Snow;
            idBox.Font = new Font("Verdana", 14.25F);
            idBox.ForeColor = Color.Black;
            idBox.Location = new Point(66, 400);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "321321321312";
            idBox.ReadOnly = true;
            idBox.Size = new Size(473, 31);
            idBox.TabIndex = 58;
            idBox.Text = "321321321312";
            idBox.UseSystemPasswordChar = true;
            // 
            // lblDisplayID
            // 
            lblDisplayID.Anchor = AnchorStyles.None;
            lblDisplayID.AutoSize = true;
            lblDisplayID.Font = new Font("Verdana", 14.25F);
            lblDisplayID.Location = new Point(66, 354);
            lblDisplayID.Name = "lblDisplayID";
            lblDisplayID.Size = new Size(124, 23);
            lblDisplayID.TabIndex = 55;
            lblDisplayID.Text = "ID Number:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSalmon;
            menuStrip1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(949, 31);
            menuStrip1.TabIndex = 35;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, editToolStripMenuItem, rentalsToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(76, 27);
            viewToolStripMenuItem.Text = "View";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(162, 28);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(162, 28);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItemProfile_Click;
            // 
            // rentalsToolStripMenuItem
            // 
            rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            rentalsToolStripMenuItem.Size = new Size(162, 28);
            rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.ForeColor = Color.Orange;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(162, 28);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logout_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = Color.Red;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(162, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // lblDisplayPhone
            // 
            lblDisplayPhone.Anchor = AnchorStyles.None;
            lblDisplayPhone.AutoSize = true;
            lblDisplayPhone.Font = new Font("Verdana", 14.25F);
            lblDisplayPhone.Location = new Point(66, 301);
            lblDisplayPhone.Name = "lblDisplayPhone";
            lblDisplayPhone.Size = new Size(159, 23);
            lblDisplayPhone.TabIndex = 67;
            lblDisplayPhone.Text = "Phone Number:";
            // 
            // lblDisplayEmail
            // 
            lblDisplayEmail.Anchor = AnchorStyles.None;
            lblDisplayEmail.AutoSize = true;
            lblDisplayEmail.Font = new Font("Verdana", 14.25F);
            lblDisplayEmail.Location = new Point(66, 250);
            lblDisplayEmail.Name = "lblDisplayEmail";
            lblDisplayEmail.Size = new Size(72, 23);
            lblDisplayEmail.TabIndex = 68;
            lblDisplayEmail.Text = "Email:";
            // 
            // lblDisplayAge
            // 
            lblDisplayAge.Anchor = AnchorStyles.None;
            lblDisplayAge.AutoSize = true;
            lblDisplayAge.Font = new Font("Verdana", 14.25F);
            lblDisplayAge.Location = new Point(66, 193);
            lblDisplayAge.Name = "lblDisplayAge";
            lblDisplayAge.Size = new Size(55, 23);
            lblDisplayAge.TabIndex = 69;
            lblDisplayAge.Text = "Age:";
            // 
            // CustomerProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 751);
            Controls.Add(menuStrip1);
            Controls.Add(profilePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerProfileForm";
            Load += CustomerProfileForm_Load;
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cusPictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel profilePanel;
        private TextBox idBox;
        private Label lblDisplayID;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAge;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button button1;
        private Label label15;
        private Button button2;
        private Label label16;
        private Label label19;
        private Label label20;
        private TextBox numberBox;
        private TextBox emailBox;
        private TextBox ageBox;
        private PictureBox cusPictureBox;
        private Button btnDone;
        private TextBox nameBox;
        private Label lblDisplayEdit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem rentalsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private Label lblDisplayAge;
        private Label lblDisplayEmail;
        private Label lblDisplayPhone;
    }
}