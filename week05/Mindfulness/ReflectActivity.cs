class ReflectActivity : Activity
{
    readonly Options _prompts;

    readonly Options _questions;


    internal ReflectActivity(string name, string description) : base(name, description)
    {
        _prompts = new Options(
            new List<string>(
            [
                "Think of when you overcame a difficult trial.",
                "Think of a creation of yours that you are proud of.",
                "Think of a weakness you overcame.",
                "Think of when you were a positive difference in someone's life.",
                "Think of when you accomplished something you previously thought you couldn't."
            ]));

        _questions = new Options(
            new List<string>(
            [
                "What gave you the strength to do this?",
                "How did this impact your life?",
                "Why did you decide to do this?",
                "How did you pace yourself when doing this?",
                "Did this take you longer than you expected?",
                "What resources did you draw upon for this?",
                "How did God help you with this?"
            ]));
    }


    internal void Run()
    {
        Console.Clear();
        Console.WriteLine(_prompts.RandomlySelect());
        Console.Write("\nPress enter when you have thought of something. ");
        Console.ReadLine();

        Pause(
            "The following questions will help you reflect on your experience.\nYou will start in ",
            5,
            true);
        
        int totalSeconds = GetDuration();
        int elapsedSeconds = 0;
        int secondsForQuestion = (totalSeconds / 3) + (totalSeconds % 3);

        while (elapsedSeconds < totalSeconds)
        {
            Pause(_questions.RandomlySelect(), secondsForQuestion);
            elapsedSeconds += secondsForQuestion;
            secondsForQuestion = totalSeconds / 3;
        }
    }
}