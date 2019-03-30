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
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.combboxCLODetails = new System.Windows.Forms.ComboBox();
            this.lblCLONames = new System.Windows.Forms.Label();
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
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(2, 2);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(75, 23);
            this.btnCLOSE.TabIndex = 41;
            this.btnCLOSE.Text = "<<CLOSE<<";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnBackTolListOfAddedRubric_Click);
            // 
            // combboxCLODetails
            // 
            this.combboxCLODetails.FormattingEnabled = true;
            this.combboxCLODetails.Location = new System.Drawing.Point(434, 52);
            this.combboxCLODetails.Name = "combboxCLODetails";
            this.combboxCLODetails.Size = new System.Drawing.Size(121, 21);
            this.combboxCLODetails.TabIndex = 45;
            // 
            // lblCLONames
            // 
            this.lblCLONames.AutoSize = true;
            this.lblCLONames.Location = new System.Drawing.Point(294, 60);
            this.lblCLONames.Name = "lblCLONames";
            this.lblCLONames.Size = new System.Drawing.Size(64, 13);
            this.lblCLONames.TabIndex = 44;
            this.lblCLONames.Text = "CLO Names";
            // 
            // EditRubricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combboxCLODetails);
            this.Controls.Add(this.lblCLONames);
            this.Controls.Add(this.btnCLOSE);
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
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.ComboBox combboxCLODetails;
        private System.Windows.Forms.Label lblCLONames;
    }
}