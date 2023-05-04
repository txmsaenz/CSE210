using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all ways acknowledge him, and he shall direct thy paths.");

        string userInput = "";

        while (userInput != "quit" && scripture.WordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }
    }
}