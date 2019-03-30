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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnaddnewstudent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegisteredStudents_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddedCLOs_Click(object sender, EventArgs e)
        {
            
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewCLO_Click(object sender, EventArgs e)
        {
            CLOsMenuForm clo = new CLOsMenuForm();
            this.Hide();
            clo.Show();
        }

        private void btnAddAssessmentMenu_Click(object sender, EventArgs e)
        {
            AssessmentMenuForm a = new AssessmentMenuForm();
            this.Hide();
            a.Show();
        }

        private void btnRubricMenu_Click(object sender, EventArgs e)
        {
            ListOfAddedRubricForm f = new ListOfAddedRubricForm();
            this.Hide();
            f.Show();

        }

        private void btnAttendenceMenu_Click(object sender, EventArgs e)
        {
            StudentAttendanceForm o = new StudentAttendanceForm();
            this.Hide();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LookupMenuForm f = new LookupMenuForm();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddStudent frm = new FormAddStudent();
            this.Hide();
            frm.Show();
        }

        private void btnCLOMenu_Click(object sender, EventArgs e)
        {
            CLOsMenuForm d = new CLOsMenuForm();
            this.Hide();
            d.Show();
        }

        private void btnStudentResultMenu_Click(object sender, EventArgs e)
        {
            StudentResultForm t = new StudentResultForm();
            t.Show();
            this.Hide();
        }
    }
}
