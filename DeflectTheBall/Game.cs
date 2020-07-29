using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeflectTheBall
{
    class Game
    {
        private int SpeedDif = 5; // than value is smaller - ball is faster
        private int MovesCounter = 0;

        //ConsoleKeyInfo UserChoice;

        Ball ball;
        Platform platform;
        Block block1;
        public Game()
        {
            //Window.ScreenWidth = 41;
            //Window.ScreenHeight = 40;
            platform = new Platform();
            ball = new Ball(1, 1);
            block1 = new Block(4, 4);
            Block block2 = new Block(8, 4);
            Console.Clear();
            //Window.Create();
            Ball.ScoreCounter = 0;
            Window.GameplayScreen();
            block1.Create();
            block2.Create();
        }

        public void Run()
        {
            while (!isOver())
            {
                //MovesCounter is used to slow down the movement
                //of the ball in relation to the movement of the platform
                if (MovesCounter == SpeedDif)
                {

                    ball.Move(platform.X, platform.Y, block1);
                    platform.Move();
                    ball.Draw();
                    platform.Draw();
                    Thread.Sleep(10);
                    ball.Erase();
                    platform.Erase();
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
                Console.SetCursorPosition(3, 2);
                Console.Write(Ball.ScoreCounter);
            }
            //Window.GameOverScreen();
            Thread.Sleep(1000);

        }

        private bool isOver()
        {
            if (ball.Y == Window.ScreenHeight)
            {
                Window.GameOverScreen();
                //Console.ReadKey();
                return true;
            }              
            else
                return false;
        }
    }
}
