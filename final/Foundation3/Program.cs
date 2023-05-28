using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("524 Dawn Drive", "League City", "Texas");
        Lecture l1 = new Lecture("Charles Boehl", "100", "How to Grill", "Grilling from the master", "March 27th", "10am", a1);

        Console.WriteLine("Lecture Messages:");
        Console.WriteLine("Standard Message: " + l1.StandardMessage());
        Console.WriteLine("Full Message: " + l1.FullMessage());
        Console.WriteLine("Short Message: " + l1.ShortMessage());
        Console.WriteLine();

        Address a2 = new Address("2191 E Grapeview Loop Road", "Grapeview", "Washington");
        Reception r1 = new Reception("Yes", "Genealogy made easy", "Learn tips and tricks that can help anyone research their family history", "February 18th", "4pm", a2);

        Console.WriteLine("Reception Messages:");
        Console.WriteLine("Standard Message: " + r1.StandardMessage());
        Console.WriteLine("Full Message: " + r1.FullMessage());
        Console.WriteLine("Short Message: " + r1.ShortMessage());
        Console.WriteLine();

        Address a3 = new Address("7961 Chloe Lane", "Charleston", "South Carolina");
        OutdoorGathering g1 = new OutdoorGathering("Sunny", "Arnold's Retirement", "Celebrating over 22 years of service to the Navy", "May 7th", "7pm", a3);

        Console.WriteLine("Outdoor Gathering Messages:");
        Console.WriteLine("Standard Message: " + g1.StandardMessage());
        Console.WriteLine("Full Message: " + g1.FullMessage());
        Console.WriteLine("Short Message: " + g1.ShortMessage());
        Console.WriteLine();

    }
}