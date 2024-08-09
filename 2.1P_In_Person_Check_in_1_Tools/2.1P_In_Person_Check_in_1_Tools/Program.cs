namespace _2._1P_In_Person_Check_in_1_Tools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntegerQueue myQueue = new IntegerQueue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);

            Console.WriteLine(myQueue.Count);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
