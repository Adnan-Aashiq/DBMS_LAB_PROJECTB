namespace ProjectB
{
    partial class AddNewCLOs
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
            this.lblCLOName = new System.Windows.Forms.Label();
            this.txtCLOName = new System.Windows.Forms.TextBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddCLOs = new System.Windows.Forms.Button();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCLOName
            // 
            this.lblCLOName.AutoSize = true;
            this.lblCLOName.Location = new System.Drawing.Point(288, 98);
            this.lblCLOName.Name = "lblCLOName";
            this.lblCLOName.Size = new System.Drawing.Size(59, 13);
            this.lblCLOName.TabIndex = 0;
            this.lblCLOName.Text = "CLO Name";
            // 
            // txtCLOName
            // 
            this.txtCLOName.Location = new System.Drawing.Point(398, 91);
            this.txtCLOName.Name = "txtCLOName";
            this.txtCLOName.Size = new System.Drawing.Size(100, 20);
            this.txtCLOName.TabIndex = 1;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(288, 151);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(70, 13);
            this.lblCreatedDate.TabIndex = 2;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Location = new System.Drawing.Point(389, 151);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreatedDate.TabIndex = 3;
            this.dtpCreatedDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAddCLOs
            // 
            this.btnAddCLOs.Location = new System.Drawing.Point(423, 226);
            this.btnAddCLOs.Name = "btnAddCLOs";
            this.btnAddCLOs.Size = new System.Drawing.Size(75, 23);
            this.btnAddCLOs.TabIndex = 4;
            this.btnAddCLOs.Text = "ADD";
            this.btnAddCLOs.UseVisualStyleBackColor = true;
            this.btnAddCLOs.Click += new System.EventHandler(this.btnAddCLOs_Click);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(0, 0);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMainPage.TabIndex = 5;
            this.btnBackToMainPage.Text = "<<BACK<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // AddNewCLOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.btnAddCLOs);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.txtCLOName);
            this.Controls.Add(this.lblCLOName);
            this.Name = "AddNewCLOs";
            this.Text = "AddNewCLOs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCLOName;
        private System.Windows.Forms.TextBox txtCLOName;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.Button btnAddCLOs;
        private System.Windows.Forms.Button btnBackToMainPage;
    }
}