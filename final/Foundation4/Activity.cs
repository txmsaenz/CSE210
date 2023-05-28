
public abstract class Activity
{
    protected string _date;
    protected double _timeSpent;
    protected string _type;
    protected string _summary;
    
    public Activity(string date, double timeSpent)
    {
        _date = date;
        _timeSpent = timeSpent;
    }

    public abstract double CalcDistance();

    public abstract double CalcSpeed();

    public abstract double CalcPace();

    public abstract string GetSummary();
}