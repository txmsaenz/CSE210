using System;

class Program
{
    static void Main(string[] args)
    {
        int time = 0;

        int menuInput = 0;

        List<string> menu = new List<string>
        {    
            "Menu options:",
            "  1. Start breathing activity",
            "  2. Start reflecting activity",
            "  3. Start listening activity",
            "  4. Quit",
            "Select a choice from the menu: "
        };

        while (menuInput != 4)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuInput = int.Parse(Console.ReadLine());

            if (menuInput == 1)
            {
                Console.Clear();
                BreathingAcvitity breathing = new BreathingAcvitity("Breathing", 0);
                breathing.getActivityName();
                breathing.getBreathingMessage();
                time = breathing.getActivityDuration();
                breathing.Start();
                breathing.runBreathingActivity(time);
                breathing.End();
            }

            if (menuInput == 2)
            {
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
                reflecting.getActivityName();
                reflecting.getReflectingMessage();
                time = reflecting.getActivityDuration();
                reflecting.Start();
                reflecting.runReflectingActivity();
                reflecting.End();
            }

            if (menuInput == 3)
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity("Listing", 0);
                listing.getActivityName();
                listing.getListingMessage();
                time = listing.getActivityDuration();
                listing.Start();
                listing.runListingActivity();
                listing.End();
            }
        }
    }
}