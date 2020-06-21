using ConsoleGame.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.logic.orders
{
    class OrderFight : IOrder
    {
        public string Name { get; private set; }

        private Health health;
        private GamePlan plan;
        private Game game;
        private Inventory inventory;
        private Random random;


        public OrderFight(GamePlan plan, Inventory inventory, Health health, Game game)
        {
            Name = "bojuj";
            this.random = new Random();
            this.inventory = inventory;
            this.health = health;
            this.plan = plan;
            this.game = game;

        }


        public string followOrder(string[] parameters)
        {
            if (!(plan.ActualSpace.Name == "doupe"))
            {
                return "Zde není s čím bojovat";
            }
            else if (!(inventory.InventoryDic.ContainsKey("kyj")))
            {
                return "Nemáš žádnou zbraň";
            }


            int nahodneCislo = random.Next(1, health.Status + 1);
            game.EndOfGame = true;
            if (nahodneCislo <= 2)
            {
                return "Bohužel jsi neměl příliš štěstní. Tygr šavlozubý tě rozsápal na kusy.";
            }
            else
            {
                return "Pokořil jsi tygra šavlozubého. Hrdě se můžeš nazvat mužem.";
            }
        }
    }
}
