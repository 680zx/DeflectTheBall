using System;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace DeflectTheBall
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //game.Run();
            Window.ScreenHeight = 20;
            Window.ScreenWidth = 41;
            
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
                        isContinue = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}