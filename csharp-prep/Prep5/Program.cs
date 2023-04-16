using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }

        static float SquareNumber(float number)
        {
            float numberSquared = number * number;
            return numberSquared;
        }

        static void DisplayResult (string userName, float numberSquared)
        {
            Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
        }

        

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        float square = SquareNumber(number);
        DisplayResult(name, square);
    }
}