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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sorgu = "SELECT * FROM tblStudentInfos where stName=@user AND stNumber=@pass";
                SqlCommand cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@user", txtusername.Text);
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    StudentDashboard ad = new StudentDashboard();
                    MessageBox.Show("Succesful.");
                    this.Hide();
                    ad.Show();
                }
                else
                {
                    MessageBox.Show("Please check your name and surname or password.");
                }
                con.Close();
                {

                }
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
            MessageBox.Show("For students who will login for the first time, the password is the school number.", "New Student Tip");
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {
            txtpassword.PasswordChar= '*';
        }
    }
}
