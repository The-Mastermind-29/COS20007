using _10._1C_Iteration_8;
using Path = _10._1C_Iteration_8.Path;

namespace _10._1C_Iteration_8_Tests
{
    public class CommandProcessorTests
    {
        [Test]
        public void MoveCommandWithCommandProcessorTest()
        {
            Player player = new Player("heman", "the strongest man");
            CommandProcessor commandProcessor = new CommandProcessor();

            Location livingRoom = new Location("Living Room", "Living Room");
            Location kitchen = new Location("Kitchen", "Kitchen");

            player.Location = livingRoom;
            Path path = new Path(new string[] { "north" }, "Corridor", "going through corridor", livingRoom, kitchen);
            livingRoom.AddPath(path);

            commandProcessor.Execute(player, new string[] { "move", "to", "north" });

            string value = player.Location.Name;
            Assert.That(value, Is.EqualTo(kitchen.Name));
        }

        [Test]
        public void LookCommandWithCommandProcessorTest()
        {
            CommandProcessor commandProcessor = new CommandProcessor();
            Player player = new Player("heman", "the master of universe");
            player.Inventory.Put(new Item(new string[] { "gem" }, "A Gem", "A shiny gem"));

            Assert.That(commandProcessor.Execute(player, new string[] { "look", "at", "gem", "in", "me" }), Is.EqualTo("A shiny gem"));
        }
    }
}
