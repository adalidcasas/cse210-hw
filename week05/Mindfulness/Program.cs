public class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        bool validation = false;
        Console.Clear();
        ActivityLog log = new ActivityLog();
        while (option != 5)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity.");
            Console.WriteLine("   2. Start reflecting activity.");
            Console.WriteLine("   3. Start listing activity.");
            Console.WriteLine("   4. View activity log.");
            Console.WriteLine("   5. Quit.");
            Console.Write("Select a choice from the menu: ");
            validation = int.TryParse(Console.ReadLine(), out option);
            option = (validation) ? option : -1;

            Console.Clear();
            switch (option)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                    log.IncreaseBreathingActivity(breathingActivity.GetDuration());
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.DisplayStartingMessage();
                    reflectionActivity.Run();
                    reflectionActivity.DisplayEndingMessage();
                    log.IncreaseReflectingActivity(reflectionActivity.GetDuration());
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                    log.IncreseListingActivity(listingActivity.GetDuration());
                    break;
                case 4:
                    log.DisplayActivityLog();
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Have a nice day!");
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }
    }
}