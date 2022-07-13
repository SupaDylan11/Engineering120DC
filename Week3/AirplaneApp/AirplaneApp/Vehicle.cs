using System;
namespace AirplaneApp;


public class Vehicle : IMovable
{
    protected int _capacity;
    protected int _numPassengers;

    public int NumPassengers
    {
        get { return _numPassengers; }
        set
        {
            if (value < 0 || value > _capacity)
                throw new ArgumentException();
            checked
            {
                _numPassengers = value;
            }
        }
    }
    public int Position { get; protected set; }
    public int Speed { get; init; }

    public Vehicle()
    {
        Position = 0;
        Speed = 10;
        _capacity = 5;
    }

    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity;
        Speed = speed;
        Position = 0;
    }

    public virtual string Move()
    {
        Position += Speed; // we only need 2 add speed, coz it only move once.
        return "Moving along";
    }

    public virtual string Move(int times)
    {
        if (times < 0)
            throw new ArgumentException();
        checked
        {
            Position += (times * Speed);
            return $"Moving along {times} times";
        }
    }

    //public override string ToString()
    //{
    //    return $"{base.ToString()}, Capacity: {_capacity}, Speed: {Speed}, Position: {Position}, Passengers: {_numPassengers}";
    //}
}
