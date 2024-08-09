using _2._1P_In_Person_Check_in_1_Tools;
namespace _2._1P_Check_In_1_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEqeue()
        {
            IntegerQueue myQueue = new IntegerQueue();

            myQueue.Enqueue(12345);
            int myCount = myQueue.Count;

            Assert.That(myCount, Is.EqualTo(1));

            Assert.That(myQueue._elements.Count, Is.EqualTo(1));
            Assert.That(myQueue._elements[0], Is.EqualTo(12345));
        }
        [Test]
        public void TestDequeue()
        {
            Assert.Fail();
        }
    }
}
