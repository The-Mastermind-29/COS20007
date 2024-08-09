using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Transaction : Thing
    {
        private readonly decimal _amount;

        public Transaction(string number, string name, decimal amount) : base(number, name)
        {
            _amount = amount;
        }

        public override void Print()
        {
            Console.WriteLine($"#{Number}, {Name}, {_amount.ToString("C2")}");
        }

        public override decimal Total()
        {
            return _amount;
        }
    }
}
