using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisatonApp;
public class Program
{
    private static readonly string _path = Path.Combine(Directory.GetCurrentDirectory());
    private static ISerialise? _serialiser;
    public static void Main(string[] args)
    {
        Trainee trainee = new Trainee
        {
            FirstName = "Dylan",
            LastName = "Cole",
            SpartaNo = 100
        };

        var serialiser = new SerialiserBinary();
        serialiser.SerialiseToFile($"{_path}/BinaryTrainee.bin", trainee);
        Trainee deserialisedDylan = serialiser.DeserialiseFromFile<Trainee>($"{_path}/BinaryTrainee.bin");

        if (trainee == deserialisedDylan)
            Console.WriteLine("Welcome Back");
        else
            Console.WriteLine("Very Sus");
    }
}
