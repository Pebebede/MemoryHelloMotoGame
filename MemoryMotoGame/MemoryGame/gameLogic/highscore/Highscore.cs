class Highscore
{
    public void Generate(Chances leftChances, TimeScore time)
    {
        int chancePoints = CalculateChancePoints(leftChances);
        int timePoints = CalculateTimePoints(time);
        int score = chancePoints + timePoints;
        Console.WriteLine("Congratulations! Your Score: " + score + " its AWESOME! You can write your name on Highscore board!");
        new HighscoreDrawer().DrawScore(score);

    }


    private int CalculateChancePoints(Chances chances)
    {
        int points = chances.getChances() * 100;


        return points;
    }

    private int CalculateTimePoints(TimeScore time)
    {

        String startTimeValue = time.GetStartTime().ToLongTimeString();
        String endTimeValue = time.GetEndTime().ToLongTimeString();
        int startTime = Int32.Parse(startTimeValue);
        int endTime = Int32.Parse(endTimeValue);
        int score = (endTime - startTime) / 100;

        return score;
    }
}

