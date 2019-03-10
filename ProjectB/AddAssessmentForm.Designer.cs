namespace ProjectB
{
    partial class AddAssessmentForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblTotalWeightage = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.txtTotalWeightage = new System.Windows.Forms.TextBox();
            this.btnADDAssessment = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnListOfAddedAssessment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(265, 94);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(457, 87);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Location = new System.Drawing.Point(416, 147);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(200, 20);
            this.dtpDateCreated.TabIndex = 2;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(265, 154);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(67, 13);
            this.lblDateCreated.TabIndex = 3;
            this.lblDateCreated.Text = "DateCreated";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(265, 207);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(60, 13);
            this.lblTotalMarks.TabIndex = 4;
            this.lblTotalMarks.Text = "TotalMarks";
            // 
            // lblTotalWeightage
            // 
            this.lblTotalWeightage.AutoSize = true;
            this.lblTotalWeightage.Location = new System.Drawing.Point(265, 263);
            this.lblTotalWeightage.Name = "lblTotalWeightage";
            this.lblTotalWeightage.Size = new System.Drawing.Size(83, 13);
            this.lblTotalWeightage.TabIndex = 5;
            this.lblTotalWeightage.Text = "TotalWeightage";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(457, 207);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMarks.TabIndex = 6;
            // 
            // txtTotalWeightage
            // 
            this.txtTotalWeightage.Location = new System.Drawing.Point(457, 256);
            this.txtTotalWeightage.Name = "txtTotalWeightage";
            this.txtTotalWeightage.Size = new System.Drawing.Size(100, 20);
            this.txtTotalWeightage.TabIndex = 7;
            // 
            // btnADDAssessment
            // 
            this.btnADDAssessment.Location = new System.Drawing.Point(462, 339);
            this.btnADDAssessment.Name = "btnADDAssessment";
            this.btnADDAssessment.Size = new System.Drawing.Size(95, 23);
            this.btnADDAssessment.TabIndex = 8;
            this.btnADDAssessment.Text = "ADDAssessment";
            this.btnADDAssessment.UseVisualStyleBackColor = true;
            this.btnADDAssessment.Click += new System.EventHandler(this.btnADDAssessment_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(1, 0);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMain.TabIndex = 9;
            this.btnBackToMain.Text = "<<BACK<<";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnListOfAddedAssessment
            // 
            this.btnListOfAddedAssessment.Location = new System.Drawing.Point(457, 406);
            this.btnListOfAddedAssessment.Name = "btnListOfAddedAssessment";
            this.btnListOfAddedAssessment.Size = new System.Drawing.Size(154, 23);
            this.btnListOfAddedAssessment.TabIndex = 10;
            this.btnListOfAddedAssessment.Text = "List Of Added Assessment";
            this.btnListOfAddedAssessment.UseVisualStyleBackColor = true;
            this.btnListOfAddedAssessment.Click += new System.EventHandler(this.btnListOfAddedAssessment_Click);
            // 
            // AddAssessmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListOfAddedAssessment);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnADDAssessment);
            this.Controls.Add(this.txtTotalWeightage);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.lblTotalWeightage);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.dtpDateCreated);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddAssessmentForm";
            this.Text = "AddAssessmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblTotalWeightage;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.TextBox txtTotalWeightage;
        private System.Windows.Forms.Button btnADDAssessment;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnListOfAddedAssessment;
    }
}