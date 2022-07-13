using System;
namespace AirplaneApp;

public class Person : IMovable
{
    private string _firstName;
    private string _lastName = " ";

    private int _age;

    public int Position { get; protected set; }

    public int Speed { get; init; }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                throw new ArgumentException();
            else
                _age = value;
        }
    }

    public Person(string firstName, string lastName, int age, int speed = 5)
    {
        _firstName = firstName;
        _lastName = lastName;
        Age = age;
        Speed = speed;
        Position = 0;
    }

    public Person(string firstName)
    {
        _firstName = firstName;
        Speed = 5;
        Position = 0;
    }

    public Person()
    {
        Speed = 0;
        Position = 0;
    }

    public string FullName => $"{_firstName} {_lastName}";

    public void SetNames(string fname, string lname)
    {
        _firstName = fname;
        _lastName = lname;
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
}