﻿namespace ProjectB
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
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnaddnewstudent = new System.Windows.Forms.Button();
            this.btnAddNewCLO = new System.Windows.Forms.Button();
            this.btnAddAssessmentMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(183, 40);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(157, 13);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Student LAB Evaluation System";
            // 
            // btnaddnewstudent
            // 
            this.btnaddnewstudent.Location = new System.Drawing.Point(41, 98);
            this.btnaddnewstudent.Name = "btnaddnewstudent";
            this.btnaddnewstudent.Size = new System.Drawing.Size(124, 23);
            this.btnaddnewstudent.TabIndex = 1;
            this.btnaddnewstudent.Text = "Add New Student";
            this.btnaddnewstudent.UseVisualStyleBackColor = true;
            this.btnaddnewstudent.Click += new System.EventHandler(this.btnaddnewstudent_Click);
            // 
            // btnAddNewCLO
            // 
            this.btnAddNewCLO.Location = new System.Drawing.Point(255, 98);
            this.btnAddNewCLO.Name = "btnAddNewCLO";
            this.btnAddNewCLO.Size = new System.Drawing.Size(106, 23);
            this.btnAddNewCLO.TabIndex = 2;
            this.btnAddNewCLO.Text = "Add New CLO";
            this.btnAddNewCLO.UseVisualStyleBackColor = true;
            this.btnAddNewCLO.Click += new System.EventHandler(this.btnAddNewCLO_Click);
            // 
            // btnAddAssessmentMenu
            // 
            this.btnAddAssessmentMenu.Location = new System.Drawing.Point(37, 185);
            this.btnAddAssessmentMenu.Name = "btnAddAssessmentMenu";
            this.btnAddAssessmentMenu.Size = new System.Drawing.Size(128, 23);
            this.btnAddAssessmentMenu.TabIndex = 6;
            this.btnAddAssessmentMenu.Text = "Add Assessment Menu";
            this.btnAddAssessmentMenu.UseVisualStyleBackColor = true;
            this.btnAddAssessmentMenu.Click += new System.EventHandler(this.btnAddAssessmentMenu_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 324);
            this.Controls.Add(this.btnAddAssessmentMenu);
            this.Controls.Add(this.btnAddNewCLO);
            this.Controls.Add(this.btnaddnewstudent);
            this.Controls.Add(this.lblinfo);
            this.Name = "WelcomeForm";
            this.Text = "formWelcome";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnaddnewstudent;
        private System.Windows.Forms.Button btnAddNewCLO;
        private System.Windows.Forms.Button btnAddAssessmentMenu;
    }
}

