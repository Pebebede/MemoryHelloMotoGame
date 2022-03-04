class HighscoreLoader
{
    public List<String> Load()
    {

        string[] arrayLine = System.IO.File.ReadAllLines(@"C:\Users\piotr\source\repos\MemoryMotoGame\MemoryMotoGame\MemoryGame\dataContent\Highscore.txt");
        List<Word> words = new();
        foreach (string line in lines)
        {
            words.Add(new Word(line));
        }
        return lines;
    }

}

