﻿namespace ProjectB
{
    partial class EditRubricLevelForm
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
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnBackToAddedRubrics = new System.Windows.Forms.Button();
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.txtMeasurementLevel = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnUpdateRubricLevel = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(1, 1);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(138, 23);
            this.btnBackToMainPage.TabIndex = 13;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnBackToAddedRubrics
            // 
            this.btnBackToAddedRubrics.Location = new System.Drawing.Point(140, 1);
            this.btnBackToAddedRubrics.Name = "btnBackToAddedRubrics";
            this.btnBackToAddedRubrics.Size = new System.Drawing.Size(75, 23);
            this.btnBackToAddedRubrics.TabIndex = 12;
            this.btnBackToAddedRubrics.Text = "<<BACK<<";
            this.btnBackToAddedRubrics.UseVisualStyleBackColor = true;
            this.btnBackToAddedRubrics.Click += new System.EventHandler(this.btnBackToAddedRubrics_Click);
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(323, 177);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lblMeasurementLevel.TabIndex = 11;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // txtMeasurementLevel
            // 
            this.txtMeasurementLevel.Location = new System.Drawing.Point(458, 174);
            this.txtMeasurementLevel.Name = "txtMeasurementLevel";
            this.txtMeasurementLevel.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurementLevel.TabIndex = 10;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(458, 84);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(100, 20);
            this.txtDetails.TabIndex = 9;
            // 
            // btnUpdateRubricLevel
            // 
            this.btnUpdateRubricLevel.Location = new System.Drawing.Point(458, 269);
            this.btnUpdateRubricLevel.Name = "btnUpdateRubricLevel";
            this.btnUpdateRubricLevel.Size = new System.Drawing.Size(134, 23);
            this.btnUpdateRubricLevel.TabIndex = 8;
            this.btnUpdateRubricLevel.Text = "Update Rubric Level";
            this.btnUpdateRubricLevel.UseVisualStyleBackColor = true;
            this.btnUpdateRubricLevel.Click += new System.EventHandler(this.btnUpdateRubricLevel_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(323, 91);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "Details";
            // 
            // EditRubricLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.btnBackToAddedRubrics);
            this.Controls.Add(this.lblMeasurementLevel);
            this.Controls.Add(this.txtMeasurementLevel);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnUpdateRubricLevel);
            this.Controls.Add(this.lblDetails);
            this.Name = "EditRubricLevelForm";
            this.Text = "EditRubricLevelForm";
            this.Load += new System.EventHandler(this.EditRubricLevelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Button btnBackToAddedRubrics;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.TextBox txtMeasurementLevel;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnUpdateRubricLevel;
        private System.Windows.Forms.Label lblDetails;
    }
}