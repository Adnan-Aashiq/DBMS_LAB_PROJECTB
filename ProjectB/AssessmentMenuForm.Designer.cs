namespace ProjectB
{
    partial class AssessmentMenuForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblTotalWeightage = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.txtTotalWeightage = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnListOfAddedAssessment = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnAddAssessmentComponent = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.cmboboxRubricDetails = new System.Windows.Forms.ComboBox();
            this.lblRubricDetails = new System.Windows.Forms.Label();
            this.dtpDateCreatedAC = new System.Windows.Forms.DateTimePicker();
            this.txtTotalMarksAC = new System.Windows.Forms.TextBox();
            this.lblDateCreatedAC = new System.Windows.Forms.Label();
            this.lblTotalMarksAC = new System.Windows.Forms.Label();
            this.btnADDComponent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddAssessment = new MetroFramework.Controls.MetroButton();
            this.lblAssessments = new MetroFramework.Drawing.Html.HtmlLabel();
            this.combboxListOfAssessment = new MetroFramework.Controls.MetroComboBox();
            this.ListOfAddedAssessmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ListOfAddedAssessmentComponentDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteAC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditAC = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentComponentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(207, 75);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Location = new System.Drawing.Point(166, 135);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(200, 20);
            this.dtpDateCreated.TabIndex = 2;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(15, 142);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(67, 13);
            this.lblDateCreated.TabIndex = 3;
            this.lblDateCreated.Text = "DateCreated";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(15, 195);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(60, 13);
            this.lblTotalMarks.TabIndex = 4;
            this.lblTotalMarks.Text = "TotalMarks";
            // 
            // lblTotalWeightage
            // 
            this.lblTotalWeightage.AutoSize = true;
            this.lblTotalWeightage.Location = new System.Drawing.Point(15, 251);
            this.lblTotalWeightage.Name = "lblTotalWeightage";
            this.lblTotalWeightage.Size = new System.Drawing.Size(83, 13);
            this.lblTotalWeightage.TabIndex = 5;
            this.lblTotalWeightage.Text = "TotalWeightage";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(207, 195);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMarks.TabIndex = 6;
            // 
            // txtTotalWeightage
            // 
            this.txtTotalWeightage.Location = new System.Drawing.Point(207, 244);
            this.txtTotalWeightage.Name = "txtTotalWeightage";
            this.txtTotalWeightage.Size = new System.Drawing.Size(100, 20);
            this.txtTotalWeightage.TabIndex = 7;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(212, 327);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(95, 23);
            this.btnADD.TabIndex = 8;
            this.btnADD.Text = "ADDAssessment";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADDAssessment_Click);
            // 
            // btnListOfAddedAssessment
            // 
            this.btnListOfAddedAssessment.Location = new System.Drawing.Point(284, 1);
            this.btnListOfAddedAssessment.Name = "btnListOfAddedAssessment";
            this.btnListOfAddedAssessment.Size = new System.Drawing.Size(141, 23);
            this.btnListOfAddedAssessment.TabIndex = 10;
            this.btnListOfAddedAssessment.Text = "List Of Added Assessment";
            this.btnListOfAddedAssessment.UseVisualStyleBackColor = true;
            this.btnListOfAddedAssessment.Click += new System.EventHandler(this.btnListOfAddedAssessment_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(0, 1);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(134, 23);
            this.btnBACK.TabIndex = 11;
            this.btnBACK.Text = "<<BACK<<";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnAddAssessmentComponent
            // 
            this.btnAddAssessmentComponent.Location = new System.Drawing.Point(426, 1);
            this.btnAddAssessmentComponent.Name = "btnAddAssessmentComponent";
            this.btnAddAssessmentComponent.Size = new System.Drawing.Size(158, 23);
            this.btnAddAssessmentComponent.TabIndex = 12;
            this.btnAddAssessmentComponent.Text = "Add Assessment Component";
            this.btnAddAssessmentComponent.UseSelectable = true;
            this.btnAddAssessmentComponent.Click += new System.EventHandler(this.btnAddAssessmentComponent_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(586, 1);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(213, 23);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "List Of Added Assessment Components";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cmboboxRubricDetails
            // 
            this.cmboboxRubricDetails.FormattingEnabled = true;
            this.cmboboxRubricDetails.Location = new System.Drawing.Point(559, 109);
            this.cmboboxRubricDetails.Name = "cmboboxRubricDetails";
            this.cmboboxRubricDetails.Size = new System.Drawing.Size(121, 21);
            this.cmboboxRubricDetails.TabIndex = 22;
            // 
            // lblRubricDetails
            // 
            this.lblRubricDetails.AutoSize = true;
            this.lblRubricDetails.Location = new System.Drawing.Point(399, 112);
            this.lblRubricDetails.Name = "lblRubricDetails";
            this.lblRubricDetails.Size = new System.Drawing.Size(70, 13);
            this.lblRubricDetails.TabIndex = 21;
            this.lblRubricDetails.Text = "RubricDetails";
            // 
            // dtpDateCreatedAC
            // 
            this.dtpDateCreatedAC.Location = new System.Drawing.Point(559, 251);
            this.dtpDateCreatedAC.Name = "dtpDateCreatedAC";
            this.dtpDateCreatedAC.Size = new System.Drawing.Size(200, 20);
            this.dtpDateCreatedAC.TabIndex = 20;
            // 
            // txtTotalMarksAC
            // 
            this.txtTotalMarksAC.Location = new System.Drawing.Point(583, 199);
            this.txtTotalMarksAC.Name = "txtTotalMarksAC";
            this.txtTotalMarksAC.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMarksAC.TabIndex = 19;
            // 
            // lblDateCreatedAC
            // 
            this.lblDateCreatedAC.AutoSize = true;
            this.lblDateCreatedAC.Location = new System.Drawing.Point(414, 257);
            this.lblDateCreatedAC.Name = "lblDateCreatedAC";
            this.lblDateCreatedAC.Size = new System.Drawing.Size(67, 13);
            this.lblDateCreatedAC.TabIndex = 18;
            this.lblDateCreatedAC.Text = "DateCreated";
            // 
            // lblTotalMarksAC
            // 
            this.lblTotalMarksAC.AutoSize = true;
            this.lblTotalMarksAC.Location = new System.Drawing.Point(414, 199);
            this.lblTotalMarksAC.Name = "lblTotalMarksAC";
            this.lblTotalMarksAC.Size = new System.Drawing.Size(60, 13);
            this.lblTotalMarksAC.TabIndex = 17;
            this.lblTotalMarksAC.Text = "TotalMarks";
            // 
            // btnADDComponent
            // 
            this.btnADDComponent.Location = new System.Drawing.Point(559, 327);
            this.btnADDComponent.Name = "btnADDComponent";
            this.btnADDComponent.Size = new System.Drawing.Size(181, 23);
            this.btnADDComponent.TabIndex = 16;
            this.btnADDComponent.Text = "ADD Component";
            this.btnADDComponent.UseVisualStyleBackColor = true;
            this.btnADDComponent.Click += new System.EventHandler(this.btnADDComponent_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(568, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(399, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Location = new System.Drawing.Point(140, 1);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(138, 23);
            this.btnAddAssessment.TabIndex = 23;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseSelectable = true;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click_1);
            // 
            // lblAssessments
            // 
            this.lblAssessments.AutoScroll = true;
            this.lblAssessments.AutoScrollMinSize = new System.Drawing.Size(113, 23);
            this.lblAssessments.AutoSize = false;
            this.lblAssessments.BackColor = System.Drawing.SystemColors.Window;
            this.lblAssessments.Location = new System.Drawing.Point(390, 154);
            this.lblAssessments.Name = "lblAssessments";
            this.lblAssessments.Size = new System.Drawing.Size(120, 23);
            this.lblAssessments.TabIndex = 24;
            this.lblAssessments.Text = "List Of Assessments";
            // 
            // combboxListOfAssessment
            // 
            this.combboxListOfAssessment.FormattingEnabled = true;
            this.combboxListOfAssessment.ItemHeight = 23;
            this.combboxListOfAssessment.Location = new System.Drawing.Point(559, 154);
            this.combboxListOfAssessment.Name = "combboxListOfAssessment";
            this.combboxListOfAssessment.Size = new System.Drawing.Size(139, 29);
            this.combboxListOfAssessment.TabIndex = 25;
            this.combboxListOfAssessment.UseSelectable = true;
            // 
            // ListOfAddedAssessmentsDataGridView
            // 
            this.ListOfAddedAssessmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedAssessmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnEdit});
            this.ListOfAddedAssessmentsDataGridView.Location = new System.Drawing.Point(-191, 183);
            this.ListOfAddedAssessmentsDataGridView.Name = "ListOfAddedAssessmentsDataGridView";
            this.ListOfAddedAssessmentsDataGridView.Size = new System.Drawing.Size(616, 282);
            this.ListOfAddedAssessmentsDataGridView.TabIndex = 26;
            this.ListOfAddedAssessmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfAddedAssessmentsDataGridView_CellContentClick);
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
            // ListOfAddedAssessmentComponentDataGridView
            // 
            this.ListOfAddedAssessmentComponentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfAddedAssessmentComponentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDeleteAC,
            this.btnEditAC});
            this.ListOfAddedAssessmentComponentDataGridView.Location = new System.Drawing.Point(271, 183);
            this.ListOfAddedAssessmentComponentDataGridView.Name = "ListOfAddedAssessmentComponentDataGridView";
            this.ListOfAddedAssessmentComponentDataGridView.Size = new System.Drawing.Size(616, 282);
            this.ListOfAddedAssessmentComponentDataGridView.TabIndex = 27;
            this.ListOfAddedAssessmentComponentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfAddedAssessmentComponentDataGridView_CellContentClick);
            // 
            // btnDeleteAC
            // 
            this.btnDeleteAC.HeaderText = "Delete";
            this.btnDeleteAC.Name = "btnDeleteAC";
            this.btnDeleteAC.Text = "Delete";
            this.btnDeleteAC.UseColumnTextForButtonValue = true;
            // 
            // btnEditAC
            // 
            this.btnEditAC.HeaderText = "Edit";
            this.btnEditAC.Name = "btnEditAC";
            this.btnEditAC.Text = "Edit";
            this.btnEditAC.UseColumnTextForButtonValue = true;
            // 
            // AddAssessmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 518);
            this.Controls.Add(this.ListOfAddedAssessmentComponentDataGridView);
            this.Controls.Add(this.ListOfAddedAssessmentsDataGridView);
            this.Controls.Add(this.combboxListOfAssessment);
            this.Controls.Add(this.lblAssessments);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.cmboboxRubricDetails);
            this.Controls.Add(this.lblRubricDetails);
            this.Controls.Add(this.dtpDateCreatedAC);
            this.Controls.Add(this.txtTotalMarksAC);
            this.Controls.Add(this.lblDateCreatedAC);
            this.Controls.Add(this.lblTotalMarksAC);
            this.Controls.Add(this.btnADDComponent);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnAddAssessmentComponent);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnListOfAddedAssessment);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtTotalWeightage);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.lblTotalWeightage);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.dtpDateCreated);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddAssessmentForm";
            this.Text = "AddAssessmentForm";
            this.Load += new System.EventHandler(this.AddAssessmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAddedAssessmentComponentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblTotalWeightage;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.TextBox txtTotalWeightage;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnListOfAddedAssessment;
        private System.Windows.Forms.Button btnBACK;
        private MetroFramework.Controls.MetroButton btnAddAssessmentComponent;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ComboBox cmboboxRubricDetails;
        private System.Windows.Forms.Label lblRubricDetails;
        private System.Windows.Forms.DateTimePicker dtpDateCreatedAC;
        private System.Windows.Forms.TextBox txtTotalMarksAC;
        private System.Windows.Forms.Label lblDateCreatedAC;
        private System.Windows.Forms.Label lblTotalMarksAC;
        private System.Windows.Forms.Button btnADDComponent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private MetroFramework.Controls.MetroButton btnAddAssessment;
        private MetroFramework.Drawing.Html.HtmlLabel lblAssessments;
        private MetroFramework.Controls.MetroComboBox combboxListOfAssessment;
        private System.Windows.Forms.DataGridView ListOfAddedAssessmentsDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridView ListOfAddedAssessmentComponentDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeleteAC;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditAC;
    }
}