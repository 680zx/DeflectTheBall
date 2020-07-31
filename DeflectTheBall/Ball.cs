using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            InitializeStartPosition();
            _vx = vx;
            _vy = vy;
        }

        private void InitializeStartPosition()
        {
            _x = rand.Next(1, Window.Width - 2);
            _y = rand.Next(5, 8);
        }

        public void Move(Platform platform, List<Block> blocks)
        {
            _x += _vx;
            _y += _vy;
            if (_x == Window.Width - 2 || _x == 1) { _vx = -_vx; }
            if (CollisionPlatform(platform) || _y == 1 || CollisionBlock(blocks)) { _vy = -_vy; }
        }

        private bool CollisionPlatform(Platform platfrom)
        {
            if ((_x == platfrom.X[0] || _x == platfrom.X[1] || _x == platfrom.X[2]) && _y == platfrom.Y)
            {
                return true;
            }
            else
                return false;
        }

        private bool CollisionBlock(List<Block> blocks)
        {
            foreach (Block block in blocks)
            {
                if ((_x == block.X[0] || _x == block.X[1] || _x == block.X[2]) && _y == block.Y)
                {
                    block.Destroy();
                    blocks.Remove(block);
                    Game.ScoreCounter += Game.ScoreMultiplier;
                    return true;
                }
            }
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