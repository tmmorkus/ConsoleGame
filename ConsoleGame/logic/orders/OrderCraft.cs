using ConsoleGame.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleGame.logic.orders
{
    class OrderCraft : IOrder
    {
        public string Name { get; private set; }
        private Inventory inventory; 

        public OrderCraft(Inventory inventory)
        {
            Name = "vyrob";
            this.inventory = inventory; 
        }

        public string followOrder(string[] parameters)
        {
            string[] material = {"lyko", "topurek", "kamen" };
            if (this.areThingsIngventory(material))
            {
                foreach (string itemName in material)
                {
                    inventory.deleteThing(itemName); 
                }

                Thing club = new Thing("kyj", true, false);
                inventory.addItem(club);
                return String.Format("{0} byl vyroben",club.Name);
            }
            else
            {
                return "Chybí ti potřebné věci!!";
            }
            

        }

        private bool areThingsIngventory(string [] things)
        {
            foreach (string thing in things)
            {
                if (this.inventory.InventoryDic.ContainsKey(thing))
                {
                  //  return false; 
                }
            }
            return true;
        }
    }
}
