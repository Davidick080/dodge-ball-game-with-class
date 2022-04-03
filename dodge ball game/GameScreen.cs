using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// work on list 
// 1st provblem figure out how to declare objects with the mouse key's 
namespace dodge_ball_game
{
    public partial class GameScreen : UserControl
    {
        Ball ball;
  
        Player hero;

        public static int lives, difficuly;
        public int score = 0;

        List<Ball> ballList = new List<Ball>();

       
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
            InitializeGame();
        }
        public void InitializeGame()
        {
            screenSize = new Size(this.Width, this.Height);
           //ero = new Player(x, y);
           //all= new Ball(x, y, 8, 8);
        }
            private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            scoreLabel.Text = $"{score}";
            livesLabel.Text = $"{lives}";
            //Graphics.FillEllipse(Brushes.Green,ball.x, ball.y, ball.size, ball.size);
          //foreach (Ball b in ballList)
         // {
           //   e.Graphics.FillEllipse(Brushes.Red, b.x, b.y, b.size, b.size);
         // }

         // e.Graphics.FillRectangle(Brushes.DodgerBlue, hero.x, hero.y, hero.width, hero.height);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
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

         


            Refresh();
        }
    }
}