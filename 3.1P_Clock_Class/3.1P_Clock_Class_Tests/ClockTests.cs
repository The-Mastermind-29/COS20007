using _3._1P_Clock_Class;

namespace _3._1P_Clock_Class_Tests
{
    public class ClockTests
    {
        [Test]
        public void ClockStartZero()
        {
            Clock clock = new Clock();
            Assert.That(clock.Time, Is.EqualTo("00:00:00"));
        }

        [Test]
        public void ClockIncreamentTest()
        {
            Clock clock = new Clock();
            clock.Tick();
            Assert.That(clock.Time, Is.EqualTo("00:00:01"));
        }

        [Test]
        public void MultipleClockIncreamentTest()
        {
            Clock clock = new Clock();
            for (int i = 0; i < 70; i++)
            {
                clock.Tick();
            }
            Assert.That(clock.Time, Is.EqualTo("00:01:10"));
        }

        [Test]
        public void ResetTest()
        {
            Clock clock = new Clock();
            clock.Tick();
            Assert.That(clock.Time, Is.EqualTo("00:00:01"));

            clock.Reset();
            Assert.That(clock.Time, Is.EqualTo("00:00:00"));
        }
    }
}