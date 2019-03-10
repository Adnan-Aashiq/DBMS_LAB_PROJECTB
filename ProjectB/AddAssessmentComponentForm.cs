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
                //string CLOID = "select CloId from dbo.Rubric WHERE Id = '" + Id + "'";
                //SqlCommand t = new SqlCommand(CLOID, Connection);
                //var r = t.ExecuteNonQuery();
                //int o = Convert.ToInt32(r);
                string rubricID = "select Id from dbo.Rubric WHERE Id = '" + Id + "'";
                SqlCommand t = new SqlCommand(rubricID,c);
                var r = t.ExecuteNonQuery();
                int RubricID = Convert.ToInt32(r);
                string assessmentID = "select Id from dbo.Assessment WHERE Id = '" + Id + "'";
                SqlCommand u = new SqlCommand(assessmentID, c);
                var i = u.ExecuteNonQuery();
                int AssessmentID = Convert.ToInt32(i);
                string Query = "insert into dbo.AssessmentComponent(Name,TotalMarks,RubricId,DateCreated,DateUpdated,AssessmentId) values('" + txtName.Text + "','"+RubricID+"','" + Convert.ToInt32(txtTotalMarks.Text) + "','"+dtpDateUpdated.Value+"','"+DateTime.Today+"','"+AssessmentID+"')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("AssessmentComponent Detail is Added");
            }
            else
            {
                MessageBox.Show("AssessmentComponent is not Added");

            }
        }
    }
}
