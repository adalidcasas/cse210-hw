public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _duration = 30;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        duration = _duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}.\n");
        Console.Write("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {_name} activity.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> AnimationString = new List<string>();
        AnimationString.Add("|");
        AnimationString.Add("/");
        AnimationString.Add("-");
        AnimationString.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int indexString = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(AnimationString[indexString]);
            Thread.Sleep(300);
            Console.Write("\b \b");
            indexString++;
            indexString = (indexString >= AnimationString.Count) ? 0 : indexString;
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        int timeSleep = 1000;
        seconds = (seconds < 0) ? 5 : seconds;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(timeSleep);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}