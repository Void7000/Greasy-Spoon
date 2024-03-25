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
using System.IO;

namespace CatererPart
{
    public partial class Form13 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["cat"].ConnectionString;

        public Form13()
        {
            InitializeComponent();
            BindGridView();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog o = new OpenFileDialog();
            o.Title = "Select image";
            o.Filter = "All Image | *.*";

            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(o.FileName);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(cs);
            string query = "insert into del values(@id,@name,@cont,@ord,@stat,@pic)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@cont", textBox3.Text);
            cmd.Parameters.AddWithValue("@ord", textBox4.Text);
            cmd.Parameters.AddWithValue("@stat", textBox5.Text);
            cmd.Parameters.AddWithValue("@pic", SavePhoto());*/

            SqlConnection con = new SqlConnection(cs);
            string query = "update del set status='Assigned',orderNo=@item where ID=@id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@item", textBox4.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Delivery Assigned");
                BindGridView();
                resetControl();

            }
            else
            {
                MessageBox.Show("Person might be busy");
            }
        }


        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }


        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from del";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[5];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 80;

        }

        void resetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            //pictureBox1.Image = Properties.Resources.City-No-Camera-icon;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[5].Value);
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update del set status='Available',orderNo=' ' where ID=@id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
          
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Order Delivered");
                BindGridView();
                resetControl();

            }
            else
            {
                MessageBox.Show("He might be busy");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from del where ID=id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data deleted Successfully ");
                BindGridView();
                resetControl();

            }
            else
            {
                MessageBox.Show("Data Not Deleted");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form11 ff = new Form11();
            ff.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
