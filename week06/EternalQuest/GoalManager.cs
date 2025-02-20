public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _level;
    public GoalManager()
    {
        _score = 0;
        _level = "Beginner ";
    }

    public void DisplayLevelsInfo()
    {
        Console.WriteLine("You can get the following levels, depending on your progress:");
        Console.WriteLine("Beginner:        (0 - 1000 points)");
        Console.WriteLine("Intermediate:    (1001 - 2000 points)");
        Console.WriteLine("Advanced:        (2001 - 5000 points)");
        Console.WriteLine("Expert:          (5001 points or more)");
        Console.WriteLine("\nPress any Key for return to menu.");
        Console.ReadLine();
        Console.Clear();
    }

    private void CheckLevel()
    {
        if (0 < _score && _score <= 1000)
        {
            _level = "Beginner ";
        }
        else if (1000 < _score && _score <= 2000)
        {
            _level = "Intermediate ";
        }
        else if (2000 < _score && _score <= 5000)
        {
            _level = "Advanced ";
        }
        else if (5000 < _score)
        {
            _level = "Expert ";
        }
    }

    public void DisplayPlayerInfo()
    {
        CheckLevel();
        Console.WriteLine($"Yout have {_score} points. Level: {_level.ToUpper()}\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal.");
        Console.WriteLine("   2. List Goals.");
        Console.WriteLine("   3. Save Goals.");
        Console.WriteLine("   4. Load Goals.");
        Console.WriteLine("   5. Record Events");
        Console.WriteLine("   6. See level information");
        Console.WriteLine("   7. Quit.");
        Console.Write("Select a choice from the menu: ");
    }

    public void ListGoalNames()
    {
        int numeration = 0;
        foreach (Goal goal in _goals)
        {
            numeration++;
            Console.WriteLine($"{numeration}. {goal.GetDetailsString()}");
        }
        Console.WriteLine("\nPress any Key for return to menu.");
        Console.ReadLine();
        Console.Clear();
    }

    public void CreateGoal()
    {
        int option = -1;
        bool validation = false;
        string name = "";
        string description = "";
        int points = 0;
        int target = 0;
        int bonus = 0;
        while (option != 0)
        {
            Console.Clear();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal.");
            Console.WriteLine("  2. Eternal Goal.");
            Console.WriteLine("  3. Checklist Goal.");
            Console.Write("What type of Goal would you like to create? ");
            validation = int.TryParse(Console.ReadLine(), out option);
            option = (validation) ? option : -1;
            option = (option < 1 || option > 3) ? -1 : option;
            if (option != -1)
            {
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("\nWhat is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("\nWhat is the amount of points associated with this goal? ");
                points = int.TryParse(Console.ReadLine(), out points) ? points : 0;

                switch (option)
                {
                    case 1:
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        _goals.Add(simpleGoal);
                        option = 0;
                        break;
                    case 2:
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                        option = 0;
                        break;
                    case 3:
                        Console.Write("\nHow many times doas this goal need to be accomplished for a bonus? ");
                        target = int.Parse(Console.ReadLine());
                        Console.Write("\nWhat is the bonus for accomplishing it thtat many times ");
                        bonus = int.Parse(Console.ReadLine());
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                        _goals.Add(checklistGoal);
                        option = 0;
                        break;
                    default:
                        Console.WriteLine("ERROR!: ");
                        option = -1;
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR!: ");
                option = -1;
            }
        }
        Console.Clear();
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        int k = 0;
        foreach (Goal goal in _goals)
        {
            k++;
            Console.WriteLine($"{k}. {goal.GetName()}.");
        }
        Console.WriteLine("Which goal did you accomplish? ");
        k = int.Parse(Console.ReadLine());
        Goal myGoal = _goals[k - 1];
        myGoal.RecordEvent();
        int points = myGoal.GetPoints();
        _score += points;
        Console.WriteLine($"\nCongratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points");
        Console.WriteLine("\nPress any kay for return.");
        Console.ReadLine();
        Console.Clear();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            string className = "";
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                className = (goal is SimpleGoal) ? "SimpleGoal" : (goal is EternalGoal) ? "EternalGoal" : "ChecklistGoal";
                outputFile.WriteLine($"{className}: {goal.GetStringRepresentation()}");
            }
        }
        Console.Clear();
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("ERROR!: The file does not exist.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("ERROR!: The file is empty.");
            return;
        }

        _score = int.TryParse(lines[0], out _score) ? _score : 0;

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(":");
            string className = parts[0];
            string[] details = parts[1].Split(",");
            switch (className)
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                    bool isComplete = bool.TryParse(details[3], out isComplete) ? isComplete : false;
                    if (isComplete)
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[3]));
                    int amountCompleted = int.TryParse(details[5], out amountCompleted) ? amountCompleted : 0;
                    for (int k = 0; k < amountCompleted; k++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                    break;
                default:
                    break;
            }
        }
        Console.Clear();
    }
}