using ConsoleGame.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleGame.logic.orders
{
    class OrderMove : IOrder
    {

        public string Name { get; private set; }
        private GamePlan plan;
        private Health health;

        public OrderMove(GamePlan plan, Health health)
        {
            Name = "jdi"; 
            this.plan = plan;
            this.health = health;
        }


        public string followOrder(string[] parameters)
        {

            if (parameters.Count() == 0)
            {
                return "Kam mám jít? Musíš zadat jméno východu";
            }

            string direction = parameters[0];


            Space adjacentSpace = plan.ActualSpace.Exits.Find(space => space.Name == direction);
            if (adjacentSpace == null)
            {
                return "Tam se odsud jít nedá!";
            }
            else
            {
                if (health.Status == 3 && direction == "doupe")
                {
                    return "Nemůžes přeplavat řeku, jsi příliš slabý. Zkus se něčeho najíst." ;
                }
                else
                {
                    plan.ActualSpace = adjacentSpace;
                    return adjacentSpace.getLongDescription();
                }


            }
        } 
    }
}
