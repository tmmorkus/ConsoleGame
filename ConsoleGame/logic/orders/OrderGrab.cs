using ConsoleGame.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleGame.logic.orders
{
    class OrderGrab : IOrder
    {
        private Inventory inventory;
        private GamePlan plan;
        public string Name { get; private set; }

        public OrderGrab(Inventory inventory, GamePlan plan)
        {
            Name = "seber";
            this.inventory = inventory;
            this.plan = plan; 
        }

        public string followOrder(string[] parameters)
        {
                if (parameters.Count() == 0)
                {

                    return "Co mám sebrat? Musíš zadat jméno věci";
                }

                string thingName = parameters[0];

                Space actualSpace = plan.ActualSpace;
                
                
                
                
                
                if (!actualSpace.Things.ContainsKey(thingName))
                {
                    return "Tato věc tu není!";
                }
                else
                {
                    Thing thing = actualSpace.Things[thingName]; 
                    if (thing.IsMovable)
                    {
                        if (inventory.addItem(thing))
                        {
                            inventory.addItem(thing);
                            actualSpace.deleteThing(thingName);
                            return String.Format("Sebral si {0}.", thing.Name);
                        }
                        else
                        {

                            actualSpace.addThing(thing);
                            return "Kapacita inventáře byla vyčerpána. Nemáš hlad?";
                        }
                    }
                    else
                    {
                        actualSpace.addThing(thing);
                        return "Věc je příliš těžká. Nemůžeš ji sebrat.";
                    }

                }
            }
        }
   }
