namespace Gym
{
    partial class ManageBilling
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
            BillingBtnCancel = new Button();
            BillingBtnConfirm = new Button();
            label3 = new Label();
            BillingTxtAmount = new TextBox();
            BillingCmbMember = new ComboBox();
            BillingDatePeriod = new DateTimePicker();
            BillingDate = new DateTimePicker();
            BillingGridList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)BillingGridList).BeginInit();
            SuspendLayout();
            // 
            // MembershipLblList
            // 
            MembershipLblList.AutoSize = true;
            MembershipLblList.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MembershipLblList.ForeColor = Color.FromArgb(0, 126, 249);
            MembershipLblList.Location = new Point(403, 32);
            MembershipLblList.Name = "MembershipLblList";
            MembershipLblList.Size = new Size(123, 27);
            MembershipLblList.TabIndex = 32;
            MembershipLblList.Text = "Billing List";
            // 
            // BillingBtnCancel
            // 
            BillingBtnCancel.BackColor = Color.SlateGray;
            BillingBtnCancel.FlatAppearance.BorderSize = 0;
            BillingBtnCancel.FlatStyle = FlatStyle.Flat;
            BillingBtnCancel.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BillingBtnCancel.Location = new Point(98, 317);
            BillingBtnCancel.Name = "BillingBtnCancel";
            BillingBtnCancel.Size = new Size(75, 30);
            BillingBtnCancel.TabIndex = 30;
            BillingBtnCancel.Text = "Clear";
            BillingBtnCancel.UseVisualStyleBackColor = false;
            BillingBtnCancel.Click += BillingBtnCancel_Click;
            // 
            // BillingBtnConfirm
            // 
            BillingBtnConfirm.BackColor = Color.FromArgb(0, 126, 249);
            BillingBtnConfirm.FlatAppearance.BorderSize = 0;
            BillingBtnConfirm.FlatStyle = FlatStyle.Flat;
            BillingBtnConfirm.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BillingBtnConfirm.Location = new Point(14, 317);
            BillingBtnConfirm.Name = "BillingBtnConfirm";
            BillingBtnConfirm.Size = new Size(75, 30);
            BillingBtnConfirm.TabIndex = 31;
            BillingBtnConfirm.Text = "Confirm";
            BillingBtnConfirm.UseVisualStyleBackColor = false;
            BillingBtnConfirm.Click += BillingBtnConfirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NAMU 1960", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(96, 34);
            label3.TabIndex = 24;
            label3.Text = "Billing";
            // 
            // BillingTxtAmount
            // 
            BillingTxtAmount.Font = new Font("NAMU 1960", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BillingTxtAmount.Location = new Point(14, 206);
            BillingTxtAmount.Name = "BillingTxtAmount";
            BillingTxtAmount.PlaceholderText = "Amount";
            BillingTxtAmount.Size = new Size(159, 22);
            BillingTxtAmount.TabIndex = 28;
            // 
            // BillingCmbMember
            // 
            BillingCmbMember.FormattingEnabled = true;
            BillingCmbMember.Location = new Point(14, 98);
            BillingCmbMember.Name = "BillingCmbMember";
            BillingCmbMember.Size = new Size(121, 23);
            BillingCmbMember.TabIndex = 34;
            // 
            // BillingDatePeriod
            // 
            BillingDatePeriod.Location = new Point(14, 138);
            BillingDatePeriod.Name = "BillingDatePeriod";
            BillingDatePeriod.Size = new Size(200, 23);
            BillingDatePeriod.TabIndex = 35;
            // 
            // BillingDate
            // 
            BillingDate.Location = new Point(14, 167);
            BillingDate.Name = "BillingDate";
            BillingDate.Size = new Size(200, 23);
            BillingDate.TabIndex = 36;
            // 
            // BillingGridList
            // 
            BillingGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillingGridList.Location = new Point(220, 78);
            BillingGridList.Name = "BillingGridList";
            BillingGridList.Size = new Size(494, 269);
            BillingGridList.TabIndex = 37;
            BillingGridList.CellClick += BillingGridList_CellClick;
            // 
            // ManageBilling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BillingGridList);
            Controls.Add(BillingDate);
            Controls.Add(BillingDatePeriod);
            Controls.Add(BillingCmbMember);
            Controls.Add(MembershipLblList);
            Controls.Add(BillingBtnCancel);
            Controls.Add(BillingBtnConfirm);
            Controls.Add(label3);
            Controls.Add(BillingTxtAmount);
            Name = "ManageBilling";
            Size = new Size(729, 358);
            ((System.ComponentModel.ISupportInitialize)BillingGridList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label MembershipLblList;
        private Button BillingBtnCancel;
        private Button BillingBtnConfirm;
        private Label label3;
        private TextBox BillingTxtAmount;
        private ComboBox BillingCmbMember;
        private DateTimePicker BillingDatePeriod;
        private DateTimePicker BillingDate;
        private DataGridView BillingGridList;
    }
}
