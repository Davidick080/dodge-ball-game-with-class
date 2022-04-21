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

       public Player hero;
   
       
        public static int lives = 3;

        List<Ball> ballList = new List<Ball>();
        Random randGen = new Random();


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
            int x = 100;
            int y = 100;
         hero = new Player(x, y);
            int xBall = randGen.Next(40, screenSize.Width + 100);
            ball = new Ball(xBall, y, 50, 68);
            for (int i = 0; i < 10; i++)
            {
                NewBall();
            }
        }
        public void NewBall()
        {
            int xBall = randGen.Next(40, screenSize.Width + 100);
            int yBall = 0;
            Ball b = new Ball(xBall, yBall, 8, 8);
            ballList.Add(b);
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            livesLabel.Text = $"{lives}";
            e.Graphics.FillRectangle(Brushes.DodgerBlue, hero.x, hero.y, hero.width, hero.height);


            foreach (Ball b in ballList)
            {
                e.Graphics.FillEllipse(Brushes.Green, b.x, b.y, b.size, b.size);
            }

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
            ball.Move(screenSize);

            if ( hero.x > screenSize.Width -50 || hero.x==screenSize.Width)
            {
                gameTimer.Enabled = false;
                Form1.ChangeScreen(this, new UserControl1());
            }

            foreach (Ball b in ballList)
            {
                b.Move(screenSize);
            }
            foreach (Ball b in ballList)
            {
                if (b.Collision(hero))
                {
                   lives--;
                   hero.x= 100;
                    if (lives == 0)
                    {
                        gameTimer.Enabled = false; 
                        Form1.ChangeScreen(this, new GameOverScreen());
                    }
                   
      
                }
            }
            Refresh();
        }

      
    }
}
            
