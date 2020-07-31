using System;
using System.IO;
using System.Diagnostics.SymbolStore;
using System.Threading;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeflectTheBall
{
    class Program
    {
        static string path = Directory.GetCurrentDirectory();
        static string fileName = "UserScores.dat";
        public static Hashtable ScoresTable = null;
        static BinaryFormatter binformatter = new BinaryFormatter();
        //public static string[] textLines;

        static void Main(string[] args)
        {
            /*
            TransformText();
            Console.WriteLine(ExtractNumber(textLines[0]));
            */

            //Thread.Sleep(5000);

            //Console.SetWindowPosition(10, 20);
            Console.CursorVisible = false;
            //game.Run();
            Window.Height = 30;
            Window.Width = 49;
            
            bool isContinue = true;

            while (isContinue)
            {

                Window.GameMenu();

                switch (Console.ReadKey().Key.ToString())
                {
                    case "D1":
                        Game game = new Game();
                        game.Run();
                        break;

                    case "D2":
                        //Console.WriteLine("scores");
                        Window.ScoresScreen();
                        break;

                    case "D3":
                        Window.HelpScreen();
                        break;

                    case "D4":
                        Window.SettingsScreen();
                        Game.SetDifficultyLevel();
                        break;
                    
                    case "D5":
                        isContinue = false;
                        break;        
                }
            }
        }

        private static void GetScores()
        {
            using (var fs = File.Open(Path.Combine(path, fileName), FileMode.Open))
            {
                ScoresTable = (Hashtable)binformatter.Deserialize(fs);
            }
        }

        private static void WriteScores()
        {
            using (var fs = File.Create(Path.Combine(path, fileName)))
            {
                binformatter.Serialize(fs, ScoresTable);
            }
        }

        /*

        private static void TransformText()
        {
            string Text;

            using (StreamReader sr = new StreamReader(Path.Combine(path, fileName)))
            {
                Text = sr.ReadToEnd();
            }

            textLines = Text.Split('\n');
        }

        private static int ExtractNumber(string input)
        {
            string pattern = @"\d";
            string number = "";
            foreach (Match match in Regex.Matches(input, pattern))
            {
                number += match.ToString();
            }
            Console.WriteLine(number);
            return int.Parse(number);
        }

        private static void CreateTable()
        {

        }
        */
    }
}