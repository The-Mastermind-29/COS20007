using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _7._1P_Iteration_5
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] idents) : base(idents)
        {
        }

        public abstract string Execute(Player p, string[] text);
    }
}
