
public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }
    public abstract int GetDistance();
    public abstract float GetSpeed();
    public abstract int GetPace();
    public virtual string GetSummary()
    {
        return $"{_date.Day} {_date.Month} {_date.Year} ";
    }
}