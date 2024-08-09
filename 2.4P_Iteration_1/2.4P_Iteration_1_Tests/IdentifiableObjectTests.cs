using _2._4P_Iteration_1;

namespace _2._4P_Iteration_1_Tests
{
    public class Tests
    {
        [Test]
        public void AreYouTests()
        {
            IdentifiableObject identifiableObject = new IdentifiableObject(new string[] { "fred", "bob" });

            Assert.That(identifiableObject.AreYou("fred"));
            Assert.That(identifiableObject.AreYou("bob"));
        }

        [Test]
        public void AreYouNotTests()
        {
            IdentifiableObject identifiableObject = new IdentifiableObject(new string[] { "fred", "bob" });

            Assert.That(identifiableObject.AreYou("wilma"), Is.EqualTo(false));
            Assert.That(identifiableObject.AreYou("bobby"));
        }

        [Test]
        public void AreYouCaseSensitivityTests()
        {
            IdentifiableObject identifiableObject = new IdentifiableObject(new string[] { "fred", "bob" });

            Assert.That(identifiableObject.AreYou("FRED"));
            Assert.That(identifiableObject.AreYou("bOB"));
        }

        [Test]
        public void FirstIdTests()
        {
            IdentifiableObject identifiableObject = new IdentifiableObject(new string[] { "fred", "bob" });

            Assert.That(identifiableObject.FirstId, Is.EqualTo("fred"));
        }

        [Test]
        public void FirstIdWithNoIdsTests()
        {
            IdentifiableObject identifiableObject = new IdentifiableObject(new string[] { });

            Assert.That(identifiableObject.FirstId, Is.EqualTo(""));
        }

        [Test]
        public void AddIdTests()
        {
            IdentifiableObject identifiableObject = new IdentifiableObject(new string[] { "fred", "bob" });
            identifiableObject.AddIdentifier("wilma");

            Assert.That(identifiableObject.AreYou("fred"));
            Assert.That(identifiableObject.AreYou("bob"));
            Assert.That(identifiableObject.AreYou("wilma"));
        }
    }
}