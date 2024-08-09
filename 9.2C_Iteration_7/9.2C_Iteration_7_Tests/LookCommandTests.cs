using _9._2C_Iteration_7;

namespace _9._2C_Iteration_7_Tests
{
    public class LookCommandTests
    {
        [Test]
        public void LookAtMeTest()
        {
            LookCommand lookCommand = new LookCommand();
            Player player = new Player("heman", "the master of universe");

            Assert.That(lookCommand.Execute(player, new string[] { "look", "at", "inventory" }), Is.EqualTo("You are heman, the master of universe.\nYou are carrying\n"));
        }

        [Test]
        public void LookAtGemInInventoryTest()
        {
            LookCommand lookCommand = new LookCommand();
            Player player = new Player("heman", "the master of universe");
            player.Inventory.Put(new Item(new string[] { "gem" }, "A Gem", "A shiny gem"));

            Assert.That(lookCommand.Execute(player, new string[] { "look", "at", "gem", "in", "inventory" }), Is.EqualTo("A shiny gem"));
        }

        [Test]
        public void UnknownInventoryTest()
        {
            LookCommand lookCommand = new LookCommand();
            Player player = new Player("heman", "the master of universe");
            player.Inventory.Put(new Item(new string[] { "sword" }, "A Sword", "A Sharp Sword"));

            Assert.That(lookCommand.Execute(player, new string[] { "look", "at", "gem", "in", "inventory" }), Is.EqualTo("I can't find gem"));
        }

        [Test]
        public void LookAtGemInMeTest()
        {
            LookCommand lookCommand = new LookCommand();
            Player player = new Player("heman", "the master of universe");
            player.Inventory.Put(new Item(new string[] { "gem" }, "A Gem", "A shiny gem"));

            Assert.That(lookCommand.Execute(player, new string[] { "look", "at", "gem", "in", "me" }), Is.EqualTo("A shiny gem"));
        }

        [Test]
        public void LookAtGemInBagTest()
        {
            LookCommand lookCommand = new LookCommand();
            Player player = new Player("heman", "the master of universe");
            Bag bag = new Bag(new string[] { "bag" }, "A bag", "A useful bag");
            Item item = new Item(new string[] { "gem" }, "A Gem", "A shiny gem");
            bag.Inventory.Put(item);
            player.Inventory.Put(bag);

            Assert.That(lookCommand.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }), Is.EqualTo("A shiny gem"));
        }

        [Test]
        public void LookAtGemInNoBagTest()
        {
            LookCommand lookCommand = new LookCommand();
            Player player = new Player("heman", "the master of universe");

            Assert.That(lookCommand.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }), Is.EqualTo("I can't find bag"));
        }

        [Test]
        public void LookAtNoGemInBagTest()
        {
            LookCommand lookCommand = new LookCommand();
            Player player = new Player("heman", "the master of universe");
            Bag bag = new Bag(new string[] { "bag" }, "A bag", "A useful bag");
            player.Inventory.Put(bag);

            Assert.That(lookCommand.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }), Is.EqualTo("I can't find gem"));
        }

        [Test]
        public void InvalidLook()
        {
            LookCommand lookCommand = new LookCommand();
            Player player = new Player("heman", "the master of universe");
            Bag bag = new Bag(new string[] { "bag" }, "A bag", "A useful bag");
            Item item = new Item(new string[] { "gem" }, "A Gem", "A shiny gem");
            bag.Inventory.Put(item);
            player.Inventory.Put(bag);

            Assert.Multiple(() =>
            {
                Assert.That(lookCommand.Execute(player, new string[] { "look", "in", "gem", "at", "bag" }), Is.EqualTo("What do you want to look at?"));
                Assert.That(lookCommand.Execute(player, new string[] { "hello", }), Is.EqualTo("Error in look input."));
                Assert.That(lookCommand.Execute(player, new string[] { "look", "around" }), Is.EqualTo("I dont know how to look like that."));
                Assert.That(lookCommand.Execute(player, new string[] { "look", "at", "gem", "on", "bag" }), Is.EqualTo("What do you want to look in?"));
            });
        }
    }
}
