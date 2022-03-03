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
        List<Position> positions = new List<Position>();
        List<Guess> guessList = new();
        for (int i = 0; i < words.Count; i++)
        {
            guessList.Add(new Guess(positions[i], words[i]));
        }
        return guessList;
    }




}

