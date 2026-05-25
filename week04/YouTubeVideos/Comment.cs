class Comment
{
    string _author;

    string _text;


    internal Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }


    internal void Print()
    {
        Console.WriteLine($"{_author}: {_text}");
    }
}