using Timer = System.Timers.Timer;

class TimerGenerator
{
    Timer timer = new Timer();
    public TimeOnly Start()
    {

        TimeOnly timeOnly = new TimeOnly();
        timer.Start();


        return timeOnly;

    }


    public TimeOnly StopTimer()
    {
        timer.Stop();
        TimeOnly endTime = new TimeOnly();
        return endTime;
    }
}

