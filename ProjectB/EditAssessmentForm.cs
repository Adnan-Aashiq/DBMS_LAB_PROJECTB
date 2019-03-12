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
using System.Globalization;

namespace ProjectB
{
    public partial class EditAssessmentForm : Form
    {
        public int Id;
        public EditAssessmentForm(int id)
        {
            Id = id;
            InitializeComponent();
        }
        public EditAssessmentForm()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnUpdateAssessment_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            int a;
            string Edit_Query = "UPDATE dbo.Assessment SET Title='" + txtTitle.Text + "',DateCreated= '" + dtpDateCreated.Value + "',TotalMarks = '" + Convert.ToInt32(txtTotalMarks.Text) + "',TotalWeightage = '" + Convert.ToInt32(txtTotalWeightage) + "' WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Edit_Query, Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }

        private void EditAssessmentForm_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            //string Edit_Query = "UPDATE FROM tbl_employees SET emp_name='" + txtname.Text + "',emp_email = '" + txtmail.Text + "',emp_department = '" + txtdept.Text + "',emp_designation = '" + txtdesg.Text + "',emp_joining_date = '" + dtpjoin.Value.ToString("MM/dd/yyyy") + "',emp_salary = '" + Convert.ToDouble(txtsalary.Text) + "'";
            string Get_Query = "select * FROM dbo.Assessment  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Get_Query, Connection);
            var myReader = cmd.ExecuteReader();
            myReader.Read();
            txtTitle.Text = myReader[1].ToString();
            DateTime datevalue;
            if (DateTime.TryParse(myReader["DateCreated"].ToString(), out datevalue))
            {
                dtpDateCreated.Value = datevalue;
            }
            else
            {

            }
            int j = (int)myReader[3];
            txtTotalMarks.Text = j.ToString();
            int p = (int)myReader[4];
            txtTotalWeightage.Text = p.ToString();
        }

        private void btnBackTolListOfAddedAssessment_Click(object sender, EventArgs e)
        {
            ListOfAddedAssessmentsForm r = new ListOfAddedAssessmentsForm();
            this.Hide();
            r.Show();
        }
    }
}
