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
        public int CloId;
        public EditRubricLevelForm(int id,int cloid)
        {
            Id = id;
            CloId = cloid;
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
            ListOfAddedRubricLevelForm g = new ListOfAddedRubricLevelForm();
            this.Hide();
            g.Hide();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void EditRubricLevelForm_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select * from dbo.Rubric";
                SqlCommand t = new SqlCommand(query, c);

                SqlDataReader Details = t.ExecuteReader();
                while (Details.Read())
                {
                    cmbboxListfAddedRubricIds.Items.Add(Details[0].ToString());
                }
            }
            c.Close();
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            string Get_Query = "select * FROM dbo.RubricLevel  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Get_Query, Connection);
            var myReader = cmd.ExecuteReader();
            myReader.Read();
            txtDetails.Text = myReader.GetValue(2).ToString();
            int j = (int)myReader.GetValue(3);
            txtMeasurementLevel.Text = j.ToString();
        }

        private void btnUpdateRubricLevel_Click(object sender, EventArgs e)
        {

            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            string Edit_Query = "UPDATE dbo.RubricLevel SET RubricId ='"+Convert.ToInt32(cmbboxListfAddedRubricIds.Items)+"' ,Details= '" + txtDetails.Text + "', MeasurementLevel = '" + Convert.ToInt32(txtMeasurementLevel.Text) + "' ";
            SqlCommand cmd = new SqlCommand(Edit_Query, Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }
    }
}
