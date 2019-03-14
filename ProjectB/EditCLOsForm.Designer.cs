namespace ProjectB
{
    partial class EditCLOsForm
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
            this.btnUpdateCLOs = new System.Windows.Forms.Button();
            this.dtpUpdatedDate = new System.Windows.Forms.DateTimePicker();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.txtCLOName = new System.Windows.Forms.TextBox();
            this.lblCLOName = new System.Windows.Forms.Label();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnBackTolListOfAddedClos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateCLOs
            // 
            this.btnUpdateCLOs.Location = new System.Drawing.Point(422, 227);
            this.btnUpdateCLOs.Name = "btnUpdateCLOs";
            this.btnUpdateCLOs.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCLOs.TabIndex = 10;
            this.btnUpdateCLOs.Text = "UPDATE";
            this.btnUpdateCLOs.UseVisualStyleBackColor = true;
            this.btnUpdateCLOs.Click += new System.EventHandler(this.btnUpdateCLOs_Click);
            // 
            // dtpUpdatedDate
            // 
            this.dtpUpdatedDate.Location = new System.Drawing.Point(388, 152);
            this.dtpUpdatedDate.Name = "dtpUpdatedDate";
            this.dtpUpdatedDate.Size = new System.Drawing.Size(200, 20);
            this.dtpUpdatedDate.TabIndex = 9;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(287, 152);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(74, 13);
            this.lblCreatedDate.TabIndex = 8;
            this.lblCreatedDate.Text = "Updated Date";
            // 
            // txtCLOName
            // 
            this.txtCLOName.Location = new System.Drawing.Point(397, 92);
            this.txtCLOName.Name = "txtCLOName";
            this.txtCLOName.Size = new System.Drawing.Size(100, 20);
            this.txtCLOName.TabIndex = 7;
            // 
            // lblCLOName
            // 
            this.lblCLOName.AutoSize = true;
            this.lblCLOName.Location = new System.Drawing.Point(287, 99);
            this.lblCLOName.Name = "lblCLOName";
            this.lblCLOName.Size = new System.Drawing.Size(59, 13);
            this.lblCLOName.TabIndex = 6;
            this.lblCLOName.Text = "CLO Name";
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(3, 1);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(148, 23);
            this.btnBackToMainPage.TabIndex = 22;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnBackTolListOfAddedClos
            // 
            this.btnBackTolListOfAddedClos.Location = new System.Drawing.Point(151, 1);
            this.btnBackTolListOfAddedClos.Name = "btnBackTolListOfAddedClos";
            this.btnBackTolListOfAddedClos.Size = new System.Drawing.Size(75, 23);
            this.btnBackTolListOfAddedClos.TabIndex = 21;
            this.btnBackTolListOfAddedClos.Text = "<<BACK<<";
            this.btnBackTolListOfAddedClos.UseVisualStyleBackColor = true;
            this.btnBackTolListOfAddedClos.Click += new System.EventHandler(this.btnBackTolListOfAddedClos_Click);
            // 
            // EditCLOsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.btnBackTolListOfAddedClos);
            this.Controls.Add(this.btnUpdateCLOs);
            this.Controls.Add(this.dtpUpdatedDate);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.txtCLOName);
            this.Controls.Add(this.lblCLOName);
            this.Name = "EditCLOsForm";
            this.Text = "CLOsEditInfo";
            this.Load += new System.EventHandler(this.CLOsEditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateCLOs;
        private System.Windows.Forms.DateTimePicker dtpUpdatedDate;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.TextBox txtCLOName;
        private System.Windows.Forms.Label lblCLOName;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Button btnBackTolListOfAddedClos;
    }
}