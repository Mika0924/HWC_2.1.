double a, b;
Console.Write("число a ");
a = Double.Parse(Console.ReadLine());
Console.Write("число b ");
b = Double.Parse(Console.ReadLine());
    if (a > b)
        Console.WriteLine($"{a} больше чем {b}");
    else Console.WriteLine($"{b} больше чем {a}");
