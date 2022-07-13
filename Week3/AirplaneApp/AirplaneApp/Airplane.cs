using System;

namespace AirplaneApp;

public class Airplane : Vehicle
{
    protected string _airline = "";
    protected int _altitude;
    public int Altitude
    {
        get { return _altitude; }
        private set
        {
            if (value < 0)
                throw new ArgumentException($"There cannot be a negative altitude of {value}");
            else
                _altitude = value;
        }
    }

    public Airplane(int capacity) : base()
    {
        _capacity = capacity;
        Altitude = 0;
        Speed = 100;
    }

    public Airplane(int capacity, string airline, int speed = 100) : base(capacity, speed)
    {
        _airline = airline;
        Altitude = 0;
    }

    //(long) value > int.MaxValue
    public void Ascend(int distance)
    {
        if (distance < 0 || (long)_altitude + (long)distance > int.MaxValue)
            throw new ArgumentException($"A plane at {Altitude} cannot acend {distance}m. Try again!");
        else
            Altitude += distance;
    }

    public void Descend(int distance)
    {
        if (distance < 0 || _altitude - distance < 0)
            throw new ArgumentException($"A plane at {Altitude} cannot descend {distance}m. Try again!");
        else
            Altitude -= distance;
    }

    public override string Move()
    {
        return $"{base.Move()} at an altitude of {Altitude} meters"; 
    }

    public override string Move(int times)
    {
        if (times < 0)
            throw new ArgumentException();
        return $"{base.Move(times)} at an altitude of {Altitude} meters";
    }

    public override string ToString()
    {
        return $"Thank you for flying {_airline}: {base.ToString()} capacity: {_capacity} passengers:" +
            $" {NumPassengers} speed: {Speed} position: {Position} altitude: {Altitude}";
    }
}

