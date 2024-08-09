using _9._2C_Iteration_7;

namespace _9._2C_Iteration_7_Tests
{
    public class LocationTests
    {
        [Test]
        public void LocationIdentifyTest()
        {
            Location location = new Location("Living Room", "Where people eat");
            Assert.That(location.Locate("location"), Is.EqualTo(location));
        }

        [Test]
        public void LocateItemTest()
        {
            Location location = new Location("Living Room", "Where people eat");

            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            location.Inventory.Put(item);

            Assert.That(location.Locate("sword"), Is.EqualTo(item));
        }

        [Test]
        public void PlayerLocateItemAtLocationTest()
        {
            Player player = new Player("heman", "the strongest man");
            Location location = new Location("Living Room", "Where people eat");

            Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");
            location.Inventory.Put(item);
            player.Location = location;

            Assert.That(player.Locate("sword"), Is.EqualTo(item));
        }
    }
}
