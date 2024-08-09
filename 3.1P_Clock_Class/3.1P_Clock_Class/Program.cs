namespace _3._1P_Clock_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            for (int i = 0; i < 3700; i++)
            {
                clock.Tick();
                Console.WriteLine(clock.Time);
            }
        }
    }
}
