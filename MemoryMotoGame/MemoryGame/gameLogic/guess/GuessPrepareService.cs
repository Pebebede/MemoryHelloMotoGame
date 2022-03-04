class GuessPrepareService
{
    public GuessDictionary GetGuess(DifficultyConfiguration difficulty, List<Word> words)
    {
        List<Word> randomWords = new WordRandomizer().Randomize(difficulty, words);
        List<Guess> guessWordList = new GuessFactory().Create(randomWords);
        GuessDictionary dictionary = GuessDictionary.Create(guessWordList);

        return dictionary;
    }
}

