using NUnit.Framework;

[TestFixture]
public class GuessTest
{

    [Test]
    public void shouldGuess1_be_marked_whenComparing()
    {

        Guess tested = Guess("hello");
        Guess compared = Guess("moto");

        tested.TryToCompare(compared);

        Assert.IsTrue(tested.GetState().isVisible);
    }
    [Test]
    public void shouldGuess2_be_marked_whenComparing()
    {

        Guess tested = Guess("hello");
        Guess compared = Guess("moto");

        compared.TryToCompare(tested);

        Assert.IsTrue(compared.GetState().isVisible);
    }

    [Test]
    public void should_be_guessed_whenComparing()
    {
        Guess tested = Guess("moto");
        Guess compared = Guess("moto");

        bool matches = compared.TryToCompare(tested);

        Assert.IsTrue(matches);
    }

    [Test]
    public void should_be_not_guessed_whenDifferent()
    {
        Guess tested = Guess("hello");
        Guess compared = Guess("moto");

        bool matches = compared.TryToCompare(tested);

        Assert.IsFalse(matches);
    }

    [Test]
    public void should_both_have_guessed_state_whenComparing()
    {
        Guess tested = Guess("moto");
        Guess compared = Guess("moto");

        bool matches = compared.TryToCompare(tested);

        Assert.IsTrue(tested.GetState().wasGuessed);
        Assert.IsTrue(compared.GetState().wasGuessed);
    }



    [Test]
    public void should_be_guessed_whenComparing_not_same()
    {
        Guess tested = Guess("moto");
        Guess compared = Guess("moto");

        bool matches = compared.TryToCompare(tested);

        Assert.IsTrue(matches);
    }



    [Test]
    public void should_be_not_visible_whenHiding()
    {
        Guess tested = Guess("moto");
        tested.Show();

        tested.HideIfNotGuessed();

        Assert.IsFalse(tested.GetState().isVisible);
    }

    [Test]
    public void should_dislayWord_whenGuessed()
    {
        Guess tested = Guess("moto");
        tested.GetState().wasGuessed = true;

        var text = tested.asText();

        Assert.AreEqual("moto", text);
    }


    [Test]
    public void should_dislayWord_whenVisible()
    {
        Guess tested = Guess("moto");
        tested.Show();

        var text = tested.asText();

        Assert.AreEqual("moto", text);
    }

    [Test]
    public void should_dislayX_ByDefault()
    {
        Guess tested = Guess("moto");

        var text = tested.asText();

        Assert.AreEqual("X", text);
    }





    Guess Guess(string text)
    {
        return new Guess(new Position(new PositionRow(0, 'a'), 0), new Word(text));
    }
}