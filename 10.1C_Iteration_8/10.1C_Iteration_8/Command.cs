namespace _10._1C_Iteration_8
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] idents) : base(idents)
        {
        }

        public abstract string Execute(Player p, string[] text);
    }
}
