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
            this.btnBackToListOfAddedAssesment = new System.Windows.Forms.Button();
            this.btnListOfAddedAssessmentComponents = new System.Windows.Forms.Button();
            this.btnbtnBackToMainPage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfAddedAssessmentsDataGridView
            // 
            this.ListOfAddedAssessmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedAssessmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnEdit});
            this.ListOfAddedAssessmentsDataGridView.Location = new System.Drawing.Point(106, 96);
            this.ListOfAddedAssessmentsDataGridView.Name = "ListOfAddedAssessmentsDataGridView";
            this.ListOfAddedAssessmentsDataGridView.Size = new System.Drawing.Size(616, 282);
            this.ListOfAddedAssessmentsDataGridView.TabIndex = 3;
            this.ListOfAddedAssessmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
            // 
            // btnBackToListOfAddedAssesment
            // 
            this.btnBackToListOfAddedAssesment.Location = new System.Drawing.Point(145, 1);
            this.btnBackToListOfAddedAssesment.Name = "btnBackToListOfAddedAssesment";
            this.btnBackToListOfAddedAssesment.Size = new System.Drawing.Size(75, 23);
            this.btnBackToListOfAddedAssesment.TabIndex = 2;
            this.btnBackToListOfAddedAssesment.Text = "<<BACK<<";
            this.btnBackToListOfAddedAssesment.UseVisualStyleBackColor = true;
            this.btnBackToListOfAddedAssesment.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnListOfAddedAssessmentComponents
            // 
            this.btnListOfAddedAssessmentComponents.Location = new System.Drawing.Point(582, 1);
            this.btnListOfAddedAssessmentComponents.Name = "btnListOfAddedAssessmentComponents";
            this.btnListOfAddedAssessmentComponents.Size = new System.Drawing.Size(216, 23);
            this.btnListOfAddedAssessmentComponents.TabIndex = 4;
            this.btnListOfAddedAssessmentComponents.Text = "List Of Added Assessment Components";
            this.btnListOfAddedAssessmentComponents.UseVisualStyleBackColor = true;
            this.btnListOfAddedAssessmentComponents.Click += new System.EventHandler(this.btnListOfAddedAssessmentComponents_Click);
            // 
            // btnbtnBackToMainPage
            // 
            this.btnbtnBackToMainPage.Location = new System.Drawing.Point(1, 1);
            this.btnbtnBackToMainPage.Name = "btnbtnBackToMainPage";
            this.btnbtnBackToMainPage.Size = new System.Drawing.Size(138, 23);
            this.btnbtnBackToMainPage.TabIndex = 5;
            this.btnbtnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnbtnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnbtnBackToMainPage.Click += new System.EventHandler(this.btnbtnBackToMainPage_Click);
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
            // ListOfAddedAssessmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbtnBackToMainPage);
            this.Controls.Add(this.btnListOfAddedAssessmentComponents);
            this.Controls.Add(this.ListOfAddedAssessmentsDataGridView);
            this.Controls.Add(this.btnBackToListOfAddedAssesment);
            this.Name = "ListOfAddedAssessmentsForm";
            this.Text = "ListOfAddedAssessmentsForm";
            this.Load += new System.EventHandler(this.ListOfAddedAssessmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfAddedAssessmentsDataGridView;
        private System.Windows.Forms.Button btnBackToListOfAddedAssesment;
        private System.Windows.Forms.Button btnListOfAddedAssessmentComponents;
        private System.Windows.Forms.Button btnbtnBackToMainPage;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
    }
}