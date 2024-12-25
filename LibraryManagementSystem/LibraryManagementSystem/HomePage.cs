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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            this.Hide();
            al.Show();
        }

        private void studentLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentLogin sl= new StudentLogin();
            this.Hide();
            sl.Show();
        }

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBook searchBook= new SearchBook();
            this.Hide();
            searchBook.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
