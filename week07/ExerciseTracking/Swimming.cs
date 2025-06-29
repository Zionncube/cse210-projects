public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // Convert meters to miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}
