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
    public partial class EditAssessmentComponentForm : Form
    {
        public int Id;
        public int RubricId;
        public int AssessmentId;
        public EditAssessmentComponentForm(int id,int rubricid,int assessmentid)
        {
            Id = id;
            RubricId = rubricid;
            AssessmentId = assessmentid;
            InitializeComponent();
        }
        public EditAssessmentComponentForm()
        {
            InitializeComponent();
        }
        public int AssmntId;
        public int RbrcId;
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnUpdateAssessmentComponent_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            string Edit_Query = "UPDATE dbo.AssessmentComponent SET Name='" + txtName.Text + "',RubricId='"+ Convert.ToInt32(combboxListOfRubricDetails.SelectedValue) + "',TotalMarks='"+ Convert.ToInt32(txtTotalMarks.Text) + "',DateCreated='"+DateTime.Today+"',DateUpdated='"+dtpDateUpdated.Value+"',AssessmentId='"+ Convert.ToInt32(combboxListOfAssesmentTitles.SelectedValue) + "'";
            SqlCommand y = new SqlCommand(Edit_Query, Connection);
            y.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }

        private void EditAssessmentComponentForm_Load(object sender, EventArgs e)
        {
            SqlConnection o = new SqlConnection(constr);
            o.Open();
            if (o.State == ConnectionState.Open)
            {
                string query = "select Id,Details from dbo.Rubric";
                SqlDataAdapter t = new SqlDataAdapter(query, o);
                DataTable dtatbl = new DataTable();
                t.Fill(dtatbl);
                combboxListOfRubricDetails.DataSource = dtatbl;
                combboxListOfRubricDetails.DisplayMember = "Details";
                combboxListOfRubricDetails.ValueMember = "id";
            }
            o.Close();
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select Id,Title from dbo.Assessment";
                SqlDataAdapter t = new SqlDataAdapter(query, c);
                DataTable i = new DataTable();
                t.Fill(i);
                combboxListOfAssesmentTitles.DataSource = i;
                combboxListOfAssesmentTitles.DisplayMember = "Title";
                combboxListOfAssesmentTitles.ValueMember = "id";
            }
            c.Close();
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            //string Edit_Query = "UPDATE FROM tbl_employees SET emp_name='" + txtname.Text + "',emp_email = '" + txtmail.Text + "',emp_department = '" + txtdept.Text + "',emp_designation = '" + txtdesg.Text + "',emp_joining_date = '" + dtpjoin.Value.ToString("MM/dd/yyyy") + "',emp_salary = '" + Convert.ToDouble(txtsalary.Text) + "'";
            string Get_Query = "select * FROM dbo.AssessmentComponent  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Get_Query, Connection);
            var myReader = cmd.ExecuteReader();
            myReader.Read();
            txtName.Text = myReader[1].ToString();
            int j = (int)myReader[3];
            txtTotalMarks.Text = j.ToString();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {

            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();
        }

        private void btnBackToAssessmentComponentList_Click(object sender, EventArgs e)
        {
            ListOfAddedAssessmentComponentForm d = new ListOfAddedAssessmentComponentForm();
            this.Hide();
            d.Show();
        }
    }
}
