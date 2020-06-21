
using System.Collections.Generic;
using System.Linq;


namespace ConsoleGame.logic
{
    class Space
    {
        public string Name { get; private set; }
        public string Description { get;private set; }
        public List<Space> Exits { get; private set; } 
        public Dictionary<string,Thing> Things { get; private set; }
        
        public Space (string name, string description)
        {
            Name = name;

            Description = description;
            Exits = new List<Space>();
            Things = new Dictionary<string, Thing>();
        }

        public string getLongDescription()
        {
            return "Jsi v prostoru: " + Description + ".\n"
            + this.exitDescription() + "\n"
            + this.thingsDescription();
        }

        private string exitDescription()
        {
            string exits = "východy:";
            foreach (Space exit in Exits)
            {
                exits += " " + exit.Name;
            }

            return exits; 
        }

        public bool addThing(Thing something)
        {
            if (Things.ContainsKey(something.Name))
            {
                return false;
            }
            else
            {
                Things.Add(something.Name, something);
                return true;
            }

        }

        public void addExit (Space exit)
        {
            Exits.Add(exit); 
        }

        private string thingsDescription()
        {
            string description = "";
            if (Things.Count() == 0)
            {
                description = "Nejsou zde žádné věci";
            }
            else
            {
                description = "Jsou zde tyto věci: ";
                foreach (string nazev in Things.Keys)
                {
                    description += nazev + " ";
                }
            }
            return description;
        }

        public Thing deleteThing (string thingName)
        {
            Thing tempThing = Things[thingName];
            Things.Remove(thingName);
            return tempThing;
        }



    }
}
