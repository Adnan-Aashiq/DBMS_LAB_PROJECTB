namespace ProjectB
{
    partial class AddAssessmentComponentForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBackToListOfAddedAssessments = new System.Windows.Forms.Button();
            this.btnAddAssessmentComponent = new System.Windows.Forms.Button();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.dtpDateUpdated = new System.Windows.Forms.DateTimePicker();
            this.btnListOfAddedAssessmentComponent = new System.Windows.Forms.Button();
            this.lblRubricDetails = new System.Windows.Forms.Label();
            this.cmboboxRubricDetails = new System.Windows.Forms.ComboBox();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(218, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(387, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnBackToListOfAddedAssessments
            // 
            this.btnBackToListOfAddedAssessments.Location = new System.Drawing.Point(147, 1);
            this.btnBackToListOfAddedAssessments.Name = "btnBackToListOfAddedAssessments";
            this.btnBackToListOfAddedAssessments.Size = new System.Drawing.Size(75, 23);
            this.btnBackToListOfAddedAssessments.TabIndex = 2;
            this.btnBackToListOfAddedAssessments.Text = "<<Back<<";
            this.btnBackToListOfAddedAssessments.UseVisualStyleBackColor = true;
            this.btnBackToListOfAddedAssessments.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddAssessmentComponent
            // 
            this.btnAddAssessmentComponent.Location = new System.Drawing.Point(363, 273);
            this.btnAddAssessmentComponent.Name = "btnAddAssessmentComponent";
            this.btnAddAssessmentComponent.Size = new System.Drawing.Size(181, 23);
            this.btnAddAssessmentComponent.TabIndex = 3;
            this.btnAddAssessmentComponent.Text = "Add AssessmemtComponent";
            this.btnAddAssessmentComponent.UseVisualStyleBackColor = true;
            this.btnAddAssessmentComponent.Click += new System.EventHandler(this.btnAddAssessmentComponent_Click);
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(218, 145);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(60, 13);
            this.lblTotalMarks.TabIndex = 4;
            this.lblTotalMarks.Text = "TotalMarks";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(218, 203);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(67, 13);
            this.lblDateCreated.TabIndex = 5;
            this.lblDateCreated.Text = "DateCreated";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(387, 145);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMarks.TabIndex = 7;
            // 
            // dtpDateUpdated
            // 
            this.dtpDateUpdated.Location = new System.Drawing.Point(363, 197);
            this.dtpDateUpdated.Name = "dtpDateUpdated";
            this.dtpDateUpdated.Size = new System.Drawing.Size(200, 20);
            this.dtpDateUpdated.TabIndex = 8;
            // 
            // btnListOfAddedAssessmentComponent
            // 
            this.btnListOfAddedAssessmentComponent.Location = new System.Drawing.Point(625, 1);
            this.btnListOfAddedAssessmentComponent.Name = "btnListOfAddedAssessmentComponent";
            this.btnListOfAddedAssessmentComponent.Size = new System.Drawing.Size(176, 23);
            this.btnListOfAddedAssessmentComponent.TabIndex = 9;
            this.btnListOfAddedAssessmentComponent.Text = "ListOfAddedAssessmentComponent";
            this.btnListOfAddedAssessmentComponent.UseVisualStyleBackColor = true;
            this.btnListOfAddedAssessmentComponent.Click += new System.EventHandler(this.btnListOfAddedAssessmentComponent_Click);
            // 
            // lblRubricDetails
            // 
            this.lblRubricDetails.AutoSize = true;
            this.lblRubricDetails.Location = new System.Drawing.Point(218, 109);
            this.lblRubricDetails.Name = "lblRubricDetails";
            this.lblRubricDetails.Size = new System.Drawing.Size(70, 13);
            this.lblRubricDetails.TabIndex = 10;
            this.lblRubricDetails.Text = "RubricDetails";
            // 
            // cmboboxRubricDetails
            // 
            this.cmboboxRubricDetails.FormattingEnabled = true;
            this.cmboboxRubricDetails.Location = new System.Drawing.Point(378, 106);
            this.cmboboxRubricDetails.Name = "cmboboxRubricDetails";
            this.cmboboxRubricDetails.Size = new System.Drawing.Size(121, 21);
            this.cmboboxRubricDetails.TabIndex = 11;
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(3, 1);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(138, 23);
            this.btnBackToMainPage.TabIndex = 12;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // AddAssessmentComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.cmboboxRubricDetails);
            this.Controls.Add(this.lblRubricDetails);
            this.Controls.Add(this.btnListOfAddedAssessmentComponent);
            this.Controls.Add(this.dtpDateUpdated);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.btnAddAssessmentComponent);
            this.Controls.Add(this.btnBackToListOfAddedAssessments);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddAssessmentComponentForm";
            this.Text = "AddAssessmentComponentForm";
            this.Load += new System.EventHandler(this.AddAssessmentComponentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBackToListOfAddedAssessments;
        private System.Windows.Forms.Button btnAddAssessmentComponent;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.DateTimePicker dtpDateUpdated;
        private System.Windows.Forms.Button btnListOfAddedAssessmentComponent;
        private System.Windows.Forms.Label lblRubricDetails;
        private System.Windows.Forms.ComboBox cmboboxRubricDetails;
        private System.Windows.Forms.Button btnBackToMainPage;
    }
}