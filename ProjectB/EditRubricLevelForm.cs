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
    public partial class EditRubricLevelForm : Form
    {
        public int Id;
        
        public EditRubricLevelForm(int id)
        {
            Id = id;
            
            InitializeComponent();
        }
        public EditRubricLevelForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();
        }

        private void btnBackToAddedRubrics_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void EditRubricLevelForm_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string query = "select Id,Details from dbo.Rubric";
                SqlDataAdapter t = new SqlDataAdapter(query, Connection);
                DataTable dtatbl = new DataTable();
                t.Fill(dtatbl);
                combboxListOfRubricDetails.DataSource = dtatbl;
                combboxListOfRubricDetails.DisplayMember = "Details";
                combboxListOfRubricDetails.ValueMember = "id";
            }
            Connection.Close();
            SqlConnection Connection1 = new SqlConnection(constr);
            Connection1.Open();
            string Get_Query = "select * FROM dbo.RubricLevel  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Get_Query, Connection1);
            var myReader = cmd.ExecuteReader();
            myReader.Read();
            combboxRubricLevelDetails.Text = myReader.GetValue(2).ToString();
            int j = (int)myReader.GetValue(3);
            txtMeasurementLevel.Text = j.ToString();
            Connection1.Close();
        }

        private void btnUpdateRubricLevel_Click(object sender, EventArgs e)
        {
         
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            string Edit_Query = "UPDATE dbo.RubricLevel SET RubricId ='"+Convert.ToInt32(combboxListOfRubricDetails.SelectedValue)+"' ,Details= '" + combboxRubricLevelDetails.SelectedValue + "', MeasurementLevel = '" + Convert.ToInt32(txtMeasurementLevel.Text) + "' ";
            SqlCommand cmd = new SqlCommand(Edit_Query, Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }
    }
}
