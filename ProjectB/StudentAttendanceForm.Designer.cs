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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMarkAttendence = new System.Windows.Forms.Button();
            this.lblMarkStudentAttendence = new System.Windows.Forms.Label();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.dtpAttendenceDate = new System.Windows.Forms.DateTimePicker();
            this.lblAttendenceDate = new System.Windows.Forms.Label();
            this.metroGridListOfAddedStudents = new MetroFramework.Controls.MetroGrid();
            this.check_box_Present = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.check_box_Absent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.check_box_Leave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.check_box_Late = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnViewListOfAddedStudents = new MetroFramework.Controls.MetroButton();
            this.btnStudentAttendenceRecord = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListOfAddedStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMarkAttendence
            // 
            this.btnMarkAttendence.Location = new System.Drawing.Point(249, 415);
            this.btnMarkAttendence.Name = "btnMarkAttendence";
            this.btnMarkAttendence.Size = new System.Drawing.Size(118, 23);
            this.btnMarkAttendence.TabIndex = 1;
            this.btnMarkAttendence.Text = "Mark Attendence";
            this.btnMarkAttendence.UseVisualStyleBackColor = true;
            this.btnMarkAttendence.Click += new System.EventHandler(this.btnMarkAttendence_Click);
            // 
            // lblMarkStudentAttendence
            // 
            this.lblMarkStudentAttendence.AutoSize = true;
            this.lblMarkStudentAttendence.Location = new System.Drawing.Point(220, 58);
            this.lblMarkStudentAttendence.Name = "lblMarkStudentAttendence";
            this.lblMarkStudentAttendence.Size = new System.Drawing.Size(129, 13);
            this.lblMarkStudentAttendence.TabIndex = 3;
            this.lblMarkStudentAttendence.Text = "Mark Student Attendence";
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
            // dtpAttendenceDate
            // 
            this.dtpAttendenceDate.Location = new System.Drawing.Point(193, 130);
            this.dtpAttendenceDate.Name = "dtpAttendenceDate";
            this.dtpAttendenceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAttendenceDate.TabIndex = 25;
            this.dtpAttendenceDate.ValueChanged += new System.EventHandler(this.dtpAttendenceDate_ValueChanged);
            // 
            // lblAttendenceDate
            // 
            this.lblAttendenceDate.AutoSize = true;
            this.lblAttendenceDate.Location = new System.Drawing.Point(68, 137);
            this.lblAttendenceDate.Name = "lblAttendenceDate";
            this.lblAttendenceDate.Size = new System.Drawing.Size(88, 13);
            this.lblAttendenceDate.TabIndex = 23;
            this.lblAttendenceDate.Text = "Attendence Date";
            // 
            // metroGridListOfAddedStudents
            // 
            this.metroGridListOfAddedStudents.AllowUserToResizeRows = false;
            this.metroGridListOfAddedStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListOfAddedStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridListOfAddedStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridListOfAddedStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListOfAddedStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridListOfAddedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridListOfAddedStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_box_Present,
            this.check_box_Absent,
            this.check_box_Leave,
            this.check_box_Late});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridListOfAddedStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridListOfAddedStudents.EnableHeadersVisualStyles = false;
            this.metroGridListOfAddedStudents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridListOfAddedStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListOfAddedStudents.Location = new System.Drawing.Point(12, 199);
            this.metroGridListOfAddedStudents.Name = "metroGridListOfAddedStudents";
            this.metroGridListOfAddedStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListOfAddedStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridListOfAddedStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridListOfAddedStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridListOfAddedStudents.Size = new System.Drawing.Size(776, 197);
            this.metroGridListOfAddedStudents.TabIndex = 27;
            this.metroGridListOfAddedStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridListOfAddedStudents_CellContentClick);
            // 
            // check_box_Present
            // 
            this.check_box_Present.HeaderText = "Present";
            this.check_box_Present.Name = "check_box_Present";
            this.check_box_Present.ToolTipText = "Present";
            // 
            // check_box_Absent
            // 
            this.check_box_Absent.HeaderText = "Absent";
            this.check_box_Absent.Name = "check_box_Absent";
            this.check_box_Absent.ToolTipText = "Absent";
            // 
            // check_box_Leave
            // 
            this.check_box_Leave.HeaderText = "Leave";
            this.check_box_Leave.Name = "check_box_Leave";
            this.check_box_Leave.ToolTipText = "Leave";
            // 
            // check_box_Late
            // 
            this.check_box_Late.HeaderText = "Late";
            this.check_box_Late.Name = "check_box_Late";
            this.check_box_Late.ToolTipText = "Late";
            // 
            // btnViewListOfAddedStudents
            // 
            this.btnViewListOfAddedStudents.Location = new System.Drawing.Point(203, 170);
            this.btnViewListOfAddedStudents.Name = "btnViewListOfAddedStudents";
            this.btnViewListOfAddedStudents.Size = new System.Drawing.Size(200, 23);
            this.btnViewListOfAddedStudents.TabIndex = 28;
            this.btnViewListOfAddedStudents.Text = "View List Of Added Students";
            this.btnViewListOfAddedStudents.UseSelectable = true;
            this.btnViewListOfAddedStudents.Click += new System.EventHandler(this.btnViewListOfAddedStudents_Click);
            // 
            // btnStudentAttendenceRecord
            // 
            this.btnStudentAttendenceRecord.AutoSize = true;
            this.btnStudentAttendenceRecord.Location = new System.Drawing.Point(596, 2);
            this.btnStudentAttendenceRecord.Name = "btnStudentAttendenceRecord";
            this.btnStudentAttendenceRecord.Size = new System.Drawing.Size(202, 83);
            this.btnStudentAttendenceRecord.TabIndex = 29;
            this.btnStudentAttendenceRecord.Text = "Student Attendence Record";
            this.btnStudentAttendenceRecord.UseSelectable = true;
            this.btnStudentAttendenceRecord.Click += new System.EventHandler(this.btnStudentAttendenceRecord_Click);
            // 
            // StudentAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStudentAttendenceRecord);
            this.Controls.Add(this.btnViewListOfAddedStudents);
            this.Controls.Add(this.metroGridListOfAddedStudents);
            this.Controls.Add(this.dtpAttendenceDate);
            this.Controls.Add(this.lblAttendenceDate);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.lblMarkStudentAttendence);
            this.Controls.Add(this.btnMarkAttendence);
            this.Name = "StudentAttendanceForm";
            this.Text = "StudentAttendanceForm";
            this.Load += new System.EventHandler(this.StudentAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListOfAddedStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMarkAttendence;
        private System.Windows.Forms.Label lblMarkStudentAttendence;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.DateTimePicker dtpAttendenceDate;
        private System.Windows.Forms.Label lblAttendenceDate;
        private MetroFramework.Controls.MetroGrid metroGridListOfAddedStudents;
        private MetroFramework.Controls.MetroButton btnViewListOfAddedStudents;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_box_Present;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_box_Absent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_box_Leave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_box_Late;
        private MetroFramework.Controls.MetroButton btnStudentAttendenceRecord;
    }
}