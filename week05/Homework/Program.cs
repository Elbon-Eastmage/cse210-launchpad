class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Elbon Eastmage", "Heritage");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new("Blasternaut", "Prime Numbers", "9.3", "1-23");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new("Daisy North", "Novel", "Starlight");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}