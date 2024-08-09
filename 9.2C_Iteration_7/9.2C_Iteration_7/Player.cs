namespace _9._2C_Iteration_7
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location;

        public Player(string name, string description) :
            base(new string[] { "me", "inventory" }, name, description)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }

            GameObject gameObject = _inventory.Fetch(id);

            if (gameObject != null)
            {
                return gameObject;
            }
            else if (_location != null)
            {
                return _location.Locate(id);
            }
            else
            {
                return null;
            }
        }

        public override string FullDescription
        {
            get
            {
                return "You are " + Name + ", " + base.FullDescription + ".\nYou are carrying\n" + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Location Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        public void MovePlayer(Path path)
        {
            if (path.Destination != null)
            {
                _location = path.Destination;
            }
        }
    }
}
