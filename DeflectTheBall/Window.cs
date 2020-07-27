﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DeflectTheBall
{
    static class Window
    {
        public static int ScreenWidth, ScreenHeight;

        public static void Create()
        {
            Console.WindowHeight = ScreenHeight + 2;
            Console.WindowWidth = ScreenWidth + 2;
            Console.CursorVisible = false;
            CreateFrame();
        }

        private static void CreateFrame()
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

        public static void GameOverScreen()
        {
            string msg = "Game Over";
            Console.Clear();
            Console.SetCursorPosition((ScreenWidth - msg.Length) / 2, ScreenHeight / 2);
            Console.WriteLine(msg);
        }
    }
}