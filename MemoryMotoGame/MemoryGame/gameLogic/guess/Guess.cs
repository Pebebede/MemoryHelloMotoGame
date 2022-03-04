class Guess
{
    private Position position;
    private Word word;
    private GuessState state;
    public Guess(Position position, Word word)
    {
        this.position = position;
        this.word = word;
        this.state = new GuessState();
    }

    public Position GetPosition() { return position; }
    public Word GetWord() { return word; }

    public GuessState GetState() { return state; }
    public bool TryToCompare(Guess other)
    {
        state.isVisible = true;

        var wordValue = word.GetValue();
        var otherWordValue = other.GetWord().GetValue();
        bool matches = wordValue.Equals(otherWordValue);
        if (matches)
        {
            state.wasGuessed = true;
            other.state.wasGuessed = true;
        }
        return matches;
    }
    public void HideIfNotGuessed()
    {
        state.isVisible = false;
    }

    public void Show()
    {
        state.isVisible = true;
    }
    public string asText()
    {

        bool isVisible = state.wasGuessed || state.isVisible;
        if (isVisible)
        {
            return word.GetValue();
        }

        return "X";
    }

    public bool HasBeenGuessed()
    {
        return state.wasGuessed;
    }
}

