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
    public partial class EditCLOsForm : Form
    {
        public int Id;
        public EditCLOsForm(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void CLOsEditInfo_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            //string Edit_Query = "UPDATE FROM tbl_employees SET emp_name='" + txtname.Text + "',emp_email = '" + txtmail.Text + "',emp_department = '" + txtdept.Text + "',emp_designation = '" + txtdesg.Text + "',emp_joining_date = '" + dtpjoin.Value.ToString("MM/dd/yyyy") + "',emp_salary = '" + Convert.ToDouble(txtsalary.Text) + "'";
            string Get_Query = "select * FROM dbo.Clo  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Get_Query, Connection);
            var myReader = cmd.ExecuteReader();
            myReader.Read();
            txtCLOName.Text = myReader[1].ToString();
        }
        private void btnAddCLOs_Click(object sender, EventArgs e)
        {

        }

        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnUpdateCLOs_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            string Edit_Query = "UPDATE dbo.Clo SET Name='" + txtCLOName.Text + "',DateCreated = '" + DateTime.Today + "',DateUpdated='" + dtpUpdatedDate.Value + "'  WHERE Id = '" + Id + "'";
            //string Get_Query = "select * from tbl_employees where emp_id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Edit_Query, Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }
        
        private void btnBackToMainPage_Click_1(object sender, EventArgs e)
        {

            ListOfAddedCLOsForm v = new ListOfAddedCLOsForm();
            this.Hide();
            v.Show();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {

            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }

        private void btnBackTolListOfAddedClos_Click(object sender, EventArgs e)
        {
            ListOfAddedCLOsForm l = new ListOfAddedCLOsForm();
            this.Hide();
            l.Show();
        }
    }
}
