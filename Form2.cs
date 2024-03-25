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
    public partial class Form2 : Form
    {

        public static string estName;
        public static string usrName;
        public static string addrss;
        public static string email;
        public static string nmbr;
        public static string pass;

        String cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into reg values(@estName,@name,@location,@email,@cont,@pass)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@estName", textBox1.Text);
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
            estName = textBox1.Text;
            usrName = textBox2.Text;
            addrss = textBox3.Text;
            email = textBox4.Text;
            nmbr = textBox5.Text;
            pass = textBox6.Text;



            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm14 = new Form1();
            frm14.ShowDialog();
        }
    }
}
