namespace ProjectB
{
    partial class ClassAttendanceForm
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
            this.lblAttendenceDate = new System.Windows.Forms.Label();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnBackToStudentAttendence = new System.Windows.Forms.Button();
            this.btnMarkAttendence = new System.Windows.Forms.Button();
            this.dtpAttendenceDates = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblAttendenceDate
            // 
            this.lblAttendenceDate.AutoSize = true;
            this.lblAttendenceDate.Location = new System.Drawing.Point(310, 108);
            this.lblAttendenceDate.Name = "lblAttendenceDate";
            this.lblAttendenceDate.Size = new System.Drawing.Size(88, 13);
            this.lblAttendenceDate.TabIndex = 1;
            this.lblAttendenceDate.Text = "Attendence Date";
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(3, 1);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(141, 23);
            this.btnBackToMainPage.TabIndex = 19;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnBackToStudentAttendence
            // 
            this.btnBackToStudentAttendence.Location = new System.Drawing.Point(148, 1);
            this.btnBackToStudentAttendence.Name = "btnBackToStudentAttendence";
            this.btnBackToStudentAttendence.Size = new System.Drawing.Size(75, 23);
            this.btnBackToStudentAttendence.TabIndex = 21;
            this.btnBackToStudentAttendence.Text = "<<BACK<<";
            this.btnBackToStudentAttendence.UseVisualStyleBackColor = true;
            this.btnBackToStudentAttendence.Click += new System.EventHandler(this.btnBackToStudentAttendence_Click);
            // 
            // btnMarkAttendence
            // 
            this.btnMarkAttendence.Location = new System.Drawing.Point(450, 163);
            this.btnMarkAttendence.Name = "btnMarkAttendence";
            this.btnMarkAttendence.Size = new System.Drawing.Size(75, 23);
            this.btnMarkAttendence.TabIndex = 20;
            this.btnMarkAttendence.Text = "Mark Attendence";
            this.btnMarkAttendence.UseVisualStyleBackColor = true;
            this.btnMarkAttendence.Click += new System.EventHandler(this.btnMarkAttendence_Click);
            // 
            // dtpAttendenceDates
            // 
            this.dtpAttendenceDates.Location = new System.Drawing.Point(434, 101);
            this.dtpAttendenceDates.Name = "dtpAttendenceDates";
            this.dtpAttendenceDates.Size = new System.Drawing.Size(200, 20);
            this.dtpAttendenceDates.TabIndex = 22;
            // 
            // ClassAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpAttendenceDates);
            this.Controls.Add(this.btnBackToStudentAttendence);
            this.Controls.Add(this.btnMarkAttendence);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.lblAttendenceDate);
            this.Name = "ClassAttendanceForm";
            this.Text = "ClassAttendanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAttendenceDate;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Button btnBackToStudentAttendence;
        private System.Windows.Forms.Button btnMarkAttendence;
        private System.Windows.Forms.DateTimePicker dtpAttendenceDates;
    }
}