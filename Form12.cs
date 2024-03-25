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
   

    public partial class Form12 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;

        public Form12()
        {
            InitializeComponent();
            fastfood();
            bev();
            dessert();
            pack();
            
        }

        void fastfood()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from tangoff";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[3];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 80;
        }

        void bev()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from tangobev";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView2.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView2.Columns[3];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowTemplate.Height = 80;
        }

        void dessert()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from tangodes";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView4.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView4.Columns[3];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.RowTemplate.Height = 80;
        }

        void pack()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from tangopack";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView3.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView3.Columns[3];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.RowTemplate.Height = 80;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 ff = new Form11();
            ff.ShowDialog();
        }
    }
}
