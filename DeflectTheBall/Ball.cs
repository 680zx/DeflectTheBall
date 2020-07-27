using System;
using System.Collections.Generic;
using System.Text;

namespace DeflectTheBall
{
    class Ball
    {
        Random rand = new Random();
        
        private int _x, _y;
        private int _vx, _vy;
        private int ScreenWidth, ScreenHeight;


        public void InitializePosition()
        {
            _x = rand.Next(1, ScreenWidth);
            _y = rand.Next(1, 5);
        }

        public void Move()
        {
            _x += _vx;
            _y += _vy;
            //if (_x == ScreenWidth || _x == 1) { _vx = -_vx; }
            //if (Collision() || _y == 1) { _vy = -_vy; }
            //if (_y == ScreenHeight) { GameOver(); isGameOver = true; }
            //if (Collision() || _y == 1) { _vy = -_vy; }
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine("*");
        }

        public void Erase()
        {
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(" ");
        }
    }
}
