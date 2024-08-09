using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2P_Counter_Class
{
    internal class Counter
    {
        private int _count;
        public int Ticks
        {
            get
            {
                return _count;
            }
        }


        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Increment();
                _name = value;
            }
        }

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public void Increment()
        {
            _count++;
        }
        public void Reset()
        {
            _count = 0;
        }
    }
}
