using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kassbrick
{
    public partial class Game : Form
    {
        bool goRight;
        bool goLeft;
        bool isInit;
        bool isGameOver;

        int score;
        int ballX;
        int ballY;
        int playerSpeed;

        Random random = new Random();
        PictureBox[] blocks;

        public Game()
        {
            isInit = true;
            InitializeComponent();
        }

        private void initGame()
        {
            isGameOver = false;
            score = 0;
            ballX = 5;
            ballY = 5;
            playerSpeed = 12;
            labelS.Text = "Ton Score Est : " + score;

            ball.Left = 376;
            ball.Top = 328;

            player.Left = 347;

            timer1.Start();

            // creation des blocks de couleurs differentes.
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                }
            }
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            timer1.Stop();
            labelS.Text = "Score: " + score + " " + message;
        }

        private void initBlocks()
        {
            blocks = new PictureBox[15];
            // creation d'un tableau de Pbox afin d'avoir des briques à casser.
            int col = 0;
            int top = 50;
            int left = 100;

            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new PictureBox();
                blocks[i].Height = 32;
                blocks[i].Width = 100;
                blocks[i].Tag = "blocks";
                blocks[i].BackColor = Color.White;

                if (col == 5)
                {
                    top += 50;
                    left = 100;
                    col = 0;
                }

                if (col < 5)
                {
                    col++;
                    blocks[i].Left = left;
                    blocks[i].Top = top;
                    this.Controls.Add(blocks[i]);
                    left = left + 130;
                }
            }
            initGame();
        }

        private void removeBlocks()
        {
            foreach (PictureBox x in blocks)
            {
                this.Controls.Remove(x);
            }
        }

        private void timerEvent(object sender, EventArgs e)
        {
            labelS.Text = "Score : " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Left < 700)
            {
                player.Left += playerSpeed;
            }

            ball.Left += ballX;
            ball.Top += ballY;

            // creation de la trajectoire de la balle.
            if (ball.Left < 0 || ball.Left > 775)
            {
                ballX = -ballX;
            }
            if (ball.Top < 0)
            {
                ballY = -ballY;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                ball.Top = 463;

                ballY = random.Next(5, 12) * -1;

                if (ballX < 0)
                {
                    ballX = random.Next(5, 12) * -1;
                }
                else
                {
                    ballX = random.Next(5, 12);
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                        ballY = -ballY;

                        this.Controls.Remove(x);
                    }
                }
            }
            // cas de victoire et de defaite
            if (score == 15)
            {
                gameOver("T'as gagné le frère !");
            }

            if (ball.Bottom > 580)
            {
                gameOver("tie nul le sang ....");
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
            // on fait deplacer la picturebox player
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            // la partie demarre quand le joueur est pret ( appui sur une touche )
            if (isInit)
            {
                initBlocks();
                isInit = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeBlocks();
                initBlocks();
            }
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }
        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void labelS_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

