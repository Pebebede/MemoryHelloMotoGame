class Guess
{
    private Position position;
    private Word word;

    public Guess(Position position, Word word)
    {
        this.position = position;
        this.word = word;
    }

    public Position GetPosition() { return position; }
    public Word GetWord() { return word; }


}

