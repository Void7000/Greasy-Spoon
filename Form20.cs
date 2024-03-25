using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CatererPart
{
    public partial class Form20 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;

        public Form20()
        {
            InitializeComponent();
            showloc();
            showest();
            showname();
            showmail();
            showcon();
            showpass();
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        void showest()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select estName from reg where userCount=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);

            textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        void showloc()
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "select loc from reg where userCount=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);

            textBox3.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        

        void showname()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select username from reg where userCount=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);

            textBox2.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        void showmail()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select email from reg where userCount=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);

            textBox4.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        void showcon()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select contact from reg where userCount=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);

            textBox5.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        void showpass()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select pass from reg where userCount=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);

            textBox6.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update reg set estName=@est,username=@name,loc=@loc,email=@mail,contact=@con,pass=@pass where userCount=1 ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@loc", textBox3.Text);
            cmd.Parameters.AddWithValue("@est", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@mail", textBox4.Text);
            cmd.Parameters.AddWithValue("@con", textBox5.Text);
            cmd.Parameters.AddWithValue("@pass", textBox6.Text);



            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully ");
                Form19 frm = new Form19();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Data Not Updated");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();
            f19.ShowDialog();
        }
    }
}
