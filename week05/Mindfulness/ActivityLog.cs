public class ActivityLog
{
    private int _countBreathingActivity;
    private int _countReflectingActivity;
    private int _countListingActivity;
    private int _sumSecondsBreathingActivity;
    private int _sumSecondsReflectingActivity;
    private int _sumSecondsListingActivity;

    public ActivityLog()
    {
        _countBreathingActivity = 0;
        _countReflectingActivity = 0;
        _countListingActivity = 0;

        _sumSecondsBreathingActivity = 0;
        _sumSecondsReflectingActivity = 0;
        _sumSecondsReflectingActivity = 0;
    }

    public int GetCountBreathingActivity()
    {
        return _countBreathingActivity;
    }

    public int GetCountReflectingActivity()
    {
        return _countReflectingActivity;
    }

    public int GetCountListingActivity()
    {
        return _countListingActivity;
    }

    public void IncreaseBreathingActivity(int seconds = 0)
    {
        _countBreathingActivity++;
        _sumSecondsBreathingActivity += seconds;
    }
    public void IncreaseReflectingActivity(int seconds = 0)
    {
        _countReflectingActivity++;
        _sumSecondsReflectingActivity += seconds;
    }
    public void IncreseListingActivity(int seconds = 0)
    {
        _countListingActivity++;
        _sumSecondsListingActivity += seconds;
    }

    public void DisplayActivityLog()
    {
        Console.Clear();
        Console.WriteLine($"Breathing Activity: {_sumSecondsBreathingActivity} seconds completed in {_countBreathingActivity} activities.");
        Console.WriteLine($"Reflecting Activity: {_sumSecondsReflectingActivity} seconds completed in {_countReflectingActivity} activities.");
        Console.WriteLine($"Listing Activity: {_sumSecondsListingActivity} seconds completed in {_countListingActivity} activities.");

        Console.WriteLine("\nPress ENTER to return.");
        Console.ReadLine();
        Console.Clear();
    }
}