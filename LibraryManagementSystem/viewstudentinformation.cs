using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem
{
    public partial class viewstudentinformation : Form
    {
        public viewstudentinformation()
        {
            InitializeComponent();
        }
        static string ConnectionString = "server=127.0.0.1;user=root;database=library;port=3306;password=Ssckboys@1;";

        MySqlConnection con = new MySqlConnection(ConnectionString);

        private void txtsearchentrollement_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchentrollement.Text != "")
            {
                con.Open();
                string querry = "select * from NewStudent where enroll Like'"+txtsearchentrollement.Text+"'%";

                MySqlCommand cmd = new MySqlCommand(@querry, con);

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
            else
            {
                con.Open();
                string querry = "select * from NewStudent";

                MySqlCommand cmd = new MySqlCommand(@querry, con);

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

            }
        }

        private void viewstudentinformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            con.Open();
            string querry = "select * from NewStudent";

            MySqlCommand cmd = new MySqlCommand(@querry, con);

            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

        }
        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            panel2.Visible =true;
            con.Open();
            string querry = "select * from NewStudent where stuid="+bid+"";

            MySqlCommand cmd = new MySqlCommand(@querry, con);

            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtsName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtentrollement.Text = DS.Tables[0].Rows[0][2].ToString();
            txtdepaetment.Text = DS.Tables[0].Rows[0][3].ToString();
            txtsemester.Text = DS.Tables[0].Rows[0][4].ToString();
            txtcontact.Text = DS.Tables[0].Rows[0][5].ToString();
            txtemail.Text = DS.Tables[0].Rows[0][6].ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
          string sname=txtsName.Text;
         string enroll=txtentrollement.Text;
            string dep = txtdepaetment.Text;
            String seme=txtsemester.Text;
            Int64 contact=Int64.Parse(txtcontact.Text);
            string semail=txtemail.Text;

            if(MessageBox.Show("Data will be updated.confirm?","success",MessageBoxButtons.OKCancel,MessageBoxIcon.Question )==DialogResult.OK)
            con.Open();
            string querry = "Update Newstudent set Sname='"+sname+ "',enroll='"+enroll+"',depart='"+dep+"',sem='"+seme+"',contact='"+contact+"',email='"+semail+"' where stuid="+rowid+"";

            MySqlCommand cmd = new MySqlCommand(@querry, con);

            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            viewstudentinformation_Load(this, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewstudentinformation_Load(this, null);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted.confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                con.Open();
            string querry = "Delete from Newstudent where stuid=" + rowid + "";
            MySqlCommand cmd = new MySqlCommand(@querry, con);

            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            viewstudentinformation_Load(this, null);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("unsaved data will be lost.", "Are you sure?,", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                this.Close();
            }
        }
    }
}
