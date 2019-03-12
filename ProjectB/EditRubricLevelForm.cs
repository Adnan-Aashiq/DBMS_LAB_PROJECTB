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
    public partial class EditRubricLevelForm : Form
    {
        public int Id;
        public int CloId;
        public EditRubricLevelForm(int id,int cloid)
        {
            Id = id;
            CloId = cloid;
            InitializeComponent();
        }
        public EditRubricLevelForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();
        }

        private void btnBackToAddedRubrics_Click(object sender, EventArgs e)
        {
            ListOfAddedRubricLevelForm g = new ListOfAddedRubricLevelForm();
            this.Hide();
            g.Hide();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void EditRubricLevelForm_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            //string Edit_Query = "UPDATE FROM tbl_employees SET emp_name='" + txtname.Text + "',emp_email = '" + txtmail.Text + "',emp_department = '" + txtdept.Text + "',emp_designation = '" + txtdesg.Text + "',emp_joining_date = '" + dtpjoin.Value.ToString("MM/dd/yyyy") + "',emp_salary = '" + Convert.ToDouble(txtsalary.Text) + "'";
            string Get_Query = "select * FROM dbo.RubricLevel  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Get_Query, Connection);
            var myReader = cmd.ExecuteReader();
            myReader.Read();
            txtDetails.Text = myReader.GetValue(2).ToString();
            int j = (int)myReader.GetValue(3);
            txtMeasurementLevel.Text = j.ToString();
        }

        private void btnUpdateRubricLevel_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            //string query = "select * from dbo.Rubric WHERE Id = '" + Id + "'";
            //SqlCommand t = new SqlCommand(query, Connection);
            //var r = t.ExecuteReader();
            //int o = r.GetInt32(0);
            string Edit_Query = "UPDATE dbo.RubricLevel SET RubricId='"+CloId+"', Details='" + txtDetails.Text + "', MeasurementLevel = '" + Convert.ToInt32(txtMeasurementLevel.Text) + "' ";
            //string Get_Query = "select * from tbl_employees where emp_id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Edit_Query, Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }
    }
}
