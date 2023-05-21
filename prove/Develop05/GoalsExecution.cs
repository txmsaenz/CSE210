
public class GoalsExecution
{
    public List<Goals> goals = new List<Goals>();
    private int _pointsTotal = 0;

    public GoalsExecution()
    {

    }

    public void AddGoals(Goals goalToAdd)
    {
        goals.Add(goalToAdd);
    }

    public List<Goals> GetGoals()
    {
        return goals;
    }

    public void SetPoints(int pointsTotal)
    {
        _pointsTotal = pointsTotal;
    }

    public void AddPoints(int points)
    {
        _pointsTotal += points;
    }

    public void AddBonusPoints(int bonusPoints)
    {
        _pointsTotal += bonusPoints;
    }
    public int GetPointsTotal()
    {
        return _pointsTotal;
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int index = 1;

        foreach (Goals goal in goals)
        {
            goal.ListGoal(index);
            index += 1;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine(GetPointsTotal());

            foreach (Goals goal in goals)
            {
                outputfile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        int _pointsTotal = int.Parse(lines[0]);
        SetPoints(_pointsTotal);

        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            string goalsType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool condition = Convert.ToBoolean(parts[4]);
            
            if (parts[0] == "Simple Goal:")
            {
                SimpleGoals simple = new SimpleGoals(goalsType, name, description, points, condition);
                AddGoals(simple);
            }

            if (parts[0] == "Eternal Goals:")
            {
                EternalGoals eternal = new EternalGoals(goalsType, name, description, points, condition);
                AddGoals(eternal);
            }

            if (parts[0] == " Checklist Goals:")
            {
                int howMany = int.Parse(parts[5]);
                int outOf = int.Parse(parts[6]);
                int bonusPoints = int.Parse(parts[7]);

                ChecklistGoals checklist = new ChecklistGoals(goalsType, name, description, points, condition, howMany, outOf, bonusPoints);
                AddGoals(checklist);
            }
        }
    }

    public void RecordEvent()
    {
        ListGoals();

        Console.WriteLine("Which goal did you accomplish? ");
        string goalNum = Console.ReadLine();
        int goalNumber = int.Parse(goalNum) - 1;

        int goalPoints = GetGoals()[goalNumber].GetPoints();
        AddPoints(goalPoints);

        GetGoals()[goalNumber].RecordGoal(goals);

        Console.WriteLine($"Congratulations! You have earned {GetPointsTotal()} points!");
    }

    
}