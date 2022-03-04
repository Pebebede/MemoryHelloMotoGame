class WordLoader
{
    public List<Word> Create()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\piotr\source\repos\MemoryMotoGame\MemoryMotoGame\MemoryGame\dataContent\words.txt2");
        List<Word> words = new();
        foreach (string line in lines)
        {
            words.Add(new Word(line));
        }


        return words;
    }


}

