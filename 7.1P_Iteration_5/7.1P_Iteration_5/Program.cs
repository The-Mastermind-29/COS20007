namespace _7._1P_Iteration_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Please describe yourself.");
            string description = Console.ReadLine();
            Console.WriteLine("Welcome " +  name);

            Player player = new Player(name, description);

            Item sword = new Item(new string[] { "sword" }, "a sword", "A mighty sword");
            Item water = new Item(new string[] { "water" }, "liquid", "A magical liquid to boost energy");
            player.Inventory.Put(sword);
            player.Inventory.Put(water);

            Bag bag = new Bag(new string[] { "bag item 1", "bag item 2" }, "a bag item 1", "bag item description");
            bag.Inventory.Put(bag);

            Item spear = new Item(new string[] { "spear" }, "a spear", "A mighty spear");
            bag.Inventory.Put(spear);

            LookCommand lookCommand = new LookCommand();

            while (true)
            {
                Console.WriteLine("Command: ");
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] commandPart = command.Split(' ');
                string result = lookCommand.Execute(player, commandPart);
                Console.WriteLine(result);
            }
        }
    }
}
