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
    }
}
