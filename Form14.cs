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
    

    public partial class Form14 : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;

        public Form14()
        {
            InitializeComponent();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form15 frm15 = new Form15();
            frm15.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != " ")
            {
                SqlConnection con = new SqlConnection(cs);
                String query = "select username,pass from custreg where username = @user and pass = @pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                con.Open();
                SqlDataReader sda = cmd.ExecuteReader();
                if (sda.HasRows == true)
                {
                    // MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Customer_Control frm17 = new Customer_Control();
                    frm17.ShowDialog();
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
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            First_Login fl = new First_Login();
            fl.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
