using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les28
{
    public partial class Animation : Form
    {
        public Animation()
        {
            InitializeComponent();
        }
        Point Point = new Point();
        private void button1_Click(object sender, EventArgs e)
        {
            Point = new Point(100, 400);
            var gr = pictureBox1.CreateGraphics();
            timer1.Start();
            //for (int i = Point.X; i < Point.X+ 500; i++)
            //{
            //    gr.Clear(Color.White);
            //    gr.FillEllipse(new SolidBrush(Color.Blue), i, Point.Y, 50, 50);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            gr.FillEllipse(new SolidBrush(Color.Blue), Point.X+=20, Point.Y, 50, 50);
            if(Point.X > 600)
            {
                timer1.Stop();
            }
        }
    }
}
