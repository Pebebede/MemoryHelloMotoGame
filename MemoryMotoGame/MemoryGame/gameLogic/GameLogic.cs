class GameFlow
{
    public DifficultyConfiguration difficulty {get;}
    public Chances chances {get;}
    private GuessDictionary dictionary;
    private GuessRenderer renderer;
    private WinCondition winConditions;
    private LoseConditions loseConditions;

    public GameFlow (
     DifficultyConfiguration difficulty,
     GuessDictionary dictionary,
     GuessRenderer renderer,
     WinCondition winConditions,
     LoseConditions loseConditions,
     Chances chances)
    {
        this.difficulty = difficulty;
        this.dictionary = dictionary;
        this.renderer = renderer;
        this.winConditions = winConditions;
        this.loseConditions = loseConditions;
        this.chances = chances;
    }

    public GameLogicResult Execute(){
        try{
            return TryExcute();
        }catch(Exception e){
            Console.WriteLine("Oops something went wrong");
            Console.WriteLine(e);
            return GameLogicResult.GameContinues;
        }
    }

    private GameLogicResult TryExcute()
    {
        HideAllNotGuessed();

        DrawUI();
        DrawGuesses();

        Guess first = PickGuess();
        DrawGuesses();

        Guess second = PickGuess();
        DrawGuesses();

        bool matches = first.TryToCompare(second);

        if (!matches)
        {
            Console.WriteLine("You miss!!!");
            chances.Decrease();
        }


        if (winConditions.HasBeenMet())
        {
            return GameLogicResult.GameWon;
        }

        if (loseConditions.HasBeenMet())
        {
            return GameLogicResult.GameLost;
        }

        return GameLogicResult.GameContinues;
    }

    private void HideAllNotGuessed(){
        foreach(Guess guess in this.dictionary.FindAll()){
            guess.HideIfNotGuessed();
        }
    }


    Guess PickGuess()
    {
        Console.WriteLine("Provide position:");
        var userInput = Console.ReadLine();
        Position position = new StringTranscription().GetPosition(userInput);
        Guess guess = dictionary.FindByPosition(position);
        guess.Show();
        return guess;
    }

    void DrawGuesses()
    {
        Console.WriteLine();
        renderer.Draw();
        Console.WriteLine();
    }

    void DrawUI()
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("|| Difficulty "+difficulty.difficulty.ToString().ToLower());
        Console.WriteLine("|| Chances "+chances.getChances());
        Console.WriteLine("--------------------------------------------------------");

    }

}