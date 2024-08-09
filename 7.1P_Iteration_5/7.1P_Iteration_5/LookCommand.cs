using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _7._1P_Iteration_5
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            if (!text.ElementAt(0).Equals("look"))
                return "Error in look input.";

            if (text.Length != 3 && text.Length != 5)
                return "I dont know how to look like that.";

            if (!text.ElementAt(1).Equals("at"))
                return "What do you want to look at?";

            if (text.Length == 5 && !text.ElementAt(3).Equals("in"))
                return "What do you want to look in?";

            IHaveInventory container = null;
            if (text.Length == 3)
                container = p as IHaveInventory;

            else if (text.Length == 5)
                container = FetchContainer(p, text.ElementAt(4));

            if (container == null)
            {
                if (text.Length == 5)
                    return "I can't find " + text.ElementAt(4);

                return "I can't find " + text.ElementAt(2);

            }

            return LookAtIn(text.ElementAt(2), container);
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            IHaveInventory container = (IHaveInventory)p.Locate(containerId);

            return container;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            GameObject gameObject = container.Locate(thingId);
            if (gameObject != null)
                return gameObject.FullDescription;

            return "I can't find " + thingId;
        }
    }
}
