class StepGoal : Goal
{
    readonly private int _bonus;

    readonly private int _requiredSteps;

    private int _completedSteps;


    internal StepGoal(
        string name,
        string description,
        int value,
        int bonus,
        int requiredSteps,
        int completedSteps) : base(name, description, value)
    {
        _bonus = bonus;
        _requiredSteps = requiredSteps;
        _completedSteps = completedSteps;
    }


    public override string ToString()
    {
        return $"{base.ToString()} - Progress: {_completedSteps}/{_requiredSteps}";
    }


    internal override bool IsComplete()
    {
        return _completedSteps == _requiredSteps;
    }


    internal override int Achieve()
    {
        int awardPoints = 0;

        if (!IsComplete())
        {
            _completedSteps++;
            awardPoints = base.Achieve();

            if (IsComplete())
            {
                awardPoints = _bonus;
            }
        }

        return awardPoints;
    }


    internal int GetBonus()
    {
        return _bonus;
    }


    internal int GetRequiredSteps()
    {
        return _requiredSteps;
    }


    internal int GetCompletedSteps()
    {
        return _completedSteps;
    }
}