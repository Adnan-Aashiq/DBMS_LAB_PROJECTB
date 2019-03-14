namespace ProjectB
{
    partial class LookupFilterForm
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
            this.LookupFilterdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LookupFilterdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LookupFilterdataGridView
            // 
            this.LookupFilterdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LookupFilterdataGridView.Location = new System.Drawing.Point(72, 61);
            this.LookupFilterdataGridView.Name = "LookupFilterdataGridView";
            this.LookupFilterdataGridView.Size = new System.Drawing.Size(679, 325);
            this.LookupFilterdataGridView.TabIndex = 0;
            // 
            // LookupFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LookupFilterdataGridView);
            this.Name = "LookupFilterForm";
            this.Text = "LookupFilterForm";
            ((System.ComponentModel.ISupportInitialize)(this.LookupFilterdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LookupFilterdataGridView;
    }
}