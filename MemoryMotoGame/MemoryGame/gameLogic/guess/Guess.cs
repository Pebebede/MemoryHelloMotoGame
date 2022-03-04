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

