using Gym.Core.Context;
using Gym.Core.Models;
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
    public partial class ManageMemberships : UserControl
    {
        private GymDbContext _context;

        public ManageMemberships()
        {
            InitializeComponent();
        }

        public ManageMemberships(GymDbContext context)
        {
            InitializeComponent();
            _context = context;
            displayData();
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
                displayData();
            }
        }

        public void displayData()
        {
            if (_context == null || DesignMode) return;

            var memberships = _context.Memberships.ToList();
            MembershipGridList.DataSource = memberships;
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
            MembershipTxtName.Text = "";
            MembershipTxtDuration.Text = "";
            MembershipTxtGoal.Text = "";
            MembershipTxtPrice.Text = "";
        }

        private void MembershipBtnSave_Click(object sender, EventArgs e)
        {
            var newMembership = new Membership
            {
                Name = MembershipTxtName.Text.Trim(),
                Duration = int.Parse(MembershipTxtDuration.Text),
                Goal = MembershipTxtGoal.Text.Trim(),
                Price = decimal.Parse(MembershipTxtPrice.Text)

            };

            _context.Memberships.Add(newMembership);
            _context.SaveChanges();

            clearFields();
            displayData();

            MessageBox.Show("Membership added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MembershipBtnEdit_Click(object sender, EventArgs e)
        {
            var membershipToUpdate = _context.Memberships.FirstOrDefault(m => m.Name == MembershipTxtName.Text.Trim());

            if (membershipToUpdate != null)
            {
                membershipToUpdate.Name = MembershipTxtName.Text.Trim();
                membershipToUpdate.Duration = int.Parse(MembershipTxtDuration.Text);
                membershipToUpdate.Goal = MembershipTxtGoal.Text.Trim();
                membershipToUpdate.Price = decimal.Parse(MembershipTxtPrice.Text);

                _context.SaveChanges();

                displayData();
                MessageBox.Show("Membership updated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int getID;

        private void MembershipBtnDelete_Click(object sender, EventArgs e)
        {
            var membershipToDelete = _context.Memberships.FirstOrDefault(m => m.Id == getID);

            if (membershipToDelete != null)
            {
                _context.Memberships.Remove(membershipToDelete);
                _context.SaveChanges();

                displayData();
                MessageBox.Show("Membership deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MembershipGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = MembershipGridList.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                MembershipTxtName.Text = MembershipGridList.Rows[e.RowIndex].Cells[1].Value.ToString();
                MembershipTxtDuration.Text = MembershipGridList.Rows[e.RowIndex].Cells[2].Value.ToString();
                MembershipTxtGoal.Text = MembershipGridList.Rows[e.RowIndex].Cells[3].Value.ToString();
                MembershipTxtPrice.Text = MembershipGridList.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
