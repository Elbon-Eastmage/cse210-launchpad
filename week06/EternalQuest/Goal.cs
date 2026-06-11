abstract class Goal
{
    readonly private string _name;

    readonly private string _description;

    readonly private int _value;


    internal Goal(string name, string description, int value)
    {
        _name = name;
        _description = description;
        _value = value;
    }


    public override string ToString()
    {
        string completionStatus = IsComplete() ? "[√]" : "[]";
        return $"{completionStatus} {_name} ({_description})";
    }


    internal abstract bool IsComplete();


    internal virtual int Achieve()
    {
        return _value;
    }


    internal string GetName()
    {
        return _name;
    }


    internal string GetDescription()
    {
        return _description;
    }


    internal int GetValue()
    {
        return _value;
    }
}