class LoseConditions
{
    Chances chances;
    public LoseConditions(Chances chances)
    {
        this.chances = chances;
    }

    public bool HasBeenMet()
    {
        return chances.getChances() <= 0;
    }
}

