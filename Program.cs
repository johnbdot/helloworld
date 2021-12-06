int index = 32;

int newIndex = myFunction(index);

Console.WriteLine($"This is the number from myFunction: {newIndex}");

static int myFunction(int myIndex)
{
    Console.WriteLine(myIndex += 5);
    return myIndex;
}