using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeflectTheBall
{
    class Game
    {
        private int SpeedDif = 3; // than value is smaller - ball is faster
        private int MovesCounter = 0;

        ConsoleKeyInfo UserChoice;

        Ball ball;
        Platform platform;

        public Game()
        {
            //Window.ScreenWidth = 41;
            //Window.ScreenHeight = 40;
            platform = new Platform();
            ball = new Ball(1, 1);
            Console.Clear();
            //Window.Create();
            Ball.BounceCounter = 0;
            Window.GameScreen();
        }

        public void Run()
        {
            //new Game();
            while (!isOver())
            {
                //MovesCounter is used to slow down the movement
                //of the ball in relation to the movement of the platform
                if (MovesCounter == SpeedDif)
                {
                    ball.Move(platform.X, platform.Y);
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
                Console.Write(Ball.BounceCounter);
            }
            //Window.GameOverScreen();
            Thread.Sleep(1000);

        }

        public void Menu()
        {
            //Window.ShowMenu();
            Console.SetCursorPosition(Window.ScreenWidth / 2 - 4, 12);
            Console.Write("Your input: ");
            while( !isOver())
            {
                Play();
            }
            //UserChoice = Console.ReadKey();
        }

        private void Play()
        {
            while (!isOver())
            {
                //MovesCounter is used to slow down the movement
                //of the ball in relation to the movement of the platform
                if (MovesCounter == SpeedDif)
                {
                    ball.Move(platform.X, platform.Y);
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
            }
            
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
