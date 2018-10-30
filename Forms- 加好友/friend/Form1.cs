using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace friend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                if (female.Checked == true || male.Checked == true)
                {
                    DialogResult checkAdd = MessageBox.Show("您確定要添加此好友嗎?", "添加好友確認", MessageBoxButtons.YesNo);

                    if (checkAdd == DialogResult.Yes)
                    {
                        StreamWriter outputFile;
                        outputFile = File.AppendText("Friend.txt");
                        if (female.Checked == true)
                        {
                            outputFile.WriteLine(name.Text + "--female--" + birthday.Value.ToShortDateString());
                        }
                        else if (male.Checked == true)
                        {
                            outputFile.WriteLine(name.Text + "--male--" + birthday.Value.ToShortDateString());
                        }
                        outputFile.Close();

                        MessageBox.Show("成功添加好友 ");
                        name.Text = "";
                        male.Checked = false;
                        female.Checked = false;
                        birthday.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                        name.Focus();
                    }
                    else
                    {
                        MessageBox.Show("取消添加好友");
                        name.Text = "";
                        male.Checked = false;
                        female.Checked = false;
                        birthday.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                        name.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("請選擇性別");
                }
            }
            else
            {
                MessageBox.Show("請輸入姓名");
                name.Focus();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
