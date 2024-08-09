using _9._2C_Iteration_7;
using Path = _9._2C_Iteration_7.Path;

namespace _9._2C_Iteration_7_Tests
{
    public class MoveCommandTests
    {

        [Test]
        public void PlayerMoveTest()
        {
            MoveCommand moveCommand = new MoveCommand();
            Player player = new Player("heman", "the strongest man");

            Location livingRoom = new Location("Living Room", "Living Room");
            Location kitchen = new Location("Kitchen", "Kitchen");

            player.Location = livingRoom;
            Path path = new Path(new string[] { "north" }, "Corridor", "going through corridor", livingRoom, kitchen);
            livingRoom.AddPath(path);

            moveCommand.Execute(player, new string[] { "move", "to", "north" });

            string value = player.Location.Name;
            Assert.That(value, Is.EqualTo(kitchen.Name));
        }

        [Test]
        public void MoveTest()
        {
            MoveCommand moveCommand = new MoveCommand();
            Player player = new Player("heman", "the strongest man");

            Location livingRoom = new Location("Living Room", "Living Room");
            Location kitchen = new Location("Kitchen", "Kitchen");

            player.Location = livingRoom;
            Path path = new Path(new string[] { "north" }, "Corridor", "going through corridor", livingRoom, kitchen);
            livingRoom.AddPath(path);

            string value = moveCommand.Execute(player, new string[] { "move", "to", "north" }); ;
            Assert.That(value, Is.EqualTo("Moved from Living Room to Kitchen"));
        }

        [Test]
        public void InvalidMoveTest()
        {
            MoveCommand moveCommand = new MoveCommand();
            Player player = new Player("heman", "the strongest man");

            Location livingRoom = new Location("Living Room", "Living Room");
            Location kitchen = new Location("Kitchen", "Kitchen");

            player.Location = livingRoom;
            Path path = new Path(new string[] { "north" }, "Corridor", "going through corridor", livingRoom, kitchen);

            string value = moveCommand.Execute(player, new string[] { "move" }); ;
            Assert.That(value, Is.EqualTo("I don't know how to move like that."));
        }

        [Test]
        public void InvalidPathTest()
        {
            MoveCommand moveCommand = new MoveCommand();
            Player player = new Player("heman", "the strongest man");

            Location livingRoom = new Location("Living Room", "Living Room");
            Location kitchen = new Location("Kitchen", "Kitchen");

            player.Location = livingRoom;
            Path path = new Path(new string[] { "north" }, "Corridor", "going through corridor", livingRoom, kitchen);

            string value = moveCommand.Execute(player, new string[] { "move", "east" }); ;
            Assert.That(value, Is.Null);
        }

        [Test]
        public void InvalidLocationTest()
        {
            MoveCommand moveCommand = new MoveCommand();
            Player player = new Player("heman", "the strongest man");

            Location livingRoom = new Location("Living Room", "Living Room");
            player.Location = livingRoom;

            string value = moveCommand.Execute(player, new string[] { "move", "east" }); ;
            Assert.That(value, Is.Null);
        }
    }
}
