using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les18WF
{
    public partial class TextBox : Form
    {
        public TextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(textBox1.Text != string.Empty)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = string.Empty;
            }
            else
            {
                textBox1.Text = textBox2.Text;
                textBox2.Text = string.Empty;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lEx.Text = textBox1.Text.Length.ToString();//$""
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //int res = int.Parse(textBox3.Text) + int.Parse(textBox4.Text);
            int a=0, b=0;
            if (!int.TryParse(textBox3.Text, out a) || 
                !int.TryParse(textBox4.Text, out b))
            {
                MessageBox.Show("error");
                return;
            }

                lResult.Text = $"= {a+b}";
        }
    }
}
