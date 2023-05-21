using System;

class Program
{
    static void Main(string[] args)
    {
        int menuInput = 0;
        int listGoalInput = 0;

        GoalsExecution goals = new GoalsExecution();

        Console.Clear();

        List<string> menu = new List<string>
        {
            "Menu Options:",
            "  1. Create New Goal",
            "  2. List Goals",
            "  3. Save Goals",
            "  4. Load Goals",
            "  5. Record Event",
            "  6. Quit",
            "Select a choice from the menu: "
        };

        while (menuInput != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {goals.GetPointsTotal()} points.");
            Console.WriteLine();

            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            menuInput = int.Parse(Console.ReadLine());

            if (menuInput == 1)
            {
                List<string> listGoal = new List<string>
                {
                    "The types of Goals are:",
                    "  1. Simple Goal",
                    "  2. Eternal Goal",
                    "  3. Checklist Goal",
                    "Which type of goal would you like to create? "
                };
            
                    foreach(string listGoalItem in listGoal)
                    {
                        Console.WriteLine(listGoalItem);
                    }
                    listGoalInput = int.Parse(Console.ReadLine());

                    if (listGoalInput == 1)
                    {
                        Console.Write("What is the name of your goal? ");
                        string name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());

                        SimpleGoals simple = new SimpleGoals("Simple Goal", name, description, points, false);

                        goals.AddGoals(simple);
                    }

                    if (listGoalInput == 2)
                    {
                        Console.Write("What is the name of your goal? ");
                        string name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());

                        EternalGoals eternal = new EternalGoals("Eternal Goal", name, description, points, false);

                        goals.AddGoals(eternal);
                        
                    }

                    if (listGoalInput == 3)
                    {
                        Console.Write("What is the name of your goal? ");
                        string name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());

                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int outOf = int.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int bonusPoints = int.Parse(Console.ReadLine());

                        ChecklistGoals checklist = new ChecklistGoals("Eternal Goal", name, description, points, false, 0, outOf, bonusPoints);

                        goals.AddGoals(checklist);
                    }
            
            }

            if (menuInput == 2)
            {
                goals.ListGoals();
            }

            if (menuInput == 3)
            {
                goals.SaveGoals();
            }

            if (menuInput == 4)
            {
                goals.LoadGoals();
            }

            if (menuInput == 5)
            {
                goals.RecordEvent();
            }
        }
        
        
        
        
        


    }
}