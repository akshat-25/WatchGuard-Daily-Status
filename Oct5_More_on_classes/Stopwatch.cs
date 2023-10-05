public class StopWatch
{
    private DateTime _startTime;
    private DateTime _endTime;
    
    public void setStartTime(DateTime startTime)
    {
        _startTime = startTime; 
    }
    public void setEndTime() { 
        _endTime = DateTime.Now;

        var timeSpan = _endTime - _startTime;
        Console.WriteLine("The duration is " + timeSpan);

    }



}