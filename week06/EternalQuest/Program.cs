// I added a levelup feature where the user will gain a new level every time he/she gains 1000
// points. For every level gained, the points will be reduced by 1000. I also added extensive
// user input validation.

class Program
{
    static void Main()
    {
        GoalCourier goalCourier = new();
        goalCourier.Run();
    }
}