class WinCondition
{
    private List<Guess> guesses;

    public WinCondition(List<Guess> guesses)
    {
        this.guesses = guesses;
    }


    public Boolean HasBeenMet()
    {
        Boolean check = true;
        foreach (Guess guess in guesses)
        {
            check = check && guess.HasBeenGuessed();
        }
        return check;
    }
}

