using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            this.Hide();
            ad.Show();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM tblStudentInfos", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                }
                con.Close();

                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(DISTINCT(bkName)) FROM tblBookInfos", con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    textBox2.Text = dr1[0].ToString();
                }
                con.Close();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT (*) FROM tblIssueBooks", con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    textBox3.Text = dr2[0].ToString();
                }
                con.Close();
            }
        }
    }
}
