using System.Media;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        //wav
        int pipeSpeed = 5;
        int gravity = 10;
        int score = 0;
        bool isPressed = false;
        bool isPause = false;
        SoundPlayer swooshingSound;
        SoundPlayer pointSound;
        SoundPlayer dieSound;
        public Form1()
        {
            InitializeComponent();

            string swooshingFilePath = "Sounds/sfx_swooshing.wav";
            string pointFilePath = "Sounds/sfx_point.wav";
            string dieFilePath = "Sounds/sfx_die.wav";

            swooshingSound = new SoundPlayer(swooshingFilePath);
            pointSound= new SoundPlayer(pointFilePath);
            dieSound = new SoundPlayer(dieFilePath);
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
                pointSound.Play();
                score++;
                pbPipeUp.Left = Width;
            }
            if (pbPipeDown.Left + pbPipeDown.Width < 0)
            {
                pointSound.Play();
                score++;
                pbPipeDown.Left = Width;
            }

            if (pbBird.Bounds.IntersectsWith(pbPipeUp.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbPipeDown.Bounds)||
                pbBird.Bounds.IntersectsWith(pbGround.Bounds)|| pbBird.Top < -25)
            {
                GameOver();
            }


        }
        private void GameOver()
        {
            timer1.Stop();
            lGameOver.Visible = true;
            dieSound.Play();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                isPressed= true;
                gravity = -10;
                swooshingSound.Play();
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (!isPause)
                {
                    isPause = true;
                    timer1.Stop();
                    //lStartText.Visible = true;
                    //lStartText.Text = "Your game is paused";
                }
                else
                {
                    isPause = false;
                    timer1.Start();
                    //lStartText.Visible = false;
                }
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