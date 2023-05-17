using System.Diagnostics;
public class Activity
{
    protected string _name = "";
    protected string _description= "";
    protected int _duration = 0;

    public Activity(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }

    public void getActivityName()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
    }

    public void setActivityName(string name)
    {
        _name = name;
    }

    public int getActivityDuration()
    {
        Console.Write("How long, in seconds, would you like for your session to last? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        spinnerStart();        
    }

    public void End()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        spinnerStart();
    }

    public void Pause()
    {
        Thread.Sleep(1000);
    }

    public void spinnerStart()
    {
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("|");
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");

        foreach (string s in spinnerStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }        
    }

    public void displayCountDown(int duration)
    {
        for (int i = duration; i >= 1; i--)
        {
            Console.Write(string.Format("You may begin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
}