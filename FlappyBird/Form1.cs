namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 5;
        int gravity = 10;
        int score = 0;
        bool isPressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbPipeUp.Left -= pipeSpeed;
            pbPipeDown.Left -= pipeSpeed;
            //pbBird.Location = new Point(pbBird.Location.X, pbBird.Location.Y + gravity);
            if (pbBird.Top+pbBird.Height < pbGround.Top|| isPressed)
            {
                pbBird.Top += gravity;
            }

            if (pbPipeUp.Left + pbPipeUp.Width < 0)
            {
                pbPipeUp.Left = Width;
            }
            if (pbPipeDown.Left + pbPipeDown.Width < 0)
            {
                pbPipeDown.Left = Width;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                isPressed= true;
                gravity = -10;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                isPressed= false;
                gravity = 10;
            }
        }
    }
}