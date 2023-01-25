namespace Les25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Path
            //windows
            string path1 = @"C:\user\max\Documents\data.txt";
            string path2 = "C:\\user\\max\\Documents\\data.txt";
            //MacOS/Linux
            string path3 = "user/max/Documents/data.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string filename = "file.txt";
            //File.Create(filename).Close();
            //File.Create(filename).Dispose();
            //if (File.Exists(filename))
            //{
            //    File.Delete(filename);
            //}else
            //{
            //    MessageBox.Show("File is not exists!");
            //}
            //Move
            //Copy

            File.Create(textBox2.Text).Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.UserName); 
            //MessageBox.Show(Environment.SystemDirectory);

            string path1 = "path1";
            string path2 = "path2";

            //MessageBox.Show(Path.Combine(path1, path2));

            textBox1.Text = $"word1{Environment.NewLine}word2";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(textBox2.Text, richTextBox1.Text);
        }
    }
}
