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
    public partial class AddAssessmentForm : Form
    {
        public AddAssessmentForm()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            this.Hide();
            w.Show();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
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

        private void btnListOfAddedAssessment_Click(object sender, EventArgs e)
        {
            ListOfAddedAssessmentsForm d = new ListOfAddedAssessmentsForm();
            this.Hide();
            d.Show();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {

            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }

        private void AddAssessmentForm_Load(object sender, EventArgs e)
        {

        }
    }       
}
