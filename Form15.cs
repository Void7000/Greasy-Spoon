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
    public partial class Form15 : Form
    {
        public static string estName;
        public static string usrName;
        public static string addrss;
        public static string email;
        public static string nmbr;
        public static string pass;

        String cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;

        public Form15()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into custreg values(@name,@location,@email,@cont,@pass)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@location", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@cont", textBox5.Text);
            cmd.Parameters.AddWithValue("@pass", textBox6.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Data Inserted successfully");
            }
            else
            {
                MessageBox.Show("Data not Inserted");
            }


            this.Hide();
            
            usrName = textBox2.Text;
            addrss = textBox3.Text;
            email = textBox4.Text;
            nmbr = textBox5.Text;
            pass = textBox6.Text;



            Form16 frm16 = new Form16();
            frm16.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
