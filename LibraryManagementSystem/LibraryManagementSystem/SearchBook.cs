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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("select  bkName as BookName, bkAuthor as BookAuthor, bkPublication as BookPublication, bkDate as BookDate from tblBookInfos where bkName like '" + textBox1.Text + "%'", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                }

            }
            else
            {
                String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
                using (SqlConnection con = new SqlConnection(CS))
                {

                    SqlCommand cmd = new SqlCommand("select  bkName as BookName, bkAuthor as BookAuthor, bkPublication as BookPublication, bkDate as BookDate from tblBookInfos", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }
            }
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select bkName as BookName, bkAuthor as BookAuthor, bkPublication as BookPublication, bkDate as BookDate from tblBookInfos", con);
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
