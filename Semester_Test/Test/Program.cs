namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sales sales = new Sales();

            Batch batchOrder = new Batch("2024x00002", "Batch orders");

            Batch batch1 = new Batch("2024x00001", "Comp Sci Books");
            batch1.Add(new Transaction("1", "Deep Learning in Python", 67.90m));
            batch1.Add(new Transaction("2", "C# in action", 54.10m));
            batch1.Add(new Transaction("3", "Design patterns", 129.75m));
            batchOrder.Add(batch1);

            Batch batch2 = new Batch("2024x00002", "Fantacy Books");
            batchOrder.Add(batch2);

            batchOrder.Add(new Transaction("00-0001", "Compilers", 134.60m));
            batchOrder.Add(new Transaction("10-0003", "Hunger Games 1-3", 45m));
            batchOrder.Add(new Transaction("15-0020", "Learning Blender", 56.90m));

            sales.Add(batchOrder);
            sales.PrintOrders();
        }
    }
}
