class GoalCourier
{
    private List<Goal> _goals;
    private int _points;
    private int _level;
    private string _goalFileName;


    internal GoalCourier()
    {
        _goals = [];
        _points = 0;
        _level = 1;
        _goalFileName = string.Empty;
        Console.SetCursorPosition(0, 0);
    }


    internal void Run()
    {
        int choice;

        do
        {
            PrintMainMenu();
            choice = GetUserChoice("What do you want to do? ", 1, 6);

            switch (choice)
            {
                case 1:
                    _goals.Add(StartGoal());
                    break;
                case 2:
                    PrintGoals(false);
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    MarkProgress();
                    break;
            }
        
        } while (choice != 6);
    }


    void ResetScreen()
    {
        Console.Clear();
        Console.WriteLine("Eternal Quest\n");
    }


    void ClearRow(int rowLocation, int rowLength)
    {
        Console.CursorVisible = false;
        string blankLine = new(' ', rowLength);

        Console.SetCursorPosition(0, rowLocation);
        Console.Write(blankLine);
        Console.CursorLeft = 0;
        Console.CursorVisible = true;
    }


    int GetUserChoice(string message, int minimumValue, int maximumValue)
    {
        int choice;
        string errorMessage = $"(That is not a valid choice.) {message}";

        Console.Write(message);
        
        int rowLocation = Console.CursorTop;
        string input = Console.ReadLine();
        int rowLength = message.Length + input.Length;

        while (!int.TryParse(input, out choice) || choice < minimumValue || choice > maximumValue)
        {
            ClearRow(rowLocation, rowLength);
            Console.Write(errorMessage);
            input = Console.ReadLine();
            rowLength = errorMessage.Length + input.Length;
        }

        return choice;
    }


    bool GetBinaryAnswer(string message)
    {
        message += "(y/n) ";
        string errorMessage = $"(That is not a valid answer.) {message}";
        Console.Write(message);
        int rowLocation = Console.CursorTop;
        string input = Console.ReadLine().ToLowerInvariant();
        int rowLength = message.Length + input.Length;

        while (input != "y" && input != "n" && input != "yes" && input != "no")
        {
            ClearRow(rowLocation, rowLength);
            Console.Write(errorMessage);
            input = Console.ReadLine().ToLowerInvariant();
            rowLength = errorMessage.Length + input.Length;
        }

        if (input == "y" || input == "yes")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    void Continue()
    {
        Console.Write("(Press enter to continue...) ");
        Console.ReadLine();
    }


    void WriteGoalFile(string fileName)
    {
        using FileStream fileStream = new(fileName, FileMode.Create);
        using BinaryWriter binaryWriter = new(fileStream);

        binaryWriter.Write(_points);
        binaryWriter.Write(_level);
        binaryWriter.Write(_goals.Count);

        foreach (Goal goal in _goals)
        {
            binaryWriter.Write(goal.GetName());
            binaryWriter.Write(goal.GetDescription());
            binaryWriter.Write(goal.GetValue());

            if (goal is SimpleGoal)
            {
                binaryWriter.Write((byte)1);
                binaryWriter.Write(goal.IsComplete());
            }
            else if (goal is EraGoal)
            {
                binaryWriter.Write((byte)2);
            }
            else if (goal is StepGoal stepGoal)
            {
                binaryWriter.Write((byte)3);
                binaryWriter.Write(stepGoal.GetBonus());
                binaryWriter.Write(stepGoal.GetRequiredSteps());
                binaryWriter.Write(stepGoal.GetCompletedSteps());
            }
        }
    }


    void ReadGoalFile(string fileName)
    {
        using FileStream fileStream = new(fileName, FileMode.Open);
        using BinaryReader binaryReader = new(fileStream);

        _points = binaryReader.ReadInt32();
        _level = binaryReader.ReadInt32();
        int goalCount = binaryReader.ReadInt32();
        _goals = new List<Goal>(goalCount);

        for (int i = 0; i < goalCount; i++)
        {
            string name = binaryReader.ReadString();
            string description = binaryReader.ReadString();
            int value = binaryReader.ReadInt32();
            int type = binaryReader.ReadByte();

            switch (type)
            {
                case 1:
                    bool isComplete = binaryReader.ReadBoolean();
                    _goals.Add(new SimpleGoal(name, description, value, isComplete));
                    break;
                case 2:
                    _goals.Add(new EraGoal(name, description, value));
                    break;
                case 3:
                    int bonus = binaryReader.ReadInt32();
                    int requiredSteps = binaryReader.ReadInt32();
                    int completedSteps = binaryReader.ReadInt32();
                    _goals.Add(new StepGoal(
                        name,
                        description,
                        value,
                        bonus,
                        requiredSteps,
                        completedSteps));
                    break;
            }
        }
    }


    void PrintMainMenu()
    {
        ResetScreen();

        if (_points != 1)
        {
            Console.WriteLine($"You have {_points} points.");
        }
        else
        {
            Console.WriteLine("You have 1 point.");
        }

        Console.WriteLine($"You are at level {_level}.\n");

        Console.WriteLine("Main Menu");
        Console.WriteLine("1: Start Goal");
        Console.WriteLine("2: View Goals");
        Console.WriteLine("3: Save");
        Console.WriteLine("4: Load");
        Console.WriteLine("5: Mark Progress");
        Console.WriteLine("6: Exit\n");
    }


    Goal StartGoal()
    {
        Goal goal;

        ResetScreen();
        Console.WriteLine("Goal Categories");
        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Era Goal");
        Console.WriteLine("3: Step Goal\n");

        int goalCategory = GetUserChoice("What category does your goal fall under? ", 1, 3);

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Goal Description: ");
        string description = Console.ReadLine();

        int value = GetUserChoice("Goal Value: ", 1, int.MaxValue);

        switch (goalCategory)
        {
            case 2:
                goal = new EraGoal(name, description, value);
                break;
            case 3:
                int bonus = GetUserChoice("Completion Bonus: ", 1, int.MaxValue);
                int requiredSteps = GetUserChoice("Number of Times: ", 2, int.MaxValue);
                goal = new StepGoal(name, description, value, bonus, requiredSteps, 0);
                break;
            default:
                goal = new SimpleGoal(name, description, value, false);
                break;
        }

        return goal;
    }


    void PrintGoals(bool allowSelection)
    {
        ResetScreen();

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}: {_goals[i]}");
        }

        if (!allowSelection)
        {
            Console.WriteLine();
            Continue();
        }
    }


    void SaveGoals()
    {
        if (string.IsNullOrEmpty(_goalFileName))
        {
            Console.Write("File Name: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                if (GetBinaryAnswer("This file already exists. Do you want to override it? "))
                {
                    WriteGoalFile(fileName);
                }
            }
            else
            {
                WriteGoalFile(fileName);
            }
        }
        else
        {
            WriteGoalFile(_goalFileName);
        }
    }


    void LoadGoals()
    {
        Console.Write("File Name: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("\nThis file does not exist.");
            Continue();
        }
        else
        {
            ReadGoalFile(fileName);
            _goalFileName = fileName;
        }
    }


    void MarkProgress()
    {
        if (_goals.Count > 0)
        {
            PrintGoals(true);
            int goalNumber = GetUserChoice("Which goal did you work on? ", 1, _goals.Count);
            _points += _goals[goalNumber - 1].Achieve();

            if (_points >= 1000)
            {
                int obtainedLevels = _points / 1000;
                _level += obtainedLevels;
                _points -= obtainedLevels * 1000;

                ResetScreen();
                Console.WriteLine($"Congratulations! You went up to level {_level}!\n");
                Continue();
            }
        }
        else
        {
            Console.WriteLine("\nYou don't have any loaded goals!");
            Continue();
        }
    }
}