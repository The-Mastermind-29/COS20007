using _3._1P_Clock_Class;

namespace _3._1P_Clock_Class_Tests
{
    public class CounterTests
    {
        [Test]
        public void CounterStartZero()
        {
            Counter counter = new Counter("Name");
            Assert.That(counter.Ticks, Is.EqualTo(0));
        }

        [Test]
        public void CounterIncreamentTest()
        {
            Counter counter = new Counter("Name");
            counter.Increment();
            Assert.That(counter.Ticks, Is.EqualTo(1));
        }

        [Test]
        public void MultipleCounterIncreamentTest()
        {
            Counter counter = new Counter("Name");
            for (int i = 0; i < 10; i++)
            {
                counter.Increment();
            }
            Assert.That(counter.Ticks, Is.EqualTo(10));
        }

        [Test]
        public void ResetTest()
        {
            Counter counter = new Counter("Name");
            counter.Increment();
            Assert.That(counter.Ticks, Is.EqualTo(1));

            counter.Reset();
            Assert.That(counter.Ticks, Is.EqualTo(0));
        }
    }
}
