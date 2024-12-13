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
    public partial class ManageMembers : UserControl
    {
        private GymDbContext _context;

        public ManageMembers()
        {
            InitializeComponent();
        }

        public ManageMembers(GymDbContext context)
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
                displayData();
                LoadComboBoxData();
            }
        }

        public void displayData()
        {
            var clients = _context.Clients.Select(client => new
        {
            client.Id,
            client.Name,
            client.Phone,
            client.Gender,
            client.Timing,
            client.Status,
            CoachId = client.CoachId,
            MembershipId = client.MembershipId,
            client.DateBirth,
            client.DateJoin
        })
        .ToList();

            MemberDataGrid.DataSource = clients;
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
            MemberTxtName.Text = "";
            MemberTxtPhone.Text = "";
            MemberCmbGender.SelectedIndex = 0;
            MemberCmbTiming.SelectedIndex = 0;
            MemberCmbStatus.SelectedIndex = 0;
            MemberCmbCoach.SelectedIndex = -1;
            MemberCmbMembership.SelectedIndex = -1;
            MemberDateBirth.Value = DateTime.Now;
            MemberDateJoin.Value = DateTime.Now;
        }

        public void LoadComboBoxData()
        {
            if (_context == null) return;

            var coaches = _context.Coaches.Select(c => new { c.Id, c.Name }).ToList();
            MemberCmbCoach.DataSource = coaches;
            MemberCmbCoach.DisplayMember = "Name";
            MemberCmbCoach.ValueMember = "Id";

            var memberships = _context.Memberships.Select(m => new { m.Id, m.Name }).ToList();
            MemberCmbMembership.DataSource = memberships;
            MemberCmbMembership.DisplayMember = "Name";
            MemberCmbMembership.ValueMember = "Id";
        }

        private void MemberDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MemberTxtName.Text = MemberDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                MemberTxtPhone.Text = MemberDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                MemberCmbGender.SelectedItem = MemberDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                MemberCmbTiming.SelectedItem = MemberDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                MemberCmbStatus.SelectedItem = MemberDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                MemberCmbCoach.SelectedValue = MemberDataGrid.Rows[e.RowIndex].Cells[6].Value;
                MemberCmbMembership.SelectedValue = MemberDataGrid.Rows[e.RowIndex].Cells[7].Value;
                MemberDateBirth.Value = (DateTime)MemberDataGrid.Rows[e.RowIndex].Cells[8].Value;
                MemberDateJoin.Value = (DateTime)MemberDataGrid.Rows[e.RowIndex].Cells[9].Value;
            }
        }

        private void ClientBtnSave_Click(object sender, EventArgs e)
        {
            var newClient = new Client
            {
                Name = MemberTxtName.Text,
                Phone = MemberTxtPhone.Text,
                Gender = MemberCmbGender.SelectedItem.ToString(),
                Timing = MemberCmbTiming.SelectedItem.ToString(),
                Status = MemberCmbStatus.SelectedItem.ToString(),
                CoachId = (int)MemberCmbCoach.SelectedValue,
                MembershipId = (int)MemberCmbMembership.SelectedValue,
                DateBirth = MemberDateBirth.Value,
                DateJoin = MemberDateJoin.Value
            };

            _context.Clients.Add(newClient);
            _context.SaveChanges();

            clearFields();
            displayData();

            MessageBox.Show("Client added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClientBtnDelete_Click(object sender, EventArgs e)
        {
            var clientToDelete = _context.Clients.FirstOrDefault(m => m.Name == MemberTxtName.Text.Trim());

            if (clientToDelete != null)
            {
                _context.Clients.Remove(clientToDelete);
                _context.SaveChanges();

                displayData();
                MessageBox.Show("Client deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClientBtnEdit_Click(object sender, EventArgs e)
        {
            var clientToUpdate = _context.Clients.FirstOrDefault(m => m.Name == MemberTxtName.Text.Trim());

            if (clientToUpdate != null)
            {
                clientToUpdate.Name = MemberTxtName.Text;
                clientToUpdate.Phone = MemberTxtPhone.Text;
                clientToUpdate.Gender = MemberCmbGender.SelectedItem.ToString();
                clientToUpdate.Timing = MemberCmbTiming.SelectedItem.ToString();
                clientToUpdate.Status = MemberCmbStatus.SelectedItem.ToString();
                clientToUpdate.CoachId = (int)MemberCmbCoach.SelectedValue;
                clientToUpdate.MembershipId = (int)MemberCmbMembership.SelectedValue;
                clientToUpdate.DateBirth = MemberDateBirth.Value;
                clientToUpdate.DateJoin = MemberDateJoin.Value;

                _context.SaveChanges();

                displayData();
                MessageBox.Show("Client updated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
