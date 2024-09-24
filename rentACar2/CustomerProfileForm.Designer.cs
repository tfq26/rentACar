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
            profilePanel = new Panel();
            boxDisplayID = new TextBox();
            lblDisplayLast = new Label();
            lblDisplayFirst = new Label();
            lblID = new Label();
            lblDisplayPhone = new Label();
            lblDisplayEmail = new Label();
            lblDisplayAge = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAge = new Label();
            pictureBox1 = new PictureBox();
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
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // profilePanel
            // 
            profilePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            profilePanel.BackColor = Color.Transparent;
            profilePanel.Controls.Add(boxDisplayID);
            profilePanel.Controls.Add(lblDisplayLast);
            profilePanel.Controls.Add(lblDisplayFirst);
            profilePanel.Controls.Add(lblID);
            profilePanel.Controls.Add(lblDisplayPhone);
            profilePanel.Controls.Add(lblDisplayEmail);
            profilePanel.Controls.Add(lblDisplayAge);
            profilePanel.Controls.Add(lblPhone);
            profilePanel.Controls.Add(lblEmail);
            profilePanel.Controls.Add(lblAge);
            profilePanel.Controls.Add(pictureBox1);
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
            profilePanel.Location = new Point(47, 38);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(827, 733);
            profilePanel.TabIndex = 34;
            profilePanel.Visible = false;
            // 
            // boxDisplayID
            // 
            boxDisplayID.BackColor = Color.Snow;
            boxDisplayID.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxDisplayID.ForeColor = Color.Black;
            boxDisplayID.Location = new Point(197, 292);
            boxDisplayID.Name = "boxDisplayID";
            boxDisplayID.PlaceholderText = "321321321312";
            boxDisplayID.ReadOnly = true;
            boxDisplayID.Size = new Size(234, 47);
            boxDisplayID.TabIndex = 58;
            // 
            // lblDisplayLast
            // 
            lblDisplayLast.Anchor = AnchorStyles.None;
            lblDisplayLast.AutoSize = true;
            lblDisplayLast.BackColor = Color.Transparent;
            lblDisplayLast.Font = new Font("Impact", 36F, FontStyle.Bold | FontStyle.Underline);
            lblDisplayLast.ForeColor = Color.Black;
            lblDisplayLast.ImageAlign = ContentAlignment.TopCenter;
            lblDisplayLast.Location = new Point(580, 377);
            lblDisplayLast.Name = "lblDisplayLast";
            lblDisplayLast.Size = new Size(234, 60);
            lblDisplayLast.TabIndex = 57;
            lblDisplayLast.Text = "Last Name";
            // 
            // lblDisplayFirst
            // 
            lblDisplayFirst.Anchor = AnchorStyles.None;
            lblDisplayFirst.AutoSize = true;
            lblDisplayFirst.BackColor = Color.Transparent;
            lblDisplayFirst.Font = new Font("Impact", 36F, FontStyle.Bold | FontStyle.Underline);
            lblDisplayFirst.ForeColor = Color.Black;
            lblDisplayFirst.ImageAlign = ContentAlignment.TopCenter;
            lblDisplayFirst.Location = new Point(327, 377);
            lblDisplayFirst.Name = "lblDisplayFirst";
            lblDisplayFirst.Size = new Size(242, 60);
            lblDisplayFirst.TabIndex = 51;
            lblDisplayFirst.Text = "First Name";
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.None;
            lblID.AutoSize = true;
            lblID.Font = new Font("Impact", 24F);
            lblID.Location = new Point(346, 611);
            lblID.Name = "lblID";
            lblID.Size = new Size(159, 39);
            lblID.TabIndex = 55;
            lblID.Text = "ID Number:";
            // 
            // lblDisplayPhone
            // 
            lblDisplayPhone.Anchor = AnchorStyles.None;
            lblDisplayPhone.AutoSize = true;
            lblDisplayPhone.Font = new Font("Impact", 24F);
            lblDisplayPhone.ForeColor = SystemColors.WindowFrame;
            lblDisplayPhone.Location = new Point(556, 558);
            lblDisplayPhone.Name = "lblDisplayPhone";
            lblDisplayPhone.Size = new Size(187, 39);
            lblDisplayPhone.TabIndex = 54;
            lblDisplayPhone.Text = "5555555555";
            // 
            // lblDisplayEmail
            // 
            lblDisplayEmail.Anchor = AnchorStyles.None;
            lblDisplayEmail.AutoSize = true;
            lblDisplayEmail.Font = new Font("Impact", 24F);
            lblDisplayEmail.ForeColor = SystemColors.WindowFrame;
            lblDisplayEmail.Location = new Point(430, 503);
            lblDisplayEmail.Name = "lblDisplayEmail";
            lblDisplayEmail.Size = new Size(289, 39);
            lblDisplayEmail.TabIndex = 53;
            lblDisplayEmail.Text = "carpickTest@vs.com";
            // 
            // lblDisplayAge
            // 
            lblDisplayAge.Anchor = AnchorStyles.None;
            lblDisplayAge.AutoSize = true;
            lblDisplayAge.Font = new Font("Impact", 24F);
            lblDisplayAge.ForeColor = SystemColors.WindowFrame;
            lblDisplayAge.Location = new Point(411, 447);
            lblDisplayAge.Name = "lblDisplayAge";
            lblDisplayAge.Size = new Size(34, 39);
            lblDisplayAge.TabIndex = 52;
            lblDisplayAge.Text = "0";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.None;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Impact", 24F);
            lblPhone.Location = new Point(346, 558);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(214, 39);
            lblPhone.TabIndex = 51;
            lblPhone.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Impact", 24F);
            lblEmail.Location = new Point(346, 503);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 39);
            lblEmail.TabIndex = 50;
            lblEmail.Text = "Email:";
            // 
            // lblAge
            // 
            lblAge.Anchor = AnchorStyles.None;
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Impact", 24F);
            lblAge.Location = new Point(346, 447);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(72, 39);
            lblAge.TabIndex = 49;
            lblAge.Text = "Age:";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.defaultPFP;
            pictureBox1.Image = Properties.Resources.defaultPFP;
            pictureBox1.InitialImage = Properties.Resources.defaultPFP;
            pictureBox1.Location = new Point(520, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "Customer";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(1425, 1090);
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
            label6.Location = new Point(1327, 1090);
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
            label7.Location = new Point(964, 1090);
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
            label8.Location = new Point(859, 1089);
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
            label9.Location = new Point(1432, 1068);
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
            label10.Location = new Point(1327, 1069);
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
            label11.Location = new Point(1432, 1045);
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
            label12.Location = new Point(1327, 1044);
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
            label13.Location = new Point(1432, 1022);
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
            label14.Location = new Point(1327, 1022);
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
            button1.Location = new Point(1315, 1142);
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
            label15.Location = new Point(963, 1069);
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
            button2.Location = new Point(1083, 1139);
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
            label16.Location = new Point(960, 1046);
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
            label19.Location = new Point(859, 1068);
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
            label20.Location = new Point(859, 1045);
            label20.Name = "label20";
            label20.Size = new Size(60, 20);
            label20.TabIndex = 10;
            label20.Text = "Mileage";
            // 
            // CustomerProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 827);
            Controls.Add(profilePanel);
            Name = "CustomerProfileForm";
            Text = "CustomerProfileForm";
            Load += CustomerProfileForm_Load;
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel profilePanel;
        private TextBox boxDisplayID;
        private Label lblDisplayLast;
        private Label lblDisplayFirst;
        private Label lblID;
        private Label lblDisplayPhone;
        private Label lblDisplayEmail;
        private Label lblDisplayAge;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAge;
        private PictureBox pictureBox1;
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
    }
}