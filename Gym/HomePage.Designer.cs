namespace Gym
{
    partial class HomePage
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
            pictureBox1 = new PictureBox();
            currentTime = new Label();
            todayDate = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kossmansGym;
            pictureBox1.Location = new Point(210, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // currentTime
            // 
            currentTime.AutoSize = true;
            currentTime.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            currentTime.ForeColor = Color.White;
            currentTime.Location = new Point(330, 260);
            currentTime.Name = "currentTime";
            currentTime.Size = new Size(64, 26);
            currentTime.TabIndex = 1;
            currentTime.Text = "label1";
            // 
            // todayDate
            // 
            todayDate.AutoSize = true;
            todayDate.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            todayDate.ForeColor = Color.FromArgb(0, 126, 249);
            todayDate.Location = new Point(280, 280);
            todayDate.Name = "todayDate";
            todayDate.Size = new Size(44, 18);
            todayDate.TabIndex = 2;
            todayDate.Text = "label1";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(todayDate);
            Controls.Add(currentTime);
            Controls.Add(pictureBox1);
            Name = "HomePage";
            Size = new Size(745, 440);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label currentTime;
        private Label todayDate;
    }
}
