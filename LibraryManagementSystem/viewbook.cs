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
using Google.Protobuf;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class viewbook : Form
    {
        public viewbook()
        {
            InitializeComponent();
        }
        static string ConnectionString = "server=127.0.0.1;user=root;database=library;port=3306;password=Ssckboys@1;";

        MySqlConnection con = new MySqlConnection(ConnectionString);



        private void viewbook_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            con.Open();
            string querry = "select * from NewBook";

            MySqlCommand cmd = new MySqlCommand(@querry, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            con.Open();
            string querry = "select =from NewBook";

            MySqlCommand cmd = new MySqlCommand(@querry, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());


            txtbname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtauthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtpublication.Text = ds.Tables[0].Rows[0][3].ToString();
            txtpdate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtprice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtquantity.Text = ds.Tables[0].Rows[0][6].ToString();


        }


        private void btncancel_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtbookname_TextChanged(object sender, EventArgs e)
        {
            if (txtbookname.Text != "")
            {
                con.Open();
                string querry = "select =from NewBook where bname Like'" + txtbookname.Text + "%'";

                MySqlCommand cmd = new MySqlCommand(@querry, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                con.Open();
                string querry = "select =from NewBook";

                MySqlCommand cmd = new MySqlCommand(@querry, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtbookname.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Data Will Be updated.", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bname = txtbname.Text;
                string bauthor = txtauthor.Text;
                string publication = txtpublication.Text;
                string pdate = txtpdate.Text;
                Int64 price = Int64.Parse(txtprice.Text);
                Int64 quan = Int64.Parse(txtquantity.Text);
                con.Open();
                string querry = "Update NewBook set bname='" + bname + "',bauthor ='" + bauthor + "',bpubl='" + publication + "',bpdate='" + pdate + "',bprice='" + price + "',bquan='" + quan + "where bid=" + rowid + "";

                MySqlCommand cmd = new MySqlCommand(@querry, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }


        }

        private void btndelete_Click(object sender, EventArgs e)
        {

         
            if (MessageBox.Show("Data Will Be Deleted.Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                con.Open();
                string querry = "Delete from NewBook Where" + "bid = @rowid";
                MySqlCommand cmd = new MySqlCommand(@querry, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }


    }
}
