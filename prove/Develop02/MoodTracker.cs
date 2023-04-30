
class MoodTracker
{
    public MoodTracker()
    {
        int moodInput = 0;
        string moodtext;

        List<string> moods = new List<string>
        {
            "Please select one of the following moods: ",
            "1. Amazing",
            "2. Busy",
            "3. Happy", 
            "4. Loved", 
            "5. Sad",
            "6. Sick", 
            "7. Thankful", 
            "8. Tired",
            "9. Quit"
        };

        while (moodInput != 9)
            {
                foreach (string moodItem in moods)
                {
                    Console.WriteLine(moodItem);
                }
                moodInput = int.Parse(Console.ReadLine());
            }

            moodtext = moods[moodInput];    
        

        string ViewMoodTracker()
        {
            DateTime theCurrentTime = DateTime.Now;
            string date = theCurrentTime.ToShortDateString();

            Console.WriteLine($"Your mood on {date} was {moodtext}.");
        }
    }
}