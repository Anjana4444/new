using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
        static string connectionString = "server=127.0.0.1;user=root;database=Library;port=3306;password=anjana4444;";
        MySqlConnection con = new MySqlConnection(connectionString);
        private void IssueBook_Load(object sender, EventArgs e)
        {
            con.Open();
            string querry = "select =from IssueBook";

            MySqlCommand cmd = new MySqlCommand(@querry, con);

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

                string querry = "select =from IssueBook";

                MySqlCommand cmd = new MySqlCommand(@querry, con);

                cmd.CommandText = "select * from NewStudent where enroll= '" + eid + "'";
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet(querry);
                DA.Fill(DS);

                //--------------------------------------------------------------------------
                cmd.CommandText = "select count (std_enroll) from IRBook where std_enroll = '" + eid + "' and book_return_date is null";
                MySqlDataAdapter DA1 = new MySqlDataAdapter(cmd);
                DataSet DS1 = new DataSet(querry);
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());




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
                    MessageBox.Show("Invalid Enrollment No", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {
            if (txtname.Text != " ")
            {
                if (cmbbooks.SelectedIndex != -1 && count <= 2)
                {
                    string enroll = txtenrollement.Text;
                    string sname = txtname.Text;
                    string sdep = txtdepartment.Text;
                    string sem = txtsemester.Text;
                    Int64 contact = Convert.ToInt64(txtcontact.Text);
                    string email = txtemail.Text;
                    string bookname = cmbbooks.Text;
                    string bookIssuedDate = dateTimePicker.Text;

                    string eid = txtenrollement.Text;

                    string querry = "select =from IssueBook";

                    MySqlCommand cmd = new MySqlCommand(@querry, con);

                    con.Open();
                    cmd.CommandText = cmd.CommandText = "insert into IRBook (std_enrool,std_name,std_sem,std_contact,std-email,book_name,book_issue_date) values('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookIssuedDate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("book issued.", " success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select book . Or Maximum number of book has been ISSUED", " No book seected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                {
                    this.Close();
                }

            }
        }
    }
}
