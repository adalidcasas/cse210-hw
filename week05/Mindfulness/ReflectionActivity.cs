public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectionActivity()
    {
        SetName("reflection");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have somenthing in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of hte followings questions as they releated to this experience.");
        Console.Write("You begin in: ");
        ShowCountDown(5);
        Console.Clear();
        int seconds = 0;
        while (seconds < GetDuration())
        {
            DisplayQuestions();
            seconds += 10;
        }
        Console.WriteLine();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---\n");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(10);
    }
}