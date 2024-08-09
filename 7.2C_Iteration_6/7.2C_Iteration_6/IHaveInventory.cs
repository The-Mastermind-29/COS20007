using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2C_Iteration_6
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        string Name { get; }
    }
}
