using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal abstract class Thing
    {
        private readonly string _number;
        private readonly string _name;

        protected Thing(string number, string name)
        {
            _number = number;
            _name = name;
        }

        public abstract void Print();

        public abstract decimal Total();

        public string Number
        {
            get { return _number; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
