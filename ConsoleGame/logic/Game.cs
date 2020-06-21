using ConsoleGame.interfaces;
using ConsoleGame.logic.orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.logic
{
    class Game
    {
        public Commands Commands { get; private set; }
        public GamePlan GamePlan { get; private set; }
        public Inventory Inventory { get; private set; }
        public Health Health { get; private set; }
        public bool EndOfGame { get; set;}


        public Game()
        {
            GamePlan = new GamePlan();
            Inventory = new Inventory();
            Health = new Health(3);
            Commands = new Commands();
            EndOfGame = false;
            
            Commands.addOrder(new OrderMove(GamePlan, Health));     
            Commands.addOrder(new OrderInventory(Inventory));
            Commands.addOrder(new OrderCraft(Inventory));
            Commands.addOrder(new OrderEat(Inventory, Health));
            Commands.addOrder(new OrderGrab(Inventory, GamePlan));    
            Commands.addOrder(new OrderFight(GamePlan,Inventory,Health,this));
            Commands.addOrder(new OrderEnd(this));
            Commands.addOrder(new OrderHelp(Commands));

        }


        public string getWelcome()
        {
            return "Vítejte!\n" +
            "Děj hry je zasazen do doby kamenné. Ujímáte se role mladého lovce, jehož čeká nelehká zkouška dospělosti.\n" +
            "Zkouška spočívá v pokoření tygra šavlozubého, jenž se nachází za řekou ve svém doupěti.\n" +
            "Ačkoli jako správný lovec bez bázně a hany byste se vydali zdolat bestii holýma rukama, pud sebezáchovy vám velí vyrobit si alespoň primitivní zbraň.\n" +
            "Cílem hry je dostat se do doupěte a porazit tygra šavlozubého.\n" +
            "Napište 'napoveda', pokud si nevíte rady, jak hrát dál.\n" + 
            "Právě se nacházíte v místě zvaném " + GamePlan.ActualSpace.Name +
            "Můžeš jít do " + GamePlan.ActualSpace.getLongDescription(); 
        }


        public string getEpiloge()
        {
            return "Dík, že jste si zahráli.  Ahoj.";
        }


        public bool isEnd()
        {
            return EndOfGame;
        }

  
        public string processOrder(string line)
        {
            string[] words = line.Split(' ');
            string[] parameters = new string[words.Count() - 1];
            string orderString = words[0];
            string returnText = "";
            for (int i = 0; i < parameters.Count(); i++)
            {
                parameters[i] = words[i+1];
            }
            
            if (Commands.isCommandOk(orderString))
            {
                IOrder order= Commands.getOrder(orderString);
                returnText = order.followOrder(parameters);
            }
            else
            {
                returnText = "Nevím co tím myslíš? Tento příkaz neznám. ";
            }
            return returnText;
        }


   
    }
}
