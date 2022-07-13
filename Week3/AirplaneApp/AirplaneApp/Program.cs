using System;

namespace AirplaneApp;

public class Program
{
    static void Main(string[] args)
    {
        Airplane a = new(200, "JetsRUs", 100)
            { NumPassengers = 150 };
        a.Ascend(500);
        Console.WriteLine(a.Move(3));
        Console.WriteLine(a); a.Descend(200);
        Console.WriteLine(a.Move());
        a.Move();
        Console.WriteLine(a);
        Person kenny = new("Kenny");
        Person bestStarWars = new("Jar-Jar", "Binks", 23);
        Vehicle kar = new(2, 80);

        List<IMovable> movables = new()
        {
            kenny, a, bestStarWars, kar
        };

        foreach (IMovable i in movables)
        {
            i.Move();
            Console.WriteLine(i);
        }
    }
}