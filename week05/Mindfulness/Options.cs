class Options
{
    readonly Random _random;

    int _optionsAvailable;

    List<Option> _options;


    internal Options(List<string> lines)
    {
        _random = new Random();
        _optionsAvailable = lines.Count;
        _options = new List<Option>(_optionsAvailable);

        foreach (string line in lines)
        {
            _options.Add(new Option(line));
        }
    }


    internal string RandomlySelect()
    {
        string text = string.Empty;

        while (string.IsNullOrEmpty(text))
        {
            int randomIndex = _random.Next(_options.Count);

            if (_options[randomIndex].IsAvailable())
            {
                text = _options[randomIndex].Select();
                _optionsAvailable--;
            }
        }

        if (_optionsAvailable == 0)
        {
            Reset();
        }

        return text;
    }


    internal int Count()
    {
        return _options.Count;
    }


    void Reset()
    {
        foreach (Option option in _options)
        {
            option.MakeAvailable();
        }

        _optionsAvailable = _options.Count;
    }
}