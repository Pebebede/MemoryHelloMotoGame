class GuessPrepareDictionary
{
    public GuessDictionary GetGuess(List<Guess> guessWordList)
    {

        GuessDictionary dictionary = GuessDictionary.Create(guessWordList);

        return dictionary;
    }
}

