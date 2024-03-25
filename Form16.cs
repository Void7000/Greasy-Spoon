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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label3.Text = Form2.usrName;
            label4.Text = Form2.addrss;
            label5.Text = Form2.email;
            label6.Text = Form2.nmbr;
            label7.Text = Form2.pass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            frm14.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            frm14.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
