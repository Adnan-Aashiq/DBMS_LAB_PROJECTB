namespace ProjectB
{
    partial class EditRubricForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtRubricDetails = new System.Windows.Forms.TextBox();
            this.lblRubricDetails = new System.Windows.Forms.Label();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnBackTolListOfAddedRubric = new System.Windows.Forms.Button();
            this.cmbboxListfAddedCLOIds = new System.Windows.Forms.ComboBox();
            this.lblCLOIds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(466, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRubricDetails
            // 
            this.txtRubricDetails.Location = new System.Drawing.Point(455, 129);
            this.txtRubricDetails.Name = "txtRubricDetails";
            this.txtRubricDetails.Size = new System.Drawing.Size(100, 20);
            this.txtRubricDetails.TabIndex = 39;
            // 
            // lblRubricDetails
            // 
            this.lblRubricDetails.AutoSize = true;
            this.lblRubricDetails.Location = new System.Drawing.Point(294, 132);
            this.lblRubricDetails.Name = "lblRubricDetails";
            this.lblRubricDetails.Size = new System.Drawing.Size(73, 13);
            this.lblRubricDetails.TabIndex = 38;
            this.lblRubricDetails.Text = "Rubric Details";
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(2, 3);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(148, 23);
            this.btnBackToMainPage.TabIndex = 42;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click_1);
            // 
            // btnBackTolListOfAddedRubric
            // 
            this.btnBackTolListOfAddedRubric.Location = new System.Drawing.Point(150, 3);
            this.btnBackTolListOfAddedRubric.Name = "btnBackTolListOfAddedRubric";
            this.btnBackTolListOfAddedRubric.Size = new System.Drawing.Size(75, 23);
            this.btnBackTolListOfAddedRubric.TabIndex = 41;
            this.btnBackTolListOfAddedRubric.Text = "<<BACK<<";
            this.btnBackTolListOfAddedRubric.UseVisualStyleBackColor = true;
            this.btnBackTolListOfAddedRubric.Click += new System.EventHandler(this.btnBackTolListOfAddedRubric_Click);
            // 
            // cmbboxListfAddedCLOIds
            // 
            this.cmbboxListfAddedCLOIds.FormattingEnabled = true;
            this.cmbboxListfAddedCLOIds.Location = new System.Drawing.Point(434, 68);
            this.cmbboxListfAddedCLOIds.Name = "cmbboxListfAddedCLOIds";
            this.cmbboxListfAddedCLOIds.Size = new System.Drawing.Size(121, 21);
            this.cmbboxListfAddedCLOIds.TabIndex = 43;
            // 
            // lblCLOIds
            // 
            this.lblCLOIds.AutoSize = true;
            this.lblCLOIds.Location = new System.Drawing.Point(294, 68);
            this.lblCLOIds.Name = "lblCLOIds";
            this.lblCLOIds.Size = new System.Drawing.Size(76, 13);
            this.lblCLOIds.TabIndex = 44;
            this.lblCLOIds.Text = "List of CLO Ids";
            // 
            // EditRubricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCLOIds);
            this.Controls.Add(this.cmbboxListfAddedCLOIds);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.btnBackTolListOfAddedRubric);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtRubricDetails);
            this.Controls.Add(this.lblRubricDetails);
            this.Name = "EditRubricForm";
            this.Text = "EditRubricForm";
            this.Load += new System.EventHandler(this.EditRubricForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtRubricDetails;
        private System.Windows.Forms.Label lblRubricDetails;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Button btnBackTolListOfAddedRubric;
        private System.Windows.Forms.ComboBox cmbboxListfAddedCLOIds;
        private System.Windows.Forms.Label lblCLOIds;
    }
}