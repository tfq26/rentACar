namespace rentACar2
{
    partial class rentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentalForm));
            displayVehiclePictureBox = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            rentalStartLabel = new Label();
            label1 = new Label();
            lblDisplayStartDate = new Label();
            lblDisplayEndDate = new Label();
            lblVehicleRentalLink = new LinkLabel();
            lblCustomerLink = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)displayVehiclePictureBox).BeginInit();
            SuspendLayout();
            // 
            // displayVehiclePictureBox
            // 
            displayVehiclePictureBox.BackColor = Color.SandyBrown;
            displayVehiclePictureBox.ErrorImage = Properties.Resources.image_missing;
            displayVehiclePictureBox.InitialImage = Properties.Resources.image_missing;
            displayVehiclePictureBox.Location = new Point(175, 20);
            displayVehiclePictureBox.Name = "displayVehiclePictureBox";
            displayVehiclePictureBox.Size = new Size(650, 350);
            displayVehiclePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            displayVehiclePictureBox.TabIndex = 0;
            displayVehiclePictureBox.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Moccasin;
            monthCalendar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar1.Location = new Point(175, 442);
            monthCalendar1.MaximumSize = new Size(1000, 1000);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.TitleBackColor = SystemColors.ActiveCaptionText;
            monthCalendar1.TitleForeColor = SystemColors.AppWorkspace;
            // 
            // rentalStartLabel
            // 
            rentalStartLabel.AutoSize = true;
            rentalStartLabel.Font = new Font("Verdana", 15F);
            rentalStartLabel.Location = new Point(470, 440);
            rentalStartLabel.Name = "rentalStartLabel";
            rentalStartLabel.Size = new Size(144, 25);
            rentalStartLabel.TabIndex = 2;
            rentalStartLabel.Text = "Rental Start:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15F);
            label1.Location = new Point(470, 490);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 3;
            label1.Text = "Rental End:";
            // 
            // lblDisplayStartDate
            // 
            lblDisplayStartDate.AutoSize = true;
            lblDisplayStartDate.Font = new Font("Verdana", 15F);
            lblDisplayStartDate.Location = new Point(642, 440);
            lblDisplayStartDate.Name = "lblDisplayStartDate";
            lblDisplayStartDate.Size = new Size(134, 25);
            lblDisplayStartDate.TabIndex = 4;
            lblDisplayStartDate.Text = "08/26/2004";
            // 
            // lblDisplayEndDate
            // 
            lblDisplayEndDate.AutoSize = true;
            lblDisplayEndDate.Font = new Font("Verdana", 15F);
            lblDisplayEndDate.Location = new Point(640, 490);
            lblDisplayEndDate.Name = "lblDisplayEndDate";
            lblDisplayEndDate.Size = new Size(134, 25);
            lblDisplayEndDate.TabIndex = 5;
            lblDisplayEndDate.Text = "09/30/2024";
            // 
            // lblVehicleRentalLink
            // 
            lblVehicleRentalLink.AutoSize = true;
            lblVehicleRentalLink.Font = new Font("Verdana", 20F);
            lblVehicleRentalLink.Location = new Point(377, 386);
            lblVehicleRentalLink.Name = "lblVehicleRentalLink";
            lblVehicleRentalLink.Size = new Size(238, 32);
            lblVehicleRentalLink.TabIndex = 6;
            lblVehicleRentalLink.TabStop = true;
            lblVehicleRentalLink.Text = "2012 Ford Focus";
            // 
            // lblCustomerLink
            // 
            lblCustomerLink.AutoSize = true;
            lblCustomerLink.Font = new Font("Verdana", 14F);
            lblCustomerLink.LinkBehavior = LinkBehavior.NeverUnderline;
            lblCustomerLink.LinkColor = Color.DarkOrange;
            lblCustomerLink.Location = new Point(640, 540);
            lblCustomerLink.Name = "lblCustomerLink";
            lblCustomerLink.Size = new Size(125, 23);
            lblCustomerLink.TabIndex = 7;
            lblCustomerLink.TabStop = true;
            lblCustomerLink.Text = "Joe Schmoe";
            lblCustomerLink.VisitedLinkColor = Color.Chocolate;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F);
            label2.Location = new Point(470, 540);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 8;
            label2.Text = "Rental End:";
            // 
            // rentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(984, 661);
            Controls.Add(label2);
            Controls.Add(lblCustomerLink);
            Controls.Add(lblVehicleRentalLink);
            Controls.Add(lblDisplayEndDate);
            Controls.Add(lblDisplayStartDate);
            Controls.Add(label1);
            Controls.Add(rentalStartLabel);
            Controls.Add(monthCalendar1);
            Controls.Add(displayVehiclePictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rentalForm";
            Text = "Carpick";
            ((System.ComponentModel.ISupportInitialize)displayVehiclePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox displayVehiclePictureBox;
        private MonthCalendar monthCalendar1;
        private Label rentalStartLabel;
        private Label label1;
        private Label lblDisplayStartDate;
        private Label lblDisplayEndDate;
        private LinkLabel lblVehicleRentalLink;
        private LinkLabel lblCustomerLink;
        private Label label2;
    }
}