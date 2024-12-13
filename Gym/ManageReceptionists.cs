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
    public partial class ManageReceptionists : UserControl
    {
        private GymDbContext _context;

        public ManageReceptionists()
        {
            InitializeComponent();
        }

        public ManageReceptionists(GymDbContext context)
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

            var receptionists = _context.Receptionists.ToList();
            ReceptionistDataGrid.DataSource = receptionists;
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
            ReceptionistTxtName.Text = "";
            ReceptionistTxtPhone.Text = "";
            ReceptionistCmbGender.SelectedIndex = -1;
            ReceptionistTxtAddress.Text = "";
            ReceptionistDateBirth.Value = DateTime.Now;

        }

        private void ReceptionistBtnEdit_Click(object sender, EventArgs e)
        {
            var receptionistToUpdate = _context.Receptionists.FirstOrDefault(r => r.Name == ReceptionistTxtName.Text.Trim());

            if (receptionistToUpdate != null)
            {
                receptionistToUpdate.Name = ReceptionistTxtName.Text;
                receptionistToUpdate.Phone = ReceptionistTxtPhone.Text;
                receptionistToUpdate.Address = ReceptionistTxtAddress.Text;
                receptionistToUpdate.Gender = ReceptionistCmbGender.SelectedItem.ToString();
                receptionistToUpdate.DateBirth = ReceptionistDateBirth.Value;

                _context.SaveChanges();

                clearFields();
                displayData();

                MessageBox.Show("Receptionist updated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReceptionistBtnSave_Click(object sender, EventArgs e)
        {
            var newReceptionist = new Receptionist
            {
                Name = ReceptionistTxtName.Text,
                Phone = ReceptionistTxtPhone.Text,
                Address = ReceptionistTxtAddress.Text,
                Gender = ReceptionistCmbGender.SelectedItem.ToString(),
                DateBirth = ReceptionistDateBirth.Value
            };

            _context.Receptionists.Add(newReceptionist);
            _context.SaveChanges();

            clearFields();
            displayData();

            MessageBox.Show("Receptionist added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int getID;

        private void ReceptionistBtnDelete_Click(object sender, EventArgs e)
        {
            var receptionistToDelete = _context.Receptionists.FirstOrDefault(r => r.Name == ReceptionistTxtName.Text.Trim());

            if (receptionistToDelete != null)
            {
                _context.Receptionists.Remove(receptionistToDelete);
                _context.SaveChanges();
                
                displayData();
                MessageBox.Show("Receptionist deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReceptionistDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = ReceptionistDataGrid.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                ReceptionistTxtName.Text = ReceptionistDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                ReceptionistTxtPhone.Text = ReceptionistDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                ReceptionistTxtAddress.Text = ReceptionistDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                ReceptionistCmbGender.SelectedItem = ReceptionistDataGrid.Rows[e.RowIndex].Cells[5].Value;
                ReceptionistDateBirth.Value = (DateTime)ReceptionistDataGrid.Rows[e.RowIndex].Cells[6].Value;
            }
        }
    }
}
