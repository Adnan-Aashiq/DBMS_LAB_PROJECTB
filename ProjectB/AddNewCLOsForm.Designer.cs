namespace ProjectB
{
    partial class AddNewCLOsForm
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
            this.lblCLOName = new System.Windows.Forms.Label();
            this.txtCLOName = new System.Windows.Forms.TextBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddCLOs = new System.Windows.Forms.Button();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnAddedCLOs = new System.Windows.Forms.Button();
            this.btnAddNewCLO = new System.Windows.Forms.Button();
            this.CLOsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddRubric = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CLOsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCLOName
            // 
            this.lblCLOName.AutoSize = true;
            this.lblCLOName.Location = new System.Drawing.Point(270, 126);
            this.lblCLOName.Name = "lblCLOName";
            this.lblCLOName.Size = new System.Drawing.Size(59, 13);
            this.lblCLOName.TabIndex = 0;
            this.lblCLOName.Text = "CLO Name";
            // 
            // txtCLOName
            // 
            this.txtCLOName.Location = new System.Drawing.Point(380, 119);
            this.txtCLOName.Name = "txtCLOName";
            this.txtCLOName.Size = new System.Drawing.Size(100, 20);
            this.txtCLOName.TabIndex = 1;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(270, 179);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(70, 13);
            this.lblCreatedDate.TabIndex = 2;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Location = new System.Drawing.Point(371, 179);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreatedDate.TabIndex = 3;
            this.dtpCreatedDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAddCLOs
            // 
            this.btnAddCLOs.Location = new System.Drawing.Point(405, 254);
            this.btnAddCLOs.Name = "btnAddCLOs";
            this.btnAddCLOs.Size = new System.Drawing.Size(75, 23);
            this.btnAddCLOs.TabIndex = 4;
            this.btnAddCLOs.Text = "ADD";
            this.btnAddCLOs.UseVisualStyleBackColor = true;
            this.btnAddCLOs.Click += new System.EventHandler(this.btnAddCLOs_Click);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Location = new System.Drawing.Point(0, 0);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMainPage.TabIndex = 5;
            this.btnBackToMainPage.Text = "<<BACK<<";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnAddedCLOs
            // 
            this.btnAddedCLOs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddedCLOs.Location = new System.Drawing.Point(430, 0);
            this.btnAddedCLOs.Name = "btnAddedCLOs";
            this.btnAddedCLOs.Size = new System.Drawing.Size(141, 23);
            this.btnAddedCLOs.TabIndex = 6;
            this.btnAddedCLOs.Text = "List Of Added CLOs";
            this.btnAddedCLOs.UseVisualStyleBackColor = false;
            this.btnAddedCLOs.Click += new System.EventHandler(this.btnAddedCLOs_Click);
            // 
            // btnAddNewCLO
            // 
            this.btnAddNewCLO.Location = new System.Drawing.Point(329, 0);
            this.btnAddNewCLO.Name = "btnAddNewCLO";
            this.btnAddNewCLO.Size = new System.Drawing.Size(95, 23);
            this.btnAddNewCLO.TabIndex = 7;
            this.btnAddNewCLO.Text = "Add New CLO";
            this.btnAddNewCLO.UseVisualStyleBackColor = true;
            this.btnAddNewCLO.Click += new System.EventHandler(this.button1_Click);
            // 
            // CLOsDataGridView
            // 
            this.CLOsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLOsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnEdit,
            this.btnAddRubric});
            this.CLOsDataGridView.Location = new System.Drawing.Point(139, 93);
            this.CLOsDataGridView.Name = "CLOsDataGridView";
            this.CLOsDataGridView.Size = new System.Drawing.Size(616, 282);
            this.CLOsDataGridView.TabIndex = 8;
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
            // AddNewCLOsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CLOsDataGridView);
            this.Controls.Add(this.btnAddNewCLO);
            this.Controls.Add(this.btnAddedCLOs);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.btnAddCLOs);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.txtCLOName);
            this.Controls.Add(this.lblCLOName);
            this.Name = "AddNewCLOsForm";
            this.Text = "AddNewCLOs";
            this.Load += new System.EventHandler(this.AddNewCLOsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLOsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCLOName;
        private System.Windows.Forms.TextBox txtCLOName;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.Button btnAddCLOs;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Button btnAddedCLOs;
        private System.Windows.Forms.Button btnAddNewCLO;
        private System.Windows.Forms.DataGridView CLOsDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnAddRubric;
    }
}