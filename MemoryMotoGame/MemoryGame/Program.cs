
List<Word> words = new WordLoader().Create();

DifficultyConfiguration difficulty = new GameDifficultyFactory().Create(new DifficultyReader().Choice());

List<Word> randomWords = new WordRandomizer().Randomize(difficulty, words);
List<Guess> guessWordList = new GuessFactory().Create(randomWords);

var renderer = new GuessRendererFactory().Create(guessWordList);

renderer.Draw();

var looseCondition = new LoseConditions(new Chances(difficulty.GetChances()));
if (looseCondition.HasBeenMet())
{
    Console.WriteLine("You loose! Try again?");
}


var condition = new WinCondition(guessWordList);
if (condition.HasBeenMet())
{
    Console.WriteLine("You won!");
}

