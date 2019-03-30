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
    public partial class AddRubricLevelForm : Form
    {
        public int Id;
        public AddRubricLevelForm(int id)
        {
            Id = id;
            InitializeComponent();
        }
        public AddRubricLevelForm()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnRubricLevel_Click(object sender, EventArgs e)
        {
                SqlConnection c = new SqlConnection(constr);
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    string Query = "insert into RubricLevel(RubricId,Details,MeasurementLevel) values('"+Id+"','" + combboxRubricLevelDetails.Text + "','" + Convert.ToInt32(txtMeasurementLevel.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Query, c);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rubric Level Detail is Added");
                }
                else
                {
                    MessageBox.Show("Rubric Level Detail is not Added");

                }
        }

        private void AddRubricLevelForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();
        }
    }
}
