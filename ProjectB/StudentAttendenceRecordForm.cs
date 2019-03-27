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
    public partial class StudentAttendenceRecordForm : Form
    {
        public StudentAttendenceRecordForm()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void StudentAttendenceRecordForm_Load(object sender, EventArgs e)
        {

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
                            dataGridViewStudentAttendenceRecord.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void StudentAttendenceRecordForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {

        }

        private void combboxFilterByStatus_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewStudentAttendenceRecord.DataSource as DataTable).DefaultView.RowFilter = string.Format("Status LIKE '{0}%'", combboxFilter.Text);
        }
    }
}
