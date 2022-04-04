using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodge_ball_game
{
    public partial class GameScreen : UserControl
    {
       // Ball chaseBall;
        Player hero;

        public static int lives, difficuly;
        public static int score = 0;

        List<Ball> dodgeBalls = new List<Ball>();

       
        Size screenSize;

        public static int gsWidth = 600;
        public static int gsHeight = 600;

        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        public GameScreen()
        {
            InitializeComponent();
            GameStart();
        }

        public void GameStart()
        {
            hero = new Player(100, 100);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, hero.x, hero.y, hero.width, hero.height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (leftArrowDown == true)
            {
                hero.Move("left", screenSize);
            }

            if (rightArrowDown == true)
            {
                hero.Move("right", screenSize);
            }

            if (upArrowDown == true)
            {
                hero.Move("up", screenSize);
            }

            if (downArrowDown == true)
            {
                hero.Move("down", screenSize);
            }


            // chaseBall.Move(screenSize);

            //foreach (Ball b in dodgeBalls)
            //{
            //    b.Move(screenSize);
            //}

            //if (chaseBall.Collision(hero))
            //{
            //    score++;
            //    NewBall();
            //}

            //foreach (Ball b in dodgeBalls)
            //{
            //    if (b.Collision(hero))
            //    {
            //        lives--;

            //        if (lives == 0)
            //        {
            //            timer1.Enabled = false;
            //            Form1.ChangeScreen(this, new ());
            //        }
            //    }
            //}
            Rectangle ballRec = new Rectangle();

            Refresh();
        }
    }
}