List<Word> words = new WordLoader().Create();

DifficultyConfiguration difficulty = new GameDifficultyFactory().Create(new DifficultyReader().Choice());
List<Word> randomWords = new WordRandomizer().Randomize(difficulty, words);
List<Guess> guessWordList = new GuessFactory().Create(randomWords);

var renderer = new GuessRendererFactory().Create(guessWordList);

renderer.Draw();

var condition = new WinCondition(guessWordList);
if (condition.hasBeenMet())
{
    Console.WriteLine("You Won!");
}


