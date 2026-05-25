class Video
{
    string _title;

    string _author;

    int _length;

    List<Comment> _comments;


    internal Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = [];
    }


    internal int GetNumberOfComments()
    {
        return _comments.Count;
    }


    internal void Print()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_length}");
        Console.WriteLine($"Comments: {GetNumberOfComments()}\n");

        foreach (Comment comment in _comments)
        {
            comment.Print();
        }

        Console.WriteLine();
    }


    internal void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}