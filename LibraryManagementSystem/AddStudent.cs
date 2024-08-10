using MySql.Data.MySqlClient;
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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtno.Clear();
            txtdep.Clear();
            txtsem.Clear();
            txtcon.Clear();
            txtemail.Clear();

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string no = txtno.Text;
            string dep = txtdep.Text;
            string sem = txtsem.Text;
            int contact = Convert.ToInt32(txtcon.Text);
            string email = txtemail.Text;

            string ConnectionString = "server=127.0.0.1;user=root;database=library;port=3306;password=anjana4444;";

            MySqlConnection con = new MySqlConnection(ConnectionString);

            string query = "Insert into NewStudent(sname,enroll,dep,sem,contact,email)" + "values(@name,@no,@dep,@sem,@contact,@email);";


            con.Open();
            MySqlCommand comd = new MySqlCommand(@query, con);
            comd.Parameters.AddWithValue("@name", name);
            comd.Parameters.AddWithValue("@no", no);
            comd.Parameters.AddWithValue("@dep", dep);
            comd.Parameters.AddWithValue("@sem", sem);
            comd.Parameters.AddWithValue("@contact", contact);
            comd.Parameters.AddWithValue("@email", email);

            comd.ExecuteNonQuery();
            MessageBox.Show("Added Successfully ");
            con.Close();
        }
    }
}
