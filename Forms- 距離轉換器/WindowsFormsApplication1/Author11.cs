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
    //Project :  距離轉換器(Distance Converter)
    //Author : 林紘毅 A107222011
    //Date : 2018.10.22



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

      

        private void button1_Click(object sender, EventArgs e)
        {




            try
            {
                double Distance = double.Parse(textBox1.Text);
                if (Convert.ToString(from.SelectedItem) == " 英吋(Inches)")
                {
                    if (Convert.ToString(to.SelectedItem) == " 英吋(Inches)")
                    {
                        textBox2.Text = Distance.ToString()+ " 英吋(Inches)";
                    }
                    else if (to.SelectedItem == "英呎(Feet)")
                    {
                        textBox2.Text = (Distance / 12).ToString()+ " 英呎(Feet)";
                    }
                    else if (to.SelectedItem == "英碼(Yards)")
                    {
                        textBox2.Text = (Distance / 36).ToString()+ " 英碼(Yards)";
                    }
                }
                else if (from.SelectedItem == "英呎(Feet)")
                {
                    if (to.SelectedItem == "英吋(Inches)")
                    {
                        textBox2.Text = (Distance * 12).ToString()+ " 英吋(Inches)";
                    }
                    else if (to.SelectedItem == "英呎(Feet)")
                    {
                        textBox2.Text = Distance.ToString()+ " 英呎(Feet)";
                    }
                    else if (to.SelectedItem == "英碼(Yards)")
                    {
                        textBox2.Text = (Distance / 3).ToString()+ " 英碼(Yards)";
                    }
                }
                else if (from.SelectedItem == "英碼(Yards)")
                {
                    if (to.SelectedItem == "英吋(Inches)")
                    {
                        textBox2.Text = (Distance * 36).ToString()+" 英吋(Inches)";
                    }
                    else if (to.SelectedItem == "英呎(Feet)")
                    {
                        textBox2.Text = (Distance * 3).ToString()+ " 英呎(Feet)";
                    }
                    else if (to.SelectedItem == "英碼(Yards)")
                    {
                        textBox2.Text = Distance.ToString()+ " 英碼(Yards)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        
        
             
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

 
      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void to_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
