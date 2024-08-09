namespace _9._2C_Iteration_7
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] idents) : base(idents)
        {
        }

        public abstract string Execute(Player p, string[] text);
    }
}
