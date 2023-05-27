using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comments> com1 = new List<Comments>();
        Comments c1 = new Comments("Matthew", "Wow!");
        com1.Add(c1);
        Comments c2 = new Comments("Andrew", "I could do that.");
        com1.Add(c2);
        Comments c3 = new Comments("Arnold", "How did you do that?");
        com1.Add(c3);

        List<Comments> com2 = new List<Comments>();
        Comments c4 = new Comments("Mimi", "I need to show this to my bestie");
        com2.Add(c4);
        Comments c5 = new Comments("Brian", "Bro!  That's amazing!");
        com2.Add(c5);
        Comments c6 = new Comments("Ben", "I want to try!");
        com2.Add(c6);

        List<Comments> com3 = new List<Comments>();
        Comments c7 = new Comments("Kathy", "That's neat");
        com3.Add(c7);
        Comments c8 = new Comments("Alisa", "What an inspiration!");
        com3.Add(c8);
        Comments c9 = new Comments("David", "I can't believe what I just watched");
        com3.Add(c9);

        List<Videos> vids = new List<Videos>();
        Videos v1 = new Videos("Watch this!", "Miranda", 5, com1);
        vids.Add(v1);
        Videos v2 = new Videos("Watch with caution", "Sam", 2, com2);
        vids.Add(v2);
        Videos v3 = new Videos("You'll never believe this!", "Jerry", 7, com3);
        vids.Add(v3);

        foreach (Videos videos in vids)
        {
            Console.WriteLine($"{videos.GetTitle()} by {videos.GetAuthor()}, {videos.GetLength()} minutes long");
            Console.WriteLine($"Number of Comments: {videos.NumComments()}");

            foreach (Comments comments in videos._comments)
            {
                Console.WriteLine($"{comments.GetCommenter()} said {comments.GetComment()}");
            }

            Console.WriteLine();
        }
    }
}