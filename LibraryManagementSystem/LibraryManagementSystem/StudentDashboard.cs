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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hp= new HomePage();
            this.Hide();
            hp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IssueBook ib= new IssueBook();
            this.Hide();
            ib.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReturnBook rb= new ReturnBook();
            this.Hide();
            rb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }
    }
}
