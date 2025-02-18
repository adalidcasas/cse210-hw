public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity()
    {
        SetName("listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!\n");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"\n--- {_prompts[index]} ---\n");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }
        return userList;
    }
}