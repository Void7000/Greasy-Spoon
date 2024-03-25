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
    public partial class Customer_Control : Form
    {
     
        public Customer_Control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl3 u3 = new UserControl3();
            Class1.showControl(u3, panel3);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            UserControl4 u4 = new UserControl4();
            Class1.showControl(u4, panel3);
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl4 u4 = new UserControl4();
            Class1.showControl(u4, panel3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserControl6 u6 = new UserControl6();
            Class1.showControl(u6, panel3);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserControl7 u7 = new UserControl7();
            Class1.showControl(u7, panel3);
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UserControl3 u3 = new UserControl3();
            Class1.showControl(u3, panel3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form14 cl = new Form14();
            cl.ShowDialog();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
