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
using PagedList;
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
            btnPrint.Hide();
            StudentResultDataGridView.Hide();
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
            btnPrint.Hide();
            StudentResultDataGridView.Hide();
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

        private void btnShowStudentResult_Click(object sender, EventArgs e)
        {
            btnPrint.Show();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string Q = "DECLARE @MaximumRubricLevel int SET @MaximumRubricLevel = 4 SELECT  STD.FirstName,STD.LastName ,ASCT.Name AS Component, RB.Details AS Rubric, ASCT.TotalMarks AS Component_Marks , RBL.MeasurementLevel AS Student_Rubric_Level,((RBL.MeasurementLevel/@MaximumRubricLevel) * ASCT.TotalMarks) AS Obtained_Marks FROM StudentResult as STDR JOIN AssessmentComponent AS ASCT ON ASCT.Id= STDR.AssessmentComponentId JOIN Student AS STD ON STD.Id=STDR.StudentId JOIN RubricLevel AS RBL ON RBL.Id = STDR.RubricMeasurementId JOIN Rubric AS RB ON RB.Id= RBL.RubricId";
                //string Query1 = "DECLARE @MaximumRubricLevel int SET @MaximumRubricLevel = 4";
                //string Query2 = "SELECT  STD.FirstName,STD.LastName ,ASCT.Name AS Component, RB.Details AS Rubric, ASCT.TotalMarks AS Component_Marks , RBL.MeasurementLevel AS Student_Rubric_Level,((RBL.MeasurementLevel/@MaximumRubricLevel) * ASCT.TotalMarks) AS Obtained_Marks FROM StudentResult as STDR";
                //string Query3 = "JOIN AssessmentComponent AS ASCT ON ASCT.Id= STDR.AssessmentComponentId ";
                //string Query4 = "JOIN Student AS STD ON STD.Id=STDR.StudentId";
                //string Query5 = "JOIN RubricLevel AS RBL ON RBL.Id = STDR.RubricMeasurementId ";
                //string Query6 = "JOIN Rubric AS RB ON RB.Id= RBL.RubricId";
                //string MainQuery = Query1 + Query2 + Query3 + Query4 + Query5 + Query6;
                using (SqlCommand cmd = new SqlCommand(Q, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            StudentResultDataGridView.DataSource = dt;
                        }
                    }
                }
            }
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
        }

        private void metroProgressSpinner2_Click(object sender, EventArgs e)
        {

        }
        Bitmap bitmap;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        private void StudentResultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.StudentResultDataGridView.Width, this.StudentResultDataGridView.Height);
            StudentResultDataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.StudentResultDataGridView.Width, this.StudentResultDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
