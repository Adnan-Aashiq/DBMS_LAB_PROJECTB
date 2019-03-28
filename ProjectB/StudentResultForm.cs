using System;
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
    public partial class StudentResultForm : Form
    {
        public StudentResultForm()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void StudentResultForm_Load(object sender, EventArgs e)
        {
            
            SqlConnection o = new SqlConnection(constr);
            o.Open();
            if (o.State == ConnectionState.Open)
            {
                string query = "select Id,RegistrationNumber from dbo.Student";
                SqlDataAdapter t = new SqlDataAdapter(query, o);
                DataTable dtatbl = new DataTable();
                t.Fill(dtatbl);
                combboxStudentRegistrationNumber.DataSource = dtatbl;
                combboxStudentRegistrationNumber.DisplayMember = "RegistrationNumber";
                combboxStudentRegistrationNumber.ValueMember = "id";
            }
            o.Close();

            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select Id,Name from dbo.AssessmentComponent";
                SqlDataAdapter t = new SqlDataAdapter(query, c);
                DataTable i = new DataTable();
                t.Fill(i);
                combboxAssessmentComponentName.DataSource = i;
                combboxAssessmentComponentName.DisplayMember = "Name";
                combboxAssessmentComponentName.ValueMember = "id";
            }
            c.Close();
            
            SqlConnection l = new SqlConnection(constr);
            l.Open();
            if (l.State == ConnectionState.Open)
            {
                string query = "select Id,Details from dbo.RubricLevel";
                SqlDataAdapter m = new SqlDataAdapter(query, l);
                DataTable r = new DataTable();
                m.Fill(r);
                combboxRubricLevelDetails.DataSource = r;
                combboxRubricLevelDetails.DisplayMember = "Details";
                combboxRubricLevelDetails.ValueMember = "id";
            }
            l.Close();

        }

        private void dtpEvaluationDate_Validated(object sender, EventArgs e)
        {

        }

        private void dtpEvaluationDate_Validating(object sender, CancelEventArgs e)
        {

        }

        private void combboxStudentRegistrationNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnEvaluateThisSelectedStudent_Click(object sender, EventArgs e)
        {
            lblAssessmentName.Hide();
            combboxAssessmentComponentName.Hide();
            lblEvaluationDate.Hide();
            dtpEvaluationDate.Hide();
            lblRubricLevelDetails.Hide();
            combboxRubricLevelDetails.Hide();
            lblStudentRegistrationNumber.Hide();
            combboxStudentRegistrationNumber.Hide();
            btnEvaluateThisSelectedStudent.Hide();
            StudentResultDataGridView.Show();
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into dbo.StudentResult(StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) values('" + Convert.ToInt32(combboxStudentRegistrationNumber.SelectedValue) + "','" + Convert.ToInt32(combboxAssessmentComponentName.SelectedValue) + "','" + Convert.ToInt32(combboxRubricLevelDetails.SelectedValue) + "','" + dtpEvaluationDate.Value +"')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Evaluation has been Added");
            }
            else
            {
                MessageBox.Show(" Evaluation has not been Added");

            }
            
        }

        private void btnComputMarks_Click(object sender, EventArgs e)
        {
            
            
            //SqlConnection c = new SqlConnection(constr);
            //c.Open();
            //if (c.State == ConnectionState.Open)
            //{
            //    string query = "select dbo.AssessmentComponent.Name from dbo.AssessmentComponent join dbo.StudentResult on dbo.AssessmentComponent.Id=dbo.StudentResult.AssessmentComponentId";
            //    SqlDataAdapter t = new SqlDataAdapter(query, c);
            //    DataTable i = new DataTable();
            //    t.Fill(i);
            //    combboxSelectedAssessmentComponentName.DataSource = i;
            //    combboxSelectedAssessmentComponentName.DisplayMember = "Name";
                
            //}
            //c.Close();
            //SqlConnection q = new SqlConnection(constr);
            //q.Open();
            //if (q.State == ConnectionState.Open)
            //{
            //    string query = "select dbo.Rubric.Details from dbo.Rubric join dbo.RubricLevel on dbo.Rubric.Id=dbo.RubricLevel.Id join dbo.StudentResult on dbo.StudentResult.RubricMeasurementId=dbo.RubricLevel.Id";
            //    SqlDataAdapter t = new SqlDataAdapter(query, q);
            //    DataTable v = new DataTable();
            //    t.Fill(v);
            //    combboxRubricDetails.DataSource = v;
            //    combboxRubricDetails.DisplayMember = "Details";

            //}
            //q.Close();
        }

        private void btnEvaluateAStudent_Click(object sender, EventArgs e)
        {
            lblAssessmentName.Show();
            combboxAssessmentComponentName.Show();
            lblEvaluationDate.Show();
            dtpEvaluationDate.Show();
            lblRubricLevelDetails.Show();
            combboxRubricLevelDetails.Show();
            lblStudentRegistrationNumber.Show();
            combboxStudentRegistrationNumber.Show();
            btnEvaluateThisSelectedStudent.Show();

        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }
    }
}
