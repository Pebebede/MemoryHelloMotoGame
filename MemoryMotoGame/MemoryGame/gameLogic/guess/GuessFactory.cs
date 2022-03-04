class GuessFactory
{
    public List<Guess> Create(List<Word> randomWords)
    {

        Shuffle(randomWords);
        List<Guess> guessList = Prepare(randomWords);


        return guessList;
    }

    private List<Word> Shuffle(List<Word> words)
    {

        Random rng = new Random();

        return words = words.OrderBy(a => rng.Next()).ToList();
    }


    private List<Guess> Prepare(List<Word> words)
    {
        List<Position> positions = GetPositionsFor(words);



        List<Guess> guessList = new();
        for (int i = 0; i < words.Count; i++)
        {
            int randomIndex = new Random().Next(positions.Count);
            Position randomPosition = positions[randomIndex];
            positions.Remove(randomPosition);
            guessList.Add(new Guess(randomPosition, words[i]));
        }

        return guessList;
    }

    private List<Position> GetPositionsFor(List<Word> words)
    {
        List<Position> positions = new PositionFactory().Create();
        return positions.GetRange(0, words.Count);
    }




}

