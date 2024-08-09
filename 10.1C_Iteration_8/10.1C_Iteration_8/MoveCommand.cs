namespace _10._1C_Iteration_8
{
    public class MoveCommand : Command
    {
        public MoveCommand() : base(new string[] { "move", "go", "head", "leave" })
        {
        }

        public override string Execute(Player player, string[] text)
        {
            if (!(new string[] { "move", "go", "head", "leave" }).Contains(text.ElementAt(0)))
            {
                return "Where would you like to move?";
            }

            if (text.Length < 2 || text.Length > 3)
            {
                return "I don't know how to move like that.";
            }

            string direction;

            if (text.Length == 2)
            {
                direction = text.ElementAt(1);
            }
            else
            {
                direction = text.ElementAt(2);
            }

            GameObject path = player.Location.Locate(direction);
            if (path != null)
            {
                Path pathObject = path as Path;
                if (path.GetType() != typeof(Path))
                {
                    return "Cannot find the path " + path.Name + ", please try again";
                }
                player.MovePlayer(pathObject);
                return "Moved from " + pathObject.Begin.Name + " to " + pathObject.End.Name;
            }
            else
            {
                return null;
            }
        }
    }
}
