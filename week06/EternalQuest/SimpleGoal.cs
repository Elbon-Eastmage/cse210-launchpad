class SimpleGoal : Goal
{
    private bool _isComplete;


    internal SimpleGoal(string name, string description, int value, bool isComplete)
        : base(name, description, value)
    {
        _isComplete = isComplete;
    }


    internal override bool IsComplete()
    {
        return _isComplete;
    }


    internal override int Achieve()
    {
        if (!IsComplete())
        {
            _isComplete = true;
            return base.Achieve();
        }
        else
        {
            return 0;
        }
    }
}