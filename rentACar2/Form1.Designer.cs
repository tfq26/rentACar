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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            browseToolStripMenuItem = new ToolStripMenuItem();
            rentalsToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            listboxVehicles = new ListBox();
            comboType = new ComboBox();
            comboMake = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            viewPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            viewPanel.Location = new Point(284, 22);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(684, 612);
            viewPanel.TabIndex = 6;
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1016, 24);
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
            // panel1
            // 
            panel1.Controls.Add(listboxVehicles);
            panel1.Controls.Add(comboType);
            panel1.Controls.Add(comboMake);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 612);
            panel1.TabIndex = 33;
            // 
            // listboxVehicles
            // 
            listboxVehicles.FormattingEnabled = true;
            listboxVehicles.ItemHeight = 15;
            listboxVehicles.Location = new Point(26, 117);
            listboxVehicles.Name = "listboxVehicles";
            listboxVehicles.Size = new Size(179, 409);
            listboxVehicles.TabIndex = 6;
            // 
            // comboType
            // 
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(84, 55);
            comboType.Name = "comboType";
            comboType.Size = new Size(121, 23);
            comboType.TabIndex = 5;
            comboType.SelectedIndexChanged += comboType_SelectedIndexChanged;
            // 
            // comboMake
            // 
            comboMake.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMake.FormattingEnabled = true;
            comboMake.Location = new Point(84, 21);
            comboMake.Name = "comboMake";
            comboMake.Size = new Size(121, 23);
            comboMake.TabIndex = 4;
            comboMake.SelectedIndexChanged += comboMake_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 58);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Make";
            // 
            // Carpick
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1016, 696);
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem browseToolStripMenuItem;
        private ToolStripMenuItem rentalsToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Panel panel1;
        private ListBox listboxVehicles;
        private ComboBox comboType;
        private ComboBox comboMake;
        private Label label2;
        private Label label1;
    }
}
