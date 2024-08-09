using _9._2C_Iteration_7;
using Path = _9._2C_Iteration_7.Path;

namespace _9._2C_Iteration_7_Tests
{
    public class PathTest
    {

        [Test]
        public void PathLocationTest()
        {
            Player player = new Player("heman", "the strongest man");

            Location livingRoom = new Location("Living Room", "Living Room");
            Location kitchen = new Location("Kitchen", "Kitchen");

            player.Location = livingRoom;
            Path path = new Path(new string[] { "north" }, "Corridor", "Going through corridor", livingRoom, kitchen);
            livingRoom.AddPath(path);

            Location value = path.Destination;

            Assert.That(value, Is.EqualTo(kitchen));
        }

        [Test]
        public void PathNameTest()
        {
            Player player = new Player("heman", "the strongest man");

            Location livingRoom = new Location("Living Room", "Living Room");
            Location kitchen = new Location("Kitchen", "Kitchen");

            player.Location = livingRoom;
            Path path = new Path(new string[] { "north" }, "Corridor", "Going through corridor", livingRoom, kitchen);
            livingRoom.AddPath(path);

            string value = path.FullDescription;

            Assert.That(value, Is.EqualTo("Going through corridor"));
        }

        [Test]
        public void PathLocateTest()
        {
            Player player = new Player("heman", "the strongest man");

            Location livingRoom = new Location("Living Room", "Living Room");
            Location kitchen = new Location("Kitchen", "Kitchen");

            player.Location = livingRoom;
            Path path = new Path(new string[] { "north" }, "Corridor", "Going through corridor", livingRoom, kitchen);
            livingRoom.AddPath(path);

            GameObject value = path;

            Assert.That(value, Is.EqualTo(livingRoom.Locate("north")));
        }
    }
}
