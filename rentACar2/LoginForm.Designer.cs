namespace rentACar2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            splashPanel = new Panel();
            titleLabelLogin = new Label();
            exitBtnLogin = new Button();
            createAccountPanel = new Panel();
            loginPanel = new Panel();
            loginDebugbtn = new Button();
            lblDisplayError = new Label();
            LoginButton = new Button();
            boxPasswordLogin = new TextBox();
            boxUsernameLogin = new TextBox();
            btnCreateAccount = new Button();
            boxUserPhone = new TextBox();
            boxUserEmail = new TextBox();
            boxUserPassword = new TextBox();
            boxUserName = new TextBox();
            lblDisplayPhonePrompt = new Label();
            lblDisplayPasswordPrompt = new Label();
            lblDisplayEmailPrompt = new Label();
            lblDisplayUsernamePrompt = new Label();
            btnSwitchAccountView = new Button();
            label2 = new Label();
            splashPanel.SuspendLayout();
            createAccountPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splashPanel
            // 
            splashPanel.Controls.Add(titleLabelLogin);
            splashPanel.Controls.Add(exitBtnLogin);
            splashPanel.Controls.Add(createAccountPanel);
            splashPanel.Controls.Add(btnSwitchAccountView);
            splashPanel.Controls.Add(label2);
            splashPanel.Location = new Point(12, 8);
            splashPanel.Name = "splashPanel";
            splashPanel.Size = new Size(520, 750);
            splashPanel.TabIndex = 1;
            // 
            // titleLabelLogin
            // 
            titleLabelLogin.AutoSize = true;
            titleLabelLogin.Font = new Font("Verdana", 80.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabelLogin.ForeColor = Color.DarkOrange;
            titleLabelLogin.Location = new Point(21, 18);
            titleLabelLogin.Name = "titleLabelLogin";
            titleLabelLogin.Size = new Size(456, 130);
            titleLabelLogin.TabIndex = 15;
            titleLabelLogin.Text = "Carpick";
            // 
            // exitBtnLogin
            // 
            exitBtnLogin.BackColor = Color.Red;
            exitBtnLogin.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtnLogin.ForeColor = SystemColors.Control;
            exitBtnLogin.Location = new Point(356, 642);
            exitBtnLogin.Name = "exitBtnLogin";
            exitBtnLogin.Size = new Size(92, 41);
            exitBtnLogin.TabIndex = 14;
            exitBtnLogin.Text = "Exit";
            exitBtnLogin.UseVisualStyleBackColor = false;
            exitBtnLogin.Click += exitBtnLogin_Click;
            // 
            // createAccountPanel
            // 
            createAccountPanel.BackColor = SystemColors.Window;
            createAccountPanel.Controls.Add(loginPanel);
            createAccountPanel.Controls.Add(btnCreateAccount);
            createAccountPanel.Controls.Add(boxUserPhone);
            createAccountPanel.Controls.Add(boxUserEmail);
            createAccountPanel.Controls.Add(boxUserPassword);
            createAccountPanel.Controls.Add(boxUserName);
            createAccountPanel.Controls.Add(lblDisplayPhonePrompt);
            createAccountPanel.Controls.Add(lblDisplayPasswordPrompt);
            createAccountPanel.Controls.Add(lblDisplayEmailPrompt);
            createAccountPanel.Controls.Add(lblDisplayUsernamePrompt);
            createAccountPanel.Location = new Point(34, 218);
            createAccountPanel.Name = "createAccountPanel";
            createAccountPanel.Size = new Size(443, 375);
            createAccountPanel.TabIndex = 12;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Cornsilk;
            loginPanel.Controls.Add(loginDebugbtn);
            loginPanel.Controls.Add(lblDisplayError);
            loginPanel.Controls.Add(LoginButton);
            loginPanel.Controls.Add(boxPasswordLogin);
            loginPanel.Controls.Add(boxUsernameLogin);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(443, 375);
            loginPanel.TabIndex = 10;
            // 
            // loginDebugbtn
            // 
            loginDebugbtn.BackColor = Color.RoyalBlue;
            loginDebugbtn.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginDebugbtn.ForeColor = SystemColors.Control;
            loginDebugbtn.Location = new Point(100, 249);
            loginDebugbtn.Name = "loginDebugbtn";
            loginDebugbtn.Size = new Size(237, 41);
            loginDebugbtn.TabIndex = 10;
            loginDebugbtn.Text = "Login (Debug)";
            loginDebugbtn.UseVisualStyleBackColor = false;
            loginDebugbtn.Click += loginDebugbtn_Click;
            // 
            // lblDisplayError
            // 
            lblDisplayError.AutoSize = true;
            lblDisplayError.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayError.ForeColor = Color.Red;
            lblDisplayError.Location = new Point(160, 200);
            lblDisplayError.Margin = new Padding(0);
            lblDisplayError.Name = "lblDisplayError";
            lblDisplayError.Size = new Size(124, 45);
            lblDisplayError.TabIndex = 9;
            lblDisplayError.Text = "Error";
            lblDisplayError.TextAlign = ContentAlignment.MiddleCenter;
            lblDisplayError.Visible = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(47, 208, 116);
            LoginButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.Control;
            LoginButton.Location = new Point(100, 296);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(237, 41);
            LoginButton.TabIndex = 8;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // boxPasswordLogin
            // 
            boxPasswordLogin.AcceptsReturn = true;
            boxPasswordLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxPasswordLogin.Location = new Point(17, 100);
            boxPasswordLogin.Name = "boxPasswordLogin";
            boxPasswordLogin.PasswordChar = '*';
            boxPasswordLogin.PlaceholderText = "Password";
            boxPasswordLogin.Size = new Size(408, 39);
            boxPasswordLogin.TabIndex = 5;
            boxPasswordLogin.KeyUp += boxPasswordLogin_KeyUp;
            // 
            // boxUsernameLogin
            // 
            boxUsernameLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxUsernameLogin.Location = new Point(17, 30);
            boxUsernameLogin.Name = "boxUsernameLogin";
            boxUsernameLogin.PlaceholderText = "Email";
            boxUsernameLogin.Size = new Size(408, 39);
            boxUsernameLogin.TabIndex = 4;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(47, 208, 116);
            btnCreateAccount.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(91, 296);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(237, 41);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // boxUserPhone
            // 
            boxUserPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxUserPhone.Location = new Point(163, 225);
            boxUserPhone.Name = "boxUserPhone";
            boxUserPhone.Size = new Size(262, 39);
            boxUserPhone.TabIndex = 7;
            // 
            // boxUserEmail
            // 
            boxUserEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxUserEmail.Location = new Point(163, 150);
            boxUserEmail.Name = "boxUserEmail";
            boxUserEmail.Size = new Size(262, 39);
            boxUserEmail.TabIndex = 6;
            // 
            // boxUserPassword
            // 
            boxUserPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxUserPassword.Location = new Point(163, 84);
            boxUserPassword.Name = "boxUserPassword";
            boxUserPassword.Size = new Size(262, 39);
            boxUserPassword.TabIndex = 5;
            // 
            // boxUserName
            // 
            boxUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxUserName.Location = new Point(163, 14);
            boxUserName.Name = "boxUserName";
            boxUserName.Size = new Size(262, 39);
            boxUserName.TabIndex = 4;
            // 
            // lblDisplayPhonePrompt
            // 
            lblDisplayPhonePrompt.AutoSize = true;
            lblDisplayPhonePrompt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayPhonePrompt.Location = new Point(3, 230);
            lblDisplayPhonePrompt.Name = "lblDisplayPhonePrompt";
            lblDisplayPhonePrompt.Size = new Size(154, 30);
            lblDisplayPhonePrompt.TabIndex = 3;
            lblDisplayPhonePrompt.Text = "Phone Number";
            // 
            // lblDisplayPasswordPrompt
            // 
            lblDisplayPasswordPrompt.AutoSize = true;
            lblDisplayPasswordPrompt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayPasswordPrompt.Location = new Point(3, 89);
            lblDisplayPasswordPrompt.Name = "lblDisplayPasswordPrompt";
            lblDisplayPasswordPrompt.Size = new Size(99, 30);
            lblDisplayPasswordPrompt.TabIndex = 2;
            lblDisplayPasswordPrompt.Text = "Password";
            // 
            // lblDisplayEmailPrompt
            // 
            lblDisplayEmailPrompt.AutoSize = true;
            lblDisplayEmailPrompt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayEmailPrompt.Location = new Point(3, 156);
            lblDisplayEmailPrompt.Name = "lblDisplayEmailPrompt";
            lblDisplayEmailPrompt.Size = new Size(63, 30);
            lblDisplayEmailPrompt.TabIndex = 1;
            lblDisplayEmailPrompt.Text = "Email";
            // 
            // lblDisplayUsernamePrompt
            // 
            lblDisplayUsernamePrompt.AutoSize = true;
            lblDisplayUsernamePrompt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayUsernamePrompt.Location = new Point(3, 19);
            lblDisplayUsernamePrompt.Name = "lblDisplayUsernamePrompt";
            lblDisplayUsernamePrompt.Size = new Size(112, 30);
            lblDisplayUsernamePrompt.TabIndex = 0;
            lblDisplayUsernamePrompt.Text = "User name";
            // 
            // btnSwitchAccountView
            // 
            btnSwitchAccountView.BackColor = Color.FromArgb(235, 167, 54);
            btnSwitchAccountView.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwitchAccountView.ForeColor = SystemColors.Control;
            btnSwitchAccountView.Location = new Point(34, 642);
            btnSwitchAccountView.Name = "btnSwitchAccountView";
            btnSwitchAccountView.Size = new Size(237, 41);
            btnSwitchAccountView.TabIndex = 13;
            btnSwitchAccountView.Text = "Create Account";
            btnSwitchAccountView.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(6, 167);
            label2.Name = "label2";
            label2.Size = new Size(511, 35);
            label2.TabIndex = 11;
            label2.Text = "Rental Car Program by Taufeeq Ali";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(547, 770);
            Controls.Add(splashPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            splashPanel.ResumeLayout(false);
            splashPanel.PerformLayout();
            createAccountPanel.ResumeLayout(false);
            createAccountPanel.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel splashPanel;
        private Button exitBtnLogin;
        private Panel createAccountPanel;
        private Panel loginPanel;
        private Label lblDisplayError;
        private Button LoginButton;
        private TextBox boxPasswordLogin;
        private TextBox boxUsernameLogin;
        private Button btnCreateAccount;
        private TextBox boxUserPhone;
        private TextBox boxUserEmail;
        private TextBox boxUserPassword;
        private TextBox boxUserName;
        private Label lblDisplayPhonePrompt;
        private Label lblDisplayPasswordPrompt;
        private Label lblDisplayEmailPrompt;
        private Label lblDisplayUsernamePrompt;
        private Button btnSwitchAccountView;
        private Label label2;
        private Label titleLabelLogin;
        private Button loginDebugbtn;
    }
}