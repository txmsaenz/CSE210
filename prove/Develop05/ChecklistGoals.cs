
public class ChecklistGoals : Goals
{
    private int _howMany;
    private int _outOf;
    private int _bonusPoints;
    public ChecklistGoals(string goalType, string name, string description, int points, bool condition, int howMany, int outOf, int bonusPoints) : base (goalType, name, description, points, condition)
    {
        _goalType = "Checklist Goal: ";
        _howMany = howMany;
        _outOf = outOf;
        _bonusPoints = bonusPoints;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetOutOf()
    {
        return _outOf;
    }

    public int GetHowMany()
    {
        return _howMany;
    }

    public int SetHowMany()
    {
        _howMany = _howMany + 1;
        return _howMany;
    }

    public override void ListGoal(int number)
    {
        if (_condition == true)
        {
            Console.WriteLine($"{number}. [X] {GetName()} ({GetDescription()}) -- Currently completed {GetHowMany()}/{GetOutOf()}");
        }
        else 
        {
            Console.WriteLine($"{number}. [ ] {GetName()} ({GetDescription()}) -- Currently completed {GetHowMany()}/{GetOutOf()}");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetIsComplete()}; {GetBonusPoints()}; {GetOutOf()}");
    }
    public override string LoadGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetIsComplete()}; {GetBonusPoints()}; {GetOutOf()}");
    }
    public override void RecordGoal(List<Goals> goals)
    {
        SetHowMany();

        int _totalPoints = GetPoints();

        if (_outOf == _howMany)
        {
            _condition = true;
            _totalPoints = _points + _bonusPoints;

            Console.WriteLine($"Congratulations!  You have earned {_totalPoints} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations!  You have earned {GetPoints()} points!");
        }
        
    }
}