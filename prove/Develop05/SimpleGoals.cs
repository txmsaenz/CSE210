
public class SimpleGoals : Goals
{

    public SimpleGoals(string goalType, string name, string description, int points, bool condition) : base (goalType, name, description, points, condition)
    {
        _goalType = "Simple Goal: ";
    }

    public override void ListGoal(int number)
    {
        if (_condition == true)
        {
            Console.WriteLine($"{number}. [X] {GetName()} ({GetDescription()})");
        }
        else
        {
            Console.WriteLine($"{number}. [ ] {GetName()} ({GetDescription()})");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetIsComplete()}");
    }
    public override string LoadGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetIsComplete()}");
    }
    public override void RecordGoal(List<Goals> goals)
    {
        _condition = true;
        Console.WriteLine($"Congratulations!  You have earned {GetPoints()} points!");
    }
}