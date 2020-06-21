using ConsoleGame.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.logic.orders
{
    class OrderInventory:IOrder
    {


        public string Name { get; private set; }
        private Inventory inventory;

        public OrderInventory(Inventory inventory)
        {
            Name = "inventar";
            this.inventory = inventory;
        }


      
        public string followOrder(string [] parametters)
        {
            return inventory.ToString();
        }
    }
}
