using ConsoleGame.logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.ui
{
    class UI
    {
        private Game game;
        public UI(Game game)
        {
            Console.Outpu­tEncoding = En­coding.UTF8;
            this.game = game; 
        }

        public void play()
        {
            Console.Write(game.getWelcome());
            while (!game.isEnd())
            {
                string line = Console.ReadLine();
                Console.WriteLine(game.processOrder(line));
            }
            Console.WriteLine(game.getEpiloge());
            Console.ReadLine();
        }

    }
}
