class GameDifficultyFactory
{


    public DifficultyConfiguration Create(Difficulty difficulty)
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                return new DifficultyConfiguration(difficulty,4, 10);
            case Difficulty.Hard:
                return new DifficultyConfiguration(difficulty,8, 15);
            default: throw new Exception("Invalid input");
        }

    }
}

