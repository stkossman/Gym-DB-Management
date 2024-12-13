using Gym.Core.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Dashboard : UserControl
    {
        private GymDbContext _context;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(GymDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadDashboardData();
        }

        public void LoadDashboardData()
        {
            DisplayProfitTotal();
            DisplayMemberships();
            DisplayClients();
            DisplayCoaches();
        }

        public void DisplayProfitTotal()
        {
            decimal totalProfitValue = _context.Payments.Sum(c => (decimal?)c.Amount) ?? 0;
            lblEarnings.Text = totalProfitValue.ToString("C", new CultureInfo("en-US"));
        }


        public void DisplayMemberships()
        { 
            int totalMemberships = _context.Memberships.Count();
            lblMemberships.Text = totalMemberships.ToString();
        }

        public void DisplayClients()
        {
            int totalClients = _context.Clients.Count();
            lblClients.Text = totalClients.ToString();
        }

        public void DisplayCoaches()
        {
            int totalCoaches = _context.Coaches.Count();
            lblCoaches.Text = totalCoaches.ToString();
        }

        private void btnMakeSurvey_Click(object sender, EventArgs e)
        {
            SurveyForm newForm = new SurveyForm();
            newForm.Show();
        }

        public void SetContext(GymDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), "Context cannot be null.");
            }

            _context = context;

            if (!DesignMode)
            {
                LoadDashboardData();
            }
        }
    }
}
