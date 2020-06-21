using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.interfaces
{
    interface IOrder
    {
        string Name { get;}
        string followOrder(string[] parameters);

    }
}
