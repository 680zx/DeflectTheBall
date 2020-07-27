using System;
using System.Collections.Generic;
using System.Text;

namespace DeflectTheBall
{
    class Platform
    {
        private int[] platformX = new int[3];
        private int platformY;
        private int platformVelocity = 0;

        public int[] X => platformX;
        public int Y => platformY;

        public Platform()
        {
            platformY = (Window.ScreenHeight) - 2;
            platformX[0] = Window.ScreenWidth / 2 - 1;
            platformX[1] = Window.ScreenWidth / 2;
            platformX[2] = Window.ScreenWidth / 2 + 1;
        }

        public void Draw()
        {
            foreach (int value in platformX)
            {
                Console.SetCursorPosition(value, platformY);
                Console.WriteLine("-");
            }
        }

        public void Erase()
        {
            foreach (int value in platformX)
            {
                Console.SetCursorPosition(value, platformY);
                Console.WriteLine(" ");
            }
        }

        public void MoveLeftRight()
        {
            platformX[0] += platformVelocity;
            platformX[1] += platformVelocity;
            platformX[2] += platformVelocity;

            if (platformX[0] - 1 == 0) { platformVelocity = -platformVelocity; }
            if (platformX[2] + 2 == Window.ScreenWidth + 1) { platformVelocity = -platformVelocity; }
        }

        public void Move()
        {
            if (Console.KeyAvailable)
            {
                var UserInput = Console.ReadKey();
                if (UserInput.Key.ToString() == "LeftArrow" && platformX[0] - 1 != 0)
                    platformVelocity = -2;
                else if (UserInput.Key.ToString() == "RightArrow" && platformX[2] + 2 < Window.ScreenWidth + 1)
                    platformVelocity = 2;
            }
            else
                platformVelocity = 0;

            platformX[0] += platformVelocity;
            platformX[1] += platformVelocity;
            platformX[2] += platformVelocity;
        }
    }
}
