﻿using System;
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
    public partial class AddRubricForm : Form
    {
        public int Id;
        public AddRubricForm(int id)
        {
            Id = id;
            InitializeComponent();
        }
        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            ListOfAddedCLOsForm w = new ListOfAddedCLOsForm();
            this.Hide();
            w.Show();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private int id;

        private void btnADD_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string Query = "insert into Rubric(Details,CloId) values('" + txtRubricDetails.Text + "','" + Id + "')";
                SqlCommand cmd = new SqlCommand(Query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rubric Detail is Added");
            }
            else
            {
                MessageBox.Show("Rubric Detail is not Added");

            }
        }

        private void AddRubricForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfAddedRubricForm f = new ListOfAddedRubricForm(id);
            this.Hide();
            f.Show();
        }
    }
}
