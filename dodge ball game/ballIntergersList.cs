using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodge_ball_game
{
    internal class ballIntergersList
    {
        public int playerSize = 10;
        public int ballSize = 15;
        public int xPlayerSpeed, yPlayerSpeed;
        public int yBallSpeed, xBallSpeed;
        public int xPlayer, yPlayer;
        public int xBall, yBall;

        public ballIntergersList(int _playerX, int _playerY, int _yBall, int _xBall, int _xPlayerSpeed, int _yPlayerSpeed, int _playerSize, int ballSize
       , int _yBallSpeed, int _xBallSpeed,int playerSize,int _ballSize)
        {
            playerSize = _playerSize;
            ballSize = _ballSize;
            xPlayer = _playerX;
            yPlayer = _playerY;
            xBall = _xBall;
            yBall = _yBall;
            xPlayerSpeed = _xPlayerSpeed;
            yPlayerSpeed = _yPlayerSpeed;
            xBallSpeed = _xBallSpeed;
            yBallSpeed = _yBallSpeed;
            

        }
    }

}
