
public class BreathingAcvitity : Activity
{
    private string _breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
    private string _breathingMessage1 = "Breathe in...";
    private string _breathingMessage2 = "Now breathe out...";

    public BreathingAcvitity(string name, int duration) : base(name, duration)
    {
        _name = name;
        _duration = duration;
    }

    public void getBreathingMessage()
    {
        Console.WriteLine(_breathingDescription);
        Console.WriteLine();
    }

     public void runBreathingActivity(int duration)
    {
        Console.WriteLine();
        int timer = 0;
        
        while (timer < duration)
        {
            
            Console.WriteLine();

            for (int i =4; i > 0; i--)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"{_breathingMessage1}{i}");
                Thread.Sleep(1000);
                timer += 1;
            }
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine($"{_breathingMessage1}  ");

            for (int i = 6; i > 0; i--)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"{_breathingMessage2}{i}");
                Thread.Sleep(1000);
                timer += 1;
            }
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine($"{_breathingMessage2}  ");
            Console.WriteLine();
        }
    }
}