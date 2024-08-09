using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

namespace Test
{
    internal class Sales
    {
        private readonly List<Thing> _orders;

        public Sales()
        {
            _orders = new List<Thing>();
        }

        public void Add(Thing order)
        {
            _orders.Add(order);
        }

        public void PrintOrders()
        {
            for(int i = 0; i < _orders.Count; i++)
            {
                Thing order = _orders[i];
                order.Print();
            }
        }
    }
}
