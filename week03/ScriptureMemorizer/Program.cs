// I exceeded the requirements by storing scriptures in a file and making a class called Library
// that retrieves the scriptures and their references from the file (getting the reference divided
// into its different parts was quite the tricky task!).
class Program
{
    static void Main(string[] args)
    {
        Library library = new();
        Scripture scripture = library.GetScripture();
        bool quit = false;

        while (!quit)
        {
            scripture.Print();
            Console.Write("Press enter to hide some words or type quit to exit the program: ");
            string input = Console.ReadLine();

            if (input != "quit")
            {
                quit = !scripture.HideWords();
            }
            else
            {
                quit = true;
            }
        }
    }
}