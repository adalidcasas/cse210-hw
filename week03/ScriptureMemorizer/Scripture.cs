using System.IO.Pipes;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        Random rand = new Random();
        int index = rand.Next(lines.Count());
        string[] parts = lines[index].Split("|"); ;

        if (parts[3] == "")
        {
            _reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
        }
        else
        {
            _reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
        }
        Word word;
        List<string> textToWords = parts[4].Split(" ").ToList();
        foreach (string singleWord in textToWords)
        {
            word = new Word(singleWord);
            _words.Add(word);
        }
    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        Word word;
        List<string> textToWords = text.Split(" ").ToList();
        foreach (string singleWord in textToWords)
        {
            word = new Word(singleWord);
            _words.Add(word);
        }
    }
    public void HideRandomsWords(int quantityOfWordsHided)
    {
        Random rand = new Random();
        int index = 0;
        int count = 0;
        while (count < quantityOfWordsHided && !IsCompletelyHidden())
        {
            index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count += 1;
            }
        }
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word singleWord in _words)
        {
            displayText += singleWord.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        bool isCompleteHidden = true;
        foreach (Word w in _words)
        {
            isCompleteHidden = isCompleteHidden && w.IsHidden();
        }
        return isCompleteHidden;
    }
}