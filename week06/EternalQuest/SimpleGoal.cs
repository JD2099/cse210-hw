using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Constructor utilizado al cargar desde archivo
    public SimpleGoal(string name, string description, int points, bool completed)
        : base(name, description, points)
    {
        _isComplete = completed;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("Este objetivo ya fue completado.");
            return 0;
        }

        _isComplete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}