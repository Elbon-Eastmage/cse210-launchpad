class BreatheActivity : Activity
{
    internal BreatheActivity(string name, string description) : base(name, description) {}


    internal void Run()
    {
        int totalSeconds = GetDuration();
        int remainingSeconds = totalSeconds;

        for (int i = 0; i < (totalSeconds / 10) - 1; i++)
        {
            Pause("Breathe in...", 5, true);
            Pause("Breathe out...", 5, true);
            remainingSeconds -= 10;
        }

        Pause("Breathe in...", (remainingSeconds / 2) + (remainingSeconds % 2), true);
        Pause("Breathe out...", remainingSeconds / 2, true);
    }
}