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

        ConsoleKeyInfo UserChoice;

        Ball ball;
        Platform platform;

        public Game()
        {
            Window.ScreenWidth = 61;
            Window.ScreenHeight = 20;
            platform = new Platform();
            ball = new Ball(1, 1);
            Window.Create();
        }

        public void Menu()
        {
            Window.ShowMenu();
            Console.SetCursorPosition(Window.ScreenWidth / 2 - 4, 12);
            Console.Write("Your input: "); 
            //UserChoice = Console.ReadKey();
        }

        private void Play()
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

        

        public void Run()
        {
            //Menu();
            Play();
            
        }
        
        public bool isOver()
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
