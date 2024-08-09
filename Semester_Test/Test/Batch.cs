using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Test
{
    internal class Batch : Thing
    {
        private readonly List<Thing> _items;

        public Batch(string number, string name) : base(number, name)
        {
            _items = new List<Thing>();
        }

        public void Add(Thing order)
        {
            _items.Add(order);
        }

        public override void Print()
        {
            Console.WriteLine($"Batch Sale: #{Number}, {Name}");
            if (_items.Count == 0)
            {
                Console.WriteLine("Empty Order.");
            }
            else
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    Thing item = _items[i];
                    item.Print();
                }
                Console.WriteLine($"Total: {Total().ToString("C2")}");
            }
        }

        public override decimal Total()
        {
            decimal total = 0;
            for (int i = 0; i < _items.Count; i++)
            {
                Thing item = _items[i];
                decimal amount = item.Total();
                total += amount;
            }
            return total;
        }
    }
}
