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
    public partial class ManageCoach : UserControl
    {
        private GymDbContext _context;

        public ManageCoach()
        {
            InitializeComponent();
        }

        public ManageCoach(GymDbContext context)
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

            var coaches = _context.Coaches.ToList();
            CoachGridList.DataSource = coaches;
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
            CoachTxtName.Text = "";
            CoachTxtExp.Text = "";
            CoachTxtAddress.Text = "";
            CoachTxtPhone.Text = "";
            CoachCmbGender.SelectedIndex = 0;
        }

        private void CoachBtnEdit_Click(object sender, EventArgs e)
        {
            var coachToUpdate = _context.Coaches.FirstOrDefault(c => c.Name == CoachTxtName.Text.Trim());

            if (coachToUpdate != null)
            {
                coachToUpdate.Name = CoachTxtName.Text.Trim();
                coachToUpdate.Experience = int.Parse(CoachTxtExp.Text);
                coachToUpdate.Address = CoachTxtAddress.Text.Trim();
                coachToUpdate.Phone = CoachTxtPhone.Text.Trim();
                coachToUpdate.Gender = CoachCmbGender.SelectedItem.ToString();
                coachToUpdate.DateBirth = CoachDateBirth.Value;

                _context.SaveChanges();

                displayData();
                MessageBox.Show("Coach updated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CoachBtnSave_Click(object sender, EventArgs e)
        {
            var newCoach = new Coach
            {
                Name = CoachTxtName.Text.Trim(),
                Experience = int.Parse(CoachTxtExp.Text),
                Address = CoachTxtAddress.Text.Trim(),
                Phone = CoachTxtPhone.Text.Trim(),
                Gender = CoachCmbGender.SelectedItem.ToString(),
                DateBirth = CoachDateBirth.Value
            };

            _context.Coaches.Add(newCoach);
            _context.SaveChanges();

            clearFields();
            displayData();

            MessageBox.Show("Coach added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int getID;

        private void CoachBtnDelete_Click(object sender, EventArgs e)
        {
            var coachToDelete = _context.Coaches.FirstOrDefault(m => m.Id == getID);

            if (coachToDelete != null)
            {
                _context.Coaches.Remove(coachToDelete);
                _context.SaveChanges();

                displayData();
                MessageBox.Show("Coach deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CoachGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = CoachGridList.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                CoachTxtName.Text = CoachGridList.Rows[e.RowIndex].Cells[1].Value.ToString();
                CoachTxtExp.Text = CoachGridList.Rows[e.RowIndex].Cells[2].Value.ToString();
                CoachTxtAddress.Text = CoachGridList.Rows[e.RowIndex].Cells[3].Value.ToString();
                CoachTxtPhone.Text = CoachGridList.Rows[e.RowIndex].Cells[4].Value.ToString();
                CoachCmbGender.SelectedItem = CoachGridList.Rows[e.RowIndex].Cells[5].Value.ToString();
                CoachDateBirth.Value = (DateTime)CoachGridList.Rows[e.RowIndex].Cells[6].Value;
            }
        }
    }
}
