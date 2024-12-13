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
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);

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
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            dashboard1.Visible = true;
            manageCoach1.Visible = false;
            manageMembers1.Visible = false;
            manageMemberships1.Visible = false;
            manageReceptionists1.Visible = false;
            manageBilling1.Visible = false;
            homePage1.Visible = false;

            dashboard1.LoadDashboardData();
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
            homePage1.Visible = false;

            manageCoach1.displayData();
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
            homePage1.Visible = false;

            manageMembers1.displayData();
            manageMembers1.LoadComboBoxData();
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
            homePage1.Visible = false;

            manageReceptionists1.displayData();
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
            homePage1.Visible = false;

            manageBilling1.LoadComboBoxData();
            manageBilling1.displayData();
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
            homePage1.Visible = false;


            manageMemberships1.displayData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
            homePage1.Visible = true;
            manageMemberships1.Visible = false;
            manageMembers1.Visible = false;
            manageCoach1.Visible = false;
            dashboard1.Visible = false;
            manageBilling1.Visible = false;
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
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

        private void btnMemberships_Leave(object sender, EventArgs e)
        {
            btnMemberships.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
