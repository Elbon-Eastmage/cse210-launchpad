using System;

class Program
{
    static void Main(string[] args)
    {
        int input;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool getInput = true;

        while (getInput)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
                numbers.Add(input);
            else
                getInput = false;
        }

        int total = 0;
        int largestNumber = 0;
        int smallestPositiveNumber = int.MaxValue;

        foreach (int number in numbers)
        {
            total += number;

            if (number > largestNumber)
                largestNumber = number;
            
            if (number > 0 && smallestPositiveNumber > number)
                smallestPositiveNumber = number;
        }
        
        float average = (float)total / numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine("The sorted list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}