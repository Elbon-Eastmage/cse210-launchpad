class WritingAssignment : Assignment
{
    private string _title;


    internal WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }


    internal string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}