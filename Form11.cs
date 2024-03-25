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
    public partial class Form11 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;

        public Form11()
        {
            InitializeComponent();
            showCustGrid();
        }
        void showCustGrid()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select userCount,username,address,email,contact from custreg";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.RowTemplate.Height = 80;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showCustGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select estName,username,loc,email,contact from reg";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.RowTemplate.Height = 80;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                Form12 frm12 = new Form12();
                frm12.ShowDialog();
             
            
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 ff = new Form10();
            ff.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
