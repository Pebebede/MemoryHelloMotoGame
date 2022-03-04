using NUnit.Framework;

[TestFixture]
public class GuessDictionaryTest
{

    [Test]
    public void shouldFind_whenPositionProvided()
    {
        List<Guess> guesses = new List<Guess>();
        Guess g = Guess(Position('A',1, 4));
        guesses.Add(g);
        var tested = GuessDictionary.Create(guesses);

        var found = tested.FindByPosition(Position('A',1,4));

        Assert.NotNull(found);
    }

    [Test]
    public void shouldFind_when2Position_inTheSameRow()
    {
        List<Guess> guesses = new List<Guess>();
        Guess g = Guess(Position('A',1, 4));
        Guess g1 = Guess(Position('A',1, 1));

        guesses.Add(g1);
        var tested = GuessDictionary.Create(guesses);

        var found = tested.FindByPosition(Position('A',1,1));

        Assert.AreEqual(found,g1);
    }


        [Test]
    public void shouldFind_when2Position_inTheColumn()
    {
        List<Guess> guesses = new List<Guess>();
        Guess g = Guess(Position('A',2, 2));
        Guess g1 = Guess(Position('C',3, 1));
        guesses.Add(g);
        guesses.Add(g1);

        var tested = GuessDictionary.Create(guesses);

        var found = tested.FindByPosition(Position('A',2,2));

        Assert.AreEqual(found,g);
    }

    [Test]
    public void shouldFound_whenMultiple()
    {
        List<Guess> guesses = new List<Guess>();
        Guess g = Guess(Position('A',1, 4));
        Guess g2 = Guess(Position('B',1, 4));
        Guess g3 = Guess(Position('C',1, 4));

        guesses.Add(g);
        guesses.Add(g2);
        guesses.Add(g3);

        var tested = GuessDictionary.Create(guesses);

        var found = tested.FindByPosition(Position('C',1,4));

        Assert.NotNull(found);
    }


    Position Position(char letter, int row, int col){
        return new Position(new PositionRow(row, letter), col);
    }
    Guess Guess(Position position)
    {
        return new Guess(position, new Word("text"));
    }
}