using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        char letterGrade;
        char gradeSymbol;

        if (gradePercentage >= 90)
            letterGrade = 'A';
        else if (gradePercentage >= 80)
            letterGrade = 'B';
        else if (gradePercentage >= 70)
            letterGrade = 'C';
        else if (gradePercentage >= 60)
            letterGrade = 'D';
        else
            letterGrade = 'F';
        
        int lastDigit = gradePercentage % 10;

        if (lastDigit >= 7)
            gradeSymbol = '+';
        else if (lastDigit < 3)
            gradeSymbol = '-';
        else
            gradeSymbol = ' ';
        
        if (letterGrade == 'A')
        {
            if (gradePercentage >= 97)
                gradeSymbol = ' ';
        }
        else if (letterGrade == 'F' && gradeSymbol != ' ')
            gradeSymbol = ' ';
        
        Console.WriteLine($"Grade: {letterGrade}{gradeSymbol}");
        
        if (gradePercentage >= 70)
            Console.WriteLine("Well done! You passed the class!");
        else
            Console.WriteLine("You didn't pass. However, it's not the end. You can try again!");
    }
}