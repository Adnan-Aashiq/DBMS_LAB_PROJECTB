namespace ProjectB
{
    partial class StudentResultForm
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
            this.lblStudentRegistrationNumber = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblAssessmentName = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblRubricLevelDetails = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblEvaluationDate = new MetroFramework.Drawing.Html.HtmlLabel();
            this.combboxStudentRegistrationNumber = new MetroFramework.Controls.MetroComboBox();
            this.combboxAssessmentComponentName = new MetroFramework.Controls.MetroComboBox();
            this.combboxRubricLevelDetails = new MetroFramework.Controls.MetroComboBox();
            this.dtpEvaluationDate = new MetroFramework.Controls.MetroDateTime();
            this.btnEvaluateThisSelectedStudent = new MetroFramework.Controls.MetroButton();
            this.btnBackToMainPage = new MetroFramework.Controls.MetroButton();
            this.btnEvaluateAStudent = new MetroFramework.Controls.MetroButton();
            this.StudentResultDataGridView = new MetroFramework.Controls.MetroGrid();
            this.btnShowStudentResult = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.StudentResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentRegistrationNumber
            // 
            this.lblStudentRegistrationNumber.AutoScroll = true;
            this.lblStudentRegistrationNumber.AutoScrollMinSize = new System.Drawing.Size(152, 23);
            this.lblStudentRegistrationNumber.AutoSize = false;
            this.lblStudentRegistrationNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblStudentRegistrationNumber.Location = new System.Drawing.Point(245, 80);
            this.lblStudentRegistrationNumber.Name = "lblStudentRegistrationNumber";
            this.lblStudentRegistrationNumber.Size = new System.Drawing.Size(192, 35);
            this.lblStudentRegistrationNumber.TabIndex = 0;
            this.lblStudentRegistrationNumber.Text = "Student Registration Number";
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.AutoScroll = true;
            this.lblAssessmentName.AutoScrollMinSize = new System.Drawing.Size(162, 23);
            this.lblAssessmentName.AutoSize = false;
            this.lblAssessmentName.BackColor = System.Drawing.SystemColors.Window;
            this.lblAssessmentName.Location = new System.Drawing.Point(245, 133);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(192, 35);
            this.lblAssessmentName.TabIndex = 1;
            this.lblAssessmentName.Text = "Assessment Component Name";
            // 
            // lblRubricLevelDetails
            // 
            this.lblRubricLevelDetails.AutoScroll = true;
            this.lblRubricLevelDetails.AutoScrollMinSize = new System.Drawing.Size(110, 23);
            this.lblRubricLevelDetails.AutoSize = false;
            this.lblRubricLevelDetails.BackColor = System.Drawing.SystemColors.Window;
            this.lblRubricLevelDetails.Location = new System.Drawing.Point(245, 194);
            this.lblRubricLevelDetails.Name = "lblRubricLevelDetails";
            this.lblRubricLevelDetails.Size = new System.Drawing.Size(127, 35);
            this.lblRubricLevelDetails.TabIndex = 2;
            this.lblRubricLevelDetails.Text = "Rubric Level Details";
            // 
            // lblEvaluationDate
            // 
            this.lblEvaluationDate.AutoScroll = true;
            this.lblEvaluationDate.AutoScrollMinSize = new System.Drawing.Size(85, 23);
            this.lblEvaluationDate.AutoSize = false;
            this.lblEvaluationDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblEvaluationDate.Location = new System.Drawing.Point(245, 257);
            this.lblEvaluationDate.Name = "lblEvaluationDate";
            this.lblEvaluationDate.Size = new System.Drawing.Size(127, 35);
            this.lblEvaluationDate.TabIndex = 2;
            this.lblEvaluationDate.Text = "EvaluationDate";
            // 
            // combboxStudentRegistrationNumber
            // 
            this.combboxStudentRegistrationNumber.FormattingEnabled = true;
            this.combboxStudentRegistrationNumber.ItemHeight = 23;
            this.combboxStudentRegistrationNumber.Location = new System.Drawing.Point(443, 79);
            this.combboxStudentRegistrationNumber.Name = "combboxStudentRegistrationNumber";
            this.combboxStudentRegistrationNumber.Size = new System.Drawing.Size(199, 29);
            this.combboxStudentRegistrationNumber.TabIndex = 3;
            this.combboxStudentRegistrationNumber.UseSelectable = true;
            this.combboxStudentRegistrationNumber.SelectionChangeCommitted += new System.EventHandler(this.combboxStudentRegistrationNumber_SelectionChangeCommitted);
            this.combboxStudentRegistrationNumber.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEvaluationDate_Validating);
            this.combboxStudentRegistrationNumber.Validated += new System.EventHandler(this.dtpEvaluationDate_Validated);
            // 
            // combboxAssessmentComponentName
            // 
            this.combboxAssessmentComponentName.FormattingEnabled = true;
            this.combboxAssessmentComponentName.ItemHeight = 23;
            this.combboxAssessmentComponentName.Location = new System.Drawing.Point(443, 133);
            this.combboxAssessmentComponentName.Name = "combboxAssessmentComponentName";
            this.combboxAssessmentComponentName.Size = new System.Drawing.Size(199, 29);
            this.combboxAssessmentComponentName.TabIndex = 4;
            this.combboxAssessmentComponentName.UseSelectable = true;
            this.combboxAssessmentComponentName.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEvaluationDate_Validating);
            this.combboxAssessmentComponentName.Validated += new System.EventHandler(this.dtpEvaluationDate_Validated);
            // 
            // combboxRubricLevelDetails
            // 
            this.combboxRubricLevelDetails.FormattingEnabled = true;
            this.combboxRubricLevelDetails.ItemHeight = 23;
            this.combboxRubricLevelDetails.Location = new System.Drawing.Point(443, 194);
            this.combboxRubricLevelDetails.Name = "combboxRubricLevelDetails";
            this.combboxRubricLevelDetails.Size = new System.Drawing.Size(199, 29);
            this.combboxRubricLevelDetails.TabIndex = 5;
            this.combboxRubricLevelDetails.UseSelectable = true;
            this.combboxRubricLevelDetails.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEvaluationDate_Validating);
            this.combboxRubricLevelDetails.Validated += new System.EventHandler(this.dtpEvaluationDate_Validated);
            // 
            // dtpEvaluationDate
            // 
            this.dtpEvaluationDate.Location = new System.Drawing.Point(443, 256);
            this.dtpEvaluationDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpEvaluationDate.Name = "dtpEvaluationDate";
            this.dtpEvaluationDate.Size = new System.Drawing.Size(215, 29);
            this.dtpEvaluationDate.TabIndex = 6;
            this.dtpEvaluationDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEvaluationDate_Validating);
            this.dtpEvaluationDate.Validated += new System.EventHandler(this.dtpEvaluationDate_Validated);
            // 
            // btnEvaluateThisSelectedStudent
            // 
            this.btnEvaluateThisSelectedStudent.Location = new System.Drawing.Point(245, 319);
            this.btnEvaluateThisSelectedStudent.Name = "btnEvaluateThisSelectedStudent";
            this.btnEvaluateThisSelectedStudent.Size = new System.Drawing.Size(413, 30);
            this.btnEvaluateThisSelectedStudent.TabIndex = 7;
            this.btnEvaluateThisSelectedStudent.Text = "Evaluate This Selected Student";
            this.btnEvaluateThisSelectedStudent.UseSelectable = true;
            this.btnEvaluateThisSelectedStudent.Click += new System.EventHandler(this.btnEvaluateThisSelectedStudent_Click);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(0, 2);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(101, 23);
            this.btnBackToMainPage.TabIndex = 8;
            this.btnBackToMainPage.Text = "<<BACK<<";
            this.btnBackToMainPage.UseSelectable = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnEvaluateAStudent
            // 
            this.btnEvaluateAStudent.Location = new System.Drawing.Point(292, 2);
            this.btnEvaluateAStudent.Name = "btnEvaluateAStudent";
            this.btnEvaluateAStudent.Size = new System.Drawing.Size(149, 23);
            this.btnEvaluateAStudent.TabIndex = 9;
            this.btnEvaluateAStudent.Text = "Evaluate A Student";
            this.btnEvaluateAStudent.UseSelectable = true;
            this.btnEvaluateAStudent.Click += new System.EventHandler(this.btnEvaluateAStudent_Click);
            // 
            // StudentResultDataGridView
            // 
            this.StudentResultDataGridView.AllowUserToResizeRows = false;
            this.StudentResultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentResultDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StudentResultDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentResultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentResultDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentResultDataGridView.EnableHeadersVisualStyles = false;
            this.StudentResultDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StudentResultDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentResultDataGridView.Location = new System.Drawing.Point(93, 31);
            this.StudentResultDataGridView.Name = "StudentResultDataGridView";
            this.StudentResultDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentResultDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentResultDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StudentResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentResultDataGridView.Size = new System.Drawing.Size(729, 334);
            this.StudentResultDataGridView.TabIndex = 10;
            this.StudentResultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentResultDataGridView_CellContentClick);
            // 
            // btnShowStudentResult
            // 
            this.btnShowStudentResult.Location = new System.Drawing.Point(443, 2);
            this.btnShowStudentResult.Name = "btnShowStudentResult";
            this.btnShowStudentResult.Size = new System.Drawing.Size(149, 23);
            this.btnShowStudentResult.TabIndex = 11;
            this.btnShowStudentResult.Text = "Show Student Result";
            this.btnShowStudentResult.UseSelectable = true;
            this.btnShowStudentResult.Click += new System.EventHandler(this.btnShowStudentResult_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(754, 371);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 64);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // StudentResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShowStudentResult);
            this.Controls.Add(this.StudentResultDataGridView);
            this.Controls.Add(this.btnEvaluateAStudent);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.btnEvaluateThisSelectedStudent);
            this.Controls.Add(this.dtpEvaluationDate);
            this.Controls.Add(this.combboxRubricLevelDetails);
            this.Controls.Add(this.combboxAssessmentComponentName);
            this.Controls.Add(this.combboxStudentRegistrationNumber);
            this.Controls.Add(this.lblEvaluationDate);
            this.Controls.Add(this.lblRubricLevelDetails);
            this.Controls.Add(this.lblAssessmentName);
            this.Controls.Add(this.lblStudentRegistrationNumber);
            this.Name = "StudentResultForm";
            this.Text = "StudentResultForm";
            this.Load += new System.EventHandler(this.StudentResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel lblStudentRegistrationNumber;
        private MetroFramework.Drawing.Html.HtmlLabel lblAssessmentName;
        private MetroFramework.Drawing.Html.HtmlLabel lblRubricLevelDetails;
        private MetroFramework.Drawing.Html.HtmlLabel lblEvaluationDate;
        private MetroFramework.Controls.MetroComboBox combboxStudentRegistrationNumber;
        private MetroFramework.Controls.MetroComboBox combboxAssessmentComponentName;
        private MetroFramework.Controls.MetroComboBox combboxRubricLevelDetails;
        private MetroFramework.Controls.MetroDateTime dtpEvaluationDate;
        private MetroFramework.Controls.MetroButton btnEvaluateThisSelectedStudent;
        private MetroFramework.Controls.MetroButton btnBackToMainPage;
        private MetroFramework.Controls.MetroButton btnEvaluateAStudent;
        private MetroFramework.Controls.MetroGrid StudentResultDataGridView;
        private MetroFramework.Controls.MetroButton btnShowStudentResult;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}