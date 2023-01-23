using System.IO;

namespace Les23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives();

            foreach(var drive in drives)
            {
                richTextBox1.AppendText($"{drive.Name}\n");
                richTextBox1.AppendText($"{drive.DriveType}\n");
                //richTextBox1.AppendText($"Is ready: {drive.IsReady}\n");
                double totalSize = drive.TotalSize / Math.Pow(1024, 3);
                richTextBox1.AppendText($"Total size: {totalSize:0.000}\n");
                double totalFreeSize = drive.TotalFreeSpace/ Math.Pow(1024, 3);
                richTextBox1.AppendText($"Free size: {totalFreeSize:0.0}\n");
                richTextBox1.AppendText($"Label: {drive.VolumeLabel}\n");
                richTextBox1.AppendText("------\n");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            DriveInfo drive = DriveInfo.GetDrives()[0];

            label1.Text = $"Name: {drive.Name}\n" +
                          $"Label: {drive.VolumeLabel}";

            progressBar1.Maximum = (int)(drive.TotalSize / Math.Pow(1024, 3));
            progressBar1.Value = (int)((drive.TotalSize - drive.TotalFreeSpace) / Math.Pow(1024, 3));

            progressBar2.Maximum = (int)(drive.TotalSize / Math.Pow(1024, 3));
            progressBar2.Value = (int)(drive.TotalFreeSpace / Math.Pow(1024, 3));

        }
    }
}
//8bit -> 1 byte
//1024 byte -> 1Kbyte
//1024Kbyte -> 1 MByte(1024^2byte)
//1024Mbyte -> 1 GByte(1024^3 byte)
//1024Gbyte -> 1 TByte(1024^4 byte)