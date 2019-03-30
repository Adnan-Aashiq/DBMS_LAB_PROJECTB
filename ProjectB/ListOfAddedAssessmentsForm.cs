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
    public partial class ListOfAddedAssessmentsForm : Form
    {
        public ListOfAddedAssessmentsForm()
        {
            InitializeComponent();
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                //EditAssessmentForm r = new EditAssessmentForm(id);
                //this.Hide();
                //r.Show();
            }
            //if (e.ColumnIndex == ListOfAddedAssessmentsDataGridView.Columns["btnAddAssessmentComponent"].Index)
            //{
            //    int row = e.RowIndex;
            //    int id = Convert.ToInt32(ListOfAddedAssessmentsDataGridView.Rows[row].Cells["Id"].Value);
            //    AddAssessmentComponentForm r = new AddAssessmentComponentForm(id);
            //    this.Hide();
            //    r.Show();
            //}
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            AddAssessmentForm f = new AddAssessmentForm();
            this.Hide();
            f.Show();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void ListOfAddedAssessmentsForm_Load(object sender, EventArgs e)
        {
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

        private void btnListOfAddedAssessmentComponents_Click(object sender, EventArgs e)
        {
            ListOfAddedAssessmentComponentForm n = new ListOfAddedAssessmentComponentForm();
            this.Hide();
            n.Show();
        }

        private void btnbtnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm t = new WelcomeForm();
            this.Hide();
            t.Show();
        }
    }
}
