public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        int seconds = 0;
        while (seconds < GetDuration())
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            seconds += 10;
            Console.WriteLine();
        }
    }
}