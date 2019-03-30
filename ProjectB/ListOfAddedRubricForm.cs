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
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string query = "select Id,Name from dbo.Clo";
                SqlDataAdapter t = new SqlDataAdapter(query, Connection);
                DataTable dtatbl = new DataTable();
                t.Fill(dtatbl);
                combboxCLODetails.DataSource = dtatbl;
                combboxCLODetails.DisplayMember = "Name";
                combboxCLODetails.ValueMember = "id";
            }
            Connection.Close();

            ListOfAddedRubricDataGridView.Hide();

            ListOfAddedRubricLeveldataGridView.Hide();

            lblListOfRubricDetails.Hide();
            combboxListOfRubricDetails.Hide();
            lblDtailsRL.Hide();
            combboxRubricLevelDetails.Hide();
            lblMeasurementLevel.Hide();
            txtMeasurementLevel.Hide();
            btnADDRL.Hide();



        }

        private void ListOfAddedRubricdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == ListOfAddedRubricDataGridView.Columns["btnDelete"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    this.ListOfAddedRubricDataGridView.Rows.RemoveAt(e.RowIndex);
                    int row = e.RowIndex;
                    int Id = Convert.ToInt32(ListOfAddedRubricDataGridView.Rows[row].Cells["Id"].Value);
                    string Delete_Query = "DELETE FROM dbo.Rubric  WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted!");
                }
                

            }
            if (e.ColumnIndex == ListOfAddedRubricDataGridView.Columns["btnEdit"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(ListOfAddedRubricDataGridView.Rows[row].Cells["Id"].Value);

                var formPopup = new EditRubricForm(id);
                formPopup.Show(this);
                //EditRubricForm r = new EditRubricForm(id);
                //this.Hide();
                //r.Show();
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
            //ListOfAddedRubricLevelForm u = new ListOfAddedRubricLevelForm();
            //this.Hide();
            //u.Show();
        }

        private void ListOfAddedRubricLeveldataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == ListOfAddedRubricLeveldataGridView.Columns["btnDeleteRL"].Index)
            {
                this.ListOfAddedRubricLeveldataGridView.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                int Id = Convert.ToInt32(ListOfAddedRubricLeveldataGridView.Rows[row].Cells["Id"].Value);
                string Delete_Query = "DELETE FROM dbo.RubricLevel  WHERE Id = '" + Id + "'";
                SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been deleted!");

            }
            if (e.ColumnIndex == ListOfAddedRubricLeveldataGridView.Columns["btnEditRL"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(ListOfAddedRubricLeveldataGridView.Rows[row].Cells["Id"].Value);
                

                var formPopup = new EditRubricLevelForm(id);
                formPopup.Show(this);

                
            }
        }

        private void btnListOfAddedRubrics_Click(object sender, EventArgs e)
        {
            ListOfAddedRubricDataGridView.Show();

            lblCLONames.Hide();
            combboxCLODetails.Hide();
            lblRubricDetails.Hide();
            txtRubricDetails.Hide();
            btnADDR.Hide();

            ListOfAddedRubricLeveldataGridView.Hide();

            lblListOfRubricDetails.Hide();
            combboxListOfRubricDetails.Hide();
            lblDtailsRL.Hide();
            combboxRubricLevelDetails.Hide();
            lblMeasurementLevel.Hide();
            txtMeasurementLevel.Hide();
            btnADDRL.Hide();


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
                            ListOfAddedRubricDataGridView.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void btnAddRubric_Click(object sender, EventArgs e)
        {
            lblCLONames.Show();
            combboxCLODetails.Show();
            lblRubricDetails.Show();
            txtRubricDetails.Show();
            btnADDR.Show();

            ListOfAddedRubricDataGridView.Hide();

            ListOfAddedRubricLeveldataGridView.Hide();

            lblListOfRubricDetails.Hide();
            combboxListOfRubricDetails.Hide();
            lblDtailsRL.Hide();
            combboxRubricLevelDetails.Hide();
            lblMeasurementLevel.Hide();
            txtMeasurementLevel.Hide();
            btnADDRL.Hide();
        }

        private void btnAddRubricLevel_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string query = "select Id,Details from dbo.Rubric";
                SqlDataAdapter t = new SqlDataAdapter(query, Connection);
                DataTable dtatbl = new DataTable();
                t.Fill(dtatbl);
                combboxListOfRubricDetails.DataSource = dtatbl;
                combboxListOfRubricDetails.DisplayMember = "Details";
                combboxListOfRubricDetails.ValueMember = "id";
            }
            Connection.Close();

            


            ListOfAddedRubricDataGridView.Hide();

            lblCLONames.Hide();
            combboxCLODetails.Hide();
            lblRubricDetails.Hide();
            txtRubricDetails.Hide();
            btnADDR.Hide();

            ListOfAddedRubricLeveldataGridView.Hide();

            lblListOfRubricDetails.Show();
            combboxListOfRubricDetails.Show();
            lblDtailsRL.Show();
            combboxRubricLevelDetails.Show();
            lblMeasurementLevel.Show();
            txtMeasurementLevel.Show();
            btnADDRL.Show();
        }

        private void btnListOfAddedRubricLevels_Click(object sender, EventArgs e)
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

            ListOfAddedRubricDataGridView.Hide();

            lblCLONames.Hide();
            combboxCLODetails.Hide();
            lblRubricDetails.Hide();
            txtRubricDetails.Hide();
            btnADDR.Hide();

            ListOfAddedRubricLeveldataGridView.Show();

            lblListOfRubricDetails.Hide();
            combboxListOfRubricDetails.Hide();
            lblDtailsRL.Hide();
            combboxRubricLevelDetails.Hide();
            lblMeasurementLevel.Hide();
            txtMeasurementLevel.Hide();
            btnADDRL.Hide();
        }

        private void btnADDR_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string query = "select Id,Name from dbo.Clo";
                SqlDataAdapter t = new SqlDataAdapter(query, Connection);
                DataTable dtatbl = new DataTable();
                t.Fill(dtatbl);
                combboxCLODetails.DataSource = dtatbl;
                combboxCLODetails.DisplayMember = "Name";
                combboxCLODetails.ValueMember = "id";
            }
            Connection.Close();

            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into Rubric(Details,CloId) values('" + txtRubricDetails.Text + "','" +Convert.ToInt32(combboxCLODetails.SelectedValue)+ "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rubric Detail is Added");
            }
            else
            {
                MessageBox.Show("Rubric Detail is not Added");

            }
        }

        private void btnADDRL_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into RubricLevel(RubricId,Details,MeasurementLevel) values('" + Convert.ToInt32(combboxListOfRubricDetails.SelectedValue) + "','" + combboxRubricLevelDetails.Text + "','" + Convert.ToInt32(txtMeasurementLevel.Text) + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rubric Level Detail is Added");
            }
            else
            {
                MessageBox.Show("Rubric Level Detail is not Added");

            }
        }
    }
}
