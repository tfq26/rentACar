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
            menuStrip1 = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            rentalsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cusPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // profilePanel
            // 
            profilePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            profilePanel.BackColor = Color.BlanchedAlmond;
            profilePanel.Controls.Add(lblDisplayEdit);
            profilePanel.Controls.Add(btnDone);
            profilePanel.Controls.Add(nameBox);
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
            cusPictureBox.ErrorImage = Properties.Resources.defaultPFP;
            cusPictureBox.Image = Properties.Resources.defaultPFP;
            cusPictureBox.InitialImage = Properties.Resources.defaultPFP;
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
            emailBox.Location = new Point(144, 243);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "test@carpick.net";
            emailBox.ReadOnly = true;
            emailBox.Size = new Size(234, 31);
            emailBox.TabIndex = 60;
            emailBox.Text = "test@carpick.net";
            // 
            // ageBox
            // 
            ageBox.BackColor = Color.Snow;
            ageBox.Font = new Font("Verdana", 14.25F);
            ageBox.ForeColor = Color.Black;
            ageBox.Location = new Point(127, 187);
            ageBox.Name = "ageBox";
            ageBox.PlaceholderText = "21";
            ageBox.ReadOnly = true;
            ageBox.Size = new Size(234, 31);
            ageBox.TabIndex = 59;
            ageBox.Text = "21";
            // 
            // idBox
            // 
            idBox.BackColor = Color.Snow;
            idBox.Font = new Font("Verdana", 14.25F);
            idBox.ForeColor = Color.Black;
            idBox.Location = new Point(196, 351);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "321321321312";
            idBox.ReadOnly = true;
            idBox.Size = new Size(234, 31);
            idBox.TabIndex = 58;
            idBox.Text = "321321321312";
            idBox.UseSystemPasswordChar = true;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.None;
            lblID.AutoSize = true;
            lblID.Font = new Font("Verdana", 14.25F);
            lblID.Location = new Point(66, 354);
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
            lblPhone.Location = new Point(66, 301);
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
            lblEmail.Location = new Point(66, 246);
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
            lblAge.Location = new Point(66, 190);
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
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, rentalsToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(76, 27);
            viewToolStripMenuItem.Text = "View";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(180, 28);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 28);
            editToolStripMenuItem.Text = "Edit";
            // 
            // rentalsToolStripMenuItem
            // 
            rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            rentalsToolStripMenuItem.Size = new Size(180, 28);
            rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.ForeColor = Color.Orange;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 28);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logout_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = Color.Red;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
        private PictureBox cusPictureBox;
        private Button btnDone;
        private TextBox nameBox;
        private Label lblDisplayEdit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem rentalsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}