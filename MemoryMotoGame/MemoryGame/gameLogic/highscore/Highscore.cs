class Highscore
{
    public Highscore(Chances leftChances, TimeScore time)
    {




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

