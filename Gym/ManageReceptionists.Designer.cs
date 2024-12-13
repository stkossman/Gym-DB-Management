namespace Gym
{
    partial class ManageReceptionists
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
            ReceptionistLblList = new Label();
            ReceptionistBtnDelete = new Button();
            ReceptionistBtnSave = new Button();
            ReceptionistBtnEdit = new Button();
            ReceptionistDateBirth = new DateTimePicker();
            ReceptionistCmbGender = new ComboBox();
            label3 = new Label();
            ReceptionistTxtAddress = new TextBox();
            ReceptionistTxtPhone = new TextBox();
            ReceptionistTxtName = new TextBox();
            ReceptionistDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ReceptionistDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ReceptionistLblList
            // 
            ReceptionistLblList.AutoSize = true;
            ReceptionistLblList.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ReceptionistLblList.ForeColor = Color.FromArgb(0, 126, 249);
            ReceptionistLblList.Location = new Point(279, 197);
            ReceptionistLblList.Name = "ReceptionistLblList";
            ReceptionistLblList.Size = new Size(185, 27);
            ReceptionistLblList.TabIndex = 22;
            ReceptionistLblList.Text = "Receptionist list";
            // 
            // ReceptionistBtnDelete
            // 
            ReceptionistBtnDelete.BackColor = Color.FromArgb(0, 126, 249);
            ReceptionistBtnDelete.FlatAppearance.BorderSize = 0;
            ReceptionistBtnDelete.FlatStyle = FlatStyle.Flat;
            ReceptionistBtnDelete.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ReceptionistBtnDelete.Location = new Point(459, 164);
            ReceptionistBtnDelete.Name = "ReceptionistBtnDelete";
            ReceptionistBtnDelete.Size = new Size(75, 30);
            ReceptionistBtnDelete.TabIndex = 19;
            ReceptionistBtnDelete.Text = "Delete";
            ReceptionistBtnDelete.UseVisualStyleBackColor = false;
            ReceptionistBtnDelete.Click += ReceptionistBtnDelete_Click;
            // 
            // ReceptionistBtnSave
            // 
            ReceptionistBtnSave.BackColor = Color.FromArgb(0, 126, 249);
            ReceptionistBtnSave.FlatAppearance.BorderSize = 0;
            ReceptionistBtnSave.FlatStyle = FlatStyle.Flat;
            ReceptionistBtnSave.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ReceptionistBtnSave.Location = new Point(326, 164);
            ReceptionistBtnSave.Name = "ReceptionistBtnSave";
            ReceptionistBtnSave.Size = new Size(75, 30);
            ReceptionistBtnSave.TabIndex = 20;
            ReceptionistBtnSave.Text = "Save";
            ReceptionistBtnSave.UseVisualStyleBackColor = false;
            ReceptionistBtnSave.Click += ReceptionistBtnSave_Click;
            // 
            // ReceptionistBtnEdit
            // 
            ReceptionistBtnEdit.BackColor = Color.FromArgb(0, 126, 249);
            ReceptionistBtnEdit.FlatAppearance.BorderSize = 0;
            ReceptionistBtnEdit.FlatStyle = FlatStyle.Flat;
            ReceptionistBtnEdit.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ReceptionistBtnEdit.Location = new Point(198, 164);
            ReceptionistBtnEdit.Name = "ReceptionistBtnEdit";
            ReceptionistBtnEdit.Size = new Size(75, 30);
            ReceptionistBtnEdit.TabIndex = 21;
            ReceptionistBtnEdit.Text = "Edit";
            ReceptionistBtnEdit.UseVisualStyleBackColor = false;
            ReceptionistBtnEdit.Click += ReceptionistBtnEdit_Click;
            // 
            // ReceptionistDateBirth
            // 
            ReceptionistDateBirth.CalendarFont = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ReceptionistDateBirth.CalendarForeColor = Color.FromArgb(0, 126, 249);
            ReceptionistDateBirth.CalendarMonthBackground = Color.FromArgb(0, 126, 249);
            ReceptionistDateBirth.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ReceptionistDateBirth.Location = new Point(363, 64);
            ReceptionistDateBirth.Name = "ReceptionistDateBirth";
            ReceptionistDateBirth.Size = new Size(200, 22);
            ReceptionistDateBirth.TabIndex = 18;
            // 
            // ReceptionistCmbGender
            // 
            ReceptionistCmbGender.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ReceptionistCmbGender.FormattingEnabled = true;
            ReceptionistCmbGender.Items.AddRange(new object[] { "Male", "Female", "Trans", "Other" });
            ReceptionistCmbGender.Location = new Point(210, 63);
            ReceptionistCmbGender.Name = "ReceptionistCmbGender";
            ReceptionistCmbGender.Size = new Size(121, 22);
            ReceptionistCmbGender.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NAMU 1960", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(317, 34);
            label3.TabIndex = 12;
            label3.Text = "Manage Receptionists";
            // 
            // ReceptionistTxtAddress
            // 
            ReceptionistTxtAddress.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ReceptionistTxtAddress.Location = new Point(14, 104);
            ReceptionistTxtAddress.Name = "ReceptionistTxtAddress";
            ReceptionistTxtAddress.PlaceholderText = "Address";
            ReceptionistTxtAddress.Size = new Size(159, 22);
            ReceptionistTxtAddress.TabIndex = 14;
            // 
            // ReceptionistTxtPhone
            // 
            ReceptionistTxtPhone.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ReceptionistTxtPhone.Location = new Point(210, 104);
            ReceptionistTxtPhone.Name = "ReceptionistTxtPhone";
            ReceptionistTxtPhone.PlaceholderText = "Phone";
            ReceptionistTxtPhone.Size = new Size(121, 22);
            ReceptionistTxtPhone.TabIndex = 15;
            // 
            // ReceptionistTxtName
            // 
            ReceptionistTxtName.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ReceptionistTxtName.Location = new Point(14, 63);
            ReceptionistTxtName.Name = "ReceptionistTxtName";
            ReceptionistTxtName.PlaceholderText = "Name";
            ReceptionistTxtName.Size = new Size(159, 22);
            ReceptionistTxtName.TabIndex = 16;
            // 
            // ReceptionistDataGrid
            // 
            ReceptionistDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReceptionistDataGrid.Location = new Point(3, 227);
            ReceptionistDataGrid.Name = "ReceptionistDataGrid";
            ReceptionistDataGrid.Size = new Size(723, 292);
            ReceptionistDataGrid.TabIndex = 23;
            ReceptionistDataGrid.CellClick += ReceptionistDataGrid_CellClick;
            // 
            // ManageReceptionists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ReceptionistDataGrid);
            Controls.Add(ReceptionistLblList);
            Controls.Add(ReceptionistBtnDelete);
            Controls.Add(ReceptionistBtnSave);
            Controls.Add(ReceptionistBtnEdit);
            Controls.Add(ReceptionistDateBirth);
            Controls.Add(ReceptionistCmbGender);
            Controls.Add(label3);
            Controls.Add(ReceptionistTxtAddress);
            Controls.Add(ReceptionistTxtPhone);
            Controls.Add(ReceptionistTxtName);
            Name = "ManageReceptionists";
            Size = new Size(729, 532);
            ((System.ComponentModel.ISupportInitialize)ReceptionistDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ReceptionistLblList;
        private Button ReceptionistBtnDelete;
        private Button ReceptionistBtnSave;
        private Button ReceptionistBtnEdit;
        private DateTimePicker ReceptionistDateBirth;
        private ComboBox ReceptionistCmbGender;
        private Label label3;
        private TextBox ReceptionistTxtAddress;
        private TextBox ReceptionistTxtPhone;
        private TextBox ReceptionistTxtName;
        private DataGridView ReceptionistDataGrid;
    }
}
