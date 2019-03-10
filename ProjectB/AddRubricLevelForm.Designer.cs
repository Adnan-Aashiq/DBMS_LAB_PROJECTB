namespace ProjectB
{
    partial class AddRubricLevelForm
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
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnRubricLevel = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtMeasurementLevel = new System.Windows.Forms.TextBox();
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(321, 92);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Details";
            // 
            // btnRubricLevel
            // 
            this.btnRubricLevel.Location = new System.Drawing.Point(456, 270);
            this.btnRubricLevel.Name = "btnRubricLevel";
            this.btnRubricLevel.Size = new System.Drawing.Size(134, 23);
            this.btnRubricLevel.TabIndex = 1;
            this.btnRubricLevel.Text = "Add Rubric Level";
            this.btnRubricLevel.UseVisualStyleBackColor = true;
            this.btnRubricLevel.Click += new System.EventHandler(this.btnRubricLevel_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(456, 85);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(100, 20);
            this.txtDetails.TabIndex = 2;
            // 
            // txtMeasurementLevel
            // 
            this.txtMeasurementLevel.Location = new System.Drawing.Point(456, 175);
            this.txtMeasurementLevel.Name = "txtMeasurementLevel";
            this.txtMeasurementLevel.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurementLevel.TabIndex = 3;
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(321, 178);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lblMeasurementLevel.TabIndex = 4;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<<BACK<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddRubricLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblMeasurementLevel);
            this.Controls.Add(this.txtMeasurementLevel);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnRubricLevel);
            this.Controls.Add(this.lblDetails);
            this.Name = "AddRubricLevelForm";
            this.Text = "AddRubricLevelForm";
            this.Load += new System.EventHandler(this.AddRubricLevelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnRubricLevel;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtMeasurementLevel;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.Button button2;
    }
}