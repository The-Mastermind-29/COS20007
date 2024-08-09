using _4._2P_Iteration_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2P_Iteration_2_Tests
{
    public class PlayerTests
    {

        [Test]
        public void AreYouTest()
        {
            Player player = new Player("heman", "the strongest man");

            Assert.That(player.AreYou("me"));
            Assert.That(player.AreYou("inventory"));
        }

        [Test]
        public void LocateItemTest()
        {
            Player player = new Player("heman", "the strongest man");
            Assert.That(player.Locate("me"), Is.EqualTo(player));

            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            player.Inventory.Put(item);

            Assert.That(player.Locate("sword"), Is.EqualTo(item));
        }

        [Test]
        public void LocateMeTest()
        {
            Player player = new Player("heman", "the strongest man");
            Assert.That(player.Locate("me"), Is.EqualTo(player));
            Assert.That(player.Locate("inventory"), Is.EqualTo(player));
        }

        [Test]
        public void LocateNothingTest()
        {
            Player player = new Player("heman", "the strongest man");
            Assert.That(player.Locate("me"), Is.EqualTo(player));

            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            player.Inventory.Put(item);

            Assert.That(player.Locate("club"), Is.EqualTo(null));
        }

        [Test]
        public void FullDescriptionTest()
        {
            Player player = new Player("heman", "the strongest man");
            Assert.That(player.Locate("me"), Is.EqualTo(player));

            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            player.Inventory.Put(item);

            Console.WriteLine(player.FullDescription);
            Assert.That(player.FullDescription, Is.EqualTo("You are heman, the strongest man.\nYou are carrying\n\ta sword\n"));
        }

    }
}
