using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CatererPart
{
    public partial class Form19 : Form
    {
         

        string cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;

        public Form19()
        {
            InitializeComponent();
            showloc();
            showest();
            showname();
            showmail();
            showcon();
            
        }

        void showloc()
        {
                       
                SqlConnection con = new SqlConnection(cs);           
                string query = "select loc from reg where userCount=1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                con.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds);

                label1.Text = ds.Tables[0].Rows[0][0].ToString();
                con.Close();           
        }

        void showest()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select estName from reg where userCount=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);

            label3.Text = ds.Tables[0].Rows[0][0].ToString();
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

            label2.Text = ds.Tables[0].Rows[0][0].ToString();
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

            label4.Text = ds.Tables[0].Rows[0][0].ToString();
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

            label5.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

       
        void showstrname()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select loc from reg where userCount=4 and username='Khabib'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);

            label2.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 frm = new Form20();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form21 frm = new Form21();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
