class Activity
{
    readonly string _name;

    readonly string _description;

    int _duration;


    internal Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }


    internal void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"\n{_description}\n");
        
        bool inputIsValid = false;

        while (!inputIsValid)
        {
            Console.Write("How long (in seconds) do you want this activity to be? ");
            string input = Console.ReadLine();
            Console.Clear();

            if (!int.TryParse(input, out int seconds) || seconds < 2)
            {
                Console.WriteLine("That is not a valid length. Please enter another value.");
            }
            else
            {
                inputIsValid = true;
                _duration = seconds;
            }
        }

        Pause("Prepare yourself.", 7);
    }


    internal void End()
    {
        Pause("Nice work!", 5);
        Pause($"You spent {_duration} seconds on the {_name} Activity.", 7);
    }


    protected void Pause(string message, int seconds, bool showCountdown = false)
    {
        Console.CursorVisible = false;
        int passedSeconds = 0;

        while (passedSeconds < seconds)
        {
            if (showCountdown)
            {
                UpdateScreen((seconds - passedSeconds).ToString(), false, 1000);
            }
            else
            {
                UpdateScreen("|");
                UpdateScreen("\\");
                UpdateScreen("──");
                UpdateScreen("/");
            }

            passedSeconds += 1;
        }

        Console.CursorVisible = true;


        void UpdateScreen(string indicator, bool haveTwoLines = true, int millisecondDelay = 250)
        {
            Console.Clear();

            if (haveTwoLines)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
            
            Console.WriteLine(indicator);
            Thread.Sleep(millisecondDelay);
        }
    }


    protected int GetDuration()
    {
        return _duration;
    }
}