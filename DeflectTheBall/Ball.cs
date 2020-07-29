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

        public static int ScoreCounter;

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

        public void Move(int[] platX, int platY, Block block)
        {
            _x += _vx;
            _y += _vy;
            if (_x == Window.ScreenWidth || _x == 1) { _vx = -_vx; }
            //if (_y == Window.ScreenHeight || _y == 1) { _vy = -_vy; }
            if (CollisionPlatform(platX, platY) || _y == 1 || CollisionBlock(block)) { _vy = -_vy; }
        }
        private bool CollisionPlatform(int[] xCoord, int yCoord)
        {
            if ((_x == xCoord[0] || _x == xCoord[1] || _x == xCoord[2]) && _y == yCoord)
            {
                return true;
            }
            else
                return false;
        }
        private bool CollisionBlock(Block block)
        {
            if ((_x == block.X[0] || _x == block.X[1] || _x == block.X[2]) && _y == block.Y)
            {
                block.Destroy();
                ScoreCounter++;
                //Console.Beep();
                return true;
            }
            else
                return false;
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
