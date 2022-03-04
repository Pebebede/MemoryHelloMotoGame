class TimeScore
{
    TimeOnly startTime;
    TimeOnly endTime;

    public TimeScore(TimeOnly endTime, TimeOnly startTime)
    {
        this.endTime = endTime;
        this.startTime = startTime;
    }

    public TimeOnly GetStartTime()
    {
        return startTime;
    }

    public TimeOnly GetEndTime()
    {
        return endTime;
    }
}

