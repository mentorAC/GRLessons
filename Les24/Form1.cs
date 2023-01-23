using System.IO;

namespace Les24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;

            for (int i = 0; i < n; i++)
            {
                Directory.CreateDirectory($"{textBox1.Text}{i+1}");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            var files = Directory.GetFiles(dir);
            foreach ( var file in files )
            {
                richTextBox1.AppendText($"{file.Substring(1+file.LastIndexOf("\\"))}\n");
            }
            //richTextBox1.Text = string.Join("\n", files);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            var dirs = Directory.GetDirectories(curDir);
            //richTextBox2.Text = string.Join("\n", dirs);

            foreach (var dir in dirs)
            {
                richTextBox2.AppendText($"{dir.Substring(1 + dir.LastIndexOf("\\"))}\n");
            }
        }
    }
}
//D:\Work cs\GRLesson\GRLessons\Les24\bin\Debug\net6.0-windows\Les24.exe