namespace Gym
{
    partial class ManageMemberships
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MembershipLblList = new Label();
            MembershipBtnDelete = new Button();
            MembershipBtnSave = new Button();
            MembershipBtnEdit = new Button();
            label3 = new Label();
            MembershipTxtDuration = new TextBox();
            MembershipTxtName = new TextBox();
            MembershipTxtGoal = new TextBox();
            MembershipTxtPrice = new TextBox();
            MembershipGridList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MembershipGridList).BeginInit();
            SuspendLayout();
            // 
            // MembershipLblList
            // 
            MembershipLblList.AutoSize = true;
            MembershipLblList.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MembershipLblList.ForeColor = Color.FromArgb(0, 126, 249);
            MembershipLblList.Location = new Point(279, 124);
            MembershipLblList.Name = "MembershipLblList";
            MembershipLblList.Size = new Size(184, 27);
            MembershipLblList.TabIndex = 22;
            MembershipLblList.Text = "Membership list";
            // 
            // MembershipBtnDelete
            // 
            MembershipBtnDelete.BackColor = Color.FromArgb(0, 126, 249);
            MembershipBtnDelete.FlatAppearance.BorderSize = 0;
            MembershipBtnDelete.FlatStyle = FlatStyle.Flat;
            MembershipBtnDelete.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MembershipBtnDelete.Location = new Point(457, 91);
            MembershipBtnDelete.Name = "MembershipBtnDelete";
            MembershipBtnDelete.Size = new Size(75, 30);
            MembershipBtnDelete.TabIndex = 19;
            MembershipBtnDelete.Text = "Delete";
            MembershipBtnDelete.UseVisualStyleBackColor = false;
            MembershipBtnDelete.Click += MembershipBtnDelete_Click;
            // 
            // MembershipBtnSave
            // 
            MembershipBtnSave.BackColor = Color.FromArgb(0, 126, 249);
            MembershipBtnSave.FlatAppearance.BorderSize = 0;
            MembershipBtnSave.FlatStyle = FlatStyle.Flat;
            MembershipBtnSave.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MembershipBtnSave.Location = new Point(329, 91);
            MembershipBtnSave.Name = "MembershipBtnSave";
            MembershipBtnSave.Size = new Size(75, 30);
            MembershipBtnSave.TabIndex = 20;
            MembershipBtnSave.Text = "Save";
            MembershipBtnSave.UseVisualStyleBackColor = false;
            MembershipBtnSave.Click += MembershipBtnSave_Click;
            // 
            // MembershipBtnEdit
            // 
            MembershipBtnEdit.BackColor = Color.FromArgb(0, 126, 249);
            MembershipBtnEdit.FlatAppearance.BorderSize = 0;
            MembershipBtnEdit.FlatStyle = FlatStyle.Flat;
            MembershipBtnEdit.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MembershipBtnEdit.Location = new Point(198, 91);
            MembershipBtnEdit.Name = "MembershipBtnEdit";
            MembershipBtnEdit.Size = new Size(75, 30);
            MembershipBtnEdit.TabIndex = 21;
            MembershipBtnEdit.Text = "Edit";
            MembershipBtnEdit.UseVisualStyleBackColor = false;
            MembershipBtnEdit.Click += MembershipBtnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NAMU 1960", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(318, 34);
            label3.TabIndex = 12;
            label3.Text = "Manage Memberships";
            // 
            // MembershipTxtDuration
            // 
            MembershipTxtDuration.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MembershipTxtDuration.Location = new Point(179, 63);
            MembershipTxtDuration.Name = "MembershipTxtDuration";
            MembershipTxtDuration.PlaceholderText = "Duration";
            MembershipTxtDuration.Size = new Size(159, 22);
            MembershipTxtDuration.TabIndex = 13;
            // 
            // MembershipTxtName
            // 
            MembershipTxtName.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MembershipTxtName.Location = new Point(14, 63);
            MembershipTxtName.Name = "MembershipTxtName";
            MembershipTxtName.PlaceholderText = "Name";
            MembershipTxtName.Size = new Size(159, 22);
            MembershipTxtName.TabIndex = 16;
            // 
            // MembershipTxtGoal
            // 
            MembershipTxtGoal.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MembershipTxtGoal.Location = new Point(344, 63);
            MembershipTxtGoal.Name = "MembershipTxtGoal";
            MembershipTxtGoal.PlaceholderText = "Goal";
            MembershipTxtGoal.Size = new Size(159, 22);
            MembershipTxtGoal.TabIndex = 13;
            // 
            // MembershipTxtPrice
            // 
            MembershipTxtPrice.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MembershipTxtPrice.Location = new Point(509, 63);
            MembershipTxtPrice.Name = "MembershipTxtPrice";
            MembershipTxtPrice.PlaceholderText = "Price";
            MembershipTxtPrice.Size = new Size(159, 22);
            MembershipTxtPrice.TabIndex = 13;
            // 
            // MembershipGridList
            // 
            MembershipGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembershipGridList.Location = new Point(3, 154);
            MembershipGridList.Name = "MembershipGridList";
            MembershipGridList.Size = new Size(730, 379);
            MembershipGridList.TabIndex = 23;
            MembershipGridList.CellClick += MembershipGridList_CellClick;
            // 
            // ManageMemberships
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MembershipGridList);
            Controls.Add(MembershipLblList);
            Controls.Add(MembershipBtnDelete);
            Controls.Add(MembershipBtnSave);
            Controls.Add(MembershipBtnEdit);
            Controls.Add(label3);
            Controls.Add(MembershipTxtPrice);
            Controls.Add(MembershipTxtGoal);
            Controls.Add(MembershipTxtDuration);
            Controls.Add(MembershipTxtName);
            Name = "ManageMemberships";
            Size = new Size(736, 544);
            ((System.ComponentModel.ISupportInitialize)MembershipGridList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label MembershipLblList;
        private Button MembershipBtnDelete;
        private Button MembershipBtnSave;
        private Button MembershipBtnEdit;
        private Label label3;
        private TextBox MembershipTxtDuration;
        private TextBox MembershipTxtName;
        private TextBox MembershipTxtGoal;
        private TextBox MembershipTxtPrice;
        private DataGridView MembershipGridList;
    }
}
