
public class Cycling : Activity
{
    private int _speed;
    public Cycling(DateTime date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    public override int GetDistance()
    {
        return _speed / (GetLength() / 60);
    }

    public override int GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance {GetDistance()} Km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min/Km";
    }
}