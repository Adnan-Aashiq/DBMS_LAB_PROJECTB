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

      
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void StudentAttendanceForm_Load(object sender, EventArgs e)
        {
            lblFilterByStatus.Hide();
            combboxFilter.Hide();
            StudentAttendenceRecordDataGridView.Hide();
        }

        private void btnMarkAttendence_Click(object sender, EventArgs e)
        {
            int StudentID=0;
            int Status = 0;
            foreach (DataGridViewRow Row in metroGridListOfAddedStudents.Rows)
            {
                if (Row.Cells[0].Value != null)
                {
                    if ((bool)(Row.Cells[0].Value) == true)
                    {
                        Status = 1;
                        StudentID = Convert.ToInt32(metroGridListOfAddedStudents.Rows[Row.Index].Cells["Id"].Value.ToString());
                        SqlConnection t = new SqlConnection(constr);
                        t.Open();
                        if (t.State == ConnectionState.Open)
                        {
                            string query = "insert into dbo.StudentAttendance(AttendanceId,StudentId,AttendanceStatus) values('" + atndid + "','" + StudentID + "','" + Status + "')";
                            SqlCommand cmd = new SqlCommand(query, t);
                            cmd.ExecuteNonQuery();
                            
                        }
                        else
                        {
                           
                        }
                        t.Close();

                    }
                }

                if (Row.Cells[1].Value != null)
                {
                    if ((bool)(Row.Cells[1].Value) == true)
                    {
                        Status = 2;
                        StudentID = Convert.ToInt32(metroGridListOfAddedStudents.Rows[Row.Index].Cells["Id"].Value.ToString());
                        SqlConnection t = new SqlConnection(constr);
                        t.Open();
                        if (t.State == ConnectionState.Open)
                        {
                            string query = "insert into dbo.StudentAttendance(AttendanceId,StudentId,AttendanceStatus) values('" + atndid + "','" + StudentID + "','" + Status + "')";
                            SqlCommand cmd = new SqlCommand(query, t);
                            cmd.ExecuteNonQuery();
                            
                        }
                        else
                        {
                            
                        }
                        t.Close();

                    }
                }
                if (Row.Cells[2].Value != null)
                {
                    if ((bool)(Row.Cells[2].Value) == true)
                    {
                        Status = 3;
                        StudentID = Convert.ToInt32(metroGridListOfAddedStudents.Rows[Row.Index].Cells["Id"].Value.ToString());
                        SqlConnection t = new SqlConnection(constr);
                        t.Open();
                        if (t.State == ConnectionState.Open)
                        {
                            string query = "insert into dbo.StudentAttendance(AttendanceId,StudentId,AttendanceStatus) values('" + atndid + "','" + StudentID + "','" + Status + "')";
                            SqlCommand cmd = new SqlCommand(query, t);
                            cmd.ExecuteNonQuery();
                            
                        }
                        else
                        {
                            
                        }
                        t.Close();

                    }
                }
                if (Row.Cells[3].Value != null)
                {
                    if ((bool)(Row.Cells[3].Value) == true)
                    {
                        Status = 4;
                        StudentID = Convert.ToInt32(metroGridListOfAddedStudents.Rows[Row.Index].Cells["Id"].Value.ToString());
                        SqlConnection t = new SqlConnection(constr);
                        t.Open();
                        if (t.State == ConnectionState.Open)
                        {
                            string query = "insert into dbo.StudentAttendance(AttendanceId,StudentId,AttendanceStatus) values('" + atndid + "','" + StudentID + "','" + Status + "')";
                            SqlCommand cmd = new SqlCommand(query, t);
                            cmd.ExecuteNonQuery();
                            
                        }
                        else
                        {
                           
                        }
                        t.Close();
                    }
                }
                
            }
            MessageBox.Show("Student Attendence is Marked");


        }

        private void metroGridListOfAddedStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewListOfAddedStudents_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id,RegistrationNumber,FirstName FROM dbo.Student", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            metroGridListOfAddedStudents.DataSource = dt;
                        }
                    }
                }
            }
        }
        public int atndid;
        private void dtpAttendenceDate_ValueChanged(object sender, EventArgs e)
        {
            
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into dbo.ClassAttendance(AttendanceDate) values('" + dtpAttendenceDate.Value + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("select * from ClassAttendance where AttendanceDate ='" + dtpAttendenceDate.Value + "'",c);
                var reader = cmd2.ExecuteReader();
                reader.Read();
                atndid= reader.GetInt32(0);
                

            }
            else
            {

            }
            c.Close();


        }

        private void btnStudentAttendenceRecord_Click(object sender, EventArgs e)
        {
            lblMarkStudentAttendence.Hide();
            lblAttendenceDate.Hide();
            dtpAttendenceDate.Hide();
            btnViewListOfAddedStudents.Hide();
            metroGridListOfAddedStudents.Hide();
            btnMark.Hide();

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT std.Id, std.FirstName,std.LastName,ca.AttendanceDate, std.RegistrationNumber,CASE a.AttendanceStatus WHEN 1 THEN 'Present' WHEN 2 THEN 'Absent' WHEN  3 THEN 'Leave' WHEN  4 THEN 'Late' END as Status FROM Student as std JOIN StudentAttendance as a ON a.StudentId= std.Id JOIN ClassAttendance ca ON ca.Id=a.AttendanceId", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            StudentAttendenceRecordDataGridView.DataSource = dt;
                        }
                    }
                }
            }
            lblFilterByStatus.Show();
            combboxFilter.Show();
            StudentAttendenceRecordDataGridView.Show();

            //StudentAttendenceRecordForm t = new StudentAttendenceRecordForm();
            //this.Hide();
            //t.Show();
        }

        private void lblMarkStudentAttendence_Click(object sender, EventArgs e)
        {

        }

        private void btnMarkAttendence_Click_1(object sender, EventArgs e)
        {
            lblMarkStudentAttendence.Show();
            lblAttendenceDate.Show();
            dtpAttendenceDate.Show();
            btnViewListOfAddedStudents.Show();
            metroGridListOfAddedStudents.Show();
            btnMark.Show();

            lblFilterByStatus.Hide();
            combboxFilter.Hide();
            StudentAttendenceRecordDataGridView.Hide();

        }

        private void combboxFilter_TextChanged(object sender, EventArgs e)
        {
            (StudentAttendenceRecordDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Status LIKE '{0}%'", combboxFilter.Text);
        }
    }
}
