using ConsoleGame.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.logic.orders
{
    class OrderHelp : IOrder
    {
        public string Name { get; set; }

        private Commands commands; 

        public OrderHelp(Commands commands)
        {
            Name = "napoveda";
            this.commands = commands;
        }

        public string followOrder(string[] parameters)
        {
            return "Můžeš zadat tyto příkazy:\n"
            + commands.getAllCommands();
        }

    }
}
