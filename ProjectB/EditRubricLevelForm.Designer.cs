namespace ProjectB
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
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.txtMeasurementLevel = new System.Windows.Forms.TextBox();
            this.btnUpdateRubricLevel = new System.Windows.Forms.Button();
            this.combboxListOfRubricDetails = new MetroFramework.Controls.MetroComboBox();
            this.lblListOfRubricDetails = new System.Windows.Forms.Label();
            this.combboxRubricLevelDetails = new MetroFramework.Controls.MetroComboBox();
            this.lblDtailsRL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(1, 1);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(75, 23);
            this.btnCLOSE.TabIndex = 12;
            this.btnCLOSE.Text = "<<CLOSE<<";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnBackToAddedRubrics_Click);
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(323, 207);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lblMeasurementLevel.TabIndex = 11;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // txtMeasurementLevel
            // 
            this.txtMeasurementLevel.Location = new System.Drawing.Point(458, 204);
            this.txtMeasurementLevel.Name = "txtMeasurementLevel";
            this.txtMeasurementLevel.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurementLevel.TabIndex = 10;
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
            // combboxListOfRubricDetails
            // 
            this.combboxListOfRubricDetails.FormattingEnabled = true;
            this.combboxListOfRubricDetails.ItemHeight = 23;
            this.combboxListOfRubricDetails.Items.AddRange(new object[] {
            "Bad",
            "Satisfactory",
            "Good",
            "Excellent"});
            this.combboxListOfRubricDetails.Location = new System.Drawing.Point(437, 66);
            this.combboxListOfRubricDetails.Name = "combboxListOfRubricDetails";
            this.combboxListOfRubricDetails.Size = new System.Drawing.Size(121, 29);
            this.combboxListOfRubricDetails.TabIndex = 52;
            this.combboxListOfRubricDetails.UseSelectable = true;
            // 
            // lblListOfRubricDetails
            // 
            this.lblListOfRubricDetails.AutoSize = true;
            this.lblListOfRubricDetails.Location = new System.Drawing.Point(299, 69);
            this.lblListOfRubricDetails.Name = "lblListOfRubricDetails";
            this.lblListOfRubricDetails.Size = new System.Drawing.Size(106, 13);
            this.lblListOfRubricDetails.TabIndex = 51;
            this.lblListOfRubricDetails.Text = "List Of Rubric Details";
            // 
            // combboxRubricLevelDetails
            // 
            this.combboxRubricLevelDetails.FormattingEnabled = true;
            this.combboxRubricLevelDetails.ItemHeight = 23;
            this.combboxRubricLevelDetails.Items.AddRange(new object[] {
            "Bad",
            "Satisfactory",
            "Good",
            "Excellent"});
            this.combboxRubricLevelDetails.Location = new System.Drawing.Point(437, 135);
            this.combboxRubricLevelDetails.Name = "combboxRubricLevelDetails";
            this.combboxRubricLevelDetails.Size = new System.Drawing.Size(121, 29);
            this.combboxRubricLevelDetails.TabIndex = 54;
            this.combboxRubricLevelDetails.UseSelectable = true;
            // 
            // lblDtailsRL
            // 
            this.lblDtailsRL.AutoSize = true;
            this.lblDtailsRL.Location = new System.Drawing.Point(299, 135);
            this.lblDtailsRL.Name = "lblDtailsRL";
            this.lblDtailsRL.Size = new System.Drawing.Size(39, 13);
            this.lblDtailsRL.TabIndex = 53;
            this.lblDtailsRL.Text = "Details";
            // 
            // EditRubricLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combboxRubricLevelDetails);
            this.Controls.Add(this.lblDtailsRL);
            this.Controls.Add(this.combboxListOfRubricDetails);
            this.Controls.Add(this.lblListOfRubricDetails);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.lblMeasurementLevel);
            this.Controls.Add(this.txtMeasurementLevel);
            this.Controls.Add(this.btnUpdateRubricLevel);
            this.Name = "EditRubricLevelForm";
            this.Text = "EditRubricLevelForm";
            this.Load += new System.EventHandler(this.EditRubricLevelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.TextBox txtMeasurementLevel;
        private System.Windows.Forms.Button btnUpdateRubricLevel;
        private MetroFramework.Controls.MetroComboBox combboxListOfRubricDetails;
        private System.Windows.Forms.Label lblListOfRubricDetails;
        private MetroFramework.Controls.MetroComboBox combboxRubricLevelDetails;
        private System.Windows.Forms.Label lblDtailsRL;
    }
}