class Program
{
    static void Main(string[] args)
    {
        Fraction oneFractionToRuleThemAll = new();
        Console.WriteLine(oneFractionToRuleThemAll.GetFractionString());
        Console.WriteLine(oneFractionToRuleThemAll.GetDecimalValue());

        Fraction unityDutyAndDestiny = new(5);
        Console.WriteLine(unityDutyAndDestiny.GetFractionString());
        Console.WriteLine(unityDutyAndDestiny.GetDecimalValue());

        Fraction missingToa = new(3, 4);
        Console.WriteLine(missingToa.GetFractionString());
        Console.WriteLine(missingToa.GetDecimalValue());

        Fraction sliceOfPie = new(1, 3);
        Console.WriteLine(sliceOfPie.GetFractionString());
        Console.WriteLine(sliceOfPie.GetDecimalValue());
    }
}