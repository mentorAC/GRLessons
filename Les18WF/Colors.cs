using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les18WF
{
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();
        }

        private void ChangeColor()
        {
            button1.BackColor = Color.FromArgb(tbAlpha.Value, tbRad.Value, tbGreen.Value, tbBlue.Value);
            lGreen.Text = $"{tbGreen.Value}";
            lBlue.Text = $"{tbBlue.Value}";
            lRad.Text = $"{tbRad.Value}";
            lAlpha.Text = $"{tbAlpha.Value}";
        }

        private void tbRad_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            ChangeColor();

        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void tbAlpha_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }
    }
}
