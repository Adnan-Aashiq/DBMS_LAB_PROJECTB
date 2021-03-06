﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectB
{
    public partial class AssessmentMenuForm : Form
    {
        public AssessmentMenuForm()
        {
            InitializeComponent();
        }
        //Getting Back to main page
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            this.Hide();
            w.Show();
        }
        //Providing Access to DataBase
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        //Adding Assessment to database on Clicking on buttton
        private void btnADDAssessment_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into dbo.Assessment(Title,DateCreated,TotalMarks,TotalWeightage) values ('" + txtTitle.Text.ToString() + "','" +dtpDateCreated.Value + "', '" + Convert.ToInt32(txtTotalMarks.Text) + "','" + Convert.ToInt32(txtTotalWeightage.Text) + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assessment is Added");
            }
            else
            {
                MessageBox.Show("Assessment is not Added");

            }
        }

        //Showing List Of Added Assessments By datagridview and Hiding other Things Except this
        private void btnListOfAddedAssessment_Click(object sender, EventArgs e)
        {

            ListOfAddedAssessmentComponentDataGridView.Hide();

            lblTitle.Hide();
            txtTitle.Hide();
            lblDateCreated.Hide();
            dtpDateCreated.Hide();
            lblTotalMarks.Hide();
            txtTotalMarks.Hide();
            lblTotalWeightage.Hide();
            txtTotalWeightage.Hide();
            btnADD.Hide();


            lblName.Hide();
            txtName.Hide();
            lblRubricDetails.Hide();
            cmboboxRubricDetails.Hide();
            lblAssessments.Hide();
            combboxListOfAssessment.Hide();
            lblTotalMarksAC.Hide();
            txtTotalMarksAC.Hide();
            lblDateCreatedAC.Hide();
            dtpDateCreatedAC.Hide();
            btnADDComponent.Hide();

            ListOfAddedAssessmentsDataGridView.Show();


            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Assessment", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            ListOfAddedAssessmentsDataGridView.DataSource = dt;
                        }
                    }
                }
            }
           
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {

            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }
        //On Load just Showing Add Assessment Menu
        private void AddAssessmentForm_Load(object sender, EventArgs e)
        {
            ListOfAddedAssessmentComponentDataGridView.Hide();

            ListOfAddedAssessmentsDataGridView.Hide();

            lblName.Hide();
            txtName.Hide();
            lblRubricDetails.Hide();
            cmboboxRubricDetails.Hide();
            lblAssessments.Hide();
            combboxListOfAssessment.Hide();
            lblTotalMarksAC.Hide();
            txtTotalMarksAC.Hide();
            lblDateCreatedAC.Hide();
            dtpDateCreatedAC.Hide();
            btnADDComponent.Hide();

        }
        // Adding Assessment Component MEnu
        private void btnAddAssessmentComponent_Click(object sender, EventArgs e)
        {
            //Showing Added RUbric Details in combobox And Adding this against this rubric
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string query = "select Id,Details from dbo.Rubric";
                SqlDataAdapter t = new SqlDataAdapter(query, Connection);
                DataTable dtatbl = new DataTable();
                t.Fill(dtatbl);
                cmboboxRubricDetails.DataSource = dtatbl;
                cmboboxRubricDetails.DisplayMember = "Details";
                cmboboxRubricDetails.ValueMember = "id";
            }
            Connection.Close();
            //Showing Added Assessment Titles in combobox And Adding this against this Assessment
            SqlConnection Connection1 = new SqlConnection(constr);
            Connection1.Open();
            if (Connection1.State == ConnectionState.Open)
            {
                string query = "select Id,Title from dbo.Assessment";
                SqlDataAdapter t = new SqlDataAdapter(query, Connection1);
                DataTable dtatbl = new DataTable();
                t.Fill(dtatbl);
                combboxListOfAssessment.DataSource = dtatbl;
                combboxListOfAssessment.DisplayMember = "Title";
                combboxListOfAssessment.ValueMember = "id";
            }
            Connection1.Close();

            ListOfAddedAssessmentComponentDataGridView.Hide();

            lblTitle.Hide();
            txtTitle.Hide();
            lblDateCreated.Hide();
            dtpDateCreated.Hide();
            lblTotalMarks.Hide();
            txtTotalMarks.Hide();
            lblTotalWeightage.Hide();
            txtTotalWeightage.Hide();
            btnADD.Hide();

            ListOfAddedAssessmentsDataGridView.Hide();


            lblName.Show();
            txtName.Show();
            lblRubricDetails.Show();
            cmboboxRubricDetails.Show();
            lblAssessments.Show();
            combboxListOfAssessment.Show();
            lblTotalMarksAC.Show();
            txtTotalMarksAC.Show();
            lblDateCreatedAC.Show();
            dtpDateCreatedAC.Show();
            btnADDComponent.Show();
            
        }
        //Showing Ad Assessment Menu
        private void btnAddAssessment_Click_1(object sender, EventArgs e)
        {
            ListOfAddedAssessmentComponentDataGridView.Hide();

            lblTitle.Show();
            txtTitle.Show();
            lblDateCreated.Show();
            dtpDateCreated.Show();
            lblTotalMarks.Show();
            txtTotalMarks.Show();
            lblTotalWeightage.Show();
            txtTotalWeightage.Show();
            btnADD.Show();

            ListOfAddedAssessmentsDataGridView.Hide();


            lblName.Hide();
            txtName.Hide();
            lblRubricDetails.Hide();
            cmboboxRubricDetails.Hide();
            lblAssessments.Hide();
            combboxListOfAssessment.Hide();
            lblTotalMarksAC.Hide();
            txtTotalMarksAC.Hide();
            lblDateCreatedAC.Hide();
            dtpDateCreatedAC.Hide();
            btnADDComponent.Hide();
        }
        // Editting and deleting Assessments from database that are showing in datagridview
        private void ListOfAddedAssessmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == ListOfAddedAssessmentsDataGridView.Columns["btnDelete"].Index)
            {
                this.ListOfAddedAssessmentsDataGridView.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                int Id = Convert.ToInt32(ListOfAddedAssessmentsDataGridView.Rows[row].Cells["Id"].Value);
                string Delete_Query = "DELETE FROM dbo.Assessment  WHERE Id = '" + Id + "'";
                SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been deleted!");

            }
            if (e.ColumnIndex == ListOfAddedAssessmentsDataGridView.Columns["btnEdit"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(ListOfAddedAssessmentsDataGridView.Rows[row].Cells["Id"].Value);

                var formPopup = new EditAssessmentForm(id);
                formPopup.Show(this);

                
            }
        }
        //Adding Assessment component to database
        private void btnADDComponent_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string Query = "insert into dbo.AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) values('" + txtName.Text + "','" + Convert.ToInt32(cmboboxRubricDetails.SelectedValue) + "','" + Convert.ToInt32(txtTotalMarksAC.Text) + "','" + dtpDateCreatedAC.Value + "','" + DateTime.Today + "','" + Convert.ToInt32(combboxListOfAssessment.SelectedValue) + "')";
                SqlCommand cmd = new SqlCommand(Query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("AssessmentComponent is Added");
            }
            else
            {
                MessageBox.Show("AssessmentComponent is not Added");

            }
            Connection.Close();
        }
        // Editting and deleting Assessment Components from database that are showing in datagridview
        private void ListOfAddedAssessmentComponentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListOfAddedAssessmentComponentDataGridView.Columns["btnEditAC"].Index)
            {
                int row = e.RowIndex;

                int id = Convert.ToInt32(ListOfAddedAssessmentComponentDataGridView.Rows[row].Cells["Id"].Value);
                var formPopup = new EditAssessmentComponentForm(id);
                formPopup.Show(this);

                
            }
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == ListOfAddedAssessmentComponentDataGridView.Columns["btnDeleteAC"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {

                    this.ListOfAddedAssessmentComponentDataGridView.Rows.RemoveAt(e.RowIndex);
                    int row = e.RowIndex;
                    int Id = Convert.ToInt32(ListOfAddedAssessmentComponentDataGridView.Rows[row].Cells["Id"].Value);
                    string Delete_Query = "DELETE FROM dbo.AssessmentComponent  WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted!");



                }
            }
        }
        //Showing Assessment Components From database in DataGridView
        private void metroButton2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.AssessmentComponent", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            ListOfAddedAssessmentComponentDataGridView.DataSource = dt;
                        }
                    }
                }
            }

            ListOfAddedAssessmentComponentDataGridView.Show();

            lblTitle.Hide();
            txtTitle.Hide();
            lblDateCreated.Hide();
            dtpDateCreated.Hide();
            lblTotalMarks.Hide();
            txtTotalMarks.Hide();
            lblTotalWeightage.Hide();
            txtTotalWeightage.Hide();
            btnADD.Hide();

            ListOfAddedAssessmentsDataGridView.Hide();


            lblName.Hide();
            txtName.Hide();
            lblRubricDetails.Hide();
            cmboboxRubricDetails.Hide();
            lblAssessments.Hide();
            combboxListOfAssessment.Hide();
            lblTotalMarksAC.Hide();
            txtTotalMarksAC.Hide();
            lblDateCreatedAC.Hide();
            dtpDateCreatedAC.Hide();
            btnADDComponent.Hide();
        }
    }       
}
