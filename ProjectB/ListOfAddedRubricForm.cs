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
    public partial class ListOfAddedRubricForm : Form
    {
        public int CLOId;
        public ListOfAddedRubricForm(int id)
        {
            CLOId = id;
            InitializeComponent();
        }
        public ListOfAddedRubricForm()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void ListOfAddedRubricForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Rubric", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            ListOfAddedRubricdataGridView.DataSource = dt;
                        }
                    }
                }
            }

        }

        private void ListOfAddedRubricdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == ListOfAddedRubricdataGridView.Columns["btnDelete"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    this.ListOfAddedRubricdataGridView.Rows.RemoveAt(e.RowIndex);
                    int row = e.RowIndex;
                    int Id = Convert.ToInt32(ListOfAddedRubricdataGridView.Rows[row].Cells["Id"].Value);
                    string Delete_Query = "DELETE FROM dbo.Rubric  WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted!");
                }
                

            }
            if (e.ColumnIndex == ListOfAddedRubricdataGridView.Columns["btnEdit"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(ListOfAddedRubricdataGridView.Rows[row].Cells["Id"].Value);
                int CLOId = Convert.ToInt32(ListOfAddedRubricdataGridView.Rows[row].Cells["CloId"].Value);

                EditRubricForm r = new EditRubricForm(id,CLOId);
                this.Hide();
                r.Show();
            }
            if (e.ColumnIndex == ListOfAddedRubricdataGridView.Columns["btnAddRubricLevel"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(ListOfAddedRubricdataGridView.Rows[row].Cells["Id"].Value);
                AddRubricLevelForm r = new AddRubricLevelForm(id);
                this.Hide();
                r.Show();
            }
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm y = new WelcomeForm();
            this.Hide();
            y.Show();
        }

        private void btnRubricLevelMenu_Click(object sender, EventArgs e)
        {
            ListOfAddedRubricLevelForm u = new ListOfAddedRubricLevelForm();
            this.Hide();
            u.Show();
        }
    }
}
