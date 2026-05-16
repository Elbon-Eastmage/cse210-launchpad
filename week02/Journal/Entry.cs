class Entry
{
    readonly string _prompt;

    readonly string _date;

    readonly string _response;


    internal Entry(string prompt, string response)
    {
        _date = GetDate();
        _prompt = prompt;
        _response = response;
    }


    internal Entry(string data)
    {
        string[] entryLines = data.Split('|');

        _date = entryLines[0];
        _prompt = entryLines[1];
        _response = entryLines[2];
    }


    internal void Print()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
        Console.WriteLine();
    }


    internal string FormatEntry() => $"{_date}|{_prompt}|{_response}";

    // Got help from "https://byui-cse.github.io/cse210-ww-course/week02/develop.html"
    string GetDate() => DateTime.Now.ToShortDateString();
}