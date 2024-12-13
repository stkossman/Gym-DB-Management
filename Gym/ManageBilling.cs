using Gym.Core.Context;
using Gym.Core.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class ManageBilling : UserControl
    {
        private GymDbContext _context;
        public ManageBilling()
        {
            InitializeComponent();
        }

        public ManageBilling(GymDbContext context)
        {
            InitializeComponent();
            _context = context;
            displayData();
            LoadComboBoxData();
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
                LoadComboBoxData();
                displayData();
            }
        }

        public void displayData()
        {
            if (_context == null || DesignMode) return;

            var billings = _context.Payments.Select(billing => new
            {
                billing.Id,
                billing.MemberId,
                billing.Member.Name,
                billing.Amount,
                billing.DatePeriod,
                billing.Date
            }).ToList();

            BillingGridList.DataSource = billings;
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayData();
        }

        public void clearFields()
        {
            BillingCmbMember.SelectedIndex = -1;
            BillingDatePeriod.Value = DateTime.Now;
        }

        public void LoadComboBoxData()
        {
            if (_context == null || DesignMode) return;
            var members = _context.Clients.Select(client => new
            {
                client.Id,
                client.Name
            }).ToList();
            BillingCmbMember.DataSource = members;
            BillingCmbMember.ValueMember = "Id";
            BillingCmbMember.DisplayMember = "Name";
        }

        private int getID;

        private void BillingGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getID = Convert.ToInt32(BillingGridList.Rows[e.RowIndex].Cells[0].Value);
                var billing = _context.Payments.Find(getID);
                BillingCmbMember.SelectedValue = billing.MemberId;
                BillingDatePeriod.Value = billing.DatePeriod;
            }
        }

        private void BillingBtnConfirm_Click(object sender, EventArgs e)
        {
            int memberId = (int)BillingCmbMember.SelectedValue;
            var member = _context.Clients.Include(c => c.Membership).FirstOrDefault(c => c.Id == memberId);

            if (member == null || member.Membership == null)
            {
                MessageBox.Show("Member does not have a membership", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal amount = member.Membership.Price;

            var newBilling = new Payment
            {
                MemberId = memberId,
                Amount = amount,
                DatePeriod = BillingDatePeriod.Value,
                Date = DateTime.Now
            };

            _context.Payments.Add(newBilling);
            _context.SaveChanges();

            clearFields();
            displayData();

            MessageBox.Show("Billing added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BillingBtnCancel_Click(object sender, EventArgs e)
        {
            var billingToDelete = _context.Payments.FirstOrDefault(b => b.Id == getID);

            if (billingToDelete != null)
            {
                _context.Payments.Remove(billingToDelete);
                _context.SaveChanges();

                displayData();
                MessageBox.Show("Billing deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}