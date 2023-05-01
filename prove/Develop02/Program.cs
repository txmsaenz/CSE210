using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        MoodTracker mood = new MoodTracker();
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

            if (menuInput == 1)
            {
                journal.CreateJournalEntries();
            }

            else if (menuInput == 2)
            {
                journal.DisplayJournalEntries();
            }

            else if (menuInput == 3)
            {
                journal.LoadFromCSV();
            }

            else if (menuInput == 4)
            {
                journal.SaveToCSV();
            }

            else if (menuInput == 5)
            {
                mood.MoodInput();
            }

            else if (menuInput == 6)
            {
                mood.ViewMoodTracker();
            }

            else if (menuInput == 7)
            {
                Console.WriteLine("Thank you!");
            }
        }
    }
}