using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les24
{
    public partial class ManagerDir : Form
    {
        public ManagerDir()
        {
            InitializeComponent();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;

            for (int i = 0; i < n; i++)
            {
                Directory.CreateDirectory($"{tbCreate.Text}{i + 1}");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            var dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
            foreach (var dir in dirs)
            {
                if (dir/*.Substring(dir.LastIndexOf("\\"))*/.Contains(tbDelete.Text))
                {
                    Directory.Delete(dir);
                }
            }

        }
    }
}
