namespace ProjectB
{
    partial class ListOfAddedCLOsForm
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
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.CLOsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddRubric = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBackToAddStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CLOsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(0, 0);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(145, 23);
            this.btnBackToMainPage.TabIndex = 0;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // CLOsDataGridView
            // 
            this.CLOsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLOsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnEdit,
            this.btnAddRubric});
            this.CLOsDataGridView.Location = new System.Drawing.Point(98, 87);
            this.CLOsDataGridView.Name = "CLOsDataGridView";
            this.CLOsDataGridView.Size = new System.Drawing.Size(616, 282);
            this.CLOsDataGridView.TabIndex = 2;
            this.CLOsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLOsDataGridView_CellContentClick);
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
            // btnAddRubric
            // 
            this.btnAddRubric.HeaderText = "AddRubric";
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.Text = "AddRubric";
            this.btnAddRubric.UseColumnTextForButtonValue = true;
            // 
            // btnBackToAddStudent
            // 
            this.btnBackToAddStudent.Location = new System.Drawing.Point(143, 0);
            this.btnBackToAddStudent.Name = "btnBackToAddStudent";
            this.btnBackToAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnBackToAddStudent.TabIndex = 3;
            this.btnBackToAddStudent.Text = "<<BACK<<";
            this.btnBackToAddStudent.UseVisualStyleBackColor = true;
            this.btnBackToAddStudent.Click += new System.EventHandler(this.btnBackToAddStudent_Click);
            // 
            // ListOfAddedCLOsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToAddStudent);
            this.Controls.Add(this.CLOsDataGridView);
            this.Controls.Add(this.btnBackToMainPage);
            this.Name = "ListOfAddedCLOsForm";
            this.Text = "ListOfAddedCLOs";
            this.Load += new System.EventHandler(this.ListOfAddedCLOs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLOsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.DataGridView CLOsDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnAddRubric;
        private System.Windows.Forms.Button btnBackToAddStudent;
    }
}