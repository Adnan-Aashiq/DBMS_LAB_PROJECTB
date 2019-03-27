namespace ProjectB
{
    partial class EditAssessmentComponentForm
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
            this.dtpDateUpdated = new System.Windows.Forms.DateTimePicker();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.btnUpdateAssessmentComponent = new System.Windows.Forms.Button();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBackToAssessmentComponentList = new System.Windows.Forms.Button();
            this.lblListOfRubricDetails = new MetroFramework.Drawing.Html.HtmlLabel();
            this.combboxListOfRubricDetails = new MetroFramework.Controls.MetroComboBox();
            this.combboxListOfAssesmentTitles = new MetroFramework.Controls.MetroComboBox();
            this.lblListOfAssesmentTitles = new MetroFramework.Drawing.Html.HtmlLabel();
            this.SuspendLayout();
            // 
            // dtpDateUpdated
            // 
            this.dtpDateUpdated.Location = new System.Drawing.Point(364, 280);
            this.dtpDateUpdated.Name = "dtpDateUpdated";
            this.dtpDateUpdated.Size = new System.Drawing.Size(200, 20);
            this.dtpDateUpdated.TabIndex = 17;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(388, 228);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMarks.TabIndex = 16;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(219, 286);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(71, 13);
            this.lblDateCreated.TabIndex = 15;
            this.lblDateCreated.Text = "DateUpdated";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(219, 228);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(60, 13);
            this.lblTotalMarks.TabIndex = 14;
            this.lblTotalMarks.Text = "TotalMarks";
            // 
            // btnUpdateAssessmentComponent
            // 
            this.btnUpdateAssessmentComponent.Location = new System.Drawing.Point(364, 356);
            this.btnUpdateAssessmentComponent.Name = "btnUpdateAssessmentComponent";
            this.btnUpdateAssessmentComponent.Size = new System.Drawing.Size(181, 23);
            this.btnUpdateAssessmentComponent.TabIndex = 13;
            this.btnUpdateAssessmentComponent.Text = "Update Assessment Component";
            this.btnUpdateAssessmentComponent.UseVisualStyleBackColor = true;
            this.btnUpdateAssessmentComponent.Click += new System.EventHandler(this.btnUpdateAssessmentComponent_Click);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(2, 3);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(141, 23);
            this.btnBackToMainPage.TabIndex = 12;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(385, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(216, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // btnBackToAssessmentComponentList
            // 
            this.btnBackToAssessmentComponentList.Location = new System.Drawing.Point(145, 4);
            this.btnBackToAssessmentComponentList.Name = "btnBackToAssessmentComponentList";
            this.btnBackToAssessmentComponentList.Size = new System.Drawing.Size(75, 23);
            this.btnBackToAssessmentComponentList.TabIndex = 18;
            this.btnBackToAssessmentComponentList.Text = "<<BACK<<";
            this.btnBackToAssessmentComponentList.UseVisualStyleBackColor = true;
            this.btnBackToAssessmentComponentList.Click += new System.EventHandler(this.btnBackToAssessmentComponentList_Click);
            // 
            // lblListOfRubricDetails
            // 
            this.lblListOfRubricDetails.AutoScroll = true;
            this.lblListOfRubricDetails.AutoScrollMinSize = new System.Drawing.Size(116, 23);
            this.lblListOfRubricDetails.AutoSize = false;
            this.lblListOfRubricDetails.BackColor = System.Drawing.SystemColors.Window;
            this.lblListOfRubricDetails.Location = new System.Drawing.Point(180, 109);
            this.lblListOfRubricDetails.Name = "lblListOfRubricDetails";
            this.lblListOfRubricDetails.Size = new System.Drawing.Size(139, 23);
            this.lblListOfRubricDetails.TabIndex = 19;
            this.lblListOfRubricDetails.Text = "List Of Rubric Details";
            // 
            // combboxListOfRubricDetails
            // 
            this.combboxListOfRubricDetails.FormattingEnabled = true;
            this.combboxListOfRubricDetails.ItemHeight = 23;
            this.combboxListOfRubricDetails.Location = new System.Drawing.Point(364, 103);
            this.combboxListOfRubricDetails.Name = "combboxListOfRubricDetails";
            this.combboxListOfRubricDetails.Size = new System.Drawing.Size(121, 29);
            this.combboxListOfRubricDetails.TabIndex = 20;
            this.combboxListOfRubricDetails.UseSelectable = true;
            // 
            // combboxListOfAssesmentTitles
            // 
            this.combboxListOfAssesmentTitles.FormattingEnabled = true;
            this.combboxListOfAssesmentTitles.ItemHeight = 23;
            this.combboxListOfAssesmentTitles.Location = new System.Drawing.Point(364, 160);
            this.combboxListOfAssesmentTitles.Name = "combboxListOfAssesmentTitles";
            this.combboxListOfAssesmentTitles.Size = new System.Drawing.Size(121, 29);
            this.combboxListOfAssesmentTitles.TabIndex = 22;
            this.combboxListOfAssesmentTitles.UseSelectable = true;
            // 
            // lblListOfAssesmentTitles
            // 
            this.lblListOfAssesmentTitles.AutoScroll = true;
            this.lblListOfAssesmentTitles.AutoScrollMinSize = new System.Drawing.Size(131, 23);
            this.lblListOfAssesmentTitles.AutoSize = false;
            this.lblListOfAssesmentTitles.BackColor = System.Drawing.SystemColors.Window;
            this.lblListOfAssesmentTitles.Location = new System.Drawing.Point(180, 160);
            this.lblListOfAssesmentTitles.Name = "lblListOfAssesmentTitles";
            this.lblListOfAssesmentTitles.Size = new System.Drawing.Size(139, 23);
            this.lblListOfAssesmentTitles.TabIndex = 21;
            this.lblListOfAssesmentTitles.Text = "List Of Assesment Titles";
            // 
            // EditAssessmentComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combboxListOfAssesmentTitles);
            this.Controls.Add(this.lblListOfAssesmentTitles);
            this.Controls.Add(this.combboxListOfRubricDetails);
            this.Controls.Add(this.lblListOfRubricDetails);
            this.Controls.Add(this.btnBackToAssessmentComponentList);
            this.Controls.Add(this.dtpDateUpdated);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.btnUpdateAssessmentComponent);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "EditAssessmentComponentForm";
            this.Text = "EditAssessmentComponentForm";
            this.Load += new System.EventHandler(this.EditAssessmentComponentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDateUpdated;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Button btnUpdateAssessmentComponent;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBackToAssessmentComponentList;
        private MetroFramework.Drawing.Html.HtmlLabel lblListOfRubricDetails;
        private MetroFramework.Controls.MetroComboBox combboxListOfRubricDetails;
        private MetroFramework.Controls.MetroComboBox combboxListOfAssesmentTitles;
        private MetroFramework.Drawing.Html.HtmlLabel lblListOfAssesmentTitles;
    }
}