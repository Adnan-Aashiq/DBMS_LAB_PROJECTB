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
    public partial class ListOfAddedRubricLevelForm : Form
    {
        public ListOfAddedRubricLevelForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void ListOfAddedRubricLevelForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.RubricLevel", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            ListOfAddedRubricLeveldataGridView.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListOfAddedRubricForm w = new ListOfAddedRubricForm();
            this.Hide();
            w.Show();
        }

        private void ListOfAddedRubricLeveldataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == ListOfAddedRubricLeveldataGridView.Columns["btnDelete"].Index)
            {
                this.ListOfAddedRubricLeveldataGridView.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                int Id = Convert.ToInt32(ListOfAddedRubricLeveldataGridView.Rows[row].Cells["Id"].Value);
                string Delete_Query = "DELETE FROM dbo.RubricLevel  WHERE Id = '" + Id + "'";
                SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been deleted!");

            }
            if (e.ColumnIndex == ListOfAddedRubricLeveldataGridView.Columns["btnEdit"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(ListOfAddedRubricLeveldataGridView.Rows[row].Cells["Id"].Value);
                int cloid = Convert.ToInt32(ListOfAddedRubricLeveldataGridView.Rows[row].Cells["RubricId"].Value);
                EditRubricLevelForm r = new EditRubricLevelForm(id);
                this.Hide();
                r.Show();
            }
        }
    }
}
