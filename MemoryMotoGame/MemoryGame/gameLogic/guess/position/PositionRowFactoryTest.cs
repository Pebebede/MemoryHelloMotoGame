using NUnit.Framework;

[TestFixture]
public class PositionRowFactoryTest
{

    [Test]
    public void testFindingPositionByA(){
        var position = PositionRowFactory.createFrom('a');

        Assert.AreEqual('a',position.letter);
        Assert.AreEqual(1,position.value);
    }



    [Test]
    public void testFindingPositionByB(){
        var position = PositionRowFactory.createFrom('b');

        Assert.AreEqual('b',position.letter);
        Assert.AreEqual(2,position.value);
    }

        [Test]
    public void testFindingPositionByC(){
        var position = PositionRowFactory.createFrom('c');

        Assert.AreEqual('c',position.letter);
        Assert.AreEqual(3,position.value);
    }


        [Test]
    public void testFindingPositionByD(){
        var position = PositionRowFactory.createFrom('d');

        Assert.AreEqual('d',position.letter);
        Assert.AreEqual(4,position.value);
    }
}