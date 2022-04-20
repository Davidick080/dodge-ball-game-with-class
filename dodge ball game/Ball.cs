using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dodge_ball_game
{
    public class Ball
    {
        public int size = 20;
        public int xSpeed, ySpeed;
        public int y, x;
       

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void Move(Size screenSize)
        {
            y += ySpeed;

            if (y > screenSize.Height - size || y < 0)
            {
                ySpeed *= -1; ;
            }
          
        }
        public bool Collision(Player p)
        {

            Rectangle ballRec = new Rectangle(x, y, 8, 8);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRec.IntersectsWith(playerRec))
            {
              
                return true;
            }

            return false;
        }
    }
}
          
        
  

        
