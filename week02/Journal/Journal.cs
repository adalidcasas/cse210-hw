using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        PromptGenerator prompt = new PromptGenerator();

        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._promptText = prompt.GetRandomPrompt();

        Console.WriteLine(entry._promptText);
        entry._entryText = Console.ReadLine();
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    public void SaveToFile(string fileName)
    {
        fileName += ".csv";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry._date + "," + entry._promptText + "," + entry._entryText);
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        fileName += ".csv";
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            Entry entry = new Entry();

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}