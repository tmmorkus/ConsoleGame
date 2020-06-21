using System;
using System.Linq;
using ConsoleGame.logic;
using ConsoleGame.ui;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            UI ui = new UI(game);
            if (args.Count() == 0)
            {
                ui.play();
            }
        }
    }
}
