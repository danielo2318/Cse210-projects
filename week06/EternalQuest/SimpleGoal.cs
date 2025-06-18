public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
        => $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";

    public override string GetStringRepresentation()
        => $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
}
