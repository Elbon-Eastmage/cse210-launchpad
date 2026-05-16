// The class in charge of showing the main menu and getting input from the user.
class Nexus
{
    readonly PromptAgent _promptAgent;

    Journal _journal;

    string _currentFilePath;


    internal Nexus()
    {
        _promptAgent = new PromptAgent();
        _journal = new Journal();
        _currentFilePath = string.Empty;
    }


    internal void ShowMainMenu()
    {
        int option;

        do
        {
            Console.WriteLine("Scribe");
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1: Write Journal Entry");
            Console.WriteLine("2: Save to File");
            Console.WriteLine("3: Load Journal");
            Console.WriteLine("4: Read Journal");
            Console.WriteLine("5: Exit");
            Console.Write("Choice: ");

            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out option) || option < 1 || option > 5)
            {
                Console.Write("That is not a valid choice. Please enter another one.");
                Console.Write("(Press enter to continue.) ");
                Console.ReadLine();
            }
            else
            {
                switch (option)
                {
                    case 1:
                        _journal.AddEntry(GetEntry());
                        break;
                    case 2:
                        if (string.IsNullOrEmpty(_currentFilePath))
                        {
                            _currentFilePath = GetFilePath();
                        }

                        _journal.Save(_currentFilePath);
                        break;
                    case 3:
                        _currentFilePath = GetExistingFilePath();

                        if (!string.IsNullOrEmpty(_currentFilePath))
                        {
                            _journal.Load(_currentFilePath);
                        }

                        break;
                    case 4:
                        _journal.PrintEntries();
                        break;
                }

            }

            Console.Clear();

        } while (option != 5);
    }

    
    Entry GetEntry()
    {
        string prompt = _promptAgent.GetPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        return new Entry(prompt, response);
    }


    string GetFilePath()
    {
        Console.Write("Please enter a file name for this journal: ");
        return Console.ReadLine();
    }


    string GetExistingFilePath()
    {
        string filePath;

        Console.Write("\nPlease enter the file name of the journal you want to open: ");
        filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            filePath = string.Empty;
            Console.Write("That is not a valid file name. (Press enter to continue.) ");
            Console.ReadLine();
        }

        return filePath;
    }

}