using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }
        static string ConnectionString = "server=127.0.0.1;user=root;database=Library;port=3306;password=Ssckboys@1;";

        MySqlConnection con = new MySqlConnection(ConnectionString);
        private void IssueBook_Load(object sender, EventArgs e)
        {
            con.Open();
            string querry = "select bName from NewBook";

            MySqlCommand cmd = new MySqlCommand(@querry, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MySqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    cmbbooks.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }
        int count;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtenrollement.Text != "")
            {
                string eid = txtenrollement.Text;
                con.Open();
                string querry = "select bName from NewBook";

                MySqlCommand cmd = new MySqlCommand(@querry, con);
                cmd.CommandText = "select * from NewStudent where enroll= '" + eid + "'";
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //------------------------------------------------------------------------------
                //code to count how many books has been issued on this enroll number




                //------------------------------------------------------------------------------

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtname.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtdepartment.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtsemester.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtcontact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtemail.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtname.Clear();
                    txtdepartment.Clear();
                    txtsemester.Clear();
                    txtcontact.Clear();
                    txtemail.Clear();
                    MessageBox.Show("Invalid Enrollment No ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                if (cmbbooks.SelectedIndex != -1 && count <= 2)
                {
                    string enroll = txtenrollement.Text;
                    string sname = txtname.Text;
                    string sdep = txtdepartment.Text;
                    string sem = txtsemester.Text;
                    int contact = Convert.ToInt32(txtcontact.Text);
                    string email = txtemail.Text;
                    string bookname = cmbbooks.Text;
                    string bookIssueDate = dateTimePicker.Text;


                    string eid = txtenrollement.Text;

                    string querry = "select bName from NewBook";


                    MySqlCommand cmd = new MySqlCommand(@querry, con);
                    cmd.CommandText = cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Select book. or maximum no of books has been issued", "No book selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Enter valid enroll Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtenrollement_TextChanged(object sender, EventArgs e)
        {
            if (txtenrollement.Text == "")
            {
                txtname.Clear();
                txtdepartment.Clear();
                txtsemester.Clear();
                txtcontact.Clear();
                txtemail.Clear();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtenrollement.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }
    }
}
    

