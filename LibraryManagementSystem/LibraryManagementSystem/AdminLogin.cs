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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sorgu = "SELECT * FROM tblLogin where UserName=@user AND Password=@pass";
                SqlCommand cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@user", txtuser.Text);
                cmd.Parameters.AddWithValue("@pass", txtpass.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    AdminDashboard ad = new AdminDashboard();
                    MessageBox.Show("Succesfull!");
                    this.Hide();
                    ad.Show();

                }
                else
                {
                    MessageBox.Show("Please check your username or password.");
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

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }
    }
}
