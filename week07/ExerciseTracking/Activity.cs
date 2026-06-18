using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // Métodos que las clases hijas deben implementar
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    // Devuelve el nombre de la actividad (Running, Cycling, Swimming)
    protected virtual string GetActivityName()
    {
        return GetType().Name;
    }

    // Método común para todas las actividades
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivityName()} ({_minutes} min): " +
               $"Distance {GetDistance():F1} km, " +
               $"Speed {GetSpeed():F1} kph, " +
               $"Pace {GetPace():F2} min per km";
    }
}