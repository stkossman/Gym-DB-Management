namespace Gym
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
            btnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            NavTxtUsername = new Label();
            pictureBox1 = new PictureBox();
            dashboard1 = new Dashboard();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            manageCoach1 = new ManageCoach();
            manageMembers1 = new ManageMembers();
            manageMemberships1 = new ManageMemberships();
            manageReceptionists1 = new ManageReceptionists();
            manageBilling1 = new ManageBilling();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 538);
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
            btnExit.Location = new Point(0, 454);
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
            btnLogout.Location = new Point(0, 496);
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
            btnMemberships.Dock = DockStyle.Top;
            btnMemberships.FlatAppearance.BorderSize = 0;
            btnMemberships.FlatStyle = FlatStyle.Flat;
            btnMemberships.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMemberships.ForeColor = Color.FromArgb(0, 126, 249);
            btnMemberships.Image = Properties.Resources.membership32;
            btnMemberships.ImageAlign = ContentAlignment.MiddleLeft;
            btnMemberships.Location = new Point(0, 354);
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
            btnBilling.Dock = DockStyle.Top;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBilling.ForeColor = Color.FromArgb(0, 126, 249);
            btnBilling.Image = Properties.Resources.finance;
            btnBilling.ImageAlign = ContentAlignment.MiddleLeft;
            btnBilling.Location = new Point(0, 312);
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
            btnReceptionists.Dock = DockStyle.Top;
            btnReceptionists.FlatAppearance.BorderSize = 0;
            btnReceptionists.FlatStyle = FlatStyle.Flat;
            btnReceptionists.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnReceptionists.ForeColor = Color.FromArgb(0, 126, 249);
            btnReceptionists.Image = Properties.Resources.receptionist;
            btnReceptionists.ImageAlign = ContentAlignment.MiddleLeft;
            btnReceptionists.Location = new Point(0, 270);
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
            btnMembers.Dock = DockStyle.Top;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMembers.ForeColor = Color.FromArgb(0, 126, 249);
            btnMembers.Image = Properties.Resources.member;
            btnMembers.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembers.Location = new Point(0, 228);
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
            btnCoach.Dock = DockStyle.Top;
            btnCoach.FlatAppearance.BorderSize = 0;
            btnCoach.FlatStyle = FlatStyle.Flat;
            btnCoach.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCoach.ForeColor = Color.FromArgb(0, 126, 249);
            btnCoach.Image = Properties.Resources._1coach32;
            btnCoach.ImageAlign = ContentAlignment.MiddleLeft;
            btnCoach.Location = new Point(0, 186);
            btnCoach.Name = "btnCoach";
            btnCoach.Size = new Size(186, 42);
            btnCoach.TabIndex = 1;
            btnCoach.Text = "Coach";
            btnCoach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCoach.UseVisualStyleBackColor = true;
            btnCoach.Click += btnCoach_Click;
            btnCoach.Leave += btnCoach_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Image = Properties.Resources.apps32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 144);
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
            panel2.Controls.Add(label2);
            panel2.Controls.Add(NavTxtUsername);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("NAMU 1960", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(65, 114);
            label2.Name = "label2";
            label2.Size = new Size(63, 11);
            label2.TabIndex = 2;
            label2.Text = "Today's Date";
            // 
            // NavTxtUsername
            // 
            NavTxtUsername.AutoSize = true;
            NavTxtUsername.Font = new Font("NAMU 1960", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NavTxtUsername.ForeColor = Color.FromArgb(0, 126, 249);
            NavTxtUsername.Location = new Point(74, 88);
            NavTxtUsername.Name = "NavTxtUsername";
            NavTxtUsername.Size = new Size(31, 15);
            NavTxtUsername.TabIndex = 1;
            NavTxtUsername.Text = "You";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.person;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(192, 3);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(745, 539);
            dashboard1.TabIndex = 12;
            // 
            // manageCoach1
            // 
            manageCoach1.Location = new Point(190, 3);
            manageCoach1.Name = "manageCoach1";
            manageCoach1.Size = new Size(747, 532);
            manageCoach1.TabIndex = 13;
            // 
            // manageMembers1
            // 
            manageMembers1.Location = new Point(192, 12);
            manageMembers1.Name = "manageMembers1";
            manageMembers1.Size = new Size(747, 535);
            manageMembers1.TabIndex = 14;
            // 
            // manageMemberships1
            // 
            manageMemberships1.Location = new Point(192, 12);
            manageMemberships1.Name = "manageMemberships1";
            manageMemberships1.Size = new Size(745, 523);
            manageMemberships1.TabIndex = 15;
            // 
            // manageReceptionists1
            // 
            manageReceptionists1.Location = new Point(194, 6);
            manageReceptionists1.Name = "manageReceptionists1";
            manageReceptionists1.Size = new Size(729, 532);
            manageReceptionists1.TabIndex = 16;
            // 
            // manageBilling1
            // 
            manageBilling1.Location = new Point(192, 3);
            manageBilling1.Name = "manageBilling1";
            manageBilling1.Size = new Size(729, 532);
            manageBilling1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(935, 538);
            Controls.Add(panel1);
            Controls.Add(dashboard1);
            Controls.Add(manageCoach1);
            Controls.Add(manageMemberships1);
            Controls.Add(manageMembers1);
            Controls.Add(manageReceptionists1);
            Controls.Add(manageBilling1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
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
    }
}
