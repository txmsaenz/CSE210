using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int numbers = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string numberGuess = Console.ReadLine();
            numbers = int.Parse(numberGuess);

            numberList.Add(numbers);

        } while (numbers != 0);

        int numberSum = 0;
        int highNum = -1;

        foreach (int i in numberList)
        {
            numberSum += i;
            
            if (i > 0)
            {
                highNum = i;
            }
        }
        Console.WriteLine($"The sum is {numberSum}");

        int count = numberList.Count - 1;
        float average = numberSum / count;
        Console.WriteLine($"The average is {average}");

        Console.WriteLine($"The largest number is {highNum}");
        
    }
}