using System;

class Program
{
    static Entry Main(string[] args)
    {
        Journal journal = new Journal();
        int menuInput = 0;

        List<string> menu = new List<string>
        {
            "Please select one of the following choices:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Mood Tracker Input",
            "6. View Mood Tracker",
            "7. Quit",
            "What would you like to do? "
        };
        
        while (menuInput != 7)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuInput = int.Parse(Console.ReadLine());
        }

        if (menuInput == 1)
        {
            Journal write = new Journal();
            write.CreateJournalEntries();
        }

        else if (menuInput == 2)
        {
            Journal display = new Journal();
            display.DisplayJournalEntries();
        }

        else if (menuInput == 3)
        {
            Journal load = new Journal();
            load.LoadFromCSV();
        }

        else if (menuInput == 4)
        {
            var save = new Journal();
            save.SaveToCSV();
        }

        else if (menuInput == 5)
        {
            var mood = new MoodTracker();
            mood.MoodTracker();
        }

        else if (menuInput == 6)
        {
            var mood = new MoodTracker();
            mood.ViewMoodTracker();
        }

        else if (menuInput == 7)
        {
            Console.WriteLine("Thank you!");
        }
    }
}