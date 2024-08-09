namespace _10._1C_Iteration_8
{
    public class CommandProcessor : Command
    {
        List<Command> commands = new List<Command>();

        public CommandProcessor() : base(new string[] { "command" })
        {
            commands = new List<Command>();
            commands.Add(new LookCommand());
            commands.Add(new MoveCommand());
        }

        public override string Execute(Player player, string[] text)
        {
            string commandName = text.ElementAt(0);
            foreach (Command command in commands)
            {
                if (commandName == "look" && command is LookCommand)
                {
                    return command.Execute(player, text);
                }

                else if (commandName == "move" && command is  MoveCommand)
                {
                    return command.Execute(player, text);
                }
            }
            return "Command not found. Please try again";
        }
    }
}
