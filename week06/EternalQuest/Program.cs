class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        bool validation = false;
        GoalManager goalManager = new GoalManager();
        Console.Clear();
        while (option != 7)
        {
            goalManager.DisplayPlayerInfo();
            validation = int.TryParse(Console.ReadLine(), out option);
            option = (validation) ? option : -1;

            Console.Clear();
            switch (option)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.ListGoalNames();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    goalManager.DisplayLevelsInfo();
                    break;
                case 7:
                    Console.Write("Have a nice day!");
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }

        }
    }
}