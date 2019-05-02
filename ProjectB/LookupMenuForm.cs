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
    public partial class LookupMenuForm : Form
    {
        public LookupMenuForm()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            WelcomeForm o = new WelcomeForm();
            this.Hide();
            o.Show();

        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        //private void btnADD_Click(object sender, EventArgs e)
        //{
        //    SqlConnection c = new SqlConnection(constr);
        //    c.Open();
        //    if (c.State == ConnectionState.Open)
        //    {
        //        string Query = "insert into Lookup(Name,Category) values('" + cmbboxSelectName.Text + "','" + cmbboxCategory.Text + "')";
        //        SqlCommand cmd = new SqlCommand(Query, c);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Lookup is Added");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lookup is not Added");

        //    }
        //}
        private string[] comboBox2RangeA = new[] { "Active", "InActive" };
        private string[] comboBox2RangeB = new[] { "Presenr", "Absent","Leave","Late" };
        private void cmbboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbboxSelectName.Items.Clear();
            if (cmbboxCategory.Text == "STUDENT_STATUS")
            {
                cmbboxSelectName.Items.AddRange(comboBox2RangeA);
            }
            else
            {
                cmbboxSelectName.Items.AddRange(comboBox2RangeB);
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            
            
        }

        private void LookupMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}