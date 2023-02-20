namespace Les28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            points = new Point[counter+1];
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            counter = 4;
            label1.Text = $"Count: {counter}";

            Graphics graphics = picture.CreateGraphics();

            graphics.Clear(Color.White);
        }

        private int counter = 4;
        private Point[] points;
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            var g = picture.CreateGraphics();
            if (counter != 0)
            {
                label1.Text = $"Count: {counter}";
                var pen = new Pen(Color.Blue, 10);
                var brush = new SolidBrush(Color.Aqua);

                int w = 50, h = 50;

                Rectangle rect = new Rectangle(e.X - w / 2, e.Y - h / 2, w, h);

                g.DrawRectangle(pen, rect);
                g.FillRectangle(brush, rect);
                g.DrawEllipse(new Pen(Color.Orange, 10), rect);

                points[counter--] = new Point(e.X, e.Y);
            }
            else
            {
                points[0] = points[points.Length - 1];
                g.DrawPolygon(new Pen(Color.Orange, 5), points);
                g.FillPolygon(new SolidBrush(Color.DarkGreen), points);
            }


        }
    }
}