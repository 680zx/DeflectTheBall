﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeflectTheBall
{
    static class Window
    {
        public static int Width, Height;

        public static void GameMenu()
        {
            Console.Clear();

            string header = "REFLECT THE BALL";
            Console.SetCursorPosition((Width - header.Length) / 2, 2);

            Console.Write(header +
                "\n\n\tMenu:" +
                "\n\t1) Play" +
                "\n\t2) Scores" +
                "\n\t3) Help" +
                "\n\t4) Settings" +
                "\n\t5) Exit\n\n");
            CreateScreen();
            //Program.hashtable
        }

        public static void GameplayScreen()
        {
            CreateFrame();
        }

        public static void ScoresScreen()
        {
            Console.Clear();

            string header = "SCORES";
            Console.SetCursorPosition((Width - header.Length) / 2, 2);

            do
            {
                Console.Write(header +
                "\n\n\t1) Player1\t100" +
                "\n\t2) Player2\t 89" +
                "\n\n\tPress Escape button to return" +
                "\n\tto the main menu");
                CreateScreen();
            }
            while (Console.ReadKey().Key.ToString() != "Escape");         
        }
        public static void HelpScreen()
        {
            Console.Clear();

            string header = "HELP";
            Console.SetCursorPosition((Width - header.Length) / 2, 2);

            do
            {
                Console.Write(header +
                "\n\n\tUse Left Arrow and Right Arrow" +
                "\n\tbuttons to control the position" +
                "\n\tof the platform" +
                "\n\n\tPress Escape button to return" +
                "\n\tto the main menu");
                CreateScreen();
            }
            while (Console.ReadKey().Key.ToString() != "Escape");
        }

        public static void SettingsScreen()
        {
            Console.Clear();

            string header = "SETTINGS";
            Console.SetCursorPosition((Width - header.Length) / 2, 2);

            Console.Write(header + "\n\n\tTo choose difficulty, press" +
            "\n\tkey 1 - easy level - x1 bonus" +
            "\n\tkey 2 - medium level - x2 bonus" +
            "\n\tkey 3 - insane level - x3 bonus");
            CreateScreen();    
        }

        public static void GameOverScreen()
        {
            string msg = "Game Over";
            Console.Clear();
            Console.SetCursorPosition((Width - msg.Length) / 2, Height / 2);
            Console.WriteLine(msg);  
        }

        public static void WinnerScreen()
        {
            string msg = "You Win!";
            Console.Clear();
            Console.SetCursorPosition((Width - msg.Length) / 2, Height / 2);
            Console.WriteLine(msg);
        }

        private static void CreateScreen()
        {
            Console.WindowHeight = Height;
            Console.WindowWidth = Width;
            CreateFrame();
        }

        private static void CreateFrame()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (i == 0 || j == 0 || i == Width - 1 || j == Height - 1)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("o");
                    }
                }
            }
        }

        
    }
}