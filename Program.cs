Car sportsCarObject = new Car();
Car van = new Car();

var carName = sportsCarObject.CarName("sports car");
var vanName = van.CarName("van");

Console.WriteLine(carName);
Console.WriteLine(vanName);

class Car
{
    public string CarName(string carType)
    {
        return $"This is a {carType}.";
    }
}