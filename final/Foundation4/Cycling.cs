
public class Cycling : Activity
{
    private double _distance;
    private double _speed;
    private double _pace;
    public Cycling(double speed, string date, double timeSpent) :base (date, timeSpent)
    {
        _speed = speed;
        _type = "Cycling";
    }

    public override double CalcDistance()
    {
        _distance = _speed * (_timeSpent/60);
        return _distance;
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        _pace = 60/_speed;
        return _pace;
    }

    public override string GetSummary()
    {
        _summary = _date + " " + _type + " (" + _timeSpent + " min)- Distance " + Math.Round(CalcDistance(), 1) + " miles, Speed " + Math.Round(CalcSpeed(), 1) + " mph, Pace: " + Math.Round(CalcPace(), 1) + " min per mile";
        return _summary;
    }
}