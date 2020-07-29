using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeflectTheBall
{
    static class Window
    {
        public static int ScreenWidth, ScreenHeight;

        public static void GameMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(ScreenWidth / 2 - 4, 2);
            Console.Write("REFLECT THE BALL" +
                "\n\n\tMenu:" +
                "\n\t1) Play" +
                "\n\t2) Scores" +
                "\n\t3) Exit\n\n");
            Create();
        }
        public static void GameScreen()
        {
            CreateFrame();
        }

        public static void ScoresScreen()
        {
            Console.Clear();
            Create();
            Console.SetCursorPosition(ScreenWidth / 2 - 4, 2);

            do
            {
                Console.Write("SCORES" +
                "\n\t1) Player1\t100" +
                "\n\t2) Player2\t 89" +
                "\n\n\tTo exit press Escape");
                Create();
            }
            while (Console.ReadKey().Key.ToString() != "Escape");
            
                    
        }

        public static void GameOverScreen()
        {
            string msg = "Game Over";
            Console.Clear();
            Console.SetCursorPosition((ScreenWidth - msg.Length) / 2, ScreenHeight / 2);
            Console.WriteLine(msg);
            
        }

        private static void Create()
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

        
    }
}
