namespace ProjectB
{
    partial class AddRubricForm
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
            this.lblRubricDetails = new System.Windows.Forms.Label();
            this.txtRubricDetails = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(2, 0);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMainPage.TabIndex = 29;
            this.btnBackToMainPage.Text = "<<BACK<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // lblRubricDetails
            // 
            this.lblRubricDetails.AutoSize = true;
            this.lblRubricDetails.Location = new System.Drawing.Point(294, 130);
            this.lblRubricDetails.Name = "lblRubricDetails";
            this.lblRubricDetails.Size = new System.Drawing.Size(73, 13);
            this.lblRubricDetails.TabIndex = 32;
            this.lblRubricDetails.Text = "Rubric Details";
            // 
            // txtRubricDetails
            // 
            this.txtRubricDetails.Location = new System.Drawing.Point(455, 127);
            this.txtRubricDetails.Name = "txtRubricDetails";
            this.txtRubricDetails.Size = new System.Drawing.Size(100, 20);
            this.txtRubricDetails.TabIndex = 34;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(466, 203);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 24);
            this.btnADD.TabIndex = 35;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // AddRubricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtRubricDetails);
            this.Controls.Add(this.lblRubricDetails);
            this.Controls.Add(this.btnBackToMainPage);
            this.Name = "AddRubricForm";
            this.Text = "AddRubricForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Label lblRubricDetails;
        private System.Windows.Forms.TextBox txtRubricDetails;
        private System.Windows.Forms.Button btnADD;
    }
}