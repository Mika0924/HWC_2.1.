// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

double a, b;
Console.Write("число a ");
a = Double.Parse(Console.ReadLine());
Console.Write("число b ");
b = Double.Parse(Console.ReadLine());
    if (a > b)
        Console.WriteLine($"{a} больше чем {b}");
    else Console.WriteLine($"{b} больше чем {a}");
