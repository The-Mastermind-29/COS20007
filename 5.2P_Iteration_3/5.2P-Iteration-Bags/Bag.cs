using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2P_Iteration_Bags;

public class Bag : Item
{
    private Inventory _inventory;

    public Inventory Inventory
    {
        get
        {
            return _inventory;
        }
    }

    public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
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

    public string FullDescription
    {
        get
        {
            return "You are " + Name + ", " + base.FullDescription + ".\nYou are carrying\n" + _inventory.ItemList;
        }
    }
}
