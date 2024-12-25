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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(CS))
            {
                if (txtstName.Text != "" && txtstNumber.Text != "" && txtstDepartment.Text != "" && txtstSemester.Text != "" && txtstContact.Text != "" && txtstEmail.Text != "")
                {
                    //Int64 contact = Int64.Parse(txtstContact.Text);
                    SqlCommand cmd = new SqlCommand("insert into tblStudentInfos(stName,stNumber,stDepartment,stSemester,stContact,stEmail) values('" + txtstName.Text + "', '" + txtstNumber.Text + "'," +
                   "'" + txtstDepartment.Text + "', '" + txtstSemester.Text + "', '" + Int64.Parse(txtstContact.Text) + "', '" + txtstEmail.Text + "') ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student saved.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                    txtstName.Clear();
                    txtstNumber.Clear();
                    txtstDepartment.Clear();
                    txtstSemester.Clear();
                    txtstContact.Clear();
                    txtstEmail.Clear();
                }
                else
                {
                    MessageBox.Show("No Info entered.", "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtstName.Clear();
            txtstNumber.Clear();
            txtstDepartment.Clear();
            txtstSemester.Clear();
            txtstContact.Clear();
            txtstEmail.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            this.Hide();
            ad.Show();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
