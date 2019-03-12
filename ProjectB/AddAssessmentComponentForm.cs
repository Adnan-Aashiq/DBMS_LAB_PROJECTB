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
    public partial class AddAssessmentComponentForm : Form
    {
        public int Id;
        public AddAssessmentComponentForm(int id)
        {
            Id = id;
            InitializeComponent();
        }
        public AddAssessmentComponentForm()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnAddAssessmentComponent_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string TextOfComboBox = cmboboxRubricDetails.Text;
                string rubricDetails = "select * from dbo.Rubric where Details= '" + TextOfComboBox + "'   ";
                SqlCommand t = new SqlCommand(rubricDetails, c);
                var r = t.ExecuteReader();
                r.Read();
                int RubricID = r.GetInt32(0);
                r.Close();
                string assessmentID = "select * from dbo.Assessment WHERE Id = '" + Id + "'  ";
                SqlCommand u = new SqlCommand(assessmentID, c);
                var i = u.ExecuteReader();
                i.Read();
                int AssessmentID = i.GetInt32(0);
                i.Close();
                string Query = "insert into dbo.AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) values('" + txtName.Text + "','" + RubricID + "','" + Convert.ToInt32(txtTotalMarks.Text) + "','" + dtpDateUpdated.Value + "','" + DateTime.Today + "','" + AssessmentID + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("AssessmentComponent Detail is Added");
            }
            else
            { 
                MessageBox.Show("AssessmentComponent is not Added");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfAddedAssessmentsForm f = new ListOfAddedAssessmentsForm();
            this.Hide();
            f.Show();
        }
        
        private void AddAssessmentComponentForm_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select * from dbo.Rubric";
                SqlCommand cmd = new SqlCommand(query, c);
             
                SqlDataReader ListOfDetails = cmd.ExecuteReader();
                while (ListOfDetails.Read())
                {
                    cmboboxRubricDetails.Items.Add(ListOfDetails[1].ToString());
                }

                
            }
        }

        private void btnListOfAddedAssessmentComponent_Click(object sender, EventArgs e)
        {
            ListOfAddedAssessmentComponentForm m = new ListOfAddedAssessmentComponentForm();
            this.Hide();
            m.Show();

        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();
        }
    }
}
