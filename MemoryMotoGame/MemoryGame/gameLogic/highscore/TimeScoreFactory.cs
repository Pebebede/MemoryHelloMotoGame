class TimeScoreFactory
{


    public TimeScore Create(TimeOnly startTime, TimeOnly endTime)
    {
        return new TimeScore(startTime, endTime);
    }


}

