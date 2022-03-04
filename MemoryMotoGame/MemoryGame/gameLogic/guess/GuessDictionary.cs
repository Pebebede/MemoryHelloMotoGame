class GuessDictionary
{
    public static GuessDictionary Create(List<Guess> guesses)
    {
        Dictionary<String, Guess> guessMap = guesses.ToDictionary(keySelector: m => m.GetPosition().asText(), elementSelector: m => m);
        return new GuessDictionary(guessMap);
    }

    private Dictionary<String, Guess> guessMap;

    private GuessDictionary(Dictionary<String, Guess> guessMap)
    {
        this.guessMap = guessMap;
    }

    public Guess FindByPosition(Position position)
    {
        return guessMap[position.asText()];
    }
    public List<Guess> FindAll()
    {
        return guessMap.Values.ToList();
    }


}

