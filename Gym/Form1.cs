using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Gym
{
    public partial class Form1 : Form
    {
        private Core.Context.GymDbContext _context;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public Form1(Core.Context.GymDbContext _context)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            label2.Text = DateTime.Today.ToString("d");

            dashboard1.SetContext(_context);
            manageMemberships1.SetContext(_context);
            manageCoach1.SetContext(_context);
            manageMembers1.SetContext(_context);
            manageReceptionists1.SetContext(_context);
            manageBilling1.SetContext(_context);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            dashboard1.Visible = true;
            manageCoach1.Visible = false;
            manageMembers1.Visible = false;
            manageMemberships1.Visible = false;
            manageReceptionists1.Visible = false;
            manageBilling1.Visible = false;

        }

        private void btnCoach_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCoach.Height;
            pnlNav.Top = btnCoach.Top;
            btnCoach.BackColor = Color.FromArgb(46, 51, 73);
            manageCoach1.Visible = true;
            dashboard1.Visible = false;
            manageMembers1.Visible = false;
            manageMemberships1.Visible = false;
            manageReceptionists1.Visible = false;
            manageBilling1.Visible = false;
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMembers.Height;
            pnlNav.Top = btnMembers.Top;
            btnMembers.BackColor = Color.FromArgb(46, 51, 73);
            manageMembers1.Visible = true;
            manageCoach1.Visible = false;
            dashboard1.Visible = false;
            manageMemberships1.Visible = false;
            manageReceptionists1.Visible = false;
            manageBilling1.Visible = false;
        }

        private void btnReceptionists_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReceptionists.Height;
            pnlNav.Top = btnReceptionists.Top;
            btnReceptionists.BackColor = Color.FromArgb(46, 51, 73);
            manageReceptionists1.Visible = true;
            dashboard1.Visible = false;
            manageCoach1.Visible = false;
            manageMembers1.Visible = false;
            manageMemberships1.Visible = false;
            manageBilling1.Visible = false;
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBilling.Height;
            pnlNav.Top = btnBilling.Top;
            btnBilling.BackColor = Color.FromArgb(46, 51, 73);
            manageBilling1.Visible = true;
            manageReceptionists1.Visible = false;
            dashboard1.Visible = false;
            manageCoach1.Visible = false;
            manageMembers1.Visible = false;
            manageMemberships1.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);

            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm login = new LoginForm(_context);
                login.Show();

                this.Hide();
            }
        }

        private void btnMemberships_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMemberships.Height;
            pnlNav.Top = btnMemberships.Top;
            btnMemberships.BackColor = Color.FromArgb(46, 51, 73);
            manageMemberships1.Visible = true;
            manageMembers1.Visible = false;
            manageCoach1.Visible = false;
            dashboard1.Visible = false;
            manageBilling1.Visible = false;
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCoach_Leave(object sender, EventArgs e)
        {
            btnCoach.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMembers_Leave(object sender, EventArgs e)
        {
            btnMembers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnReceptionists_Leave(object sender, EventArgs e)
        {
            btnReceptionists.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBilling_Leave(object sender, EventArgs e)
        {
            btnBilling.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMemberships_Leave(object sender, EventArgs e)
        {
            btnMembers.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
