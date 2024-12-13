using Gym.Core.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class LoginForm : Form
    {
        private readonly GymDbContext _context;

        public LoginForm(GymDbContext context)
        {
            InitializeComponent();
            _context = context;
            
            LoginTxtPassword.PasswordChar = '*';
            openEye.Visible = true;
            closedEye.Visible = false;

            openEye.Click += openEye_Click;
            closedEye.Click += closedEye_Click;
        }

        private void LoginPictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTxtUsername.Text) || string.IsNullOrWhiteSpace(LoginTxtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Username == LoginTxtUsername.Text.Trim()
                                         && u.Password == LoginTxtPassword.Text.Trim());

                if (user != null)
                {
                    MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (user.Role == "admin")
                    {
                        Form1 form1 = new Form1(_context);
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User is null", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openEye_Click(object sender, EventArgs e)
        {
            LoginTxtPassword.PasswordChar = '\0';
            openEye.Visible = false;
            closedEye.Visible = true;
        }

        private void closedEye_Click(object sender, EventArgs e)
        {
            LoginTxtPassword.PasswordChar = '*';
            closedEye.Visible = false;
            openEye.Visible = true;
        }
    }
}
