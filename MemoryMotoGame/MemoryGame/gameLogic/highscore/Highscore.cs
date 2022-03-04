class Highscore
{
    public void Generate(Chances leftChances)
    {
        int chancePoints = CalculateChancePoints(leftChances);
        int score = chancePoints;
        Console.WriteLine("Congratulations! Your Score: " + score + " its AWESOME! You can write your name on Highscore board!");
        new HighscoreDrawer().DrawScore(score);

    }


    private int CalculateChancePoints(Chances chances)
    {
        int points = chances.getChances() * 100;


        return points;
    }
}


