using ConsoleGame.interfaces;
using System.Collections.Generic;
namespace ConsoleGame.logic
{
    class Commands
    {
        public Dictionary<string, IOrder> OrderDic { get; private set;}


        public Commands()
        {
            OrderDic = new Dictionary<string, IOrder>();
        }

        public void addOrder(IOrder order)
        {
            OrderDic.Add(order.Name, order);
        }

        public string getAllCommands()
        {
            string returnString = "";
            foreach (string command in OrderDic.Keys)
            {
                returnString += command + "\n";
            }
            return returnString; 
        }


        public IOrder getOrder(string orderKey)
        {
            if (OrderDic.ContainsKey(orderKey))
            {
                return OrderDic[orderKey];
            }
            else
            {
                return null;
            }
        }

        public bool isCommandOk (string command)
        {
            return OrderDic.ContainsKey(command);
        }

    }
}
