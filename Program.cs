var numberFromFunction = myFunction();

Console.WriteLine($"This is the number from myFunction: {numberFromFunction}");

static int myFunction()
{
    var myIndex = 0;
    Console.WriteLine(myIndex += 5);
    return myIndex;
}