namespace ProjectB
{
    partial class ListOfAddedStudentsForm
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
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBackToAddStudent = new System.Windows.Forms.Button();
            this.btnInActive = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(0, 0);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(144, 23);
            this.btnBackToMainPage.TabIndex = 0;
            this.btnBackToMainPage.Text = "<<Back To Main Page<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnInActive,
            this.btnEdit});
            this.StudentDataGridView.Location = new System.Drawing.Point(91, 87);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.Size = new System.Drawing.Size(616, 282);
            this.StudentDataGridView.TabIndex = 1;
            this.StudentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
            // 
            // btnBackToAddStudent
            // 
            this.btnBackToAddStudent.Location = new System.Drawing.Point(144, 0);
            this.btnBackToAddStudent.Name = "btnBackToAddStudent";
            this.btnBackToAddStudent.Size = new System.Drawing.Size(124, 23);
            this.btnBackToAddStudent.TabIndex = 2;
            this.btnBackToAddStudent.Text = "<<BACK<<";
            this.btnBackToAddStudent.UseVisualStyleBackColor = true;
            this.btnBackToAddStudent.Click += new System.EventHandler(this.btnBackToAddStudent_Click);
            // 
            // btnInActive
            // 
            this.btnInActive.HeaderText = "InActive";
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Text = "InActive";
            this.btnInActive.UseColumnTextForButtonValue = true;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // ListOfAddedStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToAddStudent);
            this.Controls.Add(this.StudentDataGridView);
            this.Controls.Add(this.btnBackToMainPage);
            this.Name = "ListOfAddedStudentsForm";
            this.Text = "RegisteredStudents";
            this.Load += new System.EventHandler(this.RegisteredStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Button btnBackToAddStudent;
        private System.Windows.Forms.DataGridViewButtonColumn btnInActive;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
    }
}