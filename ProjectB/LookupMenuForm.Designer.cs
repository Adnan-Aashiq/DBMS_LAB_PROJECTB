namespace ProjectB
{
    partial class LookupMenuForm
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
            this.lblSelectName = new System.Windows.Forms.Label();
            this.cmbboxCategory = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.cmbboxSelectName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(291, 173);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(68, 13);
            this.lblSelectName.TabIndex = 0;
            this.lblSelectName.Text = "Select Name";
            // 
            // cmbboxCategory
            // 
            this.cmbboxCategory.FormattingEnabled = true;
            this.cmbboxCategory.Items.AddRange(new object[] {
            "ATTENDANCE_STATUS",
            "STUDENT_STATUS"});
            this.cmbboxCategory.Location = new System.Drawing.Point(414, 115);
            this.cmbboxCategory.Name = "cmbboxCategory";
            this.cmbboxCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbboxCategory.TabIndex = 1;
            this.cmbboxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbboxCategory_SelectedIndexChanged);
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Location = new System.Drawing.Point(280, 123);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(82, 13);
            this.lblSelectCategory.TabIndex = 3;
            this.lblSelectCategory.Text = "Select Category";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(2, 3);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMain.TabIndex = 12;
            this.btnBackToMain.Text = "<<BACK<<";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(414, 236);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(107, 23);
            this.btnADD.TabIndex = 14;
            this.btnADD.Text = "FILTER RESULT";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // cmbboxSelectName
            // 
            this.cmbboxSelectName.FormattingEnabled = true;
            this.cmbboxSelectName.Items.AddRange(new object[] {
            "ATTENDANCE_STATUS",
            "STUDENT_STATUS"});
            this.cmbboxSelectName.Location = new System.Drawing.Point(414, 173);
            this.cmbboxSelectName.Name = "cmbboxSelectName";
            this.cmbboxSelectName.Size = new System.Drawing.Size(121, 21);
            this.cmbboxSelectName.TabIndex = 15;
            // 
            // LookupMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbboxSelectName);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblSelectCategory);
            this.Controls.Add(this.cmbboxCategory);
            this.Controls.Add(this.lblSelectName);
            this.Name = "LookupMenuForm";
            this.Text = "AddLookupForm";
            this.Load += new System.EventHandler(this.LookupMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.ComboBox cmbboxCategory;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.ComboBox cmbboxSelectName;
    }
}