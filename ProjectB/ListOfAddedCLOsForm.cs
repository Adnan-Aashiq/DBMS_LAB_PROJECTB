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
    public partial class ListOfAddedCLOsForm : Form
    {
        public ListOfAddedCLOsForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm back = new WelcomeForm();
            this.Hide();
            back.Show();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void ListOfAddedCLOs_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Clo", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            CLOsDataGridView.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void CLOsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == CLOsDataGridView.Columns["btnDelete"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    this.CLOsDataGridView.Rows.RemoveAt(e.RowIndex);
                    int row = e.RowIndex;
                    int Id = Convert.ToInt32(CLOsDataGridView.Rows[row].Cells["Id"].Value);
                    string Delete_Query = "DELETE FROM dbo.Clo  WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted!");
                }

            }
            if (e.ColumnIndex == CLOsDataGridView.Columns["btnEdit"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(CLOsDataGridView.Rows[row].Cells["Id"].Value);
                EditCLOsForm r = new EditCLOsForm(id);
                this.Hide();
                r.Show();
            }
            if (e.ColumnIndex == CLOsDataGridView.Columns["btnAddRubric"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(CLOsDataGridView.Rows[row].Cells["Id"].Value);
                AddRubricForm r = new AddRubricForm(id);
                this.Hide();
                r.Show();
            }
        }

        private void btnBackToAddStudent_Click(object sender, EventArgs e)
        {
            AddNewCLOsForm v = new AddNewCLOsForm();
            this.Hide();
            v.Show();
        }
    }
}
