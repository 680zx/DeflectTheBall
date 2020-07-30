using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeflectTheBall
{
    class Game
    {
        private int SpeedDif = 2; // the smaller the value - the ball is faster
        private int MovesCounter = 0;

        Ball ball;
        Platform platform;
        List<Block> blocks;

        public Game()
        {
            Console.Clear();
            Window.GameplayScreen();

            Ball.ScoreCounter = 0;

            platform = new Platform();
            ball = new Ball(1, 1);
            blocks = new List<Block>()
            {
                new Block(Window.Width / 2 - 1, 4),

                new Block(Window.Width / 2 - 3, 5),
                new Block(Window.Width / 2 + 1, 5),

                new Block(Window.Width / 2 - 5, 6),
                new Block(Window.Width / 2 - 1, 6),
                new Block(Window.Width / 2 + 3, 6),
                
                new Block(Window.Width / 2 - 7, 7),
                new Block(Window.Width / 2 - 3, 7),
                new Block(Window.Width / 2 + 1, 7),
                new Block(Window.Width / 2 + 5, 7),
                
                new Block(Window.Width / 2 - 9, 8),
                new Block(Window.Width / 2 - 5, 8),
                new Block(Window.Width / 2 - 1, 8),
                new Block(Window.Width / 2 + 3, 8),
                new Block(Window.Width / 2 + 7, 8),
            };
        }

        public void Run()
        {       
            while (!isOver())
            {
                
                //MovesCounter is used to slow down the movement
                //of the ball in relation to the movement of the platform
                if (MovesCounter == SpeedDif)
                {

                    ball.Move(platform, blocks);
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
            Thread.Sleep(1000);

        }

        public static int GetDifficultyLevel()
        {
            return 1;
        }

        private bool isOver()
        {
            if (ball.Y == Window.Height - 2)
            {
                Window.GameOverScreen();
                return true;
            }              
            else if (Ball.ScoreCounter == 15)
            {
                Window.WinnerScreen();
                return true;
            }
            return false;
        }
    }
}