class DifficultyConfiguration
{
    private int chances;
    private int numberOfWords;

    public DifficultyConfiguration(int numberOfWords, int chances)
    {
        this.numberOfWords = numberOfWords;
        this.chances = chances;
    }

    public int GetChances() { return chances; }
    public int GetNumberOfWords() { return numberOfWords; }


}

