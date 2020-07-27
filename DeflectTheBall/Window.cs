using System;
using System.Collections.Generic;
using System.Text;

namespace DeflectTheBall
{
    class Window
    {
        public static int ScreenWidth, ScreenHeight;
        public void CreateWindow()
        {
            Console.WindowHeight = ScreenHeight + 2;
            Console.WindowWidth = ScreenWidth + 2;
            Console.CursorVisible = false;
            //CreatePlatform();
            CreateFrame();
        }

        private void CreateFrame()
        {
            for (int i = 0; i <= ScreenWidth + 1; i++)
            {
                for (int j = 0; j <= ScreenHeight + 1; j++)
                {
                    if (i == 0 || j == 0 || i == ScreenWidth + 1 || j == ScreenHeight + 1)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("o");
                    }
                }
            }
        }

        private void GameOverScreen()
        {
            string msg = "Game Over";
            Console.Clear();
            Console.SetCursorPosition((ScreenWidth - msg.Length) / 2, ScreenHeight / 2);
            Console.WriteLine(msg);
        }
    }
}
