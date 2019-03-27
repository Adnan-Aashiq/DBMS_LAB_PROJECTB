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
    public partial class ListOfAddedAssessmentComponentForm : Form
    {
        public ListOfAddedAssessmentComponentForm()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void ListOfAddedAssessmentComponentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListOfAddedAssessmentComponentDataGridView.Columns["btnEdit"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(ListOfAddedAssessmentComponentDataGridView.Rows[row].Cells["Id"].Value);
                int rubricid = Convert.ToInt32(ListOfAddedAssessmentComponentDataGridView.Rows[row].Cells["RubricId"].Value);
                int assessmentid = Convert.ToInt32(ListOfAddedAssessmentComponentDataGridView.Rows[row].Cells["AssessmentId"].Value);
                EditAssessmentComponentForm r = new EditAssessmentComponentForm(id, rubricid, assessmentid);
                this.Hide();
                r.Show();
            }
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == ListOfAddedAssessmentComponentDataGridView.Columns["btnDelete"].Index)
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

        private void ListOfAddedAssessmentComponentForm_Load(object sender, EventArgs e)
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
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {

            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }

        private void btnBackToStudentMenu_Click(object sender, EventArgs e)
        {
            ListOfAddedAssessmentsForm t = new ListOfAddedAssessmentsForm();
            this.Hide();
            t.Show();
        }
    }
}
