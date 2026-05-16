class PromptAgent
{
    const string _promptFileName = "Prompts.txt";


    IReadOnlyList<string> _prompts;


    internal PromptAgent()
    {
        _prompts = File.ReadAllLines(_promptFileName);
    }


    internal string GetPrompt()
    {
        Random random = new();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}