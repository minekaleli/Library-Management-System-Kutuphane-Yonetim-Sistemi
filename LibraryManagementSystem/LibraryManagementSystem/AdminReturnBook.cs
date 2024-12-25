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
    public partial class AdminReturnBook : Form
    {
        public AdminReturnBook()
        {
            InitializeComponent();
        }

        private void AdminReturnBook_Load(object sender, EventArgs e)
        {

            String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " select *from tblIssueBooks where bkReturnDate is not null";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            this.Hide();
            ad.Show();
        }
    }
}
