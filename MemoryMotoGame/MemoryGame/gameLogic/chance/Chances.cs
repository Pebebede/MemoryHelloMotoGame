class Chances
{
    private int chances;

    public Chances(int chances)
    {
        this.chances = chances;
    }

    public int getChances()
    {
        return this.chances;
    }

    public void Decrease()
    {
        this.chances -= 1;
    }
}

