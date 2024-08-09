using _7._1P_Iteration_5;

namespace _7._1P_Iteration_5_Tests
{
    public class BagTests
    {

        [Test]
        public void LocateBagTest()
        {
            Bag bag = new Bag(new string[] { "bag item 1", "bag item 2" }, "a bag item 1", "bag item description");
            Assert.That(bag.Locate("bag item 1"), Is.EqualTo(bag));

            bag.Inventory.Put(bag);

            Assert.Multiple(() =>
            {
                Assert.That(bag.Inventory.HasItem("bag item 1"));
                Assert.That(bag.Inventory.HasItem("bag item 2"));
            });
        }

        [Test]
        public void LocateBagItselfTest()
        {
            Bag bag = new Bag(new string[] { "bag item 1", "bag item 2" }, "a bag item 1", "bag item description");
            Assert.That(bag.Locate("bag item 1"), Is.EqualTo(bag));
        }

        [Test]
        public void LocateBagNothingTest()
        {
            Bag bag = new Bag(new string[] { "bag item 1", "bag item 2" }, "a bag item 1", "bag item description");
            Assert.That(bag.Locate("bag item 1"), Is.EqualTo(bag));

            bag.Inventory.Put(bag);

            Assert.Multiple(() =>
            {
                Assert.That(bag.Inventory.HasItem("bag item 3"), Is.False);
                Assert.That(bag.Inventory.HasItem("bag item 4"), Is.False);
            });
        }

        [Test]
        public void BagFullDescriptionTest()
        {
            Bag bag = new Bag(new string[] { "bag item 1", "bag item 2" }, "a bag item 1", "bag item description");
            Assert.That(bag.Locate("bag item 1"), Is.EqualTo(bag));

            bag.Inventory.Put(bag);

            Console.WriteLine(bag.FullDescription);
            Assert.That(bag.FullDescription, Is.EqualTo("You are a bag item 1, bag item description.\nYou are carrying\n\ta bag item 1\n"));
        }

        [Test]
        public void NestedBagTest()
        {
            Bag b1 = new Bag(new string[] { "bag item 1", "bag item 2" }, "a bag item 1", "bag item description");
            Bag b2 = new Bag(new string[] { "bag item 3", "bag item 4" }, "a bag item 3", "bag item description");

            b1.Inventory.Put(b2);

            Assert.Multiple(() =>
            {
                Assert.That(b1.Locate("bag item 3"), Is.EqualTo(b2));
                Assert.That(b1.Locate("bag item 4"), Is.EqualTo(b2));

                Assert.That(b1.Locate("bag item 1"), Is.EqualTo(b1));
                Assert.That(b1.Locate("bag item 2"), Is.EqualTo(b1));

                Assert.That(b1.AreYou("bag item 3"), Is.False);
                Assert.That(b1.AreYou("bag item 4"), Is.False);
            });

        }
    }
}