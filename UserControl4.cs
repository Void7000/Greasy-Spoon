using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatererPart
{
    public partial class UserControl4 : UserControl
    {
        Adding fn = new Adding();
        string query;
        public UserControl4()
        {
            InitializeComponent();
        }
        protected int n, total = 0;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        int amount;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void showItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getdata(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            //throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "0" && textBox3.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[2].Value = numericUpDown1.Value;
                dataGridView1.Rows[n].Cells[3].Value = textBox3.Text;

                total += int.Parse(textBox3.Text);
                label6.Text = "TAKA. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total payable Amount : " + label6.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);

            total = 0;
            dataGridView1.Rows.Clear();
            label6.Text = "TAKA : " + total;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
                listBox1.Items.Clear();
                String Category = comboBox1.Text;
                query = "select Item_Name from logpp where Category = '" + Category + "' ";
                DataSet ds = fn.getdata(query);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }

                showItemList(query);
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            numericUpDown1.ResetText();
            textBox3.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            textBox1.Text = text;
            query = "select Price from logpp where Item_Name = '" + text + "'";
            DataSet ds = fn.getdata(query);

            try
            {
                textBox2.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(numericUpDown1.Value.ToString());
            Int64 price = Int64.Parse(textBox2.Text);
            textBox3.Text = (quan * price).ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text != "0" && textBox3.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[2].Value = numericUpDown1.Value;
                dataGridView1.Rows[n].Cells[3].Value = textBox3.Text;

                total += int.Parse(textBox3.Text);
                label6.Text = "TAKA. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            label6.Text = "TAKA. " + total;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String Category = comboBox1.Text;
            query = "select Item_Name from logpp where Category = '" + Category + "'and Item_Name like '" + textBox4.Text + "%'";
            DataSet ds = fn.getdata(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }
    }
}
