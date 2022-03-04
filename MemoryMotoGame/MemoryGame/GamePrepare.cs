class GamePrepare
{
    DifficultyConfiguration difficulty = new GameDifficultyFactory().Create(new DifficultyReader().Choice());
    List<Word> words = new WordLoader().Create();
    GuessPrepareService GuessPrepareService = new GuessPrepareService();

    public void Execute()
    {
        while (true)
        {

        }
    }
}

