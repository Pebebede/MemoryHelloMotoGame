class DifficultyConfiguration
{
    public Difficulty difficulty {get;}
    private int chances;
    private int numberOfWords;

    public DifficultyConfiguration(Difficulty difficulty,int numberOfWords, int chances)
    {
        this.numberOfWords = numberOfWords;
        this.chances = chances;
        this.difficulty = difficulty;
    }

    public int GetChances() { return chances; }
    public int GetNumberOfWords() { return numberOfWords; }


}

