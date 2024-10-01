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
            lblDisplayState = new Label();
            nameBox = new TextBox();
            MenuBar = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItemProfile = new ToolStripMenuItem();
            optionsToolStripMenuItemProfile = new ToolStripMenuItem();
            logoutToolStripMenuItemProfile = new ToolStripMenuItem();
            editToolStripMenuItemProfile = new ToolStripMenuItem();
            doneToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItemProfile = new ToolStripMenuItem();
            cusPictureBox = new PictureBox();
            numberBox = new TextBox();
            emailBox = new TextBox();
            ageBox = new TextBox();
            idBox = new TextBox();
            lblID = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAge = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            button1 = new Button();
            label15 = new Label();
            button2 = new Button();
            label16 = new Label();
            label19 = new Label();
            label20 = new Label();
            btnDoneEditing = new Button();
            profilePanel.SuspendLayout();
            MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cusPictureBox).BeginInit();
            SuspendLayout();
            // 
            // profilePanel
            // 
            profilePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            profilePanel.BackColor = Color.BlanchedAlmond;
            profilePanel.Controls.Add(btnDoneEditing);
            profilePanel.Controls.Add(lblDisplayState);
            profilePanel.Controls.Add(nameBox);
            profilePanel.Controls.Add(MenuBar);
            profilePanel.Controls.Add(cusPictureBox);
            profilePanel.Controls.Add(numberBox);
            profilePanel.Controls.Add(emailBox);
            profilePanel.Controls.Add(ageBox);
            profilePanel.Controls.Add(idBox);
            profilePanel.Controls.Add(lblID);
            profilePanel.Controls.Add(lblPhone);
            profilePanel.Controls.Add(lblEmail);
            profilePanel.Controls.Add(lblAge);
            profilePanel.Controls.Add(label5);
            profilePanel.Controls.Add(label6);
            profilePanel.Controls.Add(label7);
            profilePanel.Controls.Add(label8);
            profilePanel.Controls.Add(label9);
            profilePanel.Controls.Add(label10);
            profilePanel.Controls.Add(label11);
            profilePanel.Controls.Add(label12);
            profilePanel.Controls.Add(label13);
            profilePanel.Controls.Add(label14);
            profilePanel.Controls.Add(button1);
            profilePanel.Controls.Add(label15);
            profilePanel.Controls.Add(button2);
            profilePanel.Controls.Add(label16);
            profilePanel.Controls.Add(label19);
            profilePanel.Controls.Add(label20);
            profilePanel.ForeColor = SystemColors.HotTrack;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(950, 750);
            profilePanel.TabIndex = 34;
            // 
            // lblDisplayState
            // 
            lblDisplayState.AutoSize = true;
            lblDisplayState.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayState.ForeColor = Color.Red;
            lblDisplayState.Location = new Point(597, 299);
            lblDisplayState.Name = "lblDisplayState";
            lblDisplayState.Size = new Size(209, 32);
            lblDisplayState.TabIndex = 65;
            lblDisplayState.Text = "Editing Details";
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.BlanchedAlmond;
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.ForeColor = Color.Black;
            nameBox.Location = new Point(59, 61);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "21";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(411, 45);
            nameBox.TabIndex = 64;
            nameBox.Text = "First Last";
            nameBox.TextAlign = HorizontalAlignment.Center;
            nameBox.Enter += Box_Enter;
            // 
            // MenuBar
            // 
            MenuBar.BackColor = Color.SandyBrown;
            MenuBar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MenuBar.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem });
            MenuBar.Location = new Point(0, 0);
            MenuBar.MdiWindowListItem = homeToolStripMenuItem;
            MenuBar.Name = "MenuBar";
            MenuBar.ShowItemToolTips = true;
            MenuBar.Size = new Size(950, 33);
            MenuBar.TabIndex = 63;
            MenuBar.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.AutoToolTip = true;
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItemProfile, optionsToolStripMenuItemProfile, exitToolStripMenuItemProfile });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(72, 29);
            homeToolStripMenuItem.Text = "Menu";
            homeToolStripMenuItem.ToolTipText = "Menu Dropdown";
            // 
            // homeToolStripMenuItemProfile
            // 
            homeToolStripMenuItemProfile.Name = "homeToolStripMenuItemProfile";
            homeToolStripMenuItemProfile.Size = new Size(151, 30);
            homeToolStripMenuItemProfile.Text = "Home";
            homeToolStripMenuItemProfile.ToolTipText = "Return to Home Page";
            homeToolStripMenuItemProfile.Click += homeToolStripMenuItemProfile_Click;
            // 
            // optionsToolStripMenuItemProfile
            // 
            optionsToolStripMenuItemProfile.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItemProfile, editToolStripMenuItemProfile });
            optionsToolStripMenuItemProfile.Name = "optionsToolStripMenuItemProfile";
            optionsToolStripMenuItemProfile.Size = new Size(151, 30);
            optionsToolStripMenuItemProfile.Text = "Options";
            optionsToolStripMenuItemProfile.ToolTipText = "View page Options";
            // 
            // logoutToolStripMenuItemProfile
            // 
            logoutToolStripMenuItemProfile.Name = "logoutToolStripMenuItemProfile";
            logoutToolStripMenuItemProfile.Size = new Size(144, 30);
            logoutToolStripMenuItemProfile.Text = "Logout";
            logoutToolStripMenuItemProfile.TextImageRelation = TextImageRelation.TextBeforeImage;
            logoutToolStripMenuItemProfile.ToolTipText = "Logout of current Account";
            logoutToolStripMenuItemProfile.Click += logout_Click;
            // 
            // editToolStripMenuItemProfile
            // 
            editToolStripMenuItemProfile.DropDownItems.AddRange(new ToolStripItem[] { doneToolStripMenuItem });
            editToolStripMenuItemProfile.Name = "editToolStripMenuItemProfile";
            editToolStripMenuItemProfile.Size = new Size(144, 30);
            editToolStripMenuItemProfile.Text = "Edit";
            editToolStripMenuItemProfile.ToolTipText = "Edit Current Account Details";
            editToolStripMenuItemProfile.Click += editToolStripMenuItemProfile_Click;
            // 
            // doneToolStripMenuItem
            // 
            doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            doneToolStripMenuItem.Size = new Size(130, 30);
            doneToolStripMenuItem.Text = "Done";
            doneToolStripMenuItem.Visible = false;
            doneToolStripMenuItem.Click += doneToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItemProfile
            // 
            exitToolStripMenuItemProfile.ForeColor = Color.Red;
            exitToolStripMenuItemProfile.Name = "exitToolStripMenuItemProfile";
            exitToolStripMenuItemProfile.Size = new Size(151, 30);
            exitToolStripMenuItemProfile.Text = "Exit";
            exitToolStripMenuItemProfile.ToolTipText = "Exit Application";
            exitToolStripMenuItemProfile.Click += exitToolStripMenuItem_Click;
            // 
            // cusPictureBox
            // 
            cusPictureBox.BackColor = Color.Black;
            cusPictureBox.BorderStyle = BorderStyle.FixedSingle;
            cusPictureBox.ErrorImage = Properties.Resources.defaultPFP;
            cusPictureBox.Image = Properties.Resources.defaultPFP;
            cusPictureBox.InitialImage = Properties.Resources.defaultPFP;
            cusPictureBox.Location = new Point(597, 61);
            cusPictureBox.Name = "cusPictureBox";
            cusPictureBox.Size = new Size(200, 200);
            cusPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cusPictureBox.TabIndex = 30;
            cusPictureBox.TabStop = false;
            cusPictureBox.Tag = "Customer";
            // 
            // numberBox
            // 
            numberBox.BackColor = Color.SandyBrown;
            numberBox.Font = new Font("Verdana", 14.25F);
            numberBox.ForeColor = Color.Black;
            numberBox.Location = new Point(227, 287);
            numberBox.Name = "numberBox";
            numberBox.PlaceholderText = "555-555-5555";
            numberBox.ReadOnly = true;
            numberBox.Size = new Size(234, 31);
            numberBox.TabIndex = 61;
            numberBox.Text = "555-555-5555";
            numberBox.TextAlign = HorizontalAlignment.Center;
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.SandyBrown;
            emailBox.Font = new Font("Verdana", 14.25F);
            emailBox.ForeColor = Color.Black;
            emailBox.Location = new Point(140, 232);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "test@carpick.net";
            emailBox.ReadOnly = true;
            emailBox.Size = new Size(234, 31);
            emailBox.TabIndex = 60;
            emailBox.Text = "test@carpick.net";
            emailBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ageBox
            // 
            ageBox.AcceptsReturn = true;
            ageBox.BackColor = Color.SandyBrown;
            ageBox.Font = new Font("Verdana", 14.25F);
            ageBox.ForeColor = Color.Black;
            ageBox.Location = new Point(123, 176);
            ageBox.Name = "ageBox";
            ageBox.PlaceholderText = "21";
            ageBox.ReadOnly = true;
            ageBox.Size = new Size(234, 31);
            ageBox.TabIndex = 59;
            ageBox.Text = "21";
            ageBox.TextAlign = HorizontalAlignment.Center;
            // 
            // idBox
            // 
            idBox.BackColor = Color.SandyBrown;
            idBox.Font = new Font("Verdana", 14.25F);
            idBox.ForeColor = Color.Black;
            idBox.Location = new Point(192, 340);
            idBox.Name = "idBox";
            idBox.PasswordChar = '*';
            idBox.PlaceholderText = "321321321312";
            idBox.ReadOnly = true;
            idBox.Size = new Size(234, 31);
            idBox.TabIndex = 58;
            idBox.Text = "321321321312";
            idBox.TextAlign = HorizontalAlignment.Center;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.None;
            lblID.AutoSize = true;
            lblID.Font = new Font("Verdana", 14.25F);
            lblID.Location = new Point(62, 343);
            lblID.Name = "lblID";
            lblID.Size = new Size(124, 23);
            lblID.TabIndex = 55;
            lblID.Text = "ID Number:";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.None;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Verdana", 14.25F);
            lblPhone.Location = new Point(62, 290);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(159, 23);
            lblPhone.TabIndex = 51;
            lblPhone.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 14.25F);
            lblEmail.Location = new Point(62, 235);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 23);
            lblEmail.TabIndex = 50;
            lblEmail.Text = "Email:";
            // 
            // lblAge
            // 
            lblAge.Anchor = AnchorStyles.None;
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Verdana", 14.25F);
            lblAge.Location = new Point(62, 179);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(55, 23);
            lblAge.TabIndex = 49;
            lblAge.Text = "Age:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(1487, 1099);
            label5.Name = "label5";
            label5.Size = new Size(27, 25);
            label5.TabIndex = 29;
            label5.Text = "115";
            label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F);
            label6.Location = new Point(1389, 1099);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 28;
            label6.Text = "Range";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F);
            label7.ForeColor = SystemColors.WindowFrame;
            label7.Location = new Point(1026, 1099);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 27;
            label7.Text = "Gas";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F);
            label8.Location = new Point(921, 1098);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 26;
            label8.Text = "Drivetrain";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 12F);
            label9.ForeColor = SystemColors.WindowFrame;
            label9.Location = new Point(1494, 1077);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 25;
            label9.Text = "3";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 12F);
            label10.Location = new Point(1389, 1078);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 24;
            label10.Text = "Storage";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 12F);
            label11.ForeColor = SystemColors.WindowFrame;
            label11.Location = new Point(1494, 1054);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 23;
            label11.Text = "4";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Impact", 12F);
            label12.Location = new Point(1389, 1053);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 22;
            label12.Text = "Passengers";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Impact", 12F);
            label13.ForeColor = SystemColors.WindowFrame;
            label13.Location = new Point(1494, 1031);
            label13.Name = "label13";
            label13.Size = new Size(17, 20);
            label13.TabIndex = 21;
            label13.Text = "4";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Impact", 12F);
            label14.Location = new Point(1389, 1031);
            label14.Name = "label14";
            label14.Size = new Size(48, 20);
            label14.TabIndex = 20;
            label14.Text = "Doors";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(64, 255, 104);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            button1.ForeColor = Color.ForestGreen;
            button1.Location = new Point(1377, 1151);
            button1.Name = "button1";
            button1.Size = new Size(144, 58);
            button1.TabIndex = 2;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Impact", 12F);
            label15.ForeColor = SystemColors.WindowFrame;
            label15.Location = new Point(1025, 1078);
            label15.Name = "label15";
            label15.Size = new Size(38, 20);
            label15.TabIndex = 19;
            label15.Text = "Blue";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(96, 188, 255);
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(1145, 1148);
            button2.Name = "button2";
            button2.Size = new Size(153, 61);
            button2.TabIndex = 1;
            button2.Text = "Rent";
            button2.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Impact", 12F);
            label16.ForeColor = SystemColors.WindowFrame;
            label16.Location = new Point(1022, 1055);
            label16.Name = "label16";
            label16.Size = new Size(53, 20);
            label16.TabIndex = 17;
            label16.Text = "30000";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Impact", 12F);
            label19.Location = new Point(921, 1077);
            label19.Name = "label19";
            label19.Size = new Size(44, 20);
            label19.TabIndex = 12;
            label19.Text = "Color";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Impact", 12F);
            label20.Location = new Point(921, 1054);
            label20.Name = "label20";
            label20.Size = new Size(60, 20);
            label20.TabIndex = 10;
            label20.Text = "Mileage";
            // 
            // btnDoneEditing
            // 
            btnDoneEditing.BackColor = Color.NavajoWhite;
            btnDoneEditing.Font = new Font("Verdana", 20F);
            btnDoneEditing.ForeColor = Color.Tomato;
            btnDoneEditing.Location = new Point(597, 356);
            btnDoneEditing.Name = "btnDoneEditing";
            btnDoneEditing.Size = new Size(200, 44);
            btnDoneEditing.TabIndex = 66;
            btnDoneEditing.Text = "Done";
            btnDoneEditing.UseVisualStyleBackColor = false;
            btnDoneEditing.Click += btnDoneEditing_Click;
            // 
            // CustomerProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 751);
            Controls.Add(profilePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerProfileForm";
            Load += CustomerProfileForm_Load;
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            MenuBar.ResumeLayout(false);
            MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cusPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel profilePanel;
        private TextBox idBox;
        private Label lblID;
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
        private MenuStrip MenuBar;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItemProfile;
        private PictureBox cusPictureBox;
        private ToolStripMenuItem homeToolStripMenuItemProfile;
        private ToolStripMenuItem optionsToolStripMenuItemProfile;
        private ToolStripMenuItem logoutToolStripMenuItemProfile;
        private ToolStripMenuItem editToolStripMenuItemProfile;
        private TextBox nameBox;
        private Label lblDisplayState;
        private ToolStripMenuItem doneToolStripMenuItem;
        private Button btnDoneEditing;
    }
}