namespace _5._2P_Iteration_Bags;

public class Player : GameObject
{
    private Inventory _inventory;

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
        else
        {
            return _inventory.Fetch(id);
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
}
