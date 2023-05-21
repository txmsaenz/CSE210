
public abstract class Goals
{
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _condition = false;

    public Goals(string goalType, string name, string description, int points, bool condition)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _condition = condition;
    }

    public bool GetIsComplete()
    {
        return _condition;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public abstract void ListGoal(int number);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoal(List<Goals> goals);
}