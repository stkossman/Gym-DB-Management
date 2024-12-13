namespace Gym
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
            LoginPictureExit = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            LoginTxtUsername = new TextBox();
            LoginTxtPassword = new TextBox();
            LoginBtnLogin = new Button();
            openEye = new PictureBox();
            closedEye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LoginPictureExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closedEye).BeginInit();
            SuspendLayout();
            // 
            // LoginPictureExit
            // 
            LoginPictureExit.Image = Properties.Resources.exit64;
            LoginPictureExit.Location = new Point(582, 9);
            LoginPictureExit.Name = "LoginPictureExit";
            LoginPictureExit.Size = new Size(37, 38);
            LoginPictureExit.SizeMode = PictureBoxSizeMode.Zoom;
            LoginPictureExit.TabIndex = 0;
            LoginPictureExit.TabStop = false;
            LoginPictureExit.Click += LoginPictureExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("NAMU 1960", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(459, 34);
            label1.TabIndex = 1;
            label1.Text = "Kossman's Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dumbell128;
            pictureBox1.Location = new Point(265, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LoginTxtUsername
            // 
            LoginTxtUsername.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTxtUsername.Location = new Point(230, 214);
            LoginTxtUsername.Name = "LoginTxtUsername";
            LoginTxtUsername.PlaceholderText = "Username";
            LoginTxtUsername.Size = new Size(193, 27);
            LoginTxtUsername.TabIndex = 3;
            // 
            // LoginTxtPassword
            // 
            LoginTxtPassword.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTxtPassword.Location = new Point(230, 268);
            LoginTxtPassword.Name = "LoginTxtPassword";
            LoginTxtPassword.PlaceholderText = "Password";
            LoginTxtPassword.Size = new Size(193, 27);
            LoginTxtPassword.TabIndex = 3;
            // 
            // LoginBtnLogin
            // 
            LoginBtnLogin.BackColor = Color.FromArgb(0, 126, 249);
            LoginBtnLogin.FlatAppearance.BorderSize = 0;
            LoginBtnLogin.FlatStyle = FlatStyle.Flat;
            LoginBtnLogin.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginBtnLogin.Location = new Point(230, 323);
            LoginBtnLogin.Name = "LoginBtnLogin";
            LoginBtnLogin.Size = new Size(193, 33);
            LoginBtnLogin.TabIndex = 4;
            LoginBtnLogin.Text = "Login";
            LoginBtnLogin.UseVisualStyleBackColor = false;
            LoginBtnLogin.Click += LoginBtnLogin_Click;
            // 
            // openEye
            // 
            openEye.BackColor = Color.White;
            openEye.Image = Properties.Resources.openEye;
            openEye.Location = new Point(396, 270);
            openEye.Name = "openEye";
            openEye.Size = new Size(27, 25);
            openEye.SizeMode = PictureBoxSizeMode.Zoom;
            openEye.TabIndex = 5;
            openEye.TabStop = false;
            openEye.Click += openEye_Click;
            // 
            // closedEye
            // 
            closedEye.BackColor = Color.White;
            closedEye.Image = Properties.Resources.closedEye;
            closedEye.Location = new Point(396, 270);
            closedEye.Name = "closedEye";
            closedEye.Size = new Size(27, 25);
            closedEye.SizeMode = PictureBoxSizeMode.StretchImage;
            closedEye.TabIndex = 5;
            closedEye.TabStop = false;
            closedEye.Click += closedEye_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(631, 509);
            Controls.Add(closedEye);
            Controls.Add(openEye);
            Controls.Add(LoginBtnLogin);
            Controls.Add(LoginTxtPassword);
            Controls.Add(LoginTxtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(LoginPictureExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)LoginPictureExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)openEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)closedEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LoginPictureExit;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox LoginTxtUsername;
        private TextBox LoginTxtPassword;
        private Button LoginBtnLogin;
        private PictureBox openEye;
        private PictureBox closedEye;
    }
}