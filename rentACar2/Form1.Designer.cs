namespace rentACar2
{
    partial class Carpick
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carpick));
            prevBtn = new Button();
            rentBtn = new Button();
            nextBtn = new Button();
            carPictureBox = new PictureBox();
            exitBtn = new Button();
            viewPanel = new Panel();
            profileButton = new Button();
            lblDisplayRange = new Label();
            lblRange = new Label();
            lblDisplayDrivetrain = new Label();
            lblDrivetrain = new Label();
            lblDisplayStorage = new Label();
            lblStorage = new Label();
            lblDisplayPassengers = new Label();
            lblPassengers = new Label();
            lblDisplaySeats = new Label();
            lblDoors = new Label();
            lblDisplayColor = new Label();
            lblDisplayMileage = new Label();
            lblDisplayType = new Label();
            lblDisplayVehicleTitle = new Label();
            lblColor = new Label();
            lblMileage = new Label();
            lblType = new Label();
            panel1 = new Panel();
            backButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            label11 = new Label();
            button4 = new Button();
            button5 = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            browseToolStripMenuItem = new ToolStripMenuItem();
            rentalsToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            viewPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.FromArgb(255, 170, 0);
            prevBtn.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            prevBtn.FlatAppearance.BorderSize = 2;
            prevBtn.FlatStyle = FlatStyle.Flat;
            prevBtn.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            prevBtn.ForeColor = Color.Cornsilk;
            prevBtn.Location = new Point(26, 526);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(141, 58);
            prevBtn.TabIndex = 0;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // rentBtn
            // 
            rentBtn.BackColor = Color.FromArgb(96, 188, 255);
            rentBtn.FlatAppearance.BorderColor = Color.Blue;
            rentBtn.FlatAppearance.BorderSize = 2;
            rentBtn.FlatStyle = FlatStyle.Flat;
            rentBtn.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            rentBtn.ForeColor = Color.Blue;
            rentBtn.Location = new Point(261, 415);
            rentBtn.Name = "rentBtn";
            rentBtn.Size = new Size(153, 61);
            rentBtn.TabIndex = 1;
            rentBtn.Text = "Rent";
            rentBtn.UseVisualStyleBackColor = false;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.FromArgb(64, 255, 104);
            nextBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            nextBtn.FlatAppearance.BorderSize = 2;
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            nextBtn.ForeColor = Color.ForestGreen;
            nextBtn.Location = new Point(482, 526);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(144, 58);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // carPictureBox
            // 
            carPictureBox.BackgroundImage = Properties.Resources.image_missing;
            carPictureBox.BackgroundImageLayout = ImageLayout.Center;
            carPictureBox.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox.ErrorImage = Properties.Resources.image_missing;
            carPictureBox.InitialImage = Properties.Resources.image_missing;
            carPictureBox.Location = new Point(42, 58);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(560, 317);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 3;
            carPictureBox.TabStop = false;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(255, 127, 110);
            exitBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            exitBtn.FlatAppearance.BorderSize = 2;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            exitBtn.ForeColor = Color.Red;
            exitBtn.Location = new Point(261, 526);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(153, 58);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // viewPanel
            // 
            viewPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewPanel.BackColor = Color.Transparent;
            viewPanel.Controls.Add(profileButton);
            viewPanel.Controls.Add(lblDisplayRange);
            viewPanel.Controls.Add(lblRange);
            viewPanel.Controls.Add(lblDisplayDrivetrain);
            viewPanel.Controls.Add(lblDrivetrain);
            viewPanel.Controls.Add(lblDisplayStorage);
            viewPanel.Controls.Add(lblStorage);
            viewPanel.Controls.Add(lblDisplayPassengers);
            viewPanel.Controls.Add(lblPassengers);
            viewPanel.Controls.Add(lblDisplaySeats);
            viewPanel.Controls.Add(lblDoors);
            viewPanel.Controls.Add(nextBtn);
            viewPanel.Controls.Add(exitBtn);
            viewPanel.Controls.Add(lblDisplayColor);
            viewPanel.Controls.Add(rentBtn);
            viewPanel.Controls.Add(prevBtn);
            viewPanel.Controls.Add(lblDisplayMileage);
            viewPanel.Controls.Add(lblDisplayType);
            viewPanel.Controls.Add(lblDisplayVehicleTitle);
            viewPanel.Controls.Add(lblColor);
            viewPanel.Controls.Add(lblMileage);
            viewPanel.Controls.Add(lblType);
            viewPanel.Controls.Add(carPictureBox);
            viewPanel.Location = new Point(42, 22);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(662, 612);
            viewPanel.TabIndex = 6;
            // 
            // profileButton
            // 
            profileButton.AutoEllipsis = true;
            profileButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            profileButton.BackColor = Color.Transparent;
            profileButton.FlatStyle = FlatStyle.Popup;
            profileButton.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileButton.Location = new Point(482, 3);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(177, 49);
            profileButton.TabIndex = 30;
            profileButton.Text = "Taufeeq Ali";
            profileButton.TextAlign = ContentAlignment.MiddleRight;
            profileButton.UseVisualStyleBackColor = false;
            // 
            // lblDisplayRange
            // 
            lblDisplayRange.AutoSize = true;
            lblDisplayRange.Font = new Font("Impact", 12F);
            lblDisplayRange.ForeColor = SystemColors.WindowFrame;
            lblDisplayRange.Location = new Point(592, 462);
            lblDisplayRange.Name = "lblDisplayRange";
            lblDisplayRange.Size = new Size(27, 25);
            lblDisplayRange.TabIndex = 29;
            lblDisplayRange.Text = "115";
            lblDisplayRange.UseCompatibleTextRendering = true;
            // 
            // lblRange
            // 
            lblRange.AutoSize = true;
            lblRange.Font = new Font("Impact", 12F);
            lblRange.Location = new Point(494, 462);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(50, 20);
            lblRange.TabIndex = 28;
            lblRange.Text = "Range";
            // 
            // lblDisplayDrivetrain
            // 
            lblDisplayDrivetrain.AutoSize = true;
            lblDisplayDrivetrain.Font = new Font("Impact", 12F);
            lblDisplayDrivetrain.ForeColor = SystemColors.WindowFrame;
            lblDisplayDrivetrain.Location = new Point(131, 462);
            lblDisplayDrivetrain.Name = "lblDisplayDrivetrain";
            lblDisplayDrivetrain.Size = new Size(34, 20);
            lblDisplayDrivetrain.TabIndex = 27;
            lblDisplayDrivetrain.Text = "Gas";
            // 
            // lblDrivetrain
            // 
            lblDrivetrain.AutoSize = true;
            lblDrivetrain.Font = new Font("Impact", 12F);
            lblDrivetrain.Location = new Point(26, 461);
            lblDrivetrain.Name = "lblDrivetrain";
            lblDrivetrain.Size = new Size(75, 20);
            lblDrivetrain.TabIndex = 26;
            lblDrivetrain.Text = "Drivetrain";
            // 
            // lblDisplayStorage
            // 
            lblDisplayStorage.AutoSize = true;
            lblDisplayStorage.Font = new Font("Impact", 12F);
            lblDisplayStorage.ForeColor = SystemColors.WindowFrame;
            lblDisplayStorage.Location = new Point(599, 440);
            lblDisplayStorage.Name = "lblDisplayStorage";
            lblDisplayStorage.Size = new Size(17, 20);
            lblDisplayStorage.TabIndex = 25;
            lblDisplayStorage.Text = "3";
            // 
            // lblStorage
            // 
            lblStorage.AutoSize = true;
            lblStorage.Font = new Font("Impact", 12F);
            lblStorage.Location = new Point(494, 441);
            lblStorage.Name = "lblStorage";
            lblStorage.Size = new Size(60, 20);
            lblStorage.TabIndex = 24;
            lblStorage.Text = "Storage";
            // 
            // lblDisplayPassengers
            // 
            lblDisplayPassengers.AutoSize = true;
            lblDisplayPassengers.Font = new Font("Impact", 12F);
            lblDisplayPassengers.ForeColor = SystemColors.WindowFrame;
            lblDisplayPassengers.Location = new Point(599, 417);
            lblDisplayPassengers.Name = "lblDisplayPassengers";
            lblDisplayPassengers.Size = new Size(17, 20);
            lblDisplayPassengers.TabIndex = 23;
            lblDisplayPassengers.Text = "4";
            // 
            // lblPassengers
            // 
            lblPassengers.AutoSize = true;
            lblPassengers.Font = new Font("Impact", 12F);
            lblPassengers.Location = new Point(494, 416);
            lblPassengers.Name = "lblPassengers";
            lblPassengers.Size = new Size(87, 20);
            lblPassengers.TabIndex = 22;
            lblPassengers.Text = "Passengers";
            // 
            // lblDisplaySeats
            // 
            lblDisplaySeats.AutoSize = true;
            lblDisplaySeats.Font = new Font("Impact", 12F);
            lblDisplaySeats.ForeColor = SystemColors.WindowFrame;
            lblDisplaySeats.Location = new Point(599, 394);
            lblDisplaySeats.Name = "lblDisplaySeats";
            lblDisplaySeats.Size = new Size(17, 20);
            lblDisplaySeats.TabIndex = 21;
            lblDisplaySeats.Text = "4";
            // 
            // lblDoors
            // 
            lblDoors.AutoSize = true;
            lblDoors.Font = new Font("Impact", 12F);
            lblDoors.Location = new Point(494, 394);
            lblDoors.Name = "lblDoors";
            lblDoors.Size = new Size(48, 20);
            lblDoors.TabIndex = 20;
            lblDoors.Text = "Doors";
            // 
            // lblDisplayColor
            // 
            lblDisplayColor.AutoSize = true;
            lblDisplayColor.Font = new Font("Impact", 12F);
            lblDisplayColor.ForeColor = SystemColors.WindowFrame;
            lblDisplayColor.Location = new Point(130, 441);
            lblDisplayColor.Name = "lblDisplayColor";
            lblDisplayColor.Size = new Size(38, 20);
            lblDisplayColor.TabIndex = 19;
            lblDisplayColor.Text = "Blue";
            // 
            // lblDisplayMileage
            // 
            lblDisplayMileage.AutoSize = true;
            lblDisplayMileage.Font = new Font("Impact", 12F);
            lblDisplayMileage.ForeColor = SystemColors.WindowFrame;
            lblDisplayMileage.Location = new Point(127, 418);
            lblDisplayMileage.Name = "lblDisplayMileage";
            lblDisplayMileage.Size = new Size(53, 20);
            lblDisplayMileage.TabIndex = 17;
            lblDisplayMileage.Text = "30000";
            // 
            // lblDisplayType
            // 
            lblDisplayType.AutoSize = true;
            lblDisplayType.Font = new Font("Impact", 12F);
            lblDisplayType.ForeColor = SystemColors.WindowFrame;
            lblDisplayType.Location = new Point(130, 394);
            lblDisplayType.Name = "lblDisplayType";
            lblDisplayType.Size = new Size(47, 20);
            lblDisplayType.TabIndex = 16;
            lblDisplayType.Text = "Hatch";
            // 
            // lblDisplayVehicleTitle
            // 
            lblDisplayVehicleTitle.AutoSize = true;
            lblDisplayVehicleTitle.BackColor = Color.Transparent;
            lblDisplayVehicleTitle.BorderStyle = BorderStyle.Fixed3D;
            lblDisplayVehicleTitle.Font = new Font("Impact", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisplayVehicleTitle.ForeColor = Color.Black;
            lblDisplayVehicleTitle.ImageAlign = ContentAlignment.TopCenter;
            lblDisplayVehicleTitle.Location = new Point(42, 6);
            lblDisplayVehicleTitle.Name = "lblDisplayVehicleTitle";
            lblDisplayVehicleTitle.Size = new Size(208, 36);
            lblDisplayVehicleTitle.TabIndex = 15;
            lblDisplayVehicleTitle.Text = "2012 Ford Focus";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Impact", 12F);
            lblColor.Location = new Point(26, 440);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(44, 20);
            lblColor.TabIndex = 12;
            lblColor.Text = "Color";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new Font("Impact", 12F);
            lblMileage.Location = new Point(26, 417);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(60, 20);
            lblMileage.TabIndex = 10;
            lblMileage.Text = "Mileage";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Impact", 12F);
            lblType.Location = new Point(26, 394);
            lblType.Name = "lblType";
            lblType.Size = new Size(39, 20);
            lblType.TabIndex = 9;
            lblType.Text = "Type";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(842, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 612);
            panel1.TabIndex = 31;
            // 
            // backButton
            // 
            backButton.AutoEllipsis = true;
            backButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backButton.BackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(482, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(177, 49);
            backButton.TabIndex = 30;
            backButton.Text = "Taufeeq Ali";
            backButton.TextAlign = ContentAlignment.MiddleRight;
            backButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(592, 462);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 29;
            label1.Text = "115";
            label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(494, 462);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 28;
            label2.Text = "Range";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(131, 462);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 27;
            label3.Text = "Gas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F);
            label4.Location = new Point(26, 461);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 26;
            label4.Text = "Drivetrain";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(599, 440);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 25;
            label5.Text = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F);
            label6.Location = new Point(494, 441);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 24;
            label6.Text = "Storage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F);
            label7.ForeColor = SystemColors.WindowFrame;
            label7.Location = new Point(599, 417);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 23;
            label7.Text = "4";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F);
            label8.Location = new Point(494, 416);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 22;
            label8.Text = "Passengers";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 12F);
            label9.ForeColor = SystemColors.WindowFrame;
            label9.Location = new Point(599, 394);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 21;
            label9.Text = "4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 12F);
            label10.Location = new Point(494, 394);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 20;
            label10.Text = "Doors";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 255, 104);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            button2.ForeColor = Color.ForestGreen;
            button2.Location = new Point(482, 526);
            button2.Name = "button2";
            button2.Size = new Size(144, 58);
            button2.TabIndex = 2;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 127, 110);
            button3.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(261, 526);
            button3.Name = "button3";
            button3.Size = new Size(153, 58);
            button3.TabIndex = 3;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 12F);
            label11.ForeColor = SystemColors.WindowFrame;
            label11.Location = new Point(130, 441);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 19;
            label11.Text = "Blue";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(96, 188, 255);
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            button4.ForeColor = Color.Blue;
            button4.Location = new Point(261, 415);
            button4.Name = "button4";
            button4.Size = new Size(153, 61);
            button4.TabIndex = 1;
            button4.Text = "Rent";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 170, 0);
            button5.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Impact", 20.25F, FontStyle.Italic);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(26, 526);
            button5.Name = "button5";
            button5.Size = new Size(141, 58);
            button5.TabIndex = 0;
            button5.Text = "Previous";
            button5.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Impact", 12F);
            label12.ForeColor = SystemColors.WindowFrame;
            label12.Location = new Point(127, 418);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 17;
            label12.Text = "30000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Impact", 12F);
            label13.ForeColor = SystemColors.WindowFrame;
            label13.Location = new Point(130, 394);
            label13.Name = "label13";
            label13.Size = new Size(47, 20);
            label13.TabIndex = 16;
            label13.Text = "Hatch";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Font = new Font("Impact", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.ImageAlign = ContentAlignment.TopCenter;
            label14.Location = new Point(42, 6);
            label14.Name = "label14";
            label14.Size = new Size(208, 36);
            label14.TabIndex = 15;
            label14.Text = "2012 Ford Focus";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Impact", 12F);
            label15.Location = new Point(26, 440);
            label15.Name = "label15";
            label15.Size = new Size(44, 20);
            label15.TabIndex = 12;
            label15.Text = "Color";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Impact", 12F);
            label16.Location = new Point(26, 417);
            label16.Name = "label16";
            label16.Size = new Size(60, 20);
            label16.TabIndex = 10;
            label16.Text = "Mileage";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Impact", 12F);
            label17.Location = new Point(26, 394);
            label17.Name = "label17";
            label17.Size = new Size(39, 20);
            label17.TabIndex = 9;
            label17.Text = "Type";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.image_missing;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = Properties.Resources.image_missing;
            pictureBox1.InitialImage = Properties.Resources.image_missing;
            pictureBox1.Location = new Point(42, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1791, 24);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { browseToolStripMenuItem, rentalsToolStripMenuItem, profileToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // browseToolStripMenuItem
            // 
            browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            browseToolStripMenuItem.Size = new Size(112, 22);
            browseToolStripMenuItem.Text = "Browse";
            // 
            // rentalsToolStripMenuItem
            // 
            rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            rentalsToolStripMenuItem.Size = new Size(112, 22);
            rentalsToolStripMenuItem.Text = "Rentals";
            rentalsToolStripMenuItem.Click += rentalsToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(112, 22);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // Carpick
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1791, 696);
            Controls.Add(panel1);
            Controls.Add(viewPanel);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Carpick";
            Text = "Carpick";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            viewPanel.ResumeLayout(false);
            viewPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button prevBtn;
        private Button rentBtn;
        private Button nextBtn;
        private PictureBox carPictureBox;
        private Panel viewPanel;
        private Button exitBtn;
        private Label lblColor;
        private Label lblMileage;
        private Label lblType;
        private Label lblDisplayColor;
        private Label lblDisplayMileage;
        private Label lblDisplayType;
        private Label lblDisplayVehicleTitle;
        private Label lblDisplayStorage;
        private Label lblStorage;
        private Label lblDisplayPassengers;
        private Label lblPassengers;
        private Label lblDisplaySeats;
        private Label lblDoors;
        private Label lblDisplayRange;
        private Label lblRange;
        private Label lblDisplayDrivetrain;
        private Label lblDrivetrain;
        private Button profileButton;
        private Panel panel1;
        private Button backButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button2;
        private Button button3;
        private Label label11;
        private Button button4;
        private Button button5;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem browseToolStripMenuItem;
        private ToolStripMenuItem rentalsToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
    }
}
