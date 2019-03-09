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
            FormAddStudent frm = new FormAddStudent();
            this.Hide();
            frm.Show();
        }

        private void btnRegisteredStudents_Click(object sender, EventArgs e)
        {

            RegisteredStudents registeredStudents = new RegisteredStudents();
            this.Hide();
            registeredStudents.Show();
        }

        private void btnAddedCLOs_Click(object sender, EventArgs e)
        {
            ListOfAddedCLOs registeredStudents = new ListOfAddedCLOs();
            this.Hide();
            registeredStudents.Show();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewCLO_Click(object sender, EventArgs e)
        {
            AddNewCLOs clo = new AddNewCLOs();
            this.Hide();
            clo.Show();
        }
    }
}
