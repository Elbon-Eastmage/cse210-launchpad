class EraGoal : Goal
{
    internal EraGoal(string name, string description, int value) : base(name, description, value)
    {
    }


    internal override bool IsComplete()
    {
        return false;
    }
}