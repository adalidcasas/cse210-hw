public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int GetPoints()
    {
        return IsComplete() ? base.GetPoints() + _bonus : base.GetPoints();
    }

    public override bool IsComplete()
    {
        return (_target == _amountCompleted);
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted} / {_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_bonus},{_target},{_amountCompleted}";
    }
}