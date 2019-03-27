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
using System.Data.OleDb;

namespace ProjectB
{
    public partial class EditStudentForm : Form
    {
        public int Id;
        public EditStudentForm()
        {
            InitializeComponent();
        }
        public EditStudentForm(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm re = new WelcomeForm();
            this.Hide();
            re.Show();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        

        private void StudentInfoEdit_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            //string Edit_Query = "UPDATE FROM tbl_employees SET emp_name='" + txtname.Text + "',emp_email = '" + txtmail.Text + "',emp_department = '" + txtdept.Text + "',emp_designation = '" + txtdesg.Text + "',emp_joining_date = '" + dtpjoin.Value.ToString("MM/dd/yyyy") + "',emp_salary = '" + Convert.ToDouble(txtsalary.Text) + "'";
            string Get_Query = "select * FROM dbo.Student  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Get_Query, Connection);
            var myReader =cmd.ExecuteReader();
            myReader.Read();
            txtFirstName.Text = myReader[1].ToString();
            txtLastName.Text = myReader[2].ToString();
            txtContact.Text = myReader[3].ToString();
            txtEmail.Text = myReader[4].ToString();
            txtRegistrationNumber.Text = myReader[5].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            int a;
            if (cmbboxStatus.Text == "Active")
            {
                a = 5;
            }
            else
            {
                a = 6;
            }
            string Edit_Query = "UPDATE dbo.Student SET FirstName='" + txtFirstName.Text + "',LastName= '" + txtLastName.Text + "',Contact = '" + txtContact.Text + "',Email = '" + txtEmail.Text + "',RegistrationNumber= '" + txtRegistrationNumber.Text + "',Status= '" +a + "' WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Edit_Query, Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
            
            this.Hide();
            
        }

        private void btnBackToStudentMenu_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
