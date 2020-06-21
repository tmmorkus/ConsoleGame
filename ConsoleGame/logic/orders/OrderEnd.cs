using ConsoleGame.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleGame.logic.orders
{
    class OrderEnd : IOrder
    {
        public string Name { get; private set; }

        private Game game; 

        public OrderEnd(Game game)
        {
            Name = "skonci";
            this.game = game; 
        }

        public string followOrder(string[] parameters)
        {
            
            if (parameters.Count() > 0)
            {
                return "Ukončit co? Nechápu, proč jste zadal druhé slovo.";
            }
            else
            {
                game.EndOfGame = true; 
                return "Hra ukončena příkazem konec.";
            }
           
        }

    }
}
