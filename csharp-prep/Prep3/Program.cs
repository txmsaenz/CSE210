using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int numberGuess = 0;
        int guessCount = 0;

        do
        {
            Console.Write("What is your guess for the magic number? ");
            string guess = Console.ReadLine();

            numberGuess = int.Parse(guess);
            guessCount++;

            if (numberGuess < number)
            {
                Console.WriteLine("Higher");
            }

            else if (numberGuess > number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine($"Congratulations!  You guessed it in {guessCount} tries!");
            }

        }while (numberGuess != number);
    }
}