// For exceeding the requirements, I implemented code that detects if the user enters input for the
// main menu besides 1-5. The program will notify the user that another choice needs to be made. I
// also set up the program so it will let the user know if he tries to load a nonexistent file.
// Finally, I made the user interface more visually pleasing by printing additional lines at
// strategic places and clearing the screen before reshowing the main menu.

class Program
{
    static void Main(string[] args)
    {
        Nexus nexus = new();
        nexus.ShowMainMenu();
    }
}