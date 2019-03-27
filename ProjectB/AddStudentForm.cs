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
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into dbo.Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values ('" + txtFirstName.Text.ToString() + "','" +txtLastName.Text.ToString() + "','" + txtContact.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtRegistrationNumber.Text.ToString() + "','" + 5 + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA INSERTED");
            }

            else
            {
                MessageBox.Show("DATA not INSERTED");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeForm back = new WelcomeForm();
            this.Hide();
            back.Show();
        }

        private void btnRegisteredStudents_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Student", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            StudentDataGridView.DataSource = dt;
                        }
                    }
                }
            }
            //ListOfAddedStudentsForm r = new ListOfAddedStudentsForm();
            //this.Hide();
            //r.Show();
            lblFirstName.Hide();
            txtFirstName.Hide();
            lblLastName.Hide();
            txtLastName.Hide();
            lblContact.Hide();
            txtContact.Hide();
            lblEmail.Hide();
            txtEmail.Hide();
            lblRegistrationNumber.Hide();
            txtRegistrationNumber.Hide();
            lblStatus.Hide();
            txtStatus.Hide();
            btnRegister.Hide();
            StudentDataGridView.Show();


        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            StudentDataGridView.Hide();
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            lblFirstName.Show();
            txtFirstName.Show();
            lblLastName.Show();
            txtLastName.Show();
            lblContact.Show();
            txtContact.Show();
            lblEmail.Show();
            txtEmail.Show();
            lblRegistrationNumber.Show();
            txtRegistrationNumber.Show();
            lblStatus.Show();
            txtStatus.Show();
            btnRegister.Show();
            StudentDataGridView.Hide();
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (e.ColumnIndex == StudentDataGridView.Columns["btnInActive"].Index)
            {
                int row = e.RowIndex;
                int Id = Convert.ToInt32(StudentDataGridView.Rows[row].Cells["Id"].Value);
                string Delete_Query = "UPDATE dbo.Student SET Status='" + 6 + "'  WHERE Id = '" + Id + "'";
                SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been InActivated");
            }
            if (e.ColumnIndex == StudentDataGridView.Columns["btnEdit"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(StudentDataGridView.Rows[row].Cells["Id"].Value);
                var formPopup = new EditStudentForm(id);
                formPopup.Show(this); 
                
            }
        }
    }
}
