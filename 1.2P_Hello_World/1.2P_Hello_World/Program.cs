namespace _1._2P_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("Hello, World! Greetings from Message Object");
            message.Print();

            Message[] messages = new Message[5];
            messages[0] = new Message("Hi Wilma, how are you?");
            messages[1] = new Message("Hi John, how are you?");
            messages[2] = new Message("Hi Jason, how are you?");
            messages[3] = new Message("Hi Joshua, how are you?");
            messages[4] = new Message("Welcome, nice to meet you");

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "wilma")
                messages[0].Print();
            else if (name.ToLower() == "john")
                messages[1].Print();
            else if (name.ToLower() == "jason")
                messages[2].Print();
            else if (name.ToLower() == "joshua")
                messages[3].Print();
            else
                messages[4].Print();

        }
    }
}
