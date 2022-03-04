using NUnit.Framework;

[TestFixture]
public class PositionFactoryTest
{

    PositionFactory factory;

    [SetUp]
    public void SetUp(){
        factory = new PositionFactory();
    }

    [Test]
    public void shouldFind_whenPositionProvided()
    {
        var positions = factory.Create();

        Assert.AreEqual(16,positions.Count);
    }

}