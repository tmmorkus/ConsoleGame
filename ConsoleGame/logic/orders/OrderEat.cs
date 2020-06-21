using ConsoleGame.interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;


namespace ConsoleGame.logic.orders
{
    class OrderEat : IOrder
    {
        public string Name { get; private set; }
        private Inventory inventory;
        private Health health;

        public OrderEat(Inventory inventory, Health health)
        {
            Name = "snez";
            this.inventory = inventory;
            this.health = health;

        }

        public string followOrder(string[] parameters)
        {
            if (parameters.Count() == 0)
            {
                return "Co mám sníst? Musíš zadat název pochutiny";
            }
            
            string foodName = parameters[0];
            Thing food = inventory.getThingByName(foodName);
            if (food != null)
            {
                if (food.IsEatable)
                {
                    inventory.deleteThing(foodName);
                    health.AddHealth(1);
                    return "Snědl jsi: " + foodName;

                }
                else
                {
                    return "Tato věc není k jídlu";
                }

            }
            else
            {
                return "Toto není ve tvém inventáři";
            }
        }
    }
}
