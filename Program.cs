var i = 0;

while (i == 0)
{
    Console.Write("Please enter your age: ");
    var input = Console.ReadLine();
    int age = Convert.ToInt32(input);
    int years = 100 - age;

    if (age <= 17)
    {
        Console.WriteLine($"Hi there! You are {age} years old.");
    }
    else if (age <= 35)
    {
        Console.WriteLine($"How's it going? You are {age} years old.");
    }
    else if (age <= 75)
    {
        Console.WriteLine($"Hello! You are {age} years old.");
    }
    else
    {
        Console.WriteLine($"Greetings! You are {age} years old.");
    }
    Console.WriteLine($"You have {years} until you are 100 years old!");
    Console.WriteLine();
}