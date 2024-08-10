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
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();

            
        }
        static string ConnectionString = "server=127.0.0.1;user=root;database=Library;port=3306;password=anjana4444;";

        MySqlConnection con = new MySqlConnection(ConnectionString);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string bname=txtname.Text;
            string bauthor= txtauthor.Text;
            string bpub= txtpub.Text;
            string pdate = date.Text;
            double price=Convert.ToDouble(txtprice.Text);
            int quan=Convert.ToInt32(txtquan.Text);

            
            string query = "Insert into Newbook(bName,bAuthor,bPubl ,bpDate,bPrice,bQuan)" + "values(@bname,@bauthor,@bpub,@pdate,@price,@quan) ";

            con.Open();
            MySqlCommand comd = new MySqlCommand(query, con);
            comd.Parameters.AddWithValue("@bname", bname);
            comd.Parameters.AddWithValue("@bauthor", bauthor);
            comd.Parameters.AddWithValue("@bpub", bpub);
            comd.Parameters.AddWithValue("@pdate", pdate);
            comd.Parameters.AddWithValue("@price", price);
            comd.Parameters.AddWithValue("@quan", quan);

            comd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data saved ","succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtname.Clear();
            txtauthor.Clear();
            txtpub.Clear();
            txtprice.Clear();
            txtquan.Clear();


        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
