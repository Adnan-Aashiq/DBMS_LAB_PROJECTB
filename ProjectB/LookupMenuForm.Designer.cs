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
            this.lblName = new System.Windows.Forms.Label();
            this.cmbboxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(291, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
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
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(280, 123);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
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
            this.btnADD.Location = new System.Drawing.Point(428, 236);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(107, 23);
            this.btnADD.TabIndex = 14;
            this.btnADD.Text = "FILTER RESULT";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ATTENDANCE_STATUS",
            "STUDENT_STATUS"});
            this.comboBox1.Location = new System.Drawing.Point(414, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // AddLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbboxCategory);
            this.Controls.Add(this.lblName);
            this.Name = "AddLookupForm";
            this.Text = "AddLookupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbboxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}