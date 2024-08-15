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
            rentalPanel = new Panel();
            vehicleInfoTabs = new TabControl();
            rentalPage = new TabPage();
            vehiclePage = new TabPage();
            miscPage = new TabPage();
            controlPanel = new Panel();
            viewPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            rentalPanel.SuspendLayout();
            vehicleInfoTabs.SuspendLayout();
            controlPanel.SuspendLayout();
            viewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(510, 0);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(133, 58);
            prevBtn.TabIndex = 0;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = true;
            // 
            // rentBtn
            // 
            rentBtn.Location = new Point(253, 0);
            rentBtn.Name = "rentBtn";
            rentBtn.Size = new Size(145, 58);
            rentBtn.TabIndex = 1;
            rentBtn.Text = "Rent";
            rentBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(0, 0);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(136, 58);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // carPictureBox
            // 
            carPictureBox.ErrorImage = Properties.Resources.car_image_stock;
            carPictureBox.InitialImage = Properties.Resources.car_image_stock;
            carPictureBox.Location = new Point(3, 0);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(640, 312);
            carPictureBox.TabIndex = 3;
            carPictureBox.TabStop = false;
            // 
            // rentalPanel
            // 
            rentalPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rentalPanel.Controls.Add(vehicleInfoTabs);
            rentalPanel.Location = new Point(0, 0);
            rentalPanel.Name = "rentalPanel";
            rentalPanel.Size = new Size(284, 569);
            rentalPanel.TabIndex = 4;
            // 
            // vehicleInfoTabs
            // 
            vehicleInfoTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vehicleInfoTabs.Controls.Add(rentalPage);
            vehicleInfoTabs.Controls.Add(vehiclePage);
            vehicleInfoTabs.Controls.Add(miscPage);
            vehicleInfoTabs.Location = new Point(10, 12);
            vehicleInfoTabs.Name = "vehicleInfoTabs";
            vehicleInfoTabs.SelectedIndex = 0;
            vehicleInfoTabs.Size = new Size(264, 547);
            vehicleInfoTabs.TabIndex = 0;
            // 
            // rentalPage
            // 
            rentalPage.Location = new Point(4, 24);
            rentalPage.Name = "rentalPage";
            rentalPage.Padding = new Padding(3);
            rentalPage.Size = new Size(256, 519);
            rentalPage.TabIndex = 0;
            rentalPage.Text = "Rentals";
            rentalPage.UseVisualStyleBackColor = true;
            // 
            // vehiclePage
            // 
            vehiclePage.Location = new Point(4, 24);
            vehiclePage.Name = "vehiclePage";
            vehiclePage.Padding = new Padding(3);
            vehiclePage.Size = new Size(256, 519);
            vehiclePage.TabIndex = 1;
            vehiclePage.Text = "Vehicle";
            vehiclePage.UseVisualStyleBackColor = true;
            // 
            // miscPage
            // 
            miscPage.Location = new Point(4, 24);
            miscPage.Name = "miscPage";
            miscPage.Size = new Size(256, 519);
            miscPage.TabIndex = 2;
            miscPage.Text = "Miscellaneous";
            miscPage.UseVisualStyleBackColor = true;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(nextBtn);
            controlPanel.Controls.Add(prevBtn);
            controlPanel.Controls.Add(rentBtn);
            controlPanel.Location = new Point(0, 529);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(643, 57);
            controlPanel.TabIndex = 5;
            // 
            // viewPanel
            // 
            viewPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewPanel.Controls.Add(controlPanel);
            viewPanel.Controls.Add(carPictureBox);
            viewPanel.Location = new Point(585, 0);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(645, 625);
            viewPanel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 1049);
            Controls.Add(viewPanel);
            Controls.Add(rentalPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            rentalPanel.ResumeLayout(false);
            vehicleInfoTabs.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            viewPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button prevBtn;
        private Button rentBtn;
        private Button nextBtn;
        private PictureBox carPictureBox;
        private Panel rentalPanel;
        private TabControl vehicleInfoTabs;
        private TabPage rentalPage;
        private TabPage vehiclePage;
        private TabPage miscPage;
        private Panel controlPanel;
        private Panel viewPanel;
    }
}
