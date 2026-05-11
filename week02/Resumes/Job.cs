public class Job
{
    public string _companyName;

    public string _title;

    public int _startYear;

    public int _endYear;


    public void PrintJob()
    {
        Console.WriteLine($"{_title} ({_companyName}) {_startYear}-{_endYear}");
    }
}