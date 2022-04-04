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
        public int size = 10;
        public int xSpeed, ySpeed;
        public int x, y;
         List<ballIntergersList> playerInformation = new List<ballIntergersList>();
        // colour, rectangle
        public Ball(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }


        //public bool Collision(Player p)
        //{
        //    Rectangle ballRec = new Rectangle(x, y, size, size);
        //    Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

        //    if (ballRec.IntersectsWith(playerRec))
        //    {
        //        if (y > 0)
        //        {
        //            y = p.y - size;
        //        }
        //        else
        //        {
        //            y = p.y + p.height;
        //        }

        //        ySpeed *= -1;
        //        return true;
        //    }

        //    return false;
        //}
    }
}
        
