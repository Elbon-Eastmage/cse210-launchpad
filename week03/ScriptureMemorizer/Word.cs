class Word
{
    private string _characters;

    private bool _isHidden;


    internal Word(string characters)
    {
        _characters = characters;
        _isHidden = false;
    }


    internal void Print()
    {
        Console.Write($"{_characters} ");
    }


    internal void Hide()
    {
        _characters = new string('_', _characters.Length);
        _isHidden = true;
    }


    internal bool CheckIfHidden()
    {
        return _isHidden;
    }
}