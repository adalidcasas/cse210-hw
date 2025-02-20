public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public virtual int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string complete = (IsComplete()) ? "X" : " ";
        return $"[{complete}] {_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}