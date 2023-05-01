
class MoodTracker
{
    List<string> moods;
    string moodText;
    int moodInput = 0;
    List<Entry> moodList;

    public MoodTracker()
    {
        moods = new List<string>
        {
            "Please select one of the following moods: ",
            "1. Amazing",
            "2. Busy",
            "3. Happy", 
            "4. Loved", 
            "5. Sad",
            "6. Sick", 
            "7. Thankful", 
            "8. Tired"
            //"9. Quit"
        };
    }
    public string MoodInput()
    {
        foreach (string moodItem in moods)
        {
            Console.WriteLine(moodItem);
        }

        moodInput = int.Parse(Console.ReadLine());

        moodText = moods[moodInput];

        return moodText;
          
    }

    public void ViewMoodTracker()
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        Console.WriteLine($"Your mood on {date} was {moodText}.");
    }
}