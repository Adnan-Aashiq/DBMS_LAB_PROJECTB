namespace ProjectB
{
    partial class ListOfAddedRubricLevelForm
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
            this.ListOfAddedRubricLeveldataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedRubricLeveldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfAddedRubricLeveldataGridView
            // 
            this.ListOfAddedRubricLeveldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedRubricLeveldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnEdit});
            this.ListOfAddedRubricLeveldataGridView.Location = new System.Drawing.Point(111, 82);
            this.ListOfAddedRubricLeveldataGridView.Name = "ListOfAddedRubricLeveldataGridView";
            this.ListOfAddedRubricLeveldataGridView.Size = new System.Drawing.Size(579, 287);
            this.ListOfAddedRubricLeveldataGridView.TabIndex = 1;
            this.ListOfAddedRubricLeveldataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfAddedRubricLeveldataGridView_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(0, 0);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(117, 23);
            this.btnBackToMainPage.TabIndex = 2;
            this.btnBackToMainPage.Text = "Back To Main Page";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "<<BACK<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListOfAddedRubricLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.ListOfAddedRubricLeveldataGridView);
            this.Name = "ListOfAddedRubricLevelForm";
            this.Text = "ListOfAddedRubricLevelForm";
            this.Load += new System.EventHandler(this.ListOfAddedRubricLevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedRubricLeveldataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfAddedRubricLeveldataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Button button2;
    }
}