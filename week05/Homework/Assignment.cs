using System.Reflection;

public class Assignment
{
    private string _studentName;
    private string _topic;

    protected string GetStudentName()
    {
        return _studentName;
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}