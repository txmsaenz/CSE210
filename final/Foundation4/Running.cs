
public class Running : Exercise
{
    private double _distance;

    public Running(double distance) : base(name, timeSpent)
    {
        _distance = distance;
    }

    public override double CalcDistance()
    {
        return 0;
    }

    public override double CalcSpeed()
    {
        return 0;
    }

    public override double CalcPace()
    {
        return 0;
    }

    public override string Summary()
    {
        return "";
    }
}