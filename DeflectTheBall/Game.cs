using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeflectTheBall
{
    class Game
    {
        /*
        public Game(/int x, int y,/ int vx, int vy, int ScreenWidth, int ScreenHeigth)
        {
            //_x = x;
            //_y = y;
            _x = rand.Next(1, ScreenWidth);
            _y = rand.Next(1, 5);
            _vx = vx;
            _vy = vy;
            _ScreenWidth = ScreenWidth;
            _ScreenHeight = ScreenHeigth;
            platformY = ScreenHeigth - 2;
            platformX[0] = ScreenWidth / 2 - 1;
            platformX[1] = ScreenWidth / 2;
            platformX[2] = ScreenWidth / 2 + 1;
        }
        */
        private int SpeedDif = 5;
        private int MovesCounter = 0;

        Ball ball = new Ball();
        Platform platform = new Platform();

        public Game()
        {
            Window.ScreenWidth = 60;
            Window.ScreenHeight = 20;
        }


        public void Run()
        {  
            //MovesCounter is used to slow down the movement 
            //of the ball in relation to the movement of the platform
            if (MovesCounter == SpeedDif)
            {
                ball.Move();
                platform.Move();
                ball.Draw();
                platform.Draw();
                Thread.Sleep(10);
                ball.Erase();
                platform. Erase();
                MovesCounter = 0;
            }
            else
            {
                platform.Move();
                ball.Draw();
                platform.Draw();
                Thread.Sleep(10);
                ball.Erase();
                platform.Erase();
                MovesCounter++;
            }
        }
    }
}
