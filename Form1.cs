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
    public partial class Form1 : Form
    {
        public static string name;
        String cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != " ")
            {
                
                SqlConnection con = new SqlConnection(cs);
                String query = "select username,pass from reg where username = @user and pass = @pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                con.Open();
                SqlDataReader sda = cmd.ExecuteReader();
                if (sda.HasRows == true)
                {
                    //MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form19 frm4 = new Form19();
                    frm4.ShowDialog();
                }
                else

                    MessageBox.Show("Login Faield", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                con.Close();

            }
            else
            {
                MessageBox.Show("Fill the field", "Faield", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;

            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Focus();
                errorProvider1.Icon = Properties.Resources.err;
                errorProvider1.SetError(this.textBox1, "Unchecked Inputs");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.crr;
                errorProvider1.SetError(this.textBox1, "Input Inserted");

                //errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.err;
                errorProvider2.SetError(this.textBox2, "Unchecked Inputs");
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.crr;
                errorProvider2.SetError(this.textBox2, "Input Inseted");
                // errorProvider2.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            First_Login fl = new First_Login();
            fl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
