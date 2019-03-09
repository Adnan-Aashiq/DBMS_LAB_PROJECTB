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
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into dbo.Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values ('" + txtFirstName.Text.ToString() + "','" +txtLastName.Text.ToString() + "','" + txtContact.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtRegistrationNumber.Text.ToString() + "','" + 5 + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA INSERTED");
            }

            else
            {
                MessageBox.Show("DATA not INSERTED");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeForm back = new WelcomeForm();
            this.Hide();
            back.Show();
        }
    }
}
