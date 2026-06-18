using System;

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

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    // Cada clase hija implementa su propia lógica
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    // Esta implementación sirve para SimpleGoal y EternalGoal.
    // ChecklistGoal la sobrescribirá.
    public virtual string GetDetailsString()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {_shortName} ({_description})";
    }

    // Se usa para guardar en el archivo
    public abstract string GetStringRepresentation();
}