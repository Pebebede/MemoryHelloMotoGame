class GameDifficultyFactory
{


    public DifficultyConfiguration Get(Difficulty difficulty)
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                return new DifficultyConfiguration(4, 10);
            case Difficulty.Hard:
                return new DifficultyConfiguration(8, 15);
            default: throw new Exception("Invalid input");
        }

    }
}

