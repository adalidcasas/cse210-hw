public class Running : Activity
{
    private int _distance;

    public Running(DateTime date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }

    public override int GetDistance()
    {
        return _distance;
    }

    public override int GetPace()
    {
        return GetLength() / _distance;
    }

    public override float GetSpeed()
    {

        return ((float)_distance / GetLength()) * 60;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance {_distance} Km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min/Km";
    }
}