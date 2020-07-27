using System;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace DeflectTheBall
{
    class Program
    {

        static void Main(string[] args)
        {
            Window.ScreenHeight = 30;
            Window.ScreenWidth = 61;
            Window.ShowMenu();
            while (Console.ReadKey().Key.ToString() != "D3")
            {
                Console.Clear();
                Game game = new Game();
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
            
            
            //Console.WriteLine(Console.ReadKey().Key.ToString());
        }
    }
}