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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddAssessmentComponent = new System.Windows.Forms.Button();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.dtpDateUpdated = new System.Windows.Forms.DateTimePicker();
            this.btnListOfAddedAssessmentComponent = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.btnListOfAddedAssessmentComponent.Location = new System.Drawing.Point(368, 355);
            this.btnListOfAddedAssessmentComponent.Name = "btnListOfAddedAssessmentComponent";
            this.btnListOfAddedAssessmentComponent.Size = new System.Drawing.Size(176, 23);
            this.btnListOfAddedAssessmentComponent.TabIndex = 9;
            this.btnListOfAddedAssessmentComponent.Text = "ListOfAddedAssessmentComponent";
            this.btnListOfAddedAssessmentComponent.UseVisualStyleBackColor = true;
            // 
            // AddAssessmentComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListOfAddedAssessmentComponent);
            this.Controls.Add(this.dtpDateUpdated);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.btnAddAssessmentComponent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddAssessmentComponentForm";
            this.Text = "AddAssessmentComponentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddAssessmentComponent;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.DateTimePicker dtpDateUpdated;
        private System.Windows.Forms.Button btnListOfAddedAssessmentComponent;
    }
}