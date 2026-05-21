class Scripture
{
    private readonly Reference _reference;

    private readonly List<Word> _words;


    internal Scripture(Reference reference, string text)
    {
        _reference = reference;

        List<Word> words = [];

        foreach (string word in text.Split())
        {
            words.Add(new Word(word));
        }

        _words = words;
    }


    internal void Print()
    {
        Console.Clear();
        _reference.Print();

        foreach (Word word in _words)
        {
            word.Print();
        }
        
        Console.WriteLine("\n");
    }


    internal bool HideWords()
    {
        int wordsLeft = 0;

        foreach (Word word in _words)
        {
            if (!word.CheckIfHidden())
            {
                wordsLeft++;
            }
        }

        if (wordsLeft > 0)
        {
            Random random = new();
            int wordsHidden = 0;
            int numberToHide = wordsLeft < 3 ? wordsLeft : 3;

            while (wordsHidden < numberToHide)
            {
                Word word = _words[random.Next(_words.Count)];

                if (!word.CheckIfHidden())
                {
                    word.Hide();
                    wordsHidden++;
                }
            }
        }

        return wordsLeft > 0;
    }
}