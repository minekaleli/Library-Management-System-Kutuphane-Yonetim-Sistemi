using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewStudent vs=new ViewStudent();
            this.Hide();
            vs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBook vb=new ViewBook();
            this.Hide();
            vb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            this.Hide();
            addStudent.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            this.Hide();
            addBook.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminIssueBook adminIssueBook = new AdminIssueBook();
            this.Hide();
            adminIssueBook.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminReturnBook adminReturnBook = new AdminReturnBook();
            this.Hide();
            adminReturnBook.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SearchBook searchBook=new SearchBook();
            this.Hide();
            searchBook.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            this.Hide();
            page.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            this.Hide();
            statistics.Show();
        }
    }
}
