class Reference
{
    private string _book;

    private byte _chapter;

    private byte _firstVerse;

    private byte _lastVerse;


    internal Reference(string book, byte chapter, byte verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = 0;
    }


    internal Reference(string book, byte chapter, byte firstVerse, byte lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }


    internal void Print()
    {
        Console.Write($"{_book} {_chapter}:{_firstVerse}");

        if (_lastVerse != 0)
        {
            Console.Write($"-{_lastVerse} ");
        }
        else
        {
            Console.Write(' ');
        }
    }
}