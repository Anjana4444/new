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
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        static string ConnectionString = "server=127.0.0.1;user=root;database=library;port=3306;password=;";

        MySqlConnection con = new MySqlConnection(ConnectionString);


        private void BookDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            string querry = "select * from IRBook where book_returndate is null";

            MySqlCommand cmd = new MySqlCommand(@querry, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Open();
            string querry2 = "select * from IRBook where book_returndate not null";

            MySqlCommand cmd2 = new MySqlCommand(@querry, con);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd2);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource= ds1.Tables[0];


        }
    }
}
