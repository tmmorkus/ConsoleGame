using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.logic
{
    class GamePlan
    {
        public Space ActualSpace { get; set; }

        public GamePlan()
        {
            this.createGamePlan(); 
        }


        private void createGamePlan()
        {

            Space jeskyne = new Space("jeskyne", "Malá ůtulná jeskyně, jenž byla do této tvým domovem.");
            Space les = new Space("les", "Obvyklý les strom sem, strom tam. Pozor ať se neztratíš!!");
            Space plane = new Space("plane", "Prázdné pláně rozléhající se kam okem dohlédneš");
            Space reka = new Space("reka", "Řeka s širokým korytem. Na druhé řeky straně lze spatřit doupě bestie.");
            Space doupe = new Space("doupe", "Smdrudá díra, všude se povalují kosti, pozůstatky jenž zbyly po tvých předchůdcích. V koutě vidíš krčící se monstrum.");

            jeskyne.addExit(plane);
            plane.addExit(jeskyne);
            plane.addExit(les);
            plane.addExit(reka);
            les.addExit(plane);
            reka.addExit(plane);
            reka.addExit(doupe);
            doupe.addExit(reka);

            Thing pecene = new Thing("pecene", true, true);
            Thing balvan = new Thing("balvan", false, false);
            Thing kamen = new Thing("kamen", true, false);
            Thing maliny = new Thing("maliny", true, true);
            Thing topurek = new Thing("topurek", true, false);
            Thing staryStrom = new Thing("stary_strom", false, false);
            Thing lyko = new Thing("lyko", true, false);


            jeskyne.addThing(pecene);
            jeskyne.addThing(balvan);
            plane.addThing(balvan);
            plane.addThing(kamen);
            les.addThing(maliny);
            les.addThing(topurek);
            les.addThing(staryStrom);
            reka.addThing(lyko);

            ActualSpace = jeskyne;

        }

    }
}
