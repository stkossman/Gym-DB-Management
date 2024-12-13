namespace Gym
{
    partial class ManageCoach
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
            pnlCoach = new Panel();
            CoachDateBirth = new DateTimePicker();
            CoachGridList = new DataGridView();
            CoachLblCoachList = new Label();
            CoachBtnDelete = new Button();
            CoachBtnSave = new Button();
            CoachBtnEdit = new Button();
            CoachCmbGender = new ComboBox();
            label3 = new Label();
            CoachTxtExp = new TextBox();
            CoachTxtAddress = new TextBox();
            CoachTxtPhone = new TextBox();
            CoachTxtName = new TextBox();
            pnlCoach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoachGridList).BeginInit();
            SuspendLayout();
            // 
            // pnlCoach
            // 
            pnlCoach.Controls.Add(CoachDateBirth);
            pnlCoach.Controls.Add(CoachGridList);
            pnlCoach.Controls.Add(CoachLblCoachList);
            pnlCoach.Controls.Add(CoachBtnDelete);
            pnlCoach.Controls.Add(CoachBtnSave);
            pnlCoach.Controls.Add(CoachBtnEdit);
            pnlCoach.Controls.Add(CoachCmbGender);
            pnlCoach.Controls.Add(label3);
            pnlCoach.Controls.Add(CoachTxtExp);
            pnlCoach.Controls.Add(CoachTxtAddress);
            pnlCoach.Controls.Add(CoachTxtPhone);
            pnlCoach.Controls.Add(CoachTxtName);
            pnlCoach.Location = new Point(3, 3);
            pnlCoach.Name = "pnlCoach";
            pnlCoach.Size = new Size(743, 535);
            pnlCoach.TabIndex = 4;
            // 
            // CoachDateBirth
            // 
            CoachDateBirth.CalendarFont = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CoachDateBirth.Font = new Font("NAMU 1960", 9F, FontStyle.Bold);
            CoachDateBirth.Location = new Point(416, 56);
            CoachDateBirth.Name = "CoachDateBirth";
            CoachDateBirth.Size = new Size(200, 22);
            CoachDateBirth.TabIndex = 12;
            // 
            // CoachGridList
            // 
            CoachGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoachGridList.Location = new Point(3, 224);
            CoachGridList.Name = "CoachGridList";
            CoachGridList.Size = new Size(737, 298);
            CoachGridList.TabIndex = 11;
            CoachGridList.CellClick += CoachGridList_CellClick;
            // 
            // CoachLblCoachList
            // 
            CoachLblCoachList.AutoSize = true;
            CoachLblCoachList.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CoachLblCoachList.ForeColor = Color.FromArgb(0, 126, 249);
            CoachLblCoachList.Location = new Point(295, 193);
            CoachLblCoachList.Name = "CoachLblCoachList";
            CoachLblCoachList.Size = new Size(140, 27);
            CoachLblCoachList.TabIndex = 10;
            CoachLblCoachList.Text = "Coaches list";
            // 
            // CoachBtnDelete
            // 
            CoachBtnDelete.BackColor = Color.FromArgb(0, 126, 249);
            CoachBtnDelete.FlatAppearance.BorderSize = 0;
            CoachBtnDelete.FlatStyle = FlatStyle.Flat;
            CoachBtnDelete.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CoachBtnDelete.Location = new Point(459, 160);
            CoachBtnDelete.Name = "CoachBtnDelete";
            CoachBtnDelete.Size = new Size(75, 30);
            CoachBtnDelete.TabIndex = 9;
            CoachBtnDelete.Text = "Delete";
            CoachBtnDelete.UseVisualStyleBackColor = false;
            CoachBtnDelete.Click += CoachBtnDelete_Click;
            // 
            // CoachBtnSave
            // 
            CoachBtnSave.BackColor = Color.FromArgb(0, 126, 249);
            CoachBtnSave.FlatAppearance.BorderSize = 0;
            CoachBtnSave.FlatStyle = FlatStyle.Flat;
            CoachBtnSave.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CoachBtnSave.Location = new Point(326, 160);
            CoachBtnSave.Name = "CoachBtnSave";
            CoachBtnSave.Size = new Size(75, 30);
            CoachBtnSave.TabIndex = 9;
            CoachBtnSave.Text = "Save";
            CoachBtnSave.UseVisualStyleBackColor = false;
            CoachBtnSave.Click += CoachBtnSave_Click;
            // 
            // CoachBtnEdit
            // 
            CoachBtnEdit.BackColor = Color.FromArgb(0, 126, 249);
            CoachBtnEdit.FlatAppearance.BorderSize = 0;
            CoachBtnEdit.FlatStyle = FlatStyle.Flat;
            CoachBtnEdit.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CoachBtnEdit.Location = new Point(198, 160);
            CoachBtnEdit.Name = "CoachBtnEdit";
            CoachBtnEdit.Size = new Size(75, 30);
            CoachBtnEdit.TabIndex = 9;
            CoachBtnEdit.Text = "Edit";
            CoachBtnEdit.UseVisualStyleBackColor = false;
            CoachBtnEdit.Click += CoachBtnEdit_Click;
            // 
            // CoachCmbGender
            // 
            CoachCmbGender.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CoachCmbGender.FormattingEnabled = true;
            CoachCmbGender.Items.AddRange(new object[] { "Male", "Female", "Trans", "Other" });
            CoachCmbGender.Location = new Point(210, 59);
            CoachCmbGender.Name = "CoachCmbGender";
            CoachCmbGender.Size = new Size(121, 22);
            CoachCmbGender.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NAMU 1960", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(224, 34);
            label3.TabIndex = 1;
            label3.Text = "Manage Coach";
            // 
            // CoachTxtExp
            // 
            CoachTxtExp.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CoachTxtExp.Location = new Point(14, 99);
            CoachTxtExp.Name = "CoachTxtExp";
            CoachTxtExp.PlaceholderText = "Experience";
            CoachTxtExp.Size = new Size(159, 22);
            CoachTxtExp.TabIndex = 6;
            // 
            // CoachTxtAddress
            // 
            CoachTxtAddress.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CoachTxtAddress.Location = new Point(210, 99);
            CoachTxtAddress.Name = "CoachTxtAddress";
            CoachTxtAddress.PlaceholderText = "Address";
            CoachTxtAddress.Size = new Size(200, 22);
            CoachTxtAddress.TabIndex = 6;
            // 
            // CoachTxtPhone
            // 
            CoachTxtPhone.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CoachTxtPhone.Location = new Point(416, 100);
            CoachTxtPhone.Name = "CoachTxtPhone";
            CoachTxtPhone.PlaceholderText = "Phone";
            CoachTxtPhone.Size = new Size(147, 22);
            CoachTxtPhone.TabIndex = 6;
            // 
            // CoachTxtName
            // 
            CoachTxtName.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CoachTxtName.Location = new Point(14, 59);
            CoachTxtName.Name = "CoachTxtName";
            CoachTxtName.PlaceholderText = "Name";
            CoachTxtName.Size = new Size(159, 22);
            CoachTxtName.TabIndex = 6;
            // 
            // ManageCoach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCoach);
            Name = "ManageCoach";
            Size = new Size(747, 539);
            pnlCoach.ResumeLayout(false);
            pnlCoach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CoachGridList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCoach;
        private Label CoachLblCoachList;
        private Button CoachBtnDelete;
        private Button CoachBtnSave;
        private Button CoachBtnEdit;
        private ComboBox CoachCmbGender;
        private Label label3;
        private TextBox CoachTxtExp;
        private TextBox CoachTxtAddress;
        private TextBox CoachTxtPhone;
        private TextBox CoachTxtName;
        private DataGridView CoachGridList;
        private DateTimePicker CoachDateBirth;
    }
}
