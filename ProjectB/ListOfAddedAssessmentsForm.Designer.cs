namespace ProjectB
{
    partial class ListOfAddedAssessmentsForm
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
            this.ListOfAddedAssessmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddAssessmentComponent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfAddedAssessmentsDataGridView
            // 
            this.ListOfAddedAssessmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedAssessmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnAddAssessmentComponent,
            this.btnEdit});
            this.ListOfAddedAssessmentsDataGridView.Location = new System.Drawing.Point(93, 32);
            this.ListOfAddedAssessmentsDataGridView.Name = "ListOfAddedAssessmentsDataGridView";
            this.ListOfAddedAssessmentsDataGridView.Size = new System.Drawing.Size(616, 282);
            this.ListOfAddedAssessmentsDataGridView.TabIndex = 3;
            this.ListOfAddedAssessmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(3, 0);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMainPage.TabIndex = 2;
            this.btnBackToMainPage.Text = "<<BACK<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddAssessmentComponent
            // 
            this.btnAddAssessmentComponent.HeaderText = "AddAssessmentComponent";
            this.btnAddAssessmentComponent.Name = "btnAddAssessmentComponent";
            this.btnAddAssessmentComponent.Text = "AddAssessmentComponent";
            this.btnAddAssessmentComponent.UseColumnTextForButtonValue = true;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // ListOfAddedAssessmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListOfAddedAssessmentsDataGridView);
            this.Controls.Add(this.btnBackToMainPage);
            this.Name = "ListOfAddedAssessmentsForm";
            this.Text = "ListOfAddedAssessmentsForm";
            this.Load += new System.EventHandler(this.ListOfAddedAssessmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfAddedAssessmentsDataGridView;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnAddAssessmentComponent;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
    }
}