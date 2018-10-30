using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Author11 : Form
    {
        public Author11()
        {
            InitializeComponent();
        }

        private void Author11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            label9.Text = textBox2.Text;

            label5.Text = (int.Parse(label2.Text) + int.Parse(label9.Text)).ToString();
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        
        
             
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            label4.Text = textBox2.Text;

            label8.Text = (int.Parse(label6.Text) - int.Parse(label4.Text)).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label13.Text = textBox1.Text;
            label14.Text = textBox2.Text;

            label12.Text = (int.Parse(label13.Text) * int.Parse(label14.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label17.Text = textBox1.Text;
            label18.Text = textBox2.Text;

            label16.Text = (int.Parse(label17.Text) / int.Parse(label18.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label21.Text = textBox1.Text;
            label22.Text = textBox2.Text;

            label20.Text = (int.Parse(label21.Text) % int.Parse(label22.Text)).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
