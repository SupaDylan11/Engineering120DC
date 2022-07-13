namespace AirplaneTest;

using AirplaneApp;

public class Tests
{

    [Test]
    public void GivenADefaultPlaneOfXCapacity_Move3TimesAt200Meters_ReturnsExpectedMoveString ()
    {
        Airplane a = new(200);
        a.Ascend(200);
        string result = a.Move(3);
        Assert.That(a.Position, Is.EqualTo(300));
        Assert.That(result, Is.EqualTo("Moving along 3 times at an altitude of 200 meters"));
    }

    // ideally, nobody would go onto a ry*nair plane
    [Test]
    public void GivenA300KMHPlaneFromRy_nAirofXCapacity_MovesOnlyOnceAt200Meters_ReturnsExpectedMoveString()
    {
        Airplane a = new(200, "Ry*nAir", 150);
        a.Ascend(200);
        string result = a.Move();
        Assert.That(a.Position, Is.EqualTo(150));
        Assert.That(result, Is.EqualTo("Moving along at an altitude of 200 meters"));
    }

    [Test]
    public void GivenADefaultPlaneOfCapacity100_ReturnCorrectToString()
    {
        Airplane a = new(100);
        Assert.That(a.ToString(), Is.EqualTo("Thank you for flying : AirplaneApp.Airplane capacity: 100 passengers: 0 speed: 100 position: 0 altitude: 0"));
    }

    [Test]
    public void GivenAVirginPlaneOfCapacity100Speed500And69Passengers_ReturnCorrectToString()
    {
        Airplane a = new(100, "Virgin", 500) { NumPassengers = 69 };
        Assert.That(a.ToString(), Is.EqualTo("Thank you for flying Virgin: AirplaneApp.Airplane capacity: 100 passengers: 69 speed: 500 position: 0 altitude: 0"));
    }

    [Test]
    public void GivenDescendingDistanceBeingLargerThanAltitude_ThrowArgumentException()
    {
        Airplane a = new(100, "Virgin", 500) { NumPassengers = 69 };
        a.Ascend(304);
        Assert.That(() => a.Descend(500), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void GivenAscendingDistancePlusAltitudeBeingHigherThanMaxInt_ThrowArgumentException()
    {
        Airplane a = new(100, "Virgin", 500) { NumPassengers = 69 };
        a.Ascend(int.MaxValue);
        Assert.That(() => a.Ascend(500), Throws.TypeOf<ArgumentException>());
    }

    ///[TestCase(34, 300, 334)]
}
