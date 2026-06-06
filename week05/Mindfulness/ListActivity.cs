class ListActivity : Activity
{
    readonly Options _questions;

    List<string> _answers;


    internal ListActivity(string name, string description) : base(name, description)
    {
        _questions = new Options(
            new List<string>(
            [
                "What are your favorite books?",
                "Who are your friends?",
                "What blessings has God given you?",
                "What are your favorite games?",
                "What inventions are you grateful for?",
                "When have people served you?",
                "What are your favorite movies?",
            ]));
    }


    internal void Run()
    {
        _answers = [];
        string question = _questions.RandomlySelect();

        Pause(
            $"{question}\nList as many answers as you can to this question. You will begin in ",
            7,
            true);
        
        Console.Clear();
        Console.WriteLine(question);

        int totalSeconds = GetDuration();
        DateTime startTime = DateTime.Now;

        do
        {
            Console.Write("> ");
            _answers.Add(Console.ReadLine());
        } while ((DateTime.Now - startTime).TotalSeconds < totalSeconds);

        if (_answers.Count == 1)
        {
            Console.WriteLine("You entered 1 answer.");
        }
        else
        {
            Console.WriteLine($"You entered {_answers.Count} answers.");
        }

        Console.WriteLine("(Press enter to finish...)");
        Console.ReadLine();
    }
}