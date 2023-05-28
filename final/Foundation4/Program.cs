using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> list = new List<Activity>();

        Running r1 = new Running(5, "18 February 2023", 45);
        list.Add(r1);
        Cycling c1 = new Cycling(10, "21 April 2023", 60);
        list.Add(c1);
        Swimming s1 = new Swimming(30, "05 May 2023", 60);
        list.Add(s1);

        foreach (Activity item in list)
        {
            Console.WriteLine(item.GetSummary());
        }
    }
}