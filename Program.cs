class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();
        Van van = new Van();
        Car car = new Car();

        van.canStandUpInside = true;
    }
}

class Vehicle
{
    public bool hasWheels = true;
    public string make;
    public string model;
}

class Van: Vehicle
{
    public int numberOfRowsForSeats;
    public bool canStandUpInside;
}

class Car: Vehicle
{
    public bool hasOnlyFourSeats;
}