using System.IO;

class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        foreach(Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntries()
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt); 
        string response = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response);  
    }

    public void SaveToCSV()
    {
        string file = "SaveLoadCSV.cs";

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(DisplayEntry());
        }
    }

    public void LoadFromCSV()
    {
        string file = "SaveLoadCSV.cs";
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
        }
    }
}







