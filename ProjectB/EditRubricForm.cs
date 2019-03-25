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
    public partial class EditRubricForm : Form
    {
        public int Id;
        public int a;
        public EditRubricForm(int id,int CLOId)
        {
            Id = id;
            a = CLOId;
            InitializeComponent();
        }
        public EditRubricForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            ListOfAddedRubricForm r = new ListOfAddedRubricForm();
            this.Hide();
            r.Show();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            SqlConnection Connection = new SqlConnection(constr);
            Connection.Open();
            string Edit_Query = "UPDATE dbo.Rubric SET Details='" + txtRubricDetails.Text + "', CloId = '" + cmbboxListfAddedCLOIds.SelectedItem + "'  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Edit_Query, Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }

        private void EditRubricForm_Load(object sender, EventArgs e)
        {

            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select * from dbo.Clo";
                SqlCommand t = new SqlCommand(query, c);

                SqlDataReader Details = t.ExecuteReader();
                while (Details.Read())
                {
                    cmbboxListfAddedCLOIds.Items.Add(Details[0].ToString());
                }


            }
            c.Close();
            SqlConnection x = new SqlConnection(constr);
            x.Open();
            string Get_Query = "select * FROM dbo.Rubric  WHERE Id = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(Get_Query, x);
            var Reader = cmd.ExecuteReader();
            Reader.Read();
            txtRubricDetails.Text = Reader[1].ToString();
            x.Close();
        }

        private void btnBackToMainPage_Click_1(object sender, EventArgs e)
        {

            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }

        private void btnBackTolListOfAddedRubric_Click(object sender, EventArgs e)
        {
            ListOfAddedRubricForm p = new ListOfAddedRubricForm();
            this.Hide();
            p.Show();

        }
    }
}
