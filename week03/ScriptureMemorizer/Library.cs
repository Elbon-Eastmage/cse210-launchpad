class Library
{
    private IReadOnlyList<Scripture> _scriptures;


    internal Library()
    {
        string[] fileLines = File.ReadAllLines("Scriptures.txt");
        List<Scripture> scriptures = new(fileLines.Length);

        foreach (string fileLine in fileLines)
        {
            Reference reference;

            int verseIndex = fileLine.IndexOf('[');
            int referenceEndIndex = fileLine.IndexOf(']');
            string book = fileLine.Substring(0, verseIndex);

            int colonIndex = fileLine.IndexOf(':');
            byte chapter = byte.Parse(fileLine.Substring(
                verseIndex + 1, colonIndex - verseIndex - 1));
            
            int dashIndex = fileLine.IndexOf('-');

            if (dashIndex > 0)
            {
                byte firstVerse = byte.Parse(fileLine.Substring(
                    colonIndex + 1, dashIndex - colonIndex - 1));
                
                byte lastVerse = byte.Parse(fileLine.Substring(
                    dashIndex + 1, referenceEndIndex - dashIndex - 1));
                
                reference = new Reference(book, chapter, firstVerse, lastVerse);
            }
            else
            {
                byte verse = byte.Parse(fileLine.Substring(
                    colonIndex + 1, referenceEndIndex - colonIndex - 1));
                
                reference = new Reference(book, chapter, verse);
            }

            string text = fileLine.Substring(referenceEndIndex + 1);
            scriptures.Add(new Scripture(reference, text));
        }

        _scriptures = scriptures;
    }


    internal Scripture GetScripture()
    {
        Random random = new();
        int scriptureIndex = random.Next(_scriptures.Count);

        return _scriptures[scriptureIndex];
    }
}