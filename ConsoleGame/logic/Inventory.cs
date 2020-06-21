
using System.Collections.Generic;
using System.Linq;


namespace ConsoleGame.logic
{
    class Inventory
    {
        public Dictionary<string, Thing> InventoryDic { get; private set; }

        public Inventory ()
        {
            InventoryDic = new Dictionary<string,Thing>();
        }

        public bool addItem (Thing thing)
        {
            if (InventoryDic.Count() == 4)
            {
                return false;
            }
            else if (this.getThingByName(thing.Name) != null)
            {
                return false; 
            }
            else
            {
                InventoryDic.Add(thing.Name,thing); 
                return true;
            }
        }

        public bool deleteThing (string name)
        {
            return InventoryDic.Remove(name);
        }

        public Thing getThingByName (string name)
        {
            foreach (string itemName in InventoryDic.Keys)
            {
                if (name == itemName)
                {
                    return InventoryDic[itemName];
                }

            }
           
            return null;
        }

        public override string ToString() 
        {
            string items = "Inventar obsahuje: ";
            if (InventoryDic.Count() == 0)
            {
                items = "Inventář je prázdný";
            }
            else
            {
                foreach (Thing item in InventoryDic.Values)
                {
                    items += item.Name + " ";
                }
            }
            return items; 
        }




    }
}
