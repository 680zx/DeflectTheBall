using System;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace DeflectTheBall
{
    class Program
    {

        static void Main(string[] args)
        {

            //game.Run();
            Window.ScreenHeight = 40;
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
                //
            }
            /*
            Window.ScreenHeight = 30;
            Window.ScreenWidth = 61;
            Window.ShowMenu();
            while (Console.ReadKey().Key.ToString() != "D3")
            {
                Console.Clear();
                
                //Window.ShowMenu();
                //Thread.Sleep(100);
                while (!game.isOver())
                {
                    game.Run();
                }
                Thread.Sleep(500);
                Console.Clear();
                Window.ShowMenu();
            
            }
            */

            //Console.WriteLine(Console.ReadKey().Key.ToString());
        }
    }
}