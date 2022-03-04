class WordLoader
{
    public List<Word> Create()
    {
        string[] lines = File.ReadAllLines("words.txt");
        List<Word> words = new();
        foreach (string line in lines)
        {
            words.Add(new Word(line));
        }


        return words;
    }


}

