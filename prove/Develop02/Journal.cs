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

        PromptGenerator newPrompt = new PromptGenerator();

        string prompt = newPrompt.GetRandomPrompt();
        Console.WriteLine(prompt); 
        string response = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response);  
        entries.Add(entry);
    }

    public void SaveToCSV()
    {
        string file = "SaveLoadCSV.txt";
        List<string> records = new List<string>();

        foreach(Entry entry in entries)
        {
            records.Add(entry.getEntryAsCSV());
        }
        File.WriteAllLines(file, records);
    }

    public void LoadFromCSV()
    {
        string file = "SaveLoadCSV.txt";
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







