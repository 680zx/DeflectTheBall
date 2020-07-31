using System;
using System.Collections.Generic;
using System.Text;

namespace DeflectTheBall
{
    class Platform
    {
        private int[] _x = new int[3];
        private int _y;
        private int platformVelocity = 0;

        public int[] X => _x;
        public int Y => _y;

        public Platform()
        {
            _y = (Window.Height) - 4;
            _x[0] = Window.Width / 2 - 1;
            _x[1] = Window.Width / 2;
            _x[2] = Window.Width / 2 + 1;
        }

        public void Draw()
        {
            foreach (int xCoord in _x)
            {
                Console.SetCursorPosition(xCoord, _y);
                Console.WriteLine("_");
            }
        }

        public void Erase()
        {
            foreach (int value in _x)
            {
                Console.SetCursorPosition(value, _y);
                Console.WriteLine(" ");
            }
        }

        public void MoveLeftRight()
        {
            _x[0] += platformVelocity;
            _x[1] += platformVelocity;
            _x[2] += platformVelocity;

            if (_x[0] - 1 == 0) { platformVelocity = -platformVelocity; }
            if (_x[2] + 2 == Window.Width + 1) { platformVelocity = -platformVelocity; }
        }

        public void Move()
        {
            if (Console.KeyAvailable)
            {
                var UserInput = Console.ReadKey();
                if (UserInput.Key.ToString() == "LeftArrow" && _x[0] - 1 != 0)
                    platformVelocity = -2;
                else if (UserInput.Key.ToString() == "RightArrow" && _x[2] + 2 != Window.Width)
                    platformVelocity = 2;
            }
            else
                platformVelocity = 0;

            _x[0] += platformVelocity;
            _x[1] += platformVelocity;
            _x[2] += platformVelocity;
        }
    }
}