namespace ProjectB
{
    partial class StudentAttendenceRecordForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStudentAttendenceRecord = new MetroFramework.Controls.MetroGrid();
            this.btnEditAttendaneStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFilterByStatus = new MetroFramework.Drawing.Html.HtmlLabel();
            this.combboxFilter = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentAttendenceRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentAttendenceRecord
            // 
            this.dataGridViewStudentAttendenceRecord.AllowUserToResizeRows = false;
            this.dataGridViewStudentAttendenceRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewStudentAttendenceRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudentAttendenceRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewStudentAttendenceRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentAttendenceRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudentAttendenceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentAttendenceRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditAttendaneStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudentAttendenceRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudentAttendenceRecord.EnableHeadersVisualStyles = false;
            this.dataGridViewStudentAttendenceRecord.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewStudentAttendenceRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewStudentAttendenceRecord.Location = new System.Drawing.Point(12, 127);
            this.dataGridViewStudentAttendenceRecord.Name = "dataGridViewStudentAttendenceRecord";
            this.dataGridViewStudentAttendenceRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentAttendenceRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudentAttendenceRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStudentAttendenceRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentAttendenceRecord.Size = new System.Drawing.Size(776, 272);
            this.dataGridViewStudentAttendenceRecord.TabIndex = 28;
            // 
            // btnEditAttendaneStatus
            // 
            this.btnEditAttendaneStatus.HeaderText = "EditAttendaneStatus";
            this.btnEditAttendaneStatus.Name = "btnEditAttendaneStatus";
            this.btnEditAttendaneStatus.Text = "EditAttendaneStatus";
            this.btnEditAttendaneStatus.UseColumnTextForButtonValue = true;
            // 
            // lblFilterByStatus
            // 
            this.lblFilterByStatus.AutoScroll = true;
            this.lblFilterByStatus.AutoScrollMinSize = new System.Drawing.Size(52, 23);
            this.lblFilterByStatus.AutoSize = false;
            this.lblFilterByStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilterByStatus.Location = new System.Drawing.Point(31, 58);
            this.lblFilterByStatus.Name = "lblFilterByStatus";
            this.lblFilterByStatus.Size = new System.Drawing.Size(88, 23);
            this.lblFilterByStatus.TabIndex = 29;
            this.lblFilterByStatus.Text = "Filter By";
            // 
            // combboxFilter
            // 
            this.combboxFilter.FormattingEnabled = true;
            this.combboxFilter.ItemHeight = 23;
            this.combboxFilter.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave",
            "Late"});
            this.combboxFilter.Location = new System.Drawing.Point(204, 52);
            this.combboxFilter.Name = "combboxFilter";
            this.combboxFilter.Size = new System.Drawing.Size(109, 29);
            this.combboxFilter.TabIndex = 30;
            this.combboxFilter.UseSelectable = true;
            this.combboxFilter.SelectionChangeCommitted += new System.EventHandler(this.combboxFilterByStatus_TextChanged);
            this.combboxFilter.TextChanged += new System.EventHandler(this.combboxFilterByStatus_TextChanged);
            // 
            // StudentAttendenceRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combboxFilter);
            this.Controls.Add(this.lblFilterByStatus);
            this.Controls.Add(this.dataGridViewStudentAttendenceRecord);
            this.Name = "StudentAttendenceRecordForm";
            this.Text = "StudentAttendenceRecordForm";
            this.Load += new System.EventHandler(this.StudentAttendenceRecordForm_Load);
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.StudentAttendenceRecordForm_InputLanguageChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentAttendenceRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dataGridViewStudentAttendenceRecord;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditAttendaneStatus;
        private MetroFramework.Drawing.Html.HtmlLabel lblFilterByStatus;
        private MetroFramework.Controls.MetroComboBox combboxFilter;
    }
}