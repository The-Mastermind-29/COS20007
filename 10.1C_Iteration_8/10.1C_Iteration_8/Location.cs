namespace _10._1C_Iteration_8
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        List<Path> _paths;

        public Location(string name, string description) : base(new string[] { "location" }, name, description)
        {
            _inventory = new Inventory();
            _paths = new List<Path>();
        }


        public Location(string name, string description, List<Path> paths) : this(name, description)
        {
            _paths = paths;
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            foreach (Path p in _paths)
            {
                if (p.AreYou(id))
                {
                    return p;
                }
            }
            return _inventory.Fetch(id);
        }

        public string Paths
        {
            get
            {
                string list = string.Empty + "\n";

                if (_paths.Count == 1)
                {
                    return "Exit found: " + _paths[0].FirstId + ".";
                }

                list = list + "Multiple exits found: ";

                for (int i = 0; i < _paths.Count; i++)
                {
                    if (i != _paths.Count - 1)
                    {
                        list = list + _paths[i].FirstId + ", ";
                    }
                    else
                    {
                        list = list + "and " + _paths[i].FirstId + ".";
                    }
                }

                return list;
            }
        }

        public string Items
        {
            get
            {
                if (_inventory.ItemList == "")
                {
                    return string.Empty;
                }
                return "Items in the room:\n" + _inventory.ItemList;
            }
        }

        public void AddPath(Path path)
        {
            _paths.Add(path);
        }

    }
}
