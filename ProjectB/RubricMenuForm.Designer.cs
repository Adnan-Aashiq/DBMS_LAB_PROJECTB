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
            this.ListOfAddedRubricDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnAddRubric = new MetroFramework.Controls.MetroButton();
            this.btnListOfAddedRubrics = new MetroFramework.Controls.MetroButton();
            this.btnAddRubricLevel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnListOfAddedRubricLevels = new MetroFramework.Controls.MetroButton();
            this.combboxCLODetails = new System.Windows.Forms.ComboBox();
            this.lblCLONames = new System.Windows.Forms.Label();
            this.btnADDR = new System.Windows.Forms.Button();
            this.txtRubricDetails = new System.Windows.Forms.TextBox();
            this.lblRubricDetails = new System.Windows.Forms.Label();
            this.combboxRubricLevelDetails = new MetroFramework.Controls.MetroComboBox();
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.txtMeasurementLevel = new System.Windows.Forms.TextBox();
            this.btnADDRL = new System.Windows.Forms.Button();
            this.lblDtailsRL = new System.Windows.Forms.Label();
            this.combboxListOfRubricDetails = new MetroFramework.Controls.MetroComboBox();
            this.lblListOfRubricDetails = new System.Windows.Forms.Label();
            this.ListOfAddedRubricLeveldataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteRL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditRL = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedRubricDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedRubricLeveldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfAddedRubricDataGridView
            // 
            this.ListOfAddedRubricDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedRubricDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnEdit});
            this.ListOfAddedRubricDataGridView.Location = new System.Drawing.Point(106, 29);
            this.ListOfAddedRubricDataGridView.Name = "ListOfAddedRubricDataGridView";
            this.ListOfAddedRubricDataGridView.Size = new System.Drawing.Size(579, 287);
            this.ListOfAddedRubricDataGridView.TabIndex = 0;
            this.ListOfAddedRubricDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfAddedRubricdataGridView_CellContentClick);
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
            // btnAddRubric
            // 
            this.btnAddRubric.Location = new System.Drawing.Point(120, 0);
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.Size = new System.Drawing.Size(122, 23);
            this.btnAddRubric.TabIndex = 3;
            this.btnAddRubric.Text = "Add Rubric";
            this.btnAddRubric.UseSelectable = true;
            this.btnAddRubric.Click += new System.EventHandler(this.btnAddRubric_Click);
            // 
            // btnListOfAddedRubrics
            // 
            this.btnListOfAddedRubrics.Location = new System.Drawing.Point(248, 0);
            this.btnListOfAddedRubrics.Name = "btnListOfAddedRubrics";
            this.btnListOfAddedRubrics.Size = new System.Drawing.Size(122, 23);
            this.btnListOfAddedRubrics.TabIndex = 4;
            this.btnListOfAddedRubrics.Text = "List Of Added Rubrics";
            this.btnListOfAddedRubrics.UseSelectable = true;
            this.btnListOfAddedRubrics.Click += new System.EventHandler(this.btnListOfAddedRubrics_Click);
            // 
            // btnAddRubricLevel
            // 
            this.btnAddRubricLevel.Location = new System.Drawing.Point(377, 0);
            this.btnAddRubricLevel.Name = "btnAddRubricLevel";
            this.btnAddRubricLevel.Size = new System.Drawing.Size(122, 23);
            this.btnAddRubricLevel.TabIndex = 5;
            this.btnAddRubricLevel.Text = "Add Rubric Level";
            this.btnAddRubricLevel.UseSelectable = true;
            this.btnAddRubricLevel.Click += new System.EventHandler(this.btnAddRubricLevel_Click);
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
            // btnListOfAddedRubricLevels
            // 
            this.btnListOfAddedRubricLevels.Location = new System.Drawing.Point(505, 0);
            this.btnListOfAddedRubricLevels.Name = "btnListOfAddedRubricLevels";
            this.btnListOfAddedRubricLevels.Size = new System.Drawing.Size(164, 23);
            this.btnListOfAddedRubricLevels.TabIndex = 6;
            this.btnListOfAddedRubricLevels.Text = "List Of Added Rubric Levels";
            this.btnListOfAddedRubricLevels.UseSelectable = true;
            this.btnListOfAddedRubricLevels.Click += new System.EventHandler(this.btnListOfAddedRubricLevels_Click);
            // 
            // combboxCLODetails
            // 
            this.combboxCLODetails.FormattingEnabled = true;
            this.combboxCLODetails.Location = new System.Drawing.Point(252, 108);
            this.combboxCLODetails.Name = "combboxCLODetails";
            this.combboxCLODetails.Size = new System.Drawing.Size(121, 21);
            this.combboxCLODetails.TabIndex = 43;
            // 
            // lblCLONames
            // 
            this.lblCLONames.AutoSize = true;
            this.lblCLONames.Location = new System.Drawing.Point(133, 116);
            this.lblCLONames.Name = "lblCLONames";
            this.lblCLONames.Size = new System.Drawing.Size(64, 13);
            this.lblCLONames.TabIndex = 42;
            this.lblCLONames.Text = "CLO Names";
            // 
            // btnADDR
            // 
            this.btnADDR.Location = new System.Drawing.Point(284, 244);
            this.btnADDR.Name = "btnADDR";
            this.btnADDR.Size = new System.Drawing.Size(75, 24);
            this.btnADDR.TabIndex = 41;
            this.btnADDR.Text = "ADD Rubric";
            this.btnADDR.UseVisualStyleBackColor = true;
            this.btnADDR.Click += new System.EventHandler(this.btnADDR_Click);
            // 
            // txtRubricDetails
            // 
            this.txtRubricDetails.Location = new System.Drawing.Point(273, 168);
            this.txtRubricDetails.Multiline = true;
            this.txtRubricDetails.Name = "txtRubricDetails";
            this.txtRubricDetails.Size = new System.Drawing.Size(100, 51);
            this.txtRubricDetails.TabIndex = 40;
            // 
            // lblRubricDetails
            // 
            this.lblRubricDetails.AutoSize = true;
            this.lblRubricDetails.Location = new System.Drawing.Point(133, 171);
            this.lblRubricDetails.Name = "lblRubricDetails";
            this.lblRubricDetails.Size = new System.Drawing.Size(73, 13);
            this.lblRubricDetails.TabIndex = 39;
            this.lblRubricDetails.Text = "Rubric Details";
            // 
            // combboxRubricLevelDetails
            // 
            this.combboxRubricLevelDetails.FormattingEnabled = true;
            this.combboxRubricLevelDetails.ItemHeight = 23;
            this.combboxRubricLevelDetails.Items.AddRange(new object[] {
            "Bad",
            "Satisfactory",
            "Good",
            "Excellent"});
            this.combboxRubricLevelDetails.Location = new System.Drawing.Point(532, 144);
            this.combboxRubricLevelDetails.Name = "combboxRubricLevelDetails";
            this.combboxRubricLevelDetails.Size = new System.Drawing.Size(121, 29);
            this.combboxRubricLevelDetails.TabIndex = 48;
            this.combboxRubricLevelDetails.UseSelectable = true;
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(384, 199);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lblMeasurementLevel.TabIndex = 47;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // txtMeasurementLevel
            // 
            this.txtMeasurementLevel.Location = new System.Drawing.Point(553, 196);
            this.txtMeasurementLevel.Name = "txtMeasurementLevel";
            this.txtMeasurementLevel.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurementLevel.TabIndex = 46;
            // 
            // btnADDRL
            // 
            this.btnADDRL.Location = new System.Drawing.Point(519, 245);
            this.btnADDRL.Name = "btnADDRL";
            this.btnADDRL.Size = new System.Drawing.Size(134, 23);
            this.btnADDRL.TabIndex = 45;
            this.btnADDRL.Text = "Add Rubric Level";
            this.btnADDRL.UseVisualStyleBackColor = true;
            this.btnADDRL.Click += new System.EventHandler(this.btnADDRL_Click);
            // 
            // lblDtailsRL
            // 
            this.lblDtailsRL.AutoSize = true;
            this.lblDtailsRL.Location = new System.Drawing.Point(394, 144);
            this.lblDtailsRL.Name = "lblDtailsRL";
            this.lblDtailsRL.Size = new System.Drawing.Size(39, 13);
            this.lblDtailsRL.TabIndex = 44;
            this.lblDtailsRL.Text = "Details";
            // 
            // combboxListOfRubricDetails
            // 
            this.combboxListOfRubricDetails.FormattingEnabled = true;
            this.combboxListOfRubricDetails.ItemHeight = 23;
            this.combboxListOfRubricDetails.Items.AddRange(new object[] {
            "Bad",
            "Satisfactory",
            "Good",
            "Excellent"});
            this.combboxListOfRubricDetails.Location = new System.Drawing.Point(532, 86);
            this.combboxListOfRubricDetails.Name = "combboxListOfRubricDetails";
            this.combboxListOfRubricDetails.Size = new System.Drawing.Size(121, 29);
            this.combboxListOfRubricDetails.TabIndex = 50;
            this.combboxListOfRubricDetails.UseSelectable = true;
            // 
            // lblListOfRubricDetails
            // 
            this.lblListOfRubricDetails.AutoSize = true;
            this.lblListOfRubricDetails.Location = new System.Drawing.Point(394, 89);
            this.lblListOfRubricDetails.Name = "lblListOfRubricDetails";
            this.lblListOfRubricDetails.Size = new System.Drawing.Size(106, 13);
            this.lblListOfRubricDetails.TabIndex = 49;
            this.lblListOfRubricDetails.Text = "List Of Rubric Details";
            // 
            // ListOfAddedRubricLeveldataGridView
            // 
            this.ListOfAddedRubricLeveldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedRubricLeveldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDeleteRL,
            this.btnEditRL});
            this.ListOfAddedRubricLeveldataGridView.Location = new System.Drawing.Point(106, 220);
            this.ListOfAddedRubricLeveldataGridView.Name = "ListOfAddedRubricLeveldataGridView";
            this.ListOfAddedRubricLeveldataGridView.Size = new System.Drawing.Size(579, 287);
            this.ListOfAddedRubricLeveldataGridView.TabIndex = 51;
            this.ListOfAddedRubricLeveldataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfAddedRubricLeveldataGridView_CellContentClick);
            // 
            // btnDeleteRL
            // 
            this.btnDeleteRL.HeaderText = "Delete";
            this.btnDeleteRL.Name = "btnDeleteRL";
            this.btnDeleteRL.Text = "Delete";
            this.btnDeleteRL.UseColumnTextForButtonValue = true;
            // 
            // btnEditRL
            // 
            this.btnEditRL.HeaderText = "Edit";
            this.btnEditRL.Name = "btnEditRL";
            this.btnEditRL.Text = "Edit";
            this.btnEditRL.UseColumnTextForButtonValue = true;
            // 
            // ListOfAddedRubricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.ListOfAddedRubricLeveldataGridView);
            this.Controls.Add(this.combboxListOfRubricDetails);
            this.Controls.Add(this.lblListOfRubricDetails);
            this.Controls.Add(this.combboxRubricLevelDetails);
            this.Controls.Add(this.lblMeasurementLevel);
            this.Controls.Add(this.txtMeasurementLevel);
            this.Controls.Add(this.btnADDRL);
            this.Controls.Add(this.lblDtailsRL);
            this.Controls.Add(this.combboxCLODetails);
            this.Controls.Add(this.lblCLONames);
            this.Controls.Add(this.btnADDR);
            this.Controls.Add(this.txtRubricDetails);
            this.Controls.Add(this.lblRubricDetails);
            this.Controls.Add(this.btnListOfAddedRubricLevels);
            this.Controls.Add(this.btnAddRubricLevel);
            this.Controls.Add(this.btnListOfAddedRubrics);
            this.Controls.Add(this.btnAddRubric);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.ListOfAddedRubricDataGridView);
            this.Name = "ListOfAddedRubricForm";
            this.Text = "ListOfAddedRubricForm";
            this.Load += new System.EventHandler(this.ListOfAddedRubricForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedRubricDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedRubricLeveldataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfAddedRubricDataGridView;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private MetroFramework.Controls.MetroButton btnAddRubric;
        private MetroFramework.Controls.MetroButton btnListOfAddedRubrics;
        private MetroFramework.Controls.MetroButton btnAddRubricLevel;
        private MetroFramework.Controls.MetroButton btnListOfAddedRubricLevels;
        private System.Windows.Forms.ComboBox combboxCLODetails;
        private System.Windows.Forms.Label lblCLONames;
        private System.Windows.Forms.Button btnADDR;
        private System.Windows.Forms.TextBox txtRubricDetails;
        private System.Windows.Forms.Label lblRubricDetails;
        private MetroFramework.Controls.MetroComboBox combboxRubricLevelDetails;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.TextBox txtMeasurementLevel;
        private System.Windows.Forms.Button btnADDRL;
        private System.Windows.Forms.Label lblDtailsRL;
        private MetroFramework.Controls.MetroComboBox combboxListOfRubricDetails;
        private System.Windows.Forms.Label lblListOfRubricDetails;
        private System.Windows.Forms.DataGridView ListOfAddedRubricLeveldataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeleteRL;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditRL;
    }
}