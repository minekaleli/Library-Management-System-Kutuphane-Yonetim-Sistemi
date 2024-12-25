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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbkName.Clear();
            txtbkAuthor.Clear();
            txtbkPrice.Clear();
            txtbkPublication.Clear();
            txtbkQuantity.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String CS = "Data Source =DESKTOP-M90O0PI;Initial Catalog = LMSDB;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(CS))
            {
                if (txtbkName.Text != "" && txtbkAuthor.Text != "" && txtbkPublication.Text != "" && dateTimePicker1.Text != "" && txtbkPrice.Text != "" && txtbkQuantity.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into tblBookInfos(bkName,bkAuthor,bkPublication,bkDate,bkPrice,bkQuanity) values('" + txtbkName.Text + "', '" + txtbkAuthor.Text + "'," +
                   "'" + txtbkPublication.Text + "', '" + dateTimePicker1.Text + "', '" + int.Parse(txtbkPrice.Text) + "', '" + int.Parse(txtbkQuantity.Text) + "') ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Infos saved.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                    txtbkName.Clear();
                    txtbkAuthor.Clear();
                    txtbkPublication.Clear();
                    // bkPurchaseDate.Clear();
                    txtbkPrice.Clear();
                    txtbkQuantity.Clear();
                }
                else
                {
                    MessageBox.Show("No Info entered.", "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                }
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
