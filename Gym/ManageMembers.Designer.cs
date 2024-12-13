namespace Gym
{
    partial class ManageMembers
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
            MemberLblList = new Label();
            ClientBtnDelete = new Button();
            ClientBtnSave = new Button();
            ClientBtnEdit = new Button();
            MemberDateBirth = new DateTimePicker();
            MemberCmbGender = new ComboBox();
            label3 = new Label();
            MemberTxtPhone = new TextBox();
            MemberTxtName = new TextBox();
            MemberDateJoin = new DateTimePicker();
            MemberCmbTiming = new ComboBox();
            MemberCmbStatus = new ComboBox();
            MemberCmbCoach = new ComboBox();
            MemberCmbMembership = new ComboBox();
            MemberDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MemberDataGrid).BeginInit();
            SuspendLayout();
            // 
            // MemberLblList
            // 
            MemberLblList.AutoSize = true;
            MemberLblList.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MemberLblList.ForeColor = Color.FromArgb(0, 126, 249);
            MemberLblList.Location = new Point(289, 187);
            MemberLblList.Name = "MemberLblList";
            MemberLblList.Size = new Size(150, 27);
            MemberLblList.TabIndex = 22;
            MemberLblList.Text = "Members list";
            // 
            // ClientBtnDelete
            // 
            ClientBtnDelete.BackColor = Color.FromArgb(0, 126, 249);
            ClientBtnDelete.FlatAppearance.BorderSize = 0;
            ClientBtnDelete.FlatStyle = FlatStyle.Flat;
            ClientBtnDelete.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClientBtnDelete.Location = new Point(459, 154);
            ClientBtnDelete.Name = "ClientBtnDelete";
            ClientBtnDelete.Size = new Size(75, 30);
            ClientBtnDelete.TabIndex = 19;
            ClientBtnDelete.Text = "Delete";
            ClientBtnDelete.UseVisualStyleBackColor = false;
            ClientBtnDelete.Click += ClientBtnDelete_Click;
            // 
            // ClientBtnSave
            // 
            ClientBtnSave.BackColor = Color.FromArgb(0, 126, 249);
            ClientBtnSave.FlatAppearance.BorderSize = 0;
            ClientBtnSave.FlatStyle = FlatStyle.Flat;
            ClientBtnSave.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClientBtnSave.Location = new Point(326, 154);
            ClientBtnSave.Name = "ClientBtnSave";
            ClientBtnSave.Size = new Size(75, 30);
            ClientBtnSave.TabIndex = 20;
            ClientBtnSave.Text = "Save";
            ClientBtnSave.UseVisualStyleBackColor = false;
            ClientBtnSave.Click += ClientBtnSave_Click;
            // 
            // ClientBtnEdit
            // 
            ClientBtnEdit.BackColor = Color.FromArgb(0, 126, 249);
            ClientBtnEdit.FlatAppearance.BorderSize = 0;
            ClientBtnEdit.FlatStyle = FlatStyle.Flat;
            ClientBtnEdit.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClientBtnEdit.Location = new Point(198, 154);
            ClientBtnEdit.Name = "ClientBtnEdit";
            ClientBtnEdit.Size = new Size(75, 30);
            ClientBtnEdit.TabIndex = 21;
            ClientBtnEdit.Text = "Edit";
            ClientBtnEdit.UseVisualStyleBackColor = false;
            ClientBtnEdit.Click += ClientBtnEdit_Click;
            // 
            // MemberDateBirth
            // 
            MemberDateBirth.CalendarFont = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MemberDateBirth.CalendarForeColor = Color.DimGray;
            MemberDateBirth.CalendarMonthBackground = Color.White;
            MemberDateBirth.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MemberDateBirth.Location = new Point(306, 53);
            MemberDateBirth.Name = "MemberDateBirth";
            MemberDateBirth.Size = new Size(121, 22);
            MemberDateBirth.TabIndex = 18;
            // 
            // MemberCmbGender
            // 
            MemberCmbGender.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MemberCmbGender.FormattingEnabled = true;
            MemberCmbGender.Items.AddRange(new object[] { "Male", "Female", "Trans", "Other" });
            MemberCmbGender.Location = new Point(179, 53);
            MemberCmbGender.Name = "MemberCmbGender";
            MemberCmbGender.Size = new Size(121, 22);
            MemberCmbGender.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NAMU 1960", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(263, 34);
            label3.TabIndex = 12;
            label3.Text = "Manage Members";
            // 
            // MemberTxtPhone
            // 
            MemberTxtPhone.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MemberTxtPhone.Location = new Point(14, 93);
            MemberTxtPhone.Name = "MemberTxtPhone";
            MemberTxtPhone.PlaceholderText = "Phone";
            MemberTxtPhone.Size = new Size(159, 22);
            MemberTxtPhone.TabIndex = 15;
            // 
            // MemberTxtName
            // 
            MemberTxtName.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MemberTxtName.Location = new Point(14, 53);
            MemberTxtName.Name = "MemberTxtName";
            MemberTxtName.PlaceholderText = "Name";
            MemberTxtName.Size = new Size(159, 22);
            MemberTxtName.TabIndex = 16;
            // 
            // MemberDateJoin
            // 
            MemberDateJoin.CalendarFont = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MemberDateJoin.CalendarForeColor = Color.DimGray;
            MemberDateJoin.CalendarMonthBackground = Color.White;
            MemberDateJoin.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MemberDateJoin.Location = new Point(433, 53);
            MemberDateJoin.Name = "MemberDateJoin";
            MemberDateJoin.Size = new Size(121, 22);
            MemberDateJoin.TabIndex = 18;
            // 
            // MemberCmbTiming
            // 
            MemberCmbTiming.FormattingEnabled = true;
            MemberCmbTiming.Items.AddRange(new object[] { "6AM - 8 AM", "8AM - 10 AM", "10AM - 12 AM", "12AM - 2 PM", "2PM - 4 PM", "4PM - 6 PM", "6PM - 8 PM" });
            MemberCmbTiming.Location = new Point(179, 92);
            MemberCmbTiming.Name = "MemberCmbTiming";
            MemberCmbTiming.Size = new Size(121, 23);
            MemberCmbTiming.TabIndex = 24;
            // 
            // MemberCmbStatus
            // 
            MemberCmbStatus.FormattingEnabled = true;
            MemberCmbStatus.Items.AddRange(new object[] { "Pending", "Cancelled" });
            MemberCmbStatus.Location = new Point(306, 92);
            MemberCmbStatus.Name = "MemberCmbStatus";
            MemberCmbStatus.Size = new Size(121, 23);
            MemberCmbStatus.TabIndex = 24;
            // 
            // MemberCmbCoach
            // 
            MemberCmbCoach.FormattingEnabled = true;
            MemberCmbCoach.Location = new Point(433, 92);
            MemberCmbCoach.Name = "MemberCmbCoach";
            MemberCmbCoach.Size = new Size(121, 23);
            MemberCmbCoach.TabIndex = 24;
            // 
            // MemberCmbMembership
            // 
            MemberCmbMembership.FormattingEnabled = true;
            MemberCmbMembership.Location = new Point(560, 92);
            MemberCmbMembership.Name = "MemberCmbMembership";
            MemberCmbMembership.Size = new Size(121, 23);
            MemberCmbMembership.TabIndex = 24;
            // 
            // MemberDataGrid
            // 
            MemberDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberDataGrid.Location = new Point(3, 217);
            MemberDataGrid.Name = "MemberDataGrid";
            MemberDataGrid.Size = new Size(723, 296);
            MemberDataGrid.TabIndex = 25;
            MemberDataGrid.CellClick += MemberDataGrid_CellClick;
            // 
            // ManageMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MemberDataGrid);
            Controls.Add(MemberCmbMembership);
            Controls.Add(MemberCmbCoach);
            Controls.Add(MemberCmbStatus);
            Controls.Add(MemberCmbTiming);
            Controls.Add(MemberLblList);
            Controls.Add(ClientBtnDelete);
            Controls.Add(ClientBtnSave);
            Controls.Add(ClientBtnEdit);
            Controls.Add(MemberDateJoin);
            Controls.Add(MemberDateBirth);
            Controls.Add(MemberCmbGender);
            Controls.Add(label3);
            Controls.Add(MemberTxtPhone);
            Controls.Add(MemberTxtName);
            Name = "ManageMembers";
            Size = new Size(729, 526);
            ((System.ComponentModel.ISupportInitialize)MemberDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label MemberLblList;
        private Button ClientBtnDelete;
        private Button ClientBtnSave;
        private Button ClientBtnEdit;
        private DateTimePicker MemberDateBirth;
        private ComboBox MemberCmbGender;
        private Label label3;
        private TextBox MemberTxtPhone;
        private TextBox MemberTxtName;
        private DateTimePicker MemberDateJoin;
        private ComboBox MemberCmbTiming;
        private ComboBox MemberCmbStatus;
        private ComboBox MemberCmbCoach;
        private ComboBox MemberCmbMembership;
        private DataGridView MemberDataGrid;
    }
}
