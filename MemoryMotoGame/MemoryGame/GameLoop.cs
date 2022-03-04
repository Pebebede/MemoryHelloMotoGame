class GameLoop
{

    private List<Word> words;

    public GameLoop(List<Word> words){
        this.words = words;
    }

    public void Execute()
    {
        var gameFlow = this.createGameFlow();
        while (true)
        {
            var result = gameFlow.Execute();
            bool shouldRestart = false;
            switch(result){
                case GameLogicResult.GameWon:
                shouldRestart = this.WhenGameWasWon(gameFlow.difficulty,gameFlow.chances);
                break;

                case GameLogicResult.GameLost:
                shouldRestart = this.WhenGameWasLost();
                break;

                case GameLogicResult.GameContinues:
                    continue;
            }

            if(shouldRestart){
                Console.WriteLine("Restarting game");
                gameFlow = this.createGameFlow();
            }else{
                throw new Exception("Exiting game");
            }


        }
    }

    DifficultyConfiguration GetDifficultyFromPlayer(){
        Difficulty difficulty = new DifficultyReader().Choice();
        return new GameDifficultyFactory().Create(difficulty);
    }

    GameFlow createGameFlow(){

        DifficultyConfiguration difficultyConfiguration = this.GetDifficultyFromPlayer();
       
        List<Guess> guessWordList = new GuessPrepareService().GetGuess(difficultyConfiguration,words);
        var renderer = new GuessRendererFactory().Create(guessWordList);
        
        Chances chances = new Chances(difficultyConfiguration.GetChances());

        GuessDictionary dictionary = GuessDictionary.Create(guessWordList);
        var winCondition = new WinCondition(guessWordList);
        var loseCondition = new LoseConditions(chances);
        return new GameFlow(difficultyConfiguration, dictionary, renderer, winCondition, loseCondition, chances);
    }


    bool WhenGameWasWon(DifficultyConfiguration difficultyConfiguration,Chances chances){
        Console.WriteLine("You won!");

        int tries = difficultyConfiguration.GetChances() - chances.getChances();
        Console.WriteLine("you won with tries: "+tries);
        new Highscore().Generate(chances);

        return AskToTryAgain();
    }
    bool WhenGameWasLost(){
        Console.WriteLine("You Lost!");
        return AskToTryAgain();
    }
    
    bool AskToTryAgain(){
        Console.WriteLine("Want to try again?");
        var answer = Console.ReadLine();
        return answer.ToLower().StartsWith("y");
    }

}

