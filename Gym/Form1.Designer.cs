﻿namespace Gym
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
            panel1 = new Panel();
            pnlNav = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            btnMemberships = new Button();
            btnBilling = new Button();
            btnReceptionists = new Button();
            btnMembers = new Button();
            btnCoach = new Button();
            btnHome = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            NavTxtUsername = new Label();
            pictureBox1 = new PictureBox();
            dashboard1 = new Dashboard();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            manageCoach1 = new ManageCoach();
            manageMembers1 = new ManageMembers();
            manageMemberships1 = new ManageMemberships();
            manageReceptionists1 = new ManageReceptionists();
            manageBilling1 = new ManageBilling();
            homePage1 = new HomePage();
            pnlTitleBar = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnMemberships);
            panel1.Controls.Add(btnBilling);
            panel1.Controls.Add(btnReceptionists);
            panel1.Controls.Add(btnMembers);
            panel1.Controls.Add(btnCoach);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 631);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.FromArgb(0, 126, 249);
            btnExit.Image = Properties.Resources.exit32;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 547);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(186, 42);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            btnExit.Leave += btnLogout_Leave;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogout.ForeColor = Color.FromArgb(0, 126, 249);
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 589);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(186, 42);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            btnLogout.Leave += btnLogout_Leave;
            // 
            // btnMemberships
            // 
            btnMemberships.FlatAppearance.BorderSize = 0;
            btnMemberships.FlatStyle = FlatStyle.Flat;
            btnMemberships.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMemberships.ForeColor = Color.FromArgb(0, 126, 249);
            btnMemberships.Image = Properties.Resources.membership32;
            btnMemberships.ImageAlign = ContentAlignment.MiddleLeft;
            btnMemberships.Location = new Point(0, 352);
            btnMemberships.Name = "btnMemberships";
            btnMemberships.Size = new Size(186, 42);
            btnMemberships.TabIndex = 1;
            btnMemberships.Text = "Memberships";
            btnMemberships.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMemberships.UseVisualStyleBackColor = true;
            btnMemberships.Click += btnMemberships_Click;
            btnMemberships.Leave += btnMemberships_Leave;
            // 
            // btnBilling
            // 
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBilling.ForeColor = Color.FromArgb(0, 126, 249);
            btnBilling.Image = Properties.Resources.finance;
            btnBilling.ImageAlign = ContentAlignment.MiddleLeft;
            btnBilling.Location = new Point(0, 310);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(186, 42);
            btnBilling.TabIndex = 1;
            btnBilling.Text = "Billing";
            btnBilling.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            btnBilling.Leave += btnBilling_Leave;
            // 
            // btnReceptionists
            // 
            btnReceptionists.FlatAppearance.BorderSize = 0;
            btnReceptionists.FlatStyle = FlatStyle.Flat;
            btnReceptionists.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnReceptionists.ForeColor = Color.FromArgb(0, 126, 249);
            btnReceptionists.Image = Properties.Resources.receptionist;
            btnReceptionists.ImageAlign = ContentAlignment.MiddleLeft;
            btnReceptionists.Location = new Point(0, 268);
            btnReceptionists.Name = "btnReceptionists";
            btnReceptionists.Size = new Size(186, 42);
            btnReceptionists.TabIndex = 1;
            btnReceptionists.Text = "Receptionists";
            btnReceptionists.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReceptionists.UseVisualStyleBackColor = true;
            btnReceptionists.Click += btnReceptionists_Click;
            btnReceptionists.Leave += btnReceptionists_Leave;
            // 
            // btnMembers
            // 
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMembers.ForeColor = Color.FromArgb(0, 126, 249);
            btnMembers.Image = Properties.Resources.member;
            btnMembers.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembers.Location = new Point(0, 226);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(186, 42);
            btnMembers.TabIndex = 1;
            btnMembers.Text = "Members";
            btnMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            btnMembers.Leave += btnMembers_Leave;
            // 
            // btnCoach
            // 
            btnCoach.FlatAppearance.BorderSize = 0;
            btnCoach.FlatStyle = FlatStyle.Flat;
            btnCoach.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCoach.ForeColor = Color.FromArgb(0, 126, 249);
            btnCoach.Image = Properties.Resources._1coach32;
            btnCoach.ImageAlign = ContentAlignment.MiddleLeft;
            btnCoach.Location = new Point(0, 184);
            btnCoach.Name = "btnCoach";
            btnCoach.Size = new Size(186, 42);
            btnCoach.TabIndex = 1;
            btnCoach.Text = "Coach";
            btnCoach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCoach.UseVisualStyleBackColor = true;
            btnCoach.Click += btnCoach_Click;
            btnCoach.Leave += btnCoach_Leave;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnHome.ForeColor = Color.FromArgb(0, 126, 249);
            btnHome.Image = Properties.Resources.home32;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 97);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(186, 42);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            btnHome.Leave += btnHome_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Image = Properties.Resources.apps32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 145);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(186, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(NavTxtUsername);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 100);
            panel2.TabIndex = 0;
            // 
            // NavTxtUsername
            // 
            NavTxtUsername.AutoSize = true;
            NavTxtUsername.Font = new Font("NAMU 1960", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NavTxtUsername.ForeColor = Color.FromArgb(0, 126, 249);
            NavTxtUsername.Location = new Point(81, 78);
            NavTxtUsername.Name = "NavTxtUsername";
            NavTxtUsername.Size = new Size(31, 15);
            NavTxtUsername.TabIndex = 1;
            NavTxtUsername.Text = "You";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.person;
            pictureBox1.Location = new Point(65, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(192, 97);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(745, 535);
            dashboard1.TabIndex = 12;
            // 
            // manageCoach1
            // 
            manageCoach1.Location = new Point(192, 97);
            manageCoach1.Name = "manageCoach1";
            manageCoach1.Size = new Size(745, 535);
            manageCoach1.TabIndex = 13;
            // 
            // manageMembers1
            // 
            manageMembers1.Location = new Point(192, 97);
            manageMembers1.Name = "manageMembers1";
            manageMembers1.Size = new Size(745, 535);
            manageMembers1.TabIndex = 14;
            // 
            // manageMemberships1
            // 
            manageMemberships1.Location = new Point(192, 97);
            manageMemberships1.Name = "manageMemberships1";
            manageMemberships1.Size = new Size(745, 535);
            manageMemberships1.TabIndex = 15;
            // 
            // manageReceptionists1
            // 
            manageReceptionists1.Location = new Point(192, 97);
            manageReceptionists1.Name = "manageReceptionists1";
            manageReceptionists1.Size = new Size(745, 535);
            manageReceptionists1.TabIndex = 16;
            // 
            // manageBilling1
            // 
            manageBilling1.Location = new Point(192, 97);
            manageBilling1.Name = "manageBilling1";
            manageBilling1.Size = new Size(745, 535);
            manageBilling1.TabIndex = 17;
            // 
            // homePage1
            // 
            homePage1.Location = new Point(190, 97);
            homePage1.Name = "homePage1";
            homePage1.Size = new Size(745, 535);
            homePage1.TabIndex = 18;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(24, 30, 54);
            pnlTitleBar.Controls.Add(pictureBox2);
            pnlTitleBar.Controls.Add(label2);
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(186, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(749, 97);
            pnlTitleBar.TabIndex = 19;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dumbell128;
            pictureBox2.Location = new Point(642, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(442, 49);
            label2.Name = "label2";
            label2.Size = new Size(194, 26);
            label2.TabIndex = 1;
            label2.Text = "made by Kossman";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(288, 12);
            label1.Name = "label1";
            label1.Size = new Size(348, 33);
            label1.TabIndex = 1;
            label1.Text = "Gym Management System";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(935, 631);
            Controls.Add(pnlTitleBar);
            Controls.Add(panel1);
            Controls.Add(homePage1);
            Controls.Add(dashboard1);
            Controls.Add(manageCoach1);
            Controls.Add(manageMemberships1);
            Controls.Add(manageMembers1);
            Controls.Add(manageReceptionists1);
            Controls.Add(manageBilling1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label NavTxtUsername;
        private Button btnDashboard;
        private Button btnReceptionists;
        private Button btnMembers;
        private Button btnCoach;
        private Button btnLogout;
        private Button btnBilling;
        private Panel pnlNav;
        private Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Dashboard dashboard1;
        private ManageCoach manageCoach1;
        private ManageMembers manageMembers1;
        private Button btnMemberships;
        private ManageMemberships manageMemberships1;
        private ManageReceptionists manageReceptionists1;
        private ManageBilling manageBilling1;
        private HomePage homePage1;
        private Button btnHome;
        private Panel pnlTitleBar;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
    }
}
