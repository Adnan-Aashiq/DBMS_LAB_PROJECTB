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
    public partial class AddNewCLOs : Form
    {
        public AddNewCLOs()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm back = new WelcomeForm();
            this.Hide();
            back.Show();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnAddCLOs_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into dbo.Clo(Name,DateCreated, DateUpdated) values ('" + txtCLOName.Text.ToString() + "','" + dtpCreatedDate.Value + "', '"+DateTime.Today+"')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("CLO is Added");
            }
            else
            {
                MessageBox.Show("CLO is not Added");

            }
        }

    }
}
