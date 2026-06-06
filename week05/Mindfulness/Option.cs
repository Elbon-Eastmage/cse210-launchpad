class Option
{
    readonly string _text;

    bool _locked;


    internal Option(string text)
    {
        _text = text;
        _locked = false;
    }


    internal bool IsAvailable()
    {
        return !_locked;
    }


    internal string Select()
    {
        _locked = true;
        return _text;
    }


    internal void MakeAvailable()
    {
        _locked = false;
    }
}