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

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public Ball(int vx, int vy)
        {
            InitializePosition();
            _vx = vx;
            _vy = vy;
        }

        private void InitializePosition()
        {
            _x = rand.Next(1, Window.ScreenWidth);
            _y = rand.Next(1, 5);
        }

        public void Move(int[] platX, int platY)
        {
            _x += _vx;
            _y += _vy;
            if (_x == Window.ScreenWidth || _x == 1) { _vx = -_vx; }
            //if (_y == Window.ScreenHeight || _y == 1) { _vy = -_vy; }
            if (Collision(platX, platY) || _y == 1) { _vy = -_vy; }
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

        public bool Collision(int[] platformX, int platformY)
        {
            if ((_x == platformX[0] || _x == platformX[1] || _x == platformX[2]) && _y == platformY)
            {
                //Console.Beep();
                return true;
            }
            else
                return false;
        }
    }
}
