class DifficultyReader
{
    public Difficulty Choice()
    {
        Console.WriteLine("Pick your difficulty Easy(1) or Hard(2)");
        var key = Console.ReadLine();
        switch (key)
        {
            case "1":
                return Difficulty.Easy;
            case "2":
                return Difficulty.Hard;
            default: throw new Exception("Invalid input");
        }


    }


}

