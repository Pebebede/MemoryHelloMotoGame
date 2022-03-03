class WordRandomizer
{
    public List<Word> Randomize(DifficultyConfiguration difficulty, List<Word> words)
    {
        var random = new Random();
        int numberOfWords = difficulty.GetNumberOfWords();
        List<Word> clonedWordList = new List<Word>(words);
        List<Word> preparedWords = new List<Word>();

        for (int i = 0; i < numberOfWords; i++)
        {
            int index = random.Next(clonedWordList.Count);
            preparedWords.Add(clonedWordList[index]);
            preparedWords.Add(clonedWordList[index]);
            clonedWordList.RemoveAt(index);

        }
        return preparedWords;
    }


}

