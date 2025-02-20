using System.Net.Http.Headers;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override int GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override int GetPace()
    {
        return (int)(GetLength() / (float)GetDistance());
    }

    public override float GetSpeed()
    {
        return (float)GetDistance() / (float)GetLength();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance {GetDistance()} Km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min/Km";
    }
}