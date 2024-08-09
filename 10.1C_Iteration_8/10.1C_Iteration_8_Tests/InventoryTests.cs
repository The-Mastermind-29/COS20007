using _10._1C_Iteration_8;

namespace _10._1C_Iteration_8_Tests
{
    public class InventoryTests
    {

        [Test]
        public void HasItemTest()
        {
            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            Inventory inventory = new Inventory();
            inventory.Put(item);

            Assert.That(inventory.HasItem("sword"));
            Assert.That(inventory.HasItem("spear"));
        }

        [Test]
        public void DoesNotHaveItemTest()
        {
            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            Inventory inventory = new Inventory();
            inventory.Put(item);

            Assert.That(inventory.HasItem("club"), Is.EqualTo(false));
        }

        [Test]
        public void FetchTest()
        {
            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            Inventory inventory = new Inventory();
            inventory.Put(item);

            Assert.That(inventory.Fetch("sword"), Is.EqualTo(item));
            Assert.That(inventory.Fetch("spear"), Is.EqualTo(item));
        }

        [Test]
        public void TakeTest()
        {
            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            Inventory inventory = new Inventory();

            inventory.Put(item);
            Assert.That(inventory.Fetch("sword"), Is.EqualTo(item));

            item = inventory.Take("sword");
            Assert.That(inventory.HasItem(item.FirstId), Is.EqualTo(false));
        }

        [Test]
        public void ItemListTest()
        {
            Inventory inventory = new Inventory();

            Item item1 = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            inventory.Put(item1);

            Item item2 = new Item(new string[] { "club", "hammer" }, "a club", "A powerful club");
            inventory.Put(item2);

            Assert.That(inventory.ItemList, Is.EqualTo("\ta sword\n\ta club\n"));
        }

    }
}
