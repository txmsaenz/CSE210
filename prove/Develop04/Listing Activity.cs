using System;
using System.Diagnostics;
public class ListingActivity : Activity
{
    private string _listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> userInput = new List<string>();
    private List<string> _items = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, int duration) : base(name, duration)
    {

    }

    public void getListingMessage()
    {
        Console.WriteLine(_listingDescription);
        Console.WriteLine();
    }
    public string getItems()
    {
        var ranItems = new Random();
        int index = ranItems.Next(_items.Count);
        return _items[index];
    }

    public void runListingActivity()
    {
        Console.WriteLine();
        var itemList = getItems();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {itemList} --- ");
        displayCountDown(5);
        Stopwatch(_duration);
    }

    public void Stopwatch(int duration)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Console.WriteLine();
    
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            
            Console.Write("> ");
            userInput.Add(Console.ReadLine());            
        }

        stopwatch.Stop();

        int length = userInput.Count;
        Console.WriteLine($"You listed {length} items!");
        Console.WriteLine();
    }
}