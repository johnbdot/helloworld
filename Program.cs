class Program
{
    static void Main(string[] args)
    {
        Program programObject = new Program();
        programObject.SecretFunction();
    }

    void SecretFunction()
    {
        Console.WriteLine("You found me.");
    }
}

class Car
{
    public static string CarName(string carType)
    {
        return $"This is a {carType}.";
    }
}