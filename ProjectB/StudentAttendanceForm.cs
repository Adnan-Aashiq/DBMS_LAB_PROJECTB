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
    public partial class StudentAttendanceForm : Form
    {
        public StudentAttendanceForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {

            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();
        }

        private void btnViewClassAttendence_Click(object sender, EventArgs e)
        {
            ClassAttendanceForm c = new ClassAttendanceForm();
            this.Hide();
            c.Show();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void StudentAttendanceForm_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select * from dbo.Student";
                SqlCommand cmd = new SqlCommand(query, c);

                SqlDataReader ListOfRegistrationNumbers = cmd.ExecuteReader();
                while (ListOfRegistrationNumbers.Read())
                {
                    cmbboxStudentRegistrationNumbers.Items.Add(ListOfRegistrationNumbers[5].ToString());
                }


            }
        }

        private void btnMarkAttendence_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string TextOfComboBox = cmbboxStudentRegistrationNumbers.Text;
                string registrationnumber = "select Id from dbo.Student where RegistrationNumber= '" + TextOfComboBox + "'   ";
                SqlCommand t = new SqlCommand(registrationnumber, c);
                var r = t.ExecuteReader();
                r.Read();
                int StudentID = r.GetInt32(0);
                r.Close();
                int a;
                if (cmbboxAttendenceStatus.Text == "Present")
                {
                    a = 1;
                }
                else if(cmbboxAttendenceStatus.Text == "Absent")
                {
                    a = 2;
                }
                else if (cmbboxAttendenceStatus.Text == "Leave")
                {
                    a = 3;
                }
                else
                {
                    a = 4;
                }
                string Query = "insert into dbo.StudentAttendance(StudentId,AttendanceStatus) values('" + StudentID + "','" +a  + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendence is marked");
            }
            else
            {
                MessageBox.Show("Attendence is marked");

            }
        }
    }
}
