namespace ProjectB
{
    partial class ListOfAddedRubricForm
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
            this.ListOfAddedRubricdataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddRubricLevel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnRubricLevelMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedRubricdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfAddedRubricdataGridView
            // 
            this.ListOfAddedRubricdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedRubricdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnAddRubricLevel,
            this.btnDelete,
            this.btnEdit});
            this.ListOfAddedRubricdataGridView.Location = new System.Drawing.Point(109, 67);
            this.ListOfAddedRubricdataGridView.Name = "ListOfAddedRubricdataGridView";
            this.ListOfAddedRubricdataGridView.Size = new System.Drawing.Size(579, 287);
            this.ListOfAddedRubricdataGridView.TabIndex = 0;
            this.ListOfAddedRubricdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfAddedRubricdataGridView_CellContentClick);
            // 
            // btnAddRubricLevel
            // 
            this.btnAddRubricLevel.HeaderText = "AddRubricLevel";
            this.btnAddRubricLevel.Name = "btnAddRubricLevel";
            this.btnAddRubricLevel.Text = "AddRubricLevel";
            this.btnAddRubricLevel.UseColumnTextForButtonValue = true;
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
            this.btnBackToMainPage.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMainPage.TabIndex = 1;
            this.btnBackToMainPage.Text = "<<BACK<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnRubricLevelMenu
            // 
            this.btnRubricLevelMenu.Location = new System.Drawing.Point(691, 1);
            this.btnRubricLevelMenu.Name = "btnRubricLevelMenu";
            this.btnRubricLevelMenu.Size = new System.Drawing.Size(105, 23);
            this.btnRubricLevelMenu.TabIndex = 2;
            this.btnRubricLevelMenu.Text = "Rubric Level Menu";
            this.btnRubricLevelMenu.UseVisualStyleBackColor = true;
            this.btnRubricLevelMenu.Click += new System.EventHandler(this.btnRubricLevelMenu_Click);
            // 
            // ListOfAddedRubricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRubricLevelMenu);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.ListOfAddedRubricdataGridView);
            this.Name = "ListOfAddedRubricForm";
            this.Text = "ListOfAddedRubricForm";
            this.Load += new System.EventHandler(this.ListOfAddedRubricForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedRubricdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfAddedRubricdataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnAddRubricLevel;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Button btnRubricLevelMenu;
    }
}