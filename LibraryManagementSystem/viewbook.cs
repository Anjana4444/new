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
    public partial class viewbook : Form
    {
        public viewbook()
        {
            InitializeComponent();
        }

        private void viewbook_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(); 
        }
    }
}
