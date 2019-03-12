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
    public partial class ClassAttendanceForm : Form
    {
        public ClassAttendanceForm()
        {
            InitializeComponent();
        }

        private void btnBackToStudentAttendence_Click(object sender, EventArgs e)
        {
            StudentAttendanceForm a = new StudentAttendanceForm();
            this.Hide();
            a.Show();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {

            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnMarkAttendence_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            { 
                string Query = "insert into dbo.ClassAttendance(AttendanceDate) values('" + dtpAttendenceDates.Value + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendence Date is Added");
            }
            else
            {
                MessageBox.Show("Attendence Date is not Added");

            }
        }
    }
}
