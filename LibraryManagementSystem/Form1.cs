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
    public partial class FrmNVMLibrary : Form
    {
        public FrmNVMLibrary()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks abs= new AddBooks();
            abs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are yousure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void nonFictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook vb = new viewbook();
            vb.Show();
        }

        private void resurveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook ib = new IssueBook();
            ib.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstudentinformation vsi = new viewstudentinformation();
                vsi.Show();
        }
    }
}
