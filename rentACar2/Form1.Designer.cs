namespace rentACar2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            prevBtn = new Button();
            rentBtn = new Button();
            nextBtn = new Button();
            carPictureBox = new PictureBox();
            exitBtn = new Button();
            viewPanel = new Panel();
            lblDisplayColor = new Label();
            lblDisplayCondition = new Label();
            lblDisplayMileage = new Label();
            lblDisplayType = new Label();
            lblDisplayYear = new Label();
            lblDisplayModel = new Label();
            lblDisplayMake = new Label();
            lblColor = new Label();
            lblCondition = new Label();
            lblMileage = new Label();
            lblType = new Label();
            lblYear = new Label();
            lblModel = new Label();
            lblMake = new Label();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            viewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(20, 526);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(133, 58);
            prevBtn.TabIndex = 0;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // rentBtn
            // 
            rentBtn.Location = new Point(159, 526);
            rentBtn.Name = "rentBtn";
            rentBtn.Size = new Size(145, 58);
            rentBtn.TabIndex = 1;
            rentBtn.Text = "Rent";
            rentBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(482, 526);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(136, 58);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // carPictureBox
            // 
            carPictureBox.ErrorImage = Properties.Resources.image_missing;
            carPictureBox.InitialImage = Properties.Resources.image_missing;
            carPictureBox.Location = new Point(16, 16);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(626, 312);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 3;
            carPictureBox.TabStop = false;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(320, 526);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(145, 58);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // viewPanel
            // 
            viewPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewPanel.Controls.Add(nextBtn);
            viewPanel.Controls.Add(exitBtn);
            viewPanel.Controls.Add(lblDisplayColor);
            viewPanel.Controls.Add(lblDisplayCondition);
            viewPanel.Controls.Add(rentBtn);
            viewPanel.Controls.Add(prevBtn);
            viewPanel.Controls.Add(lblDisplayMileage);
            viewPanel.Controls.Add(lblDisplayType);
            viewPanel.Controls.Add(lblDisplayYear);
            viewPanel.Controls.Add(lblDisplayModel);
            viewPanel.Controls.Add(lblDisplayMake);
            viewPanel.Controls.Add(lblColor);
            viewPanel.Controls.Add(lblCondition);
            viewPanel.Controls.Add(lblMileage);
            viewPanel.Controls.Add(lblType);
            viewPanel.Controls.Add(lblYear);
            viewPanel.Controls.Add(lblModel);
            viewPanel.Controls.Add(lblMake);
            viewPanel.Controls.Add(carPictureBox);
            viewPanel.Location = new Point(40, 12);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(662, 612);
            viewPanel.TabIndex = 6;
            // 
            // lblDisplayColor
            // 
            lblDisplayColor.AutoSize = true;
            lblDisplayColor.Location = new Point(111, 489);
            lblDisplayColor.Name = "lblDisplayColor";
            lblDisplayColor.Size = new Size(38, 15);
            lblDisplayColor.TabIndex = 19;
            lblDisplayColor.Text = "label1";
            // 
            // lblDisplayCondition
            // 
            lblDisplayCondition.AutoSize = true;
            lblDisplayCondition.Location = new Point(111, 467);
            lblDisplayCondition.Name = "lblDisplayCondition";
            lblDisplayCondition.Size = new Size(38, 15);
            lblDisplayCondition.TabIndex = 18;
            lblDisplayCondition.Text = "label1";
            // 
            // lblDisplayMileage
            // 
            lblDisplayMileage.AutoSize = true;
            lblDisplayMileage.Location = new Point(111, 443);
            lblDisplayMileage.Name = "lblDisplayMileage";
            lblDisplayMileage.Size = new Size(38, 15);
            lblDisplayMileage.TabIndex = 17;
            lblDisplayMileage.Text = "label1";
            // 
            // lblDisplayType
            // 
            lblDisplayType.AutoSize = true;
            lblDisplayType.Location = new Point(111, 419);
            lblDisplayType.Name = "lblDisplayType";
            lblDisplayType.Size = new Size(38, 15);
            lblDisplayType.TabIndex = 16;
            lblDisplayType.Text = "label1";
            // 
            // lblDisplayYear
            // 
            lblDisplayYear.AutoSize = true;
            lblDisplayYear.Location = new Point(111, 395);
            lblDisplayYear.Name = "lblDisplayYear";
            lblDisplayYear.Size = new Size(38, 15);
            lblDisplayYear.TabIndex = 15;
            lblDisplayYear.Text = "label1";
            // 
            // lblDisplayModel
            // 
            lblDisplayModel.AutoSize = true;
            lblDisplayModel.Location = new Point(111, 370);
            lblDisplayModel.Name = "lblDisplayModel";
            lblDisplayModel.Size = new Size(38, 15);
            lblDisplayModel.TabIndex = 14;
            lblDisplayModel.Text = "label1";
            // 
            // lblDisplayMake
            // 
            lblDisplayMake.AutoSize = true;
            lblDisplayMake.Location = new Point(111, 347);
            lblDisplayMake.Name = "lblDisplayMake";
            lblDisplayMake.Size = new Size(38, 15);
            lblDisplayMake.TabIndex = 13;
            lblDisplayMake.Text = "label1";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblColor.Location = new Point(26, 489);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 12;
            lblColor.Text = "Color";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCondition.Location = new Point(26, 467);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(60, 15);
            lblCondition.TabIndex = 11;
            lblCondition.Text = "Condition";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMileage.Location = new Point(26, 443);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(51, 15);
            lblMileage.TabIndex = 10;
            lblMileage.Text = "Mileage";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblType.Location = new Point(26, 419);
            lblType.Name = "lblType";
            lblType.Size = new Size(33, 15);
            lblType.TabIndex = 9;
            lblType.Text = "Type";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYear.Location = new Point(26, 395);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(31, 15);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModel.Location = new Point(26, 370);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(42, 15);
            lblModel.TabIndex = 7;
            lblModel.Text = "Model";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMake.Location = new Point(26, 346);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(38, 15);
            lblMake.TabIndex = 6;
            lblMake.Text = "Make";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(743, 652);
            Controls.Add(viewPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            viewPanel.ResumeLayout(false);
            viewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button prevBtn;
        private Button rentBtn;
        private Button nextBtn;
        private PictureBox carPictureBox;
        private Panel viewPanel;
        private Button exitBtn;
        private Label lblMake;
        private Label lblDisplayMake;
        private Label lblColor;
        private Label lblCondition;
        private Label lblMileage;
        private Label lblType;
        private Label lblYear;
        private Label lblModel;
        private Label lblDisplayColor;
        private Label lblDisplayCondition;
        private Label lblDisplayMileage;
        private Label lblDisplayType;
        private Label lblDisplayYear;
        private Label lblDisplayModel;
    }
}
