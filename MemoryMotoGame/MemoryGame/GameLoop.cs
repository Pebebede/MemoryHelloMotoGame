class GameLoop
{

    // DifficultyConfiguration configuredDifficulty;
    List<Word> words = new WordLoader().Create();
    GuessPrepareDictionary GuessPrepareService = new GuessPrepareDictionary();//zwraca mape z słowami
                                                                              //  GuessPrepareService preparedGuess = new GuessPrepareService().GetGuess(configuredDifficulty, words);
    public void Execute()
    {
        while (true)
        {
            Difficulty difficulty = new DifficultyReader().Choice();
            DifficultyConfiguration difficultyConfiguration = new GameDifficultyFactory().Create(difficulty);
            List<Guess> guessWordList = new GuessFactory().Create(randomWords);
            var renderer = new GuessRendererFactory().Create(guessWordList);
        }
    }
}

