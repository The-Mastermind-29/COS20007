using _6._1P_Iteration_4;

namespace _6._1P_Iteration_4_Tests;

public class ItemTests
{

    [Test]
    public void AreYouTest()
    {
        Item item = new Item(new string[] { "sword", "spear" }, "a sword", "A mighty sword");

        Assert.That(item.AreYou("sword"));
        Assert.That(item.AreYou("spear"));
    }

    [Test]
    public void ShortDescriptionTest()
    {
        Item item = new Item(new string[] { "sword", "spear" }, "a bronze sword", "A mighty sword");

        Assert.That(item.ShortDescription, Is.EqualTo("a bronze sword (sword)"));
    }

    [Test]
    public void FullDescriptionTest()
    {
        Item item = new Item(new string[] { "sword", "spear" }, "a bronze sword", "A mighty sword");

        Assert.That(item.FullDescription, Is.EqualTo("A mighty sword"));
    }
}