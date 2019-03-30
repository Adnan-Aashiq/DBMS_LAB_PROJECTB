namespace ProjectB
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnAssessmentMenu = new System.Windows.Forms.Button();
            this.btnAttendenceMenu = new System.Windows.Forms.Button();
            this.btnListRubricMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCLOMenu = new System.Windows.Forms.Button();
            this.btnStudentResultMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(269, 143);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(329, 28);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Student LAB Evaluation System";
            // 
            // btnAssessmentMenu
            // 
            this.btnAssessmentMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAssessmentMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssessmentMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssessmentMenu.Location = new System.Drawing.Point(199, 1);
            this.btnAssessmentMenu.Name = "btnAssessmentMenu";
            this.btnAssessmentMenu.Size = new System.Drawing.Size(125, 23);
            this.btnAssessmentMenu.TabIndex = 6;
            this.btnAssessmentMenu.Text = "Assessment Menu";
            this.btnAssessmentMenu.UseVisualStyleBackColor = false;
            this.btnAssessmentMenu.Click += new System.EventHandler(this.btnAddAssessmentMenu_Click);
            // 
            // btnAttendenceMenu
            // 
            this.btnAttendenceMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAttendenceMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttendenceMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendenceMenu.Location = new System.Drawing.Point(325, 1);
            this.btnAttendenceMenu.Name = "btnAttendenceMenu";
            this.btnAttendenceMenu.Size = new System.Drawing.Size(123, 23);
            this.btnAttendenceMenu.TabIndex = 17;
            this.btnAttendenceMenu.Text = "Attendence Menu";
            this.btnAttendenceMenu.UseVisualStyleBackColor = false;
            this.btnAttendenceMenu.Click += new System.EventHandler(this.btnAttendenceMenu_Click);
            // 
            // btnListRubricMenu
            // 
            this.btnListRubricMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListRubricMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListRubricMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListRubricMenu.Location = new System.Drawing.Point(449, 1);
            this.btnListRubricMenu.Name = "btnListRubricMenu";
            this.btnListRubricMenu.Size = new System.Drawing.Size(122, 23);
            this.btnListRubricMenu.TabIndex = 18;
            this.btnListRubricMenu.Text = "List Rubric Menu";
            this.btnListRubricMenu.UseVisualStyleBackColor = false;
            this.btnListRubricMenu.Click += new System.EventHandler(this.btnRubricMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(572, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Lookup Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Student Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCLOMenu
            // 
            this.btnCLOMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCLOMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCLOMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLOMenu.Location = new System.Drawing.Point(117, 1);
            this.btnCLOMenu.Name = "btnCLOMenu";
            this.btnCLOMenu.Size = new System.Drawing.Size(81, 23);
            this.btnCLOMenu.TabIndex = 22;
            this.btnCLOMenu.Text = "CLO Menu";
            this.btnCLOMenu.UseVisualStyleBackColor = false;
            this.btnCLOMenu.Click += new System.EventHandler(this.btnCLOMenu_Click);
            // 
            // btnStudentResultMenu
            // 
            this.btnStudentResultMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudentResultMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentResultMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentResultMenu.Location = new System.Drawing.Point(701, 1);
            this.btnStudentResultMenu.Name = "btnStudentResultMenu";
            this.btnStudentResultMenu.Size = new System.Drawing.Size(155, 23);
            this.btnStudentResultMenu.TabIndex = 23;
            this.btnStudentResultMenu.Text = "Student Result Menu";
            this.btnStudentResultMenu.UseVisualStyleBackColor = false;
            this.btnStudentResultMenu.Click += new System.EventHandler(this.btnStudentResultMenu_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(873, 408);
            this.Controls.Add(this.btnStudentResultMenu);
            this.Controls.Add(this.btnCLOMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListRubricMenu);
            this.Controls.Add(this.btnAttendenceMenu);
            this.Controls.Add(this.btnAssessmentMenu);
            this.Controls.Add(this.lblinfo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "WelcomeForm";
            this.Text = "formWelcome";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnAssessmentMenu;
        private System.Windows.Forms.Button btnAttendenceMenu;
        private System.Windows.Forms.Button btnListRubricMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCLOMenu;
        private System.Windows.Forms.Button btnStudentResultMenu;
    }
}

