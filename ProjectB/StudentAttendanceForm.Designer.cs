namespace ProjectB
{
    partial class StudentAttendanceForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrationNumber = new System.Windows.Forms.Label();
            this.btnMarkAttendence = new System.Windows.Forms.Button();
            this.cmbboxStudentRegistrationNumbers = new System.Windows.Forms.ComboBox();
            this.lblMarkStudentAttendence = new System.Windows.Forms.Label();
            this.btnViewClassAttendence = new System.Windows.Forms.Button();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.lblAttendenceStatus = new System.Windows.Forms.Label();
            this.cmbboxAttendenceStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRegistrationNumber
            // 
            this.btnRegistrationNumber.AutoSize = true;
            this.btnRegistrationNumber.Location = new System.Drawing.Point(204, 162);
            this.btnRegistrationNumber.Name = "btnRegistrationNumber";
            this.btnRegistrationNumber.Size = new System.Drawing.Size(103, 13);
            this.btnRegistrationNumber.TabIndex = 0;
            this.btnRegistrationNumber.Text = "Registration Number";
            // 
            // btnMarkAttendence
            // 
            this.btnMarkAttendence.Location = new System.Drawing.Point(351, 262);
            this.btnMarkAttendence.Name = "btnMarkAttendence";
            this.btnMarkAttendence.Size = new System.Drawing.Size(118, 23);
            this.btnMarkAttendence.TabIndex = 1;
            this.btnMarkAttendence.Text = "Mark Attendence";
            this.btnMarkAttendence.UseVisualStyleBackColor = true;
            this.btnMarkAttendence.Click += new System.EventHandler(this.btnMarkAttendence_Click);
            // 
            // cmbboxStudentRegistrationNumbers
            // 
            this.cmbboxStudentRegistrationNumbers.FormattingEnabled = true;
            this.cmbboxStudentRegistrationNumbers.Location = new System.Drawing.Point(343, 154);
            this.cmbboxStudentRegistrationNumbers.Name = "cmbboxStudentRegistrationNumbers";
            this.cmbboxStudentRegistrationNumbers.Size = new System.Drawing.Size(121, 21);
            this.cmbboxStudentRegistrationNumbers.TabIndex = 2;
            // 
            // lblMarkStudentAttendence
            // 
            this.lblMarkStudentAttendence.AutoSize = true;
            this.lblMarkStudentAttendence.Location = new System.Drawing.Point(340, 96);
            this.lblMarkStudentAttendence.Name = "lblMarkStudentAttendence";
            this.lblMarkStudentAttendence.Size = new System.Drawing.Size(129, 13);
            this.lblMarkStudentAttendence.TabIndex = 3;
            this.lblMarkStudentAttendence.Text = "Mark Student Attendence";
            // 
            // btnViewClassAttendence
            // 
            this.btnViewClassAttendence.Location = new System.Drawing.Point(653, 2);
            this.btnViewClassAttendence.Name = "btnViewClassAttendence";
            this.btnViewClassAttendence.Size = new System.Drawing.Size(144, 23);
            this.btnViewClassAttendence.TabIndex = 4;
            this.btnViewClassAttendence.Text = "Class Attendence";
            this.btnViewClassAttendence.UseVisualStyleBackColor = true;
            this.btnViewClassAttendence.Click += new System.EventHandler(this.btnViewClassAttendence_Click);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(1, 2);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMainPage.TabIndex = 5;
            this.btnBackToMainPage.Text = "<<BACK<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // lblAttendenceStatus
            // 
            this.lblAttendenceStatus.AutoSize = true;
            this.lblAttendenceStatus.Location = new System.Drawing.Point(204, 208);
            this.lblAttendenceStatus.Name = "lblAttendenceStatus";
            this.lblAttendenceStatus.Size = new System.Drawing.Size(95, 13);
            this.lblAttendenceStatus.TabIndex = 6;
            this.lblAttendenceStatus.Text = "Attendence Status";
            // 
            // cmbboxAttendenceStatus
            // 
            this.cmbboxAttendenceStatus.FormattingEnabled = true;
            this.cmbboxAttendenceStatus.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave",
            "Late"});
            this.cmbboxAttendenceStatus.Location = new System.Drawing.Point(343, 208);
            this.cmbboxAttendenceStatus.Name = "cmbboxAttendenceStatus";
            this.cmbboxAttendenceStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbboxAttendenceStatus.TabIndex = 7;
            // 
            // StudentAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbboxAttendenceStatus);
            this.Controls.Add(this.lblAttendenceStatus);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.btnViewClassAttendence);
            this.Controls.Add(this.lblMarkStudentAttendence);
            this.Controls.Add(this.cmbboxStudentRegistrationNumbers);
            this.Controls.Add(this.btnMarkAttendence);
            this.Controls.Add(this.btnRegistrationNumber);
            this.Name = "StudentAttendanceForm";
            this.Text = "StudentAttendanceForm";
            this.Load += new System.EventHandler(this.StudentAttendanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnRegistrationNumber;
        private System.Windows.Forms.Button btnMarkAttendence;
        private System.Windows.Forms.ComboBox cmbboxStudentRegistrationNumbers;
        private System.Windows.Forms.Label lblMarkStudentAttendence;
        private System.Windows.Forms.Button btnViewClassAttendence;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Label lblAttendenceStatus;
        private System.Windows.Forms.ComboBox cmbboxAttendenceStatus;
    }
}