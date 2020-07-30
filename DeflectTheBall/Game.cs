using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeflectTheBall
{
    class Game
    {
        private static int SpeedDif = 3; // the smaller the value - the ball is faster
        public static int ScoreMultiplier = 1;
        public static int ScoreCounter = 0;
        private int MovesCounter = 0;
        

        Ball ball;
        Platform platform;
        List<Block> blocks;

        public Game()
        {
            Console.Clear();
            Window.GameplayScreen();

            ScoreCounter = 0;

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
                Console.Write(ScoreCounter);
            }
            Thread.Sleep(1000);
        }

        public static void SetDifficultyLevel(string gameLevel)
        {
            switch (gameLevel)
            {
                case "D1":
                    SpeedDif = 5;
                    ScoreMultiplier = 1;
                    break;
                case "D2":
                    SpeedDif = 3;
                    ScoreMultiplier = 2;
                    break;
                case "D3":
                    SpeedDif = 1;
                    ScoreMultiplier = 3;
                    break;
                default:
                    break;
            }
        }

        private bool isOver()
        {
            if (ball.Y == Window.Height - 2)
            {
                Window.GameOverScreen();
                return true;
            }              
            else if (ScoreCounter == (15 * ScoreMultiplier))
            {
                Window.WinnerScreen();
                return true;
            }
            return false;
        }
    }
}