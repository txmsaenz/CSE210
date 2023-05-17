using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private string _reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.";


    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(string name, int duration) : base(name, duration)
    {

    }

    public void getReflectingMessage()
    {
        Console.WriteLine(_reflectingDescription);
        Console.WriteLine();
    }

    public string getPrompt()
    {
        var randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    public string getQuestion()
    {
        var randomQuestion = new Random();
        int index = randomQuestion.Next(_questions.Count);
        return _questions[index];
    }
    public void ReflectQuestion(int duration)
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        displayCountDown(5);
        Console.Clear();
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            if (_questions.Count != 0)
            {
                Console.WriteLine();
                var ranQuestion = getQuestion();
                Console.Write($">> {ranQuestion}  ");
                _questions.Remove(ranQuestion);
            }

            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("|");
            Console.Write("\b \b");
            
        }

        stopwatch.Stop();
        Console.WriteLine();
        Console.WriteLine();

    }

    public void runReflectingActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {getPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        
        var pressEnter = Console.ReadKey();
        if (pressEnter.Key == ConsoleKey.Enter)
        {
            ReflectQuestion(_duration);
        }

        
    }
}