namespace ProjectB
{
    partial class ListOfAddedAssessmentComponentForm
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
            this.ListOfAddedAssessmentComponentDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBackToStudentMenu = new System.Windows.Forms.Button();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentComponentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfAddedAssessmentComponentDataGridView
            // 
            this.ListOfAddedAssessmentComponentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedAssessmentComponentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnEdit});
            this.ListOfAddedAssessmentComponentDataGridView.Location = new System.Drawing.Point(92, 84);
            this.ListOfAddedAssessmentComponentDataGridView.Name = "ListOfAddedAssessmentComponentDataGridView";
            this.ListOfAddedAssessmentComponentDataGridView.Size = new System.Drawing.Size(616, 282);
            this.ListOfAddedAssessmentComponentDataGridView.TabIndex = 4;
            this.ListOfAddedAssessmentComponentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfAddedAssessmentComponentDataGridView_CellContentClick);
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
            // btnBackToStudentMenu
            // 
            this.btnBackToStudentMenu.Location = new System.Drawing.Point(159, 2);
            this.btnBackToStudentMenu.Name = "btnBackToStudentMenu";
            this.btnBackToStudentMenu.Size = new System.Drawing.Size(75, 23);
            this.btnBackToStudentMenu.TabIndex = 32;
            this.btnBackToStudentMenu.Text = "<<BACK<<";
            this.btnBackToStudentMenu.UseVisualStyleBackColor = true;
            this.btnBackToStudentMenu.Click += new System.EventHandler(this.btnBackToStudentMenu_Click);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(-1, 2);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(157, 23);
            this.btnBackToMainPage.TabIndex = 31;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // ListOfAddedAssessmentComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToStudentMenu);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.ListOfAddedAssessmentComponentDataGridView);
            this.Name = "ListOfAddedAssessmentComponentForm";
            this.Text = "ListOfAddedAssessmentComponentForm";
            this.Load += new System.EventHandler(this.ListOfAddedAssessmentComponentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentComponentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfAddedAssessmentComponentDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.Button btnBackToStudentMenu;
        private System.Windows.Forms.Button btnBackToMainPage;
    }
}