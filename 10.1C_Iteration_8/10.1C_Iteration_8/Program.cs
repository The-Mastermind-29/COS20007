namespace _10._1C_Iteration_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string welcome;
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Please describe yourself.");
            string description = Console.ReadLine();
            Console.WriteLine("Welcome " + name);

            Player player = new Player(name, description);

            Location startingRoom = new Location("Starting room", "Starting room");
            player.Location = startingRoom;

            Location entertainmentRoom = new Location("Entertainment Room", "Entertainment Room");
            Path startingRoomToEntertainmentRoom = new Path(new string[] { "north" }, "Corridor", "Going through corridor", startingRoom, entertainmentRoom);
            Path entertainmentRoomToStartingRoom = new Path(new string[] { "south" }, "Corridor", "Going through corridor", entertainmentRoom, startingRoom);
            startingRoom.AddPath(startingRoomToEntertainmentRoom);
            entertainmentRoom.AddPath(entertainmentRoomToStartingRoom);

            Location livingRoom = new Location("Living Room", "Living Room");
            Path startingRoomToLivingRoom = new Path(new string[] { "east" }, "Corridor", "Going through corridor", startingRoom, livingRoom);
            Path livingRoomToStartingRoom = new Path(new string[] { "west" }, "Corridor", "Going through corridor", livingRoom, startingRoom);
            startingRoom.AddPath(startingRoomToLivingRoom);
            livingRoom.AddPath(livingRoomToStartingRoom);

            Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
            Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
            Item wallet = new Item(new string[] { "wallet" }, "a wallet", "This is a wallet");
            Item television = new Item(new string[] { "television" }, "a television", "This is a television");
            Item soundBar = new Item(new string[] { "soundbar" }, "a soundbar", "This is a soundbar");
            Item phone = new Item(new string[] { "phone" }, "a phone", "This is a phone");

            startingRoom.Inventory.Put(phone);

            entertainmentRoom.Inventory.Put(television);
            entertainmentRoom.Inventory.Put(soundBar);

            Bag bag = new Bag(new string[] { $"bag" }, $"{player.Name}'s bag", $"This is {player.Name}'s bag");
            player.Inventory.Put(shovel);
            player.Inventory.Put(sword);
            player.Inventory.Put(bag);
            bag.Inventory.Put(wallet);

            Command command = new CommandProcessor();

            while (true)
            {
                Console.Write("Enter your command: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You forgot to write.");
                    continue;
                }

                if (input.StartsWith("look"))
                    command = new LookCommand();

                else if (input.StartsWith("move") || input.StartsWith("head") || input.StartsWith("go") || input.StartsWith("leave"))
                    command = new MoveCommand();

                else if (input.StartsWith("quit"))
                {
                    Console.WriteLine("quitting");
                    break;
                }
                else
                {
                    Console.WriteLine("please start your command with look, move, head, go, leave");
                    continue;
                }

                Console.WriteLine(command.Execute(player, input.Split()));
            }
        }
    }
}
