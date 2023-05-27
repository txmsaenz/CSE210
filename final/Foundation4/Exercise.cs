
public abstract class Exercise
{
    protected string _date;
    protected double _timeSpent;

    public Exercise(string date, double timeSpent)
    {
        _date = date;
        _timeSpent = timeSpent;
    }

    public abstract double CalcDistance();

    public abstract double CalcSpeed();

    public abstract double CalcPace();

    public abstract string Summary();
}