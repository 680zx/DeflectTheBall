using System;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace DeflectTheBall
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BallStartPosX = 8;
            const int BallStartPosY = 10;
            const int BallVelocityX = 1;
            const int BallVelocityY = 1;
            const int GameWindowWidth = 59;
            const int GameWindowHeight = 30;

            Game game = new Game(/*BallStartPosX, BallStartPosY,*/ BallVelocityX, BallVelocityY, GameWindowWidth, GameWindowHeight) ;
            
            game.CreateWindow();
            //ball.CreateFrame();

            while (! game.isGameOver)
            {
                game.Run();
                //ball.Show();
            }
            Console.ReadKey();

        }
    }


    /*
    class Game
    {
        Random rand = new Random();

        private int _ScreenWidth;
        private int _ScreenHeight;

        private int _x, _y;
        private int _vx, _vy;

        private int[] platformX = new int[3];
        private int platformY;
        private int platformVelocity = 0;

        public bool isGameOver = false;

        private int SpeedDif = 5;
        private int MovesCounter = 0;

        

        public Game(int x, int y, int vx, int vy, int ScreenWidth, int ScreenHeigth)
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
        
        public void Run()
        {
            
            MoveBall();
            //MovePlatformLeftRight();
            MovePlatform();
            DrawBall();
            DrawPlatform();
            Thread.Sleep(10);
            EraseBall();
            ErasePlatform();
            

            //MovesCounter is used to slow down the movement 
            //of the ball in relation to the movement of the platform
            if (MovesCounter == SpeedDif)
            {
                MoveBall();
                MovePlatform();
                DrawBall();
                DrawPlatform();
                Thread.Sleep(10);
                EraseBall();
                ErasePlatform();
                MovesCounter = 0;
            }
            else
            {
                MovePlatform();
                DrawBall();
                DrawPlatform();
                Thread.Sleep(10);
                EraseBall();
                ErasePlatform();
                MovesCounter++;
            }
        }

        public void CreateWindow()
        {
            Console.WindowHeight = _ScreenHeight + 2;
            Console.WindowWidth = _ScreenWidth + 2;
            Console.CursorVisible = false;
            //CreatePlatform();
            CreateFrame();
        }

        private void CreateFrame()
        {
            for (int i = 0; i <= _ScreenWidth + 1; i++)
            {
                for (int j = 0; j <= _ScreenHeight + 1; j++)
                {
                    if (i == 0 || j == 0 || i == _ScreenWidth + 1 || j == _ScreenHeight + 1)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("o");
                    }
                }
            }
        }

        private void InitializeBallPosition()
        {
            _x = rand.Next(1, _ScreenWidth);
            _y = rand.Next(1, 5);
        }

        private void MoveBall()
        {
            _x += _vx;
            _y += _vy;
            if (_x == _ScreenWidth || _x == 1) { _vx = -_vx; }
            //if (Collision() || _y == 1) { _vy = -_vy; }
            if (_y == _ScreenHeight) { GameOver(); isGameOver = true; }
            if (Collision() || _y == 1) { _vy = -_vy; }
        }

        private void DrawBall()
        {
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine("*");
        }

        private void EraseBall()
        {
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(" ");
        }

        private void DrawPlatform()
        {
            foreach (int value in platformX)
            {
                Console.SetCursorPosition(value, platformY);
                Console.WriteLine("-");
            }
        }

        private void ErasePlatform()
        {
            foreach (int value in platformX)
            {
                Console.SetCursorPosition(value, platformY);
                Console.WriteLine(" ");
            }
        }

        private void MovePlatformLeftRight()
        {
            platformX[0] += platformVelocity;
            platformX[1] += platformVelocity;
            platformX[2] += platformVelocity;

            if (platformX[0] - 1 == 0) { platformVelocity = -platformVelocity; }
            if (platformX[2] + 2 == _ScreenWidth + 1) { platformVelocity = -platformVelocity; }
        }

        private void MovePlatform()
        {
            if (Console.KeyAvailable)
            {
                var UserInput = Console.ReadKey();
                if (UserInput.Key.ToString() == "LeftArrow" && platformX[0] - 1 != 0)
                    platformVelocity = -2;
                else if (UserInput.Key.ToString() == "RightArrow" && platformX[2] + 2 < _ScreenWidth + 1)
                    platformVelocity = 2;
            }
            else
                platformVelocity = 0;

            platformX[0] += platformVelocity;            
            platformX[1] += platformVelocity;            
            platformX[2] += platformVelocity;
        }
        
        private bool Collision()
        {
            //if ((_x == platformX[0] || _x == platformX[1] || _x == platformX[2]) && (_y + 1 == platformY || _y == platformY))
            if ((_x == platformX[0] || _x == platformX[1] || _x == platformX[2]) && _y == platformY)
            { 
                //Console.Beep();
                return true; 
            }    
            else
                return false;
        }

        private void GameOver()
        {
            string msg = "Game Over";
            Console.Clear();
            Console.SetCursorPosition((_ScreenWidth - msg.Length) / 2, _ScreenHeight / 2);
            Console.WriteLine(msg);
        } 

    }
    */
    
}
